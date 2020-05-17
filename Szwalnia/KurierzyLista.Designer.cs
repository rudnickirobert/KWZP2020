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
            this.kurierzyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.szwalniaDataSet7 = new Szwalnia.SzwalniaDataSet7();
            this.szwalniaDataSet4 = new Szwalnia.SzwalniaDataSet4();
            this.dostawcyZaopatrzenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dostawcy_ZaopatrzenieTableAdapter = new Szwalnia.SzwalniaDataSet4TableAdapters.Dostawcy_ZaopatrzenieTableAdapter();
            this.kurierzyTableAdapter = new Szwalnia.SzwalniaDataSet7TableAdapters.KurierzyTableAdapter();
            this.btnDodajKuriera = new System.Windows.Forms.Button();
            this.btnWstecz = new System.Windows.Forms.Button();
            this.ID_Kurier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurierzy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurierzyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawcyZaopatrzenieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz kuriera z listy.";
            // 
            // dgvKurierzy
            // 
            this.dgvKurierzy.AutoGenerateColumns = false;
            this.dgvKurierzy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKurierzy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Kurier,
            this.nazwaDataGridViewTextBoxColumn,
            this.telefon1DataGridViewTextBoxColumn,
            this.telefon2DataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvKurierzy.DataSource = this.kurierzyBindingSource;
            this.dgvKurierzy.Location = new System.Drawing.Point(63, 84);
            this.dgvKurierzy.Name = "dgvKurierzy";
            this.dgvKurierzy.Size = new System.Drawing.Size(548, 328);
            this.dgvKurierzy.TabIndex = 1;
            this.dgvKurierzy.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKurierzy_CellDoubleClick);
            // 
            // kurierzyBindingSource
            // 
            this.kurierzyBindingSource.DataMember = "Kurierzy";
            this.kurierzyBindingSource.DataSource = this.szwalniaDataSet7;
            // 
            // szwalniaDataSet7
            // 
            this.szwalniaDataSet7.DataSetName = "SzwalniaDataSet7";
            this.szwalniaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // kurierzyTableAdapter
            // 
            this.kurierzyTableAdapter.ClearBeforeFill = true;
            // 
            // btnDodajKuriera
            // 
            this.btnDodajKuriera.Location = new System.Drawing.Point(393, 45);
            this.btnDodajKuriera.Name = "btnDodajKuriera";
            this.btnDodajKuriera.Size = new System.Drawing.Size(133, 24);
            this.btnDodajKuriera.TabIndex = 2;
            this.btnDodajKuriera.Text = "Dodaj nowego kuriera";
            this.btnDodajKuriera.UseVisualStyleBackColor = true;
            this.btnDodajKuriera.Click += new System.EventHandler(this.btnDodajKuriera_Click);
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(247, 40);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(75, 23);
            this.btnWstecz.TabIndex = 3;
            this.btnWstecz.Text = "button1";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // ID_Kurier
            // 
            this.ID_Kurier.DataPropertyName = "ID_Kurier";
            this.ID_Kurier.HeaderText = "ID_Kurier";
            this.ID_Kurier.Name = "ID_Kurier";
            this.ID_Kurier.ReadOnly = true;
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
            // KurierzyLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.btnDodajKuriera);
            this.Controls.Add(this.dgvKurierzy);
            this.Controls.Add(this.label1);
            this.Name = "KurierzyLista";
            this.Text = "KurierzyLista";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KurierzyLista_FormClosed);
            this.Load += new System.EventHandler(this.KurierzyLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurierzy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurierzyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawcyZaopatrzenieBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnDodajKuriera;
        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Kurier;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}