namespace Szwalnia
{
    partial class UmowyKurierzy
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
            this.szwalniaDataSetUmowyKurierzy = new Szwalnia.SzwalniaDataSetUmowyKurierzy();
            this.umowyKurierzyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.umowy_KurierzyTableAdapter = new Szwalnia.SzwalniaDataSetUmowyKurierzyTableAdapters.Umowy_KurierzyTableAdapter();
            this.iDUmowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKurierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataZawarciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czasDostawyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosztKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosztStalyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSetUmowyKurierzy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umowyKurierzyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUmowyDataGridViewTextBoxColumn,
            this.iDKurierDataGridViewTextBoxColumn,
            this.dataZawarciaDataGridViewTextBoxColumn,
            this.czasDostawyDataGridViewTextBoxColumn,
            this.kosztKmDataGridViewTextBoxColumn,
            this.kosztStalyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.umowyKurierzyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // szwalniaDataSetUmowyKurierzy
            // 
            this.szwalniaDataSetUmowyKurierzy.DataSetName = "SzwalniaDataSetUmowyKurierzy";
            this.szwalniaDataSetUmowyKurierzy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // umowyKurierzyBindingSource
            // 
            this.umowyKurierzyBindingSource.DataMember = "Umowy_Kurierzy";
            this.umowyKurierzyBindingSource.DataSource = this.szwalniaDataSetUmowyKurierzy;
            // 
            // umowy_KurierzyTableAdapter
            // 
            this.umowy_KurierzyTableAdapter.ClearBeforeFill = true;
            // 
            // iDUmowyDataGridViewTextBoxColumn
            // 
            this.iDUmowyDataGridViewTextBoxColumn.DataPropertyName = "ID_Umowy";
            this.iDUmowyDataGridViewTextBoxColumn.HeaderText = "ID_Umowy";
            this.iDUmowyDataGridViewTextBoxColumn.Name = "iDUmowyDataGridViewTextBoxColumn";
            this.iDUmowyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDKurierDataGridViewTextBoxColumn
            // 
            this.iDKurierDataGridViewTextBoxColumn.DataPropertyName = "ID_Kurier";
            this.iDKurierDataGridViewTextBoxColumn.HeaderText = "ID_Kurier";
            this.iDKurierDataGridViewTextBoxColumn.Name = "iDKurierDataGridViewTextBoxColumn";
            // 
            // dataZawarciaDataGridViewTextBoxColumn
            // 
            this.dataZawarciaDataGridViewTextBoxColumn.DataPropertyName = "Data_Zawarcia";
            this.dataZawarciaDataGridViewTextBoxColumn.HeaderText = "Data_Zawarcia";
            this.dataZawarciaDataGridViewTextBoxColumn.Name = "dataZawarciaDataGridViewTextBoxColumn";
            // 
            // czasDostawyDataGridViewTextBoxColumn
            // 
            this.czasDostawyDataGridViewTextBoxColumn.DataPropertyName = "Czas_Dostawy";
            this.czasDostawyDataGridViewTextBoxColumn.HeaderText = "Czas_Dostawy";
            this.czasDostawyDataGridViewTextBoxColumn.Name = "czasDostawyDataGridViewTextBoxColumn";
            // 
            // kosztKmDataGridViewTextBoxColumn
            // 
            this.kosztKmDataGridViewTextBoxColumn.DataPropertyName = "Koszt_Km";
            this.kosztKmDataGridViewTextBoxColumn.HeaderText = "Koszt_Km";
            this.kosztKmDataGridViewTextBoxColumn.Name = "kosztKmDataGridViewTextBoxColumn";
            // 
            // kosztStalyDataGridViewTextBoxColumn
            // 
            this.kosztStalyDataGridViewTextBoxColumn.DataPropertyName = "Koszt_Staly";
            this.kosztStalyDataGridViewTextBoxColumn.HeaderText = "Koszt_Staly";
            this.kosztStalyDataGridViewTextBoxColumn.Name = "kosztStalyDataGridViewTextBoxColumn";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(517, 45);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(121, 29);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj nową umowę";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz umowę z listy.";
            // 
            // UmowyKurierzy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UmowyKurierzy";
            this.Text = "UmowyKurierzy";
            this.Load += new System.EventHandler(this.UmowyKurierzy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSetUmowyKurierzy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umowyKurierzyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SzwalniaDataSetUmowyKurierzy szwalniaDataSetUmowyKurierzy;
        private System.Windows.Forms.BindingSource umowyKurierzyBindingSource;
        private SzwalniaDataSetUmowyKurierzyTableAdapters.Umowy_KurierzyTableAdapter umowy_KurierzyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUmowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKurierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZawarciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn czasDostawyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosztKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosztStalyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
    }
}