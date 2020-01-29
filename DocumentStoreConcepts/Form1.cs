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

            if (!AnyRowsSelected(grid))
                return;

            var selectedGroups =
                GetSelectedItems<DocumentGroup>
                (
                    grdDocumentGroups,
                    bsDocumentGroups
                );

            var documents = 
                selectedGroups.
                SelectMany(n => n.Documents);
            
            documentsBindingSource.DataSource = documents;
            documentsBindingSource.ResetBindings(true);
        }

        private static List<T> GetSelectedItems<T>(DataGridView grid, BindingSource source)
        { 
            var indices = GetSelectedIndices(grid);
            var all = (List<T>)source.DataSource;
            var selected = new List<T>();

            indices.ForEach(n => selected.Add(all[n]));

            return selected;
        }

        private static List<int> GetSelectedIndices(DataGridView grid)
        {
            var indices = new List<int>();

            foreach (DataGridViewRow row in grid.SelectedRows)
            {
                indices.Add(row.Index);
            }

            return indices;
        }

        private static bool AnyRowsSelected(DataGridView grid)
        {
            return grid.SelectedRows.Count > 0;
        }

        private void btnDownloadSelected_Click(object sender, EventArgs e)
        {

        }
    }
}
