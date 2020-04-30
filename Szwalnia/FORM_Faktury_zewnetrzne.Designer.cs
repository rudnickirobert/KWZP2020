namespace Szwalnia
{
    partial class FORM_Faktury_Zewnetrzne
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
            this.LBL1 = new System.Windows.Forms.Label();
            this.TXTBOX1 = new System.Windows.Forms.TextBox();
            this.TXTBOX2 = new System.Windows.Forms.TextBox();
            this.TXTBOX3 = new System.Windows.Forms.TextBox();
            this.TXTBOX4 = new System.Windows.Forms.TextBox();
            this.LBL2 = new System.Windows.Forms.Label();
            this.LBL3 = new System.Windows.Forms.Label();
            this.LBL4 = new System.Windows.Forms.Label();
            this.LBL5 = new System.Windows.Forms.Label();
            this.fakturyZewnetrzneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.szwalniaDataSet = new Szwalnia.SzwalniaDataSet();
            this.faktury_ZewnetrzneTableAdapter = new Szwalnia.SzwalniaDataSetTableAdapters.Faktury_ZewnetrzneTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDFakturazewnetrznaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrFakturyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDGrupaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaFirmyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bruttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podatekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szwalniaDataSet1 = new Szwalnia.SzwalniaDataSet1();
            this.vFakturyZewnetrzneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vFakturyZewnetrzneTableAdapter = new Szwalnia.SzwalniaDataSet1TableAdapters.vFakturyZewnetrzneTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fakturyZewnetrzneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFakturyZewnetrzneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.LBL1.Location = new System.Drawing.Point(245, 9);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(370, 46);
            this.LBL1.TabIndex = 0;
            this.LBL1.Text = "Faktury Zewnetrzne";
            this.LBL1.Click += new System.EventHandler(this.LBL1_Click);
            // 
            // TXTBOX1
            // 
            this.TXTBOX1.Location = new System.Drawing.Point(233, 101);
            this.TXTBOX1.Name = "TXTBOX1";
            this.TXTBOX1.Size = new System.Drawing.Size(382, 20);
            this.TXTBOX1.TabIndex = 1;
            // 
            // TXTBOX2
            // 
            this.TXTBOX2.Location = new System.Drawing.Point(233, 127);
            this.TXTBOX2.Name = "TXTBOX2";
            this.TXTBOX2.Size = new System.Drawing.Size(382, 20);
            this.TXTBOX2.TabIndex = 1;
            // 
            // TXTBOX3
            // 
            this.TXTBOX3.Location = new System.Drawing.Point(233, 153);
            this.TXTBOX3.Name = "TXTBOX3";
            this.TXTBOX3.Size = new System.Drawing.Size(382, 20);
            this.TXTBOX3.TabIndex = 1;
            // 
            // TXTBOX4
            // 
            this.TXTBOX4.Location = new System.Drawing.Point(233, 179);
            this.TXTBOX4.Name = "TXTBOX4";
            this.TXTBOX4.Size = new System.Drawing.Size(382, 20);
            this.TXTBOX4.TabIndex = 1;
            // 
            // LBL2
            // 
            this.LBL2.AutoSize = true;
            this.LBL2.Location = new System.Drawing.Point(158, 101);
            this.LBL2.Name = "LBL2";
            this.LBL2.Size = new System.Drawing.Size(53, 13);
            this.LBL2.TabIndex = 0;
            this.LBL2.Text = "Nr faktury";
            this.LBL2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LBL3
            // 
            this.LBL3.AutoSize = true;
            this.LBL3.Location = new System.Drawing.Point(158, 127);
            this.LBL3.Name = "LBL3";
            this.LBL3.Size = new System.Drawing.Size(64, 13);
            this.LBL3.TabIndex = 0;
            this.LBL3.Text = "Nazwa firmy";
            this.LBL3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LBL4
            // 
            this.LBL4.AutoSize = true;
            this.LBL4.Location = new System.Drawing.Point(158, 153);
            this.LBL4.Name = "LBL4";
            this.LBL4.Size = new System.Drawing.Size(66, 13);
            this.LBL4.TabIndex = 0;
            this.LBL4.Text = "Kwota Netto";
            // 
            // LBL5
            // 
            this.LBL5.AutoSize = true;
            this.LBL5.Location = new System.Drawing.Point(158, 179);
            this.LBL5.Name = "LBL5";
            this.LBL5.Size = new System.Drawing.Size(68, 13);
            this.LBL5.TabIndex = 0;
            this.LBL5.Text = "Kwota Brutto";
            // 
            // fakturyZewnetrzneBindingSource
            // 
            this.fakturyZewnetrzneBindingSource.DataMember = "Faktury_Zewnetrzne";
            this.fakturyZewnetrzneBindingSource.DataSource = this.szwalniaDataSet;
            // 
            // szwalniaDataSet
            // 
            this.szwalniaDataSet.DataSetName = "SzwalniaDataSet";
            this.szwalniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // faktury_ZewnetrzneTableAdapter
            // 
            this.faktury_ZewnetrzneTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(293, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Znaleziona faktura";
            this.label1.Click += new System.EventHandler(this.LBL1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDFakturazewnetrznaDataGridViewTextBoxColumn,
            this.nrFakturyDataGridViewTextBoxColumn,
            this.iDGrupaDataGridViewTextBoxColumn,
            this.nazwaFirmyDataGridViewTextBoxColumn,
            this.nettoDataGridViewTextBoxColumn,
            this.bruttoDataGridViewTextBoxColumn,
            this.podatekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vFakturyZewnetrzneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 269);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDFakturazewnetrznaDataGridViewTextBoxColumn
            // 
            this.iDFakturazewnetrznaDataGridViewTextBoxColumn.DataPropertyName = "ID_Faktura_zewnetrzna";
            this.iDFakturazewnetrznaDataGridViewTextBoxColumn.HeaderText = "ID_Faktura_zewnetrzna";
            this.iDFakturazewnetrznaDataGridViewTextBoxColumn.Name = "iDFakturazewnetrznaDataGridViewTextBoxColumn";
            this.iDFakturazewnetrznaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrFakturyDataGridViewTextBoxColumn
            // 
            this.nrFakturyDataGridViewTextBoxColumn.DataPropertyName = "Nr_Faktury";
            this.nrFakturyDataGridViewTextBoxColumn.HeaderText = "Nr_Faktury";
            this.nrFakturyDataGridViewTextBoxColumn.Name = "nrFakturyDataGridViewTextBoxColumn";
            // 
            // iDGrupaDataGridViewTextBoxColumn
            // 
            this.iDGrupaDataGridViewTextBoxColumn.DataPropertyName = "ID_Grupa";
            this.iDGrupaDataGridViewTextBoxColumn.HeaderText = "ID_Grupa";
            this.iDGrupaDataGridViewTextBoxColumn.Name = "iDGrupaDataGridViewTextBoxColumn";
            // 
            // nazwaFirmyDataGridViewTextBoxColumn
            // 
            this.nazwaFirmyDataGridViewTextBoxColumn.DataPropertyName = "Nazwa_Firmy";
            this.nazwaFirmyDataGridViewTextBoxColumn.HeaderText = "Nazwa_Firmy";
            this.nazwaFirmyDataGridViewTextBoxColumn.Name = "nazwaFirmyDataGridViewTextBoxColumn";
            // 
            // nettoDataGridViewTextBoxColumn
            // 
            this.nettoDataGridViewTextBoxColumn.DataPropertyName = "Netto";
            this.nettoDataGridViewTextBoxColumn.HeaderText = "Netto";
            this.nettoDataGridViewTextBoxColumn.Name = "nettoDataGridViewTextBoxColumn";
            // 
            // bruttoDataGridViewTextBoxColumn
            // 
            this.bruttoDataGridViewTextBoxColumn.DataPropertyName = "Brutto";
            this.bruttoDataGridViewTextBoxColumn.HeaderText = "Brutto";
            this.bruttoDataGridViewTextBoxColumn.Name = "bruttoDataGridViewTextBoxColumn";
            // 
            // podatekDataGridViewTextBoxColumn
            // 
            this.podatekDataGridViewTextBoxColumn.DataPropertyName = "Podatek";
            this.podatekDataGridViewTextBoxColumn.HeaderText = "Podatek";
            this.podatekDataGridViewTextBoxColumn.Name = "podatekDataGridViewTextBoxColumn";
            // 
            // szwalniaDataSet1
            // 
            this.szwalniaDataSet1.DataSetName = "SzwalniaDataSet1";
            this.szwalniaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vFakturyZewnetrzneBindingSource
            // 
            this.vFakturyZewnetrzneBindingSource.DataMember = "vFakturyZewnetrzne";
            this.vFakturyZewnetrzneBindingSource.DataSource = this.szwalniaDataSet1;
            // 
            // vFakturyZewnetrzneTableAdapter
            // 
            this.vFakturyZewnetrzneTableAdapter.ClearBeforeFill = true;
            // 
            // FORM_Faktury_Zewnetrzne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 486);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TXTBOX4);
            this.Controls.Add(this.TXTBOX3);
            this.Controls.Add(this.TXTBOX2);
            this.Controls.Add(this.TXTBOX1);
            this.Controls.Add(this.LBL5);
            this.Controls.Add(this.LBL4);
            this.Controls.Add(this.LBL3);
            this.Controls.Add(this.LBL2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL1);
            this.Name = "FORM_Faktury_Zewnetrzne";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FORM_Faktury_Zewnetrzne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fakturyZewnetrzneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFakturyZewnetrzneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.TextBox TXTBOX1;
        private System.Windows.Forms.TextBox TXTBOX2;
        private System.Windows.Forms.TextBox TXTBOX3;
        private System.Windows.Forms.TextBox TXTBOX4;
        private System.Windows.Forms.Label LBL2;
        private System.Windows.Forms.Label LBL3;
        private System.Windows.Forms.Label LBL4;
        private System.Windows.Forms.Label LBL5;
        private SzwalniaDataSet szwalniaDataSet;
        private System.Windows.Forms.BindingSource fakturyZewnetrzneBindingSource;
        private SzwalniaDataSetTableAdapters.Faktury_ZewnetrzneTableAdapter faktury_ZewnetrzneTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFakturazewnetrznaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrFakturyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGrupaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaFirmyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bruttoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podatekDataGridViewTextBoxColumn;
        private SzwalniaDataSet1 szwalniaDataSet1;
        private System.Windows.Forms.BindingSource vFakturyZewnetrzneBindingSource;
        private SzwalniaDataSet1TableAdapters.vFakturyZewnetrzneTableAdapter vFakturyZewnetrzneTableAdapter;
    }
}