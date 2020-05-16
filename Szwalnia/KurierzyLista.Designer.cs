namespace Szwalnia
{
    partial class KurierzyLista
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKurierzy = new System.Windows.Forms.DataGridView();
            this.szwalniaDataSet4 = new Szwalnia.SzwalniaDataSet4();
            this.dostawcyZaopatrzenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dostawcy_ZaopatrzenieTableAdapter = new Szwalnia.SzwalniaDataSet4TableAdapters.Dostawcy_ZaopatrzenieTableAdapter();
            this.szwalniaDataSet7 = new Szwalnia.SzwalniaDataSet7();
            this.kurierzyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kurierzyTableAdapter = new Szwalnia.SzwalniaDataSet7TableAdapters.KurierzyTableAdapter();
            this.iDKurierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajKuriera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurierzy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawcyZaopatrzenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurierzyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
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
            this.dgvKurierzy.Location = new System.Drawing.Point(63, 84);
            this.dgvKurierzy.Name = "dgvKurierzy";
            this.dgvKurierzy.Size = new System.Drawing.Size(549, 328);
            this.dgvKurierzy.TabIndex = 1;
            // 
            // szwalniaDataSet4
            // 
            this.szwalniaDataSet4.DataSetName = "SzwalniaDataSet4";
            this.szwalniaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dostawcyZaopatrzenieBindingSource
            // 
            this.dostawcyZaopatrzenieBindingSource.DataMember = "Dostawcy_Zaopatrzenie";
            this.dostawcyZaopatrzenieBindingSource.DataSource = this.szwalniaDataSet4;
            // 
            // dostawcy_ZaopatrzenieTableAdapter
            // 
            this.dostawcy_ZaopatrzenieTableAdapter.ClearBeforeFill = true;
            // 
            // szwalniaDataSet7
            // 
            this.szwalniaDataSet7.DataSetName = "SzwalniaDataSet7";
            this.szwalniaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kurierzyBindingSource
            // 
            this.kurierzyBindingSource.DataMember = "Kurierzy";
            this.kurierzyBindingSource.DataSource = this.szwalniaDataSet7;
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
            // btnDodajKuriera
            // 
            this.btnDodajKuriera.Location = new System.Drawing.Point(451, 40);
            this.btnDodajKuriera.Name = "btnDodajKuriera";
            this.btnDodajKuriera.Size = new System.Drawing.Size(133, 24);
            this.btnDodajKuriera.TabIndex = 2;
            this.btnDodajKuriera.Text = "Dodaj nowego kuriera";
            this.btnDodajKuriera.UseVisualStyleBackColor = true;
            this.btnDodajKuriera.Click += new System.EventHandler(this.btnDodajKuriera_Click);
            // 
            // KurierzyLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.btnDodajKuriera);
            this.Controls.Add(this.dgvKurierzy);
            this.Controls.Add(this.label1);
            this.Name = "KurierzyLista";
            this.Text = "KurierzyLista";
            this.Load += new System.EventHandler(this.KurierzyLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurierzy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawcyZaopatrzenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurierzyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKurierzy;
        private SzwalniaDataSet4 szwalniaDataSet4;
        private System.Windows.Forms.BindingSource dostawcyZaopatrzenieBindingSource;
        private SzwalniaDataSet4TableAdapters.Dostawcy_ZaopatrzenieTableAdapter dostawcy_ZaopatrzenieTableAdapter;
        private SzwalniaDataSet7 szwalniaDataSet7;
        private System.Windows.Forms.BindingSource kurierzyBindingSource;
        private SzwalniaDataSet7TableAdapters.KurierzyTableAdapter kurierzyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKurierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDodajKuriera;
    }
}