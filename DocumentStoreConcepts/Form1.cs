using DocumentStoreConcepts.Models;
using DocumentStoreConcepts.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;

namespace DocumentStoreConcepts
{
    public partial class Form1 : Form
    {
        List<DocumentGroup> model;

        public Form1()
        {
            InitializeComponent();

            model = new List<DocumentGroup>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var factory = new MockDocumentGroupListGenerator();

            model = factory.Generate();

            bsDocumentGroups.DataSource = model;
        }

        private void dgvDocumentGroups_SelectionChanged(object sender, EventArgs e)
        {
            var grid = (DataGridView)sender;

            if (!DataGridOperations.AnyRowsSelected(grid))
                return;

            var selectedGroups =
                DataGridOperations.GetSelectedItems<DocumentGroup>
                (
                    grdDocumentGroups,
                    bsDocumentGroups
                );

            var documents = 
                selectedGroups.
                SelectMany(n => n.Documents);
            
            bsDocuments.DataSource = documents;
            bsDocuments.ResetBindings(true);
        }

        private void btnDownloadSelected_Click(object sender, EventArgs e)
        {
            if (!DataGridOperations.AnyRowsSelected(grdDocuments))
                return;

            var selected = 
                DataGridOperations.GetSelectedItems<Document>
                (
                    grdDocuments, 
                    bsDocuments
                );

            // TODO: extract this to a ZipFactory;
            var source = "document.pdf";
            var uniquename = Guid.NewGuid().ToString();
            var tempDir = Path.GetTempPath();
            var basedir = Path.Combine(tempDir, uniquename);

            Directory.CreateDirectory(basedir);

            foreach(var document in selected)
            {
                var destination = Path.Combine(basedir, document.Filename);
                File.Copy(source, destination);
            }

            var zipDest = Path.Combine(tempDir, String.Concat(uniquename,".zip"));

            ZipFile.CreateFromDirectory(basedir, zipDest);

            Process.Start("explorer.exe", zipDest);
        }

        protected class DataGridOperations
        {

            public static List<T> GetSelectedItems<T>(DataGridView grid, BindingSource source)
            {
                var indices = GetSelectedIndices(grid);
                var all = ((IEnumerable<T>)source.DataSource).ToList();
                var selected = new List<T>();

                indices.ForEach(n => selected.Add(all[n]));

                return selected;
            }

            public static List<int> GetSelectedIndices(DataGridView grid)
            {
                var indices = new List<int>();

                foreach (DataGridViewRow row in grid.SelectedRows)
                {
                    indices.Add(row.Index);
                }

                return indices;
            }

            public static bool AnyRowsSelected(DataGridView grid)
            {
                return grid.SelectedRows.Count > 0;
            }

        }
    }
}
