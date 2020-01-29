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

            GridBindingSource.DataSource = model;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.SelectedRows.Count <= 0)
                return;

            // get indices
            var indices = new List<int>();
            foreach (DataGridViewRow row in grid.SelectedRows)
            {
                indices.Add(row.Index);
            }

            // get data
            var groups = (List<DocumentGroup>)GridBindingSource.DataSource;
            var documents = new List<Document>();
            indices.ForEach(n => documents.AddRange(groups[n].Documents));

            documentsBindingSource.DataSource = documents;
            documentsBindingSource.ResetBindings(true);
        }
    }
}
