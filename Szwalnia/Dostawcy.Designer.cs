namespace Szwalnia
{
    partial class Dostawcy
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvDostawcy = new System.Windows.Forms.DataGridView();
            this.iDDostawcyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostawcyZaopatrzenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.szwalniaDataSet6 = new Szwalnia.SzwalniaDataSet6();
            this.dostawcy_ZaopatrzenieTableAdapter = new Szwalnia.SzwalniaDataSet6TableAdapters.Dostawcy_ZaopatrzenieTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWstecz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostawcy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawcyZaopatrzenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(405, 22);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(139, 23);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj nowego dostawcę";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvDostawcy
            // 
            this.dgvDostawcy.AutoGenerateColumns = false;
            this.dgvDostawcy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDostawcy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDostawcyDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.telefon1DataGridViewTextBoxColumn,
            this.telefon2DataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvDostawcy.DataSource = this.dostawcyZaopatrzenieBindingSource;
            this.dgvDostawcy.Location = new System.Drawing.Point(12, 70);
            this.dgvDostawcy.Name = "dgvDostawcy";
            this.dgvDostawcy.Size = new System.Drawing.Size(548, 251);
            this.dgvDostawcy.TabIndex = 1;
            this.dgvDostawcy.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDostawcy_CellContentDoubleClick);
            // 
            // iDDostawcyDataGridViewTextBoxColumn
            // 
            this.iDDostawcyDataGridViewTextBoxColumn.DataPropertyName = "ID_Dostawcy";
            this.iDDostawcyDataGridViewTextBoxColumn.HeaderText = "ID_Dostawcy";
            this.iDDostawcyDataGridViewTextBoxColumn.Name = "iDDostawcyDataGridViewTextBoxColumn";
            this.iDDostawcyDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dostawcyZaopatrzenieBindingSource
            // 
            this.dostawcyZaopatrzenieBindingSource.DataMember = "Dostawcy_Zaopatrzenie";
            this.dostawcyZaopatrzenieBindingSource.DataSource = this.szwalniaDataSet6;
            // 
            // szwalniaDataSet6
            // 
            this.szwalniaDataSet6.DataSetName = "SzwalniaDataSet6";
            this.szwalniaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dostawcy_ZaopatrzenieTableAdapter
            // 
            this.dostawcy_ZaopatrzenieTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz dostawcę z listy.";
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(290, 22);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(75, 23);
            this.btnWstecz.TabIndex = 3;
            this.btnWstecz.Text = "btnWstecz";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // Dostawcy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDostawcy);
            this.Controls.Add(this.btnDodaj);
            this.Name = "Dostawcy";
            this.Text = "Dostawcy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dostawcy_FormClosed);
            this.Load += new System.EventHandler(this.Dostawcy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDostawcy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawcyZaopatrzenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvDostawcy;
        private SzwalniaDataSet6 szwalniaDataSet6;
        private System.Windows.Forms.BindingSource dostawcyZaopatrzenieBindingSource;
        private SzwalniaDataSet6TableAdapters.Dostawcy_ZaopatrzenieTableAdapter dostawcy_ZaopatrzenieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDostawcyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWstecz;
    }
}