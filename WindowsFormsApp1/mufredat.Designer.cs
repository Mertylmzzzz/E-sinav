namespace WindowsFormsApp1
{
    partial class mufredat
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sinavsistemiDataSet3 = new WindowsFormsApp1.sinavsistemiDataSet3();
            this.derslerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.derslerTableAdapter = new WindowsFormsApp1.sinavsistemiDataSet3TableAdapters.DerslerTableAdapter();
            this.dersleridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavsistemiDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.derslerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dersleridDataGridViewTextBoxColumn,
            this.dersAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.derslerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // sinavsistemiDataSet3
            // 
            this.sinavsistemiDataSet3.DataSetName = "sinavsistemiDataSet3";
            this.sinavsistemiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // derslerBindingSource
            // 
            this.derslerBindingSource.DataMember = "Dersler";
            this.derslerBindingSource.DataSource = this.sinavsistemiDataSet3;
            // 
            // derslerTableAdapter
            // 
            this.derslerTableAdapter.ClearBeforeFill = true;
            // 
            // dersleridDataGridViewTextBoxColumn
            // 
            this.dersleridDataGridViewTextBoxColumn.DataPropertyName = "Derslerid";
            this.dersleridDataGridViewTextBoxColumn.HeaderText = "Derslerid";
            this.dersleridDataGridViewTextBoxColumn.Name = "dersleridDataGridViewTextBoxColumn";
            this.dersleridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dersAdDataGridViewTextBoxColumn
            // 
            this.dersAdDataGridViewTextBoxColumn.DataPropertyName = "DersAd";
            this.dersAdDataGridViewTextBoxColumn.HeaderText = "DersAd";
            this.dersAdDataGridViewTextBoxColumn.Name = "dersAdDataGridViewTextBoxColumn";
            // 
            // mufredat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 409);
            this.Controls.Add(this.dataGridView1);
            this.Name = "mufredat";
            this.Text = "mufredat";
            this.Load += new System.EventHandler(this.mufredat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinavsistemiDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.derslerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private sinavsistemiDataSet3 sinavsistemiDataSet3;
        private System.Windows.Forms.BindingSource derslerBindingSource;
        private sinavsistemiDataSet3TableAdapters.DerslerTableAdapter derslerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersleridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersAdDataGridViewTextBoxColumn;
    }
}