namespace DocumentStoreConcepts
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grdDocumentGroups = new System.Windows.Forms.DataGridView();
            this.grdDocuments = new System.Windows.Forms.DataGridView();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GroupRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDownloadSelected = new System.Windows.Forms.Button();
            this.thumbnailImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDocumentGroups = new System.Windows.Forms.BindingSource(this.components);
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocumentGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDocumentGroups
            // 
            this.grdDocumentGroups.AllowUserToAddRows = false;
            this.grdDocumentGroups.AllowUserToDeleteRows = false;
            this.grdDocumentGroups.AllowUserToResizeRows = false;
            this.grdDocumentGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDocumentGroups.AutoGenerateColumns = false;
            this.grdDocumentGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDocumentGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDocumentGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupRef,
            this.typeDataGridViewTextBoxColumn,
            this.deliveredDataGridViewTextBoxColumn,
            this.DocumentCount});
            this.grdDocumentGroups.DataSource = this.bsDocumentGroups;
            this.grdDocumentGroups.Location = new System.Drawing.Point(14, 18);
            this.grdDocumentGroups.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdDocumentGroups.Name = "grdDocumentGroups";
            this.grdDocumentGroups.ReadOnly = true;
            this.grdDocumentGroups.RowHeadersVisible = false;
            this.grdDocumentGroups.RowHeadersWidth = 82;
            this.grdDocumentGroups.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDocumentGroups.RowTemplate.Height = 33;
            this.grdDocumentGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDocumentGroups.Size = new System.Drawing.Size(466, 416);
            this.grdDocumentGroups.TabIndex = 0;
            this.grdDocumentGroups.SelectionChanged += new System.EventHandler(this.dgvDocumentGroups_SelectionChanged);
            // 
            // grdDocuments
            // 
            this.grdDocuments.AllowUserToAddRows = false;
            this.grdDocuments.AllowUserToDeleteRows = false;
            this.grdDocuments.AllowUserToResizeRows = false;
            this.grdDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDocuments.AutoGenerateColumns = false;
            this.grdDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdDocuments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDocuments.ColumnHeadersVisible = false;
            this.grdDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thumbnailImageDataGridViewImageColumn,
            this.dataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn1,
            this.filenameDataGridViewTextBoxColumn});
            this.grdDocuments.DataSource = this.documentsBindingSource;
            this.grdDocuments.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdDocuments.Location = new System.Drawing.Point(493, 18);
            this.grdDocuments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdDocuments.Name = "grdDocuments";
            this.grdDocuments.ReadOnly = true;
            this.grdDocuments.RowHeadersVisible = false;
            this.grdDocuments.RowHeadersWidth = 82;
            this.grdDocuments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDocuments.RowTemplate.Height = 33;
            this.grdDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDocuments.Size = new System.Drawing.Size(303, 352);
            this.grdDocuments.TabIndex = 1;
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "Documents";
            this.documentsBindingSource.DataSource = this.bsDocumentGroups;
            // 
            // GroupRef
            // 
            this.GroupRef.DataPropertyName = "GroupRef";
            this.GroupRef.HeaderText = "GroupRef";
            this.GroupRef.Name = "GroupRef";
            this.GroupRef.ReadOnly = true;
            this.GroupRef.Width = 78;
            // 
            // DocumentCount
            // 
            this.DocumentCount.DataPropertyName = "DocumentCount";
            this.DocumentCount.HeaderText = "Document(s)";
            this.DocumentCount.MinimumWidth = 10;
            this.DocumentCount.Name = "DocumentCount";
            this.DocumentCount.ReadOnly = true;
            this.DocumentCount.Width = 92;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GroupRef";
            this.dataGridViewTextBoxColumn1.HeaderText = "GroupRef";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // btnDownloadSelected
            // 
            this.btnDownloadSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadSelected.Image = ((System.Drawing.Image)(resources.GetObject("btnDownloadSelected.Image")));
            this.btnDownloadSelected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadSelected.Location = new System.Drawing.Point(493, 377);
            this.btnDownloadSelected.Name = "btnDownloadSelected";
            this.btnDownloadSelected.Size = new System.Drawing.Size(177, 57);
            this.btnDownloadSelected.TabIndex = 2;
            this.btnDownloadSelected.Text = "             Download Selected";
            this.btnDownloadSelected.UseVisualStyleBackColor = true;
            this.btnDownloadSelected.Click += new System.EventHandler(this.btnDownloadSelected_Click);
            // 
            // thumbnailImageDataGridViewImageColumn
            // 
            this.thumbnailImageDataGridViewImageColumn.DataPropertyName = "ThumbnailImage";
            this.thumbnailImageDataGridViewImageColumn.HeaderText = "ThumbnailImage";
            this.thumbnailImageDataGridViewImageColumn.MinimumWidth = 10;
            this.thumbnailImageDataGridViewImageColumn.Name = "thumbnailImageDataGridViewImageColumn";
            this.thumbnailImageDataGridViewImageColumn.ReadOnly = true;
            this.thumbnailImageDataGridViewImageColumn.Width = 10;
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            this.typeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn1.Width = 10;
            // 
            // filenameDataGridViewTextBoxColumn
            // 
            this.filenameDataGridViewTextBoxColumn.DataPropertyName = "Filename";
            this.filenameDataGridViewTextBoxColumn.HeaderText = "Filename";
            this.filenameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.filenameDataGridViewTextBoxColumn.Name = "filenameDataGridViewTextBoxColumn";
            this.filenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.filenameDataGridViewTextBoxColumn.Width = 10;
            // 
            // GridBindingSource
            // 
            this.bsDocumentGroups.DataSource = typeof(DocumentStoreConcepts.Models.DocumentGroup);
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 56;
            // 
            // deliveredDataGridViewTextBoxColumn
            // 
            this.deliveredDataGridViewTextBoxColumn.DataPropertyName = "Delivered";
            this.deliveredDataGridViewTextBoxColumn.HeaderText = "Delivered";
            this.deliveredDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.deliveredDataGridViewTextBoxColumn.Name = "deliveredDataGridViewTextBoxColumn";
            this.deliveredDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveredDataGridViewTextBoxColumn.Width = 77;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 445);
            this.Controls.Add(this.btnDownloadSelected);
            this.Controls.Add(this.grdDocuments);
            this.Controls.Add(this.grdDocumentGroups);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDocumentGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocumentGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsDocumentGroups;
        private System.Windows.Forms.DataGridView grdDocumentGroups;
        private System.Windows.Forms.DataGridView grdDocuments;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentCount;
        private System.Windows.Forms.DataGridViewImageColumn thumbnailImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDownloadSelected;
    }
}

