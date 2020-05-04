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
            this.lblWyborKuriera = new System.Windows.Forms.Label();
            this.lblKurError = new System.Windows.Forms.Label();
            this.numIDKurier = new System.Windows.Forms.NumericUpDown();
            this.dgvKurierzy = new System.Windows.Forms.DataGridView();
            this.btnKurSzukaj = new System.Windows.Forms.Button();
            this.btnKurOK = new System.Windows.Forms.Button();
            this.szwalniaDataSet = new Szwalnia.SzwalniaDataSet();
            this.kurierzyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kurierzyTableAdapter = new Szwalnia.SzwalniaDataSetTableAdapters.KurierzyTableAdapter();
            this.iDKurierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numIDKurier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurierzy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurierzyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWyborKuriera
            // 
            this.lblWyborKuriera.AutoSize = true;
            this.lblWyborKuriera.Location = new System.Drawing.Point(194, 20);
            this.lblWyborKuriera.Name = "lblWyborKuriera";
            this.lblWyborKuriera.Size = new System.Drawing.Size(97, 13);
            this.lblWyborKuriera.TabIndex = 0;
            this.lblWyborKuriera.Text = "Wybierz ID kuriera.";
            // 
            // lblKurError
            // 
            this.lblKurError.AutoSize = true;
            this.lblKurError.Location = new System.Drawing.Point(168, 50);
            this.lblKurError.Name = "lblKurError";
            this.lblKurError.Size = new System.Drawing.Size(0, 13);
            this.lblKurError.TabIndex = 1;
            // 
            // numIDKurier
            // 
            this.numIDKurier.Location = new System.Drawing.Point(171, 66);
            this.numIDKurier.Name = "numIDKurier";
            this.numIDKurier.Size = new System.Drawing.Size(120, 20);
            this.numIDKurier.TabIndex = 2;
            this.numIDKurier.ValueChanged += new System.EventHandler(this.numIDKurier_ValueChanged);
            // 
            // dgvKurierzy
            // 
            this.dgvKurierzy.AutoGenerateColumns = false;
            this.dgvKurierzy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKurierzy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKurierDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.telefon1DataGridViewTextBoxColumn,
            this.telefon2DataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvKurierzy.DataSource = this.kurierzyBindingSource;
            this.dgvKurierzy.Location = new System.Drawing.Point(41, 106);
            this.dgvKurierzy.Name = "dgvKurierzy";
            this.dgvKurierzy.Size = new System.Drawing.Size(547, 150);
            this.dgvKurierzy.TabIndex = 3;
            // 
            // btnKurSzukaj
            // 
            this.btnKurSzukaj.Location = new System.Drawing.Point(347, 66);
            this.btnKurSzukaj.Name = "btnKurSzukaj";
            this.btnKurSzukaj.Size = new System.Drawing.Size(75, 23);
            this.btnKurSzukaj.TabIndex = 4;
            this.btnKurSzukaj.Text = "SZUKAJ";
            this.btnKurSzukaj.UseVisualStyleBackColor = true;
            this.btnKurSzukaj.Click += new System.EventHandler(this.btnKurSzukaj_Click);
            // 
            // btnKurOK
            // 
            this.btnKurOK.Location = new System.Drawing.Point(606, 221);
            this.btnKurOK.Name = "btnKurOK";
            this.btnKurOK.Size = new System.Drawing.Size(75, 23);
            this.btnKurOK.TabIndex = 5;
            this.btnKurOK.Text = "OK";
            this.btnKurOK.UseVisualStyleBackColor = true;
            this.btnKurOK.Click += new System.EventHandler(this.btnKurOK_Click);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKurOK);
            this.Controls.Add(this.btnKurSzukaj);
            this.Controls.Add(this.dgvKurierzy);
            this.Controls.Add(this.numIDKurier);
            this.Controls.Add(this.lblKurError);
            this.Controls.Add(this.lblWyborKuriera);
            this.Name = "Wybor_kuriera";
            this.Text = "Wybor_kuriera";
            this.Load += new System.EventHandler(this.Wybor_kuriera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numIDKurier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurierzy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurierzyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWyborKuriera;
        private System.Windows.Forms.Label lblKurError;
        private System.Windows.Forms.NumericUpDown numIDKurier;
        private System.Windows.Forms.DataGridView dgvKurierzy;
        private System.Windows.Forms.Button btnKurSzukaj;
        private System.Windows.Forms.Button btnKurOK;
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