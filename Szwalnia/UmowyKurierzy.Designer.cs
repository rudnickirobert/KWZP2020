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
            this.dgvUmowy = new System.Windows.Forms.DataGridView();
            this.umowyKurierzyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.szwalniaDataSetUmowyKurierzy = new Szwalnia.SzwalniaDataSetUmowyKurierzy();
            this.umowy_KurierzyTableAdapter = new Szwalnia.SzwalniaDataSetUmowyKurierzyTableAdapters.Umowy_KurierzyTableAdapter();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWstecz = new System.Windows.Forms.Button();
            this.umowyKurierzyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDKurierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataZawarciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czasDostawyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosztKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosztStalyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUmowy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umowyKurierzyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSetUmowyKurierzy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umowyKurierzyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUmowy
            // 
            this.dgvUmowy.AutoGenerateColumns = false;
            this.dgvUmowy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUmowy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKurierDataGridViewTextBoxColumn,
            this.dataZawarciaDataGridViewTextBoxColumn,
            this.czasDostawyDataGridViewTextBoxColumn,
            this.kosztKmDataGridViewTextBoxColumn,
            this.kosztStalyDataGridViewTextBoxColumn});
            this.dgvUmowy.DataSource = this.umowyKurierzyBindingSource1;
            this.dgvUmowy.Location = new System.Drawing.Point(29, 105);
            this.dgvUmowy.Name = "dgvUmowy";
            this.dgvUmowy.Size = new System.Drawing.Size(556, 320);
            this.dgvUmowy.TabIndex = 0;
            this.dgvUmowy.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUmowy_CellDoubleClick);
            // 
            // umowyKurierzyBindingSource
            // 
            this.umowyKurierzyBindingSource.DataMember = "Umowy_Kurierzy";
            this.umowyKurierzyBindingSource.DataSource = this.szwalniaDataSetUmowyKurierzy;
            // 
            // szwalniaDataSetUmowyKurierzy
            // 
            this.szwalniaDataSetUmowyKurierzy.DataSetName = "SzwalniaDataSetUmowyKurierzy";
            this.szwalniaDataSetUmowyKurierzy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // umowy_KurierzyTableAdapter
            // 
            this.umowy_KurierzyTableAdapter.ClearBeforeFill = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(433, 45);
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
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(318, 45);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(60, 29);
            this.btnWstecz.TabIndex = 3;
            this.btnWstecz.Text = "button1";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // umowyKurierzyBindingSource1
            // 
            this.umowyKurierzyBindingSource1.DataMember = "Umowy_Kurierzy";
            this.umowyKurierzyBindingSource1.DataSource = this.szwalniaDataSetUmowyKurierzy;
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
            // UmowyKurierzy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvUmowy);
            this.Name = "UmowyKurierzy";
            this.Text = "Umowy z kurierami";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UmowyKurierzy_FormClosed);
            this.Load += new System.EventHandler(this.UmowyKurierzy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUmowy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umowyKurierzyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSetUmowyKurierzy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umowyKurierzyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUmowy;
        private SzwalniaDataSetUmowyKurierzy szwalniaDataSetUmowyKurierzy;
        private System.Windows.Forms.BindingSource umowyKurierzyBindingSource;
        private SzwalniaDataSetUmowyKurierzyTableAdapters.Umowy_KurierzyTableAdapter umowy_KurierzyTableAdapter;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKurierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZawarciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn czasDostawyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosztKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosztStalyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource umowyKurierzyBindingSource1;
    }
}