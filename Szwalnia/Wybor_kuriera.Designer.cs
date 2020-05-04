namespace Szwalnia
{
    partial class Wybor_kuriera
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
            this.lblKurierzy = new System.Windows.Forms.Label();
            this.btnKurierzy1 = new System.Windows.Forms.Button();
            this.dgvRecordsKurierzy = new System.Windows.Forms.DataGridView();
            this.btnKurSzukaj = new System.Windows.Forms.Button();
            this.numKurier = new System.Windows.Forms.NumericUpDown();
            this.lblKurError = new System.Windows.Forms.Label();
            this.szwalniaDataSet = new Szwalnia.SzwalniaDataSet();
            this.kurierzyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kurierzyTableAdapter = new Szwalnia.SzwalniaDataSetTableAdapters.KurierzyTableAdapter();
            this.iDKurierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordsKurierzy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKurier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurierzyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKurierzy
            // 
            this.lblKurierzy.AutoSize = true;
            this.lblKurierzy.Location = new System.Drawing.Point(265, 35);
            this.lblKurierzy.Name = "lblKurierzy";
            this.lblKurierzy.Size = new System.Drawing.Size(110, 13);
            this.lblKurierzy.TabIndex = 0;
            this.lblKurierzy.Text = "Wprowadź ID kuriera.";
            this.lblKurierzy.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnKurierzy1
            // 
            this.btnKurierzy1.Location = new System.Drawing.Point(619, 246);
            this.btnKurierzy1.Name = "btnKurierzy1";
            this.btnKurierzy1.Size = new System.Drawing.Size(75, 23);
            this.btnKurierzy1.TabIndex = 1;
            this.btnKurierzy1.Text = "OK";
            this.btnKurierzy1.UseVisualStyleBackColor = true;
            this.btnKurierzy1.Click += new System.EventHandler(this.btnKurierzy1_Click);
            // 
            // dgvRecordsKurierzy
            // 
            this.dgvRecordsKurierzy.AutoGenerateColumns = false;
            this.dgvRecordsKurierzy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecordsKurierzy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKurierDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.telefon1DataGridViewTextBoxColumn,
            this.telefon2DataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvRecordsKurierzy.DataSource = this.kurierzyBindingSource;
            this.dgvRecordsKurierzy.Location = new System.Drawing.Point(23, 127);
            this.dgvRecordsKurierzy.Name = "dgvRecordsKurierzy";
            this.dgvRecordsKurierzy.Size = new System.Drawing.Size(550, 155);
            this.dgvRecordsKurierzy.TabIndex = 2;
            // 
            // btnKurSzukaj
            // 
            this.btnKurSzukaj.Location = new System.Drawing.Point(357, 85);
            this.btnKurSzukaj.Name = "btnKurSzukaj";
            this.btnKurSzukaj.Size = new System.Drawing.Size(75, 23);
            this.btnKurSzukaj.TabIndex = 3;
            this.btnKurSzukaj.Text = "SZUKAJ";
            this.btnKurSzukaj.UseVisualStyleBackColor = true;
            this.btnKurSzukaj.Click += new System.EventHandler(this.btnKurSzukaj_Click);
            // 
            // numKurier
            // 
            this.numKurier.Location = new System.Drawing.Point(192, 85);
            this.numKurier.Name = "numKurier";
            this.numKurier.Size = new System.Drawing.Size(120, 20);
            this.numKurier.TabIndex = 4;
            // 
            // lblKurError
            // 
            this.lblKurError.AutoSize = true;
            this.lblKurError.Location = new System.Drawing.Point(192, 66);
            this.lblKurError.Name = "lblKurError";
            this.lblKurError.Size = new System.Drawing.Size(0, 13);
            this.lblKurError.TabIndex = 5;
            // 
            // szwalniaDataSet
            // 
            this.szwalniaDataSet.DataSetName = "SzwalniaDataSet";
            this.szwalniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kurierzyBindingSource
            // 
            this.kurierzyBindingSource.DataMember = "Kurierzy";
            this.kurierzyBindingSource.DataSource = this.szwalniaDataSet;
            // 
            // kurierzyTableAdapter
            // 
            this.kurierzyTableAdapter.ClearBeforeFill = true;
            // 
            // iDKurierDataGridViewTextBoxColumn
            // 
            this.iDKurierDataGridViewTextBoxColumn.DataPropertyName = "ID_Kurier";
            this.iDKurierDataGridViewTextBoxColumn.HeaderText = "ID_Kurier";
            this.iDKurierDataGridViewTextBoxColumn.Name = "iDKurierDataGridViewTextBoxColumn";
            this.iDKurierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            // 
            // telefon1DataGridViewTextBoxColumn
            // 
            this.telefon1DataGridViewTextBoxColumn.DataPropertyName = "Telefon_1";
            this.telefon1DataGridViewTextBoxColumn.HeaderText = "Telefon_1";
            this.telefon1DataGridViewTextBoxColumn.Name = "telefon1DataGridViewTextBoxColumn";
            // 
            // telefon2DataGridViewTextBoxColumn
            // 
            this.telefon2DataGridViewTextBoxColumn.DataPropertyName = "Telefon_2";
            this.telefon2DataGridViewTextBoxColumn.HeaderText = "Telefon_2";
            this.telefon2DataGridViewTextBoxColumn.Name = "telefon2DataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // Wybor_kuriera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 294);
            this.Controls.Add(this.lblKurError);
            this.Controls.Add(this.numKurier);
            this.Controls.Add(this.btnKurSzukaj);
            this.Controls.Add(this.dgvRecordsKurierzy);
            this.Controls.Add(this.btnKurierzy1);
            this.Controls.Add(this.lblKurierzy);
            this.Name = "Wybor_kuriera";
            this.Text = "Wybor_kuriera";
            this.Load += new System.EventHandler(this.Wybor_kuriera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordsKurierzy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKurier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurierzyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKurierzy;
        private System.Windows.Forms.Button btnKurierzy1;
        private System.Windows.Forms.DataGridView dgvRecordsKurierzy;
        private System.Windows.Forms.Button btnKurSzukaj;
        private System.Windows.Forms.NumericUpDown numKurier;
        private System.Windows.Forms.Label lblKurError;
        private SzwalniaDataSet szwalniaDataSet;
        private System.Windows.Forms.BindingSource kurierzyBindingSource;
        private SzwalniaDataSetTableAdapters.KurierzyTableAdapter kurierzyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKurierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}