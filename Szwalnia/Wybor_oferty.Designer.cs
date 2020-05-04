namespace Szwalnia
{
    partial class Wybor_oferty
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
            this.lblMain = new System.Windows.Forms.Label();
            this.lblElement = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnWyszukaj = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.numUpElement = new System.Windows.Forms.NumericUpDown();
            this.szwalniaDataSet1 = new Szwalnia.SzwalniaDataSet1();
            this.elementyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementyTableAdapter = new Szwalnia.SzwalniaDataSet1TableAdapters.ElementyTableAdapter();
            this.iDElementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDElementTypDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementNazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okresPrzydatnosciMiesiaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMain.Location = new System.Drawing.Point(178, 32);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(259, 46);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Wybór oferty";
            // 
            // lblElement
            // 
            this.lblElement.AutoSize = true;
            this.lblElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblElement.Location = new System.Drawing.Point(37, 115);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(267, 18);
            this.lblElement.TabIndex = 1;
            this.lblElement.Text = "Wprowadź ID wyszukiwanego elemntu:";
            this.lblElement.Click += new System.EventHandler(this.lblElement_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDElementDataGridViewTextBoxColumn,
            this.iDElementTypDataGridViewTextBoxColumn,
            this.elementNazwaDataGridViewTextBoxColumn,
            this.okresPrzydatnosciMiesiaceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.elementyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(566, 247);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnWyszukaj
            // 
            this.btnWyszukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyszukaj.Location = new System.Drawing.Point(433, 104);
            this.btnWyszukaj.Name = "btnWyszukaj";
            this.btnWyszukaj.Size = new System.Drawing.Size(131, 42);
            this.btnWyszukaj.TabIndex = 4;
            this.btnWyszukaj.Text = "Wyszukaj";
            this.btnWyszukaj.UseVisualStyleBackColor = true;
            this.btnWyszukaj.Click += new System.EventHandler(this.btnWyszukaj_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblError.Location = new System.Drawing.Point(205, 164);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(199, 20);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Niepoprawny numer ID";
            this.lblError.Visible = false;
            // 
            // numUpElement
            // 
            this.numUpElement.Location = new System.Drawing.Point(311, 115);
            this.numUpElement.Name = "numUpElement";
            this.numUpElement.Size = new System.Drawing.Size(67, 22);
            this.numUpElement.TabIndex = 6;
            // 
            // szwalniaDataSet1
            // 
            this.szwalniaDataSet1.DataSetName = "SzwalniaDataSet1";
            this.szwalniaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elementyBindingSource
            // 
            this.elementyBindingSource.DataMember = "Elementy";
            this.elementyBindingSource.DataSource = this.szwalniaDataSet1;
            // 
            // elementyTableAdapter
            // 
            this.elementyTableAdapter.ClearBeforeFill = true;
            // 
            // iDElementDataGridViewTextBoxColumn
            // 
            this.iDElementDataGridViewTextBoxColumn.DataPropertyName = "ID_Element";
            this.iDElementDataGridViewTextBoxColumn.HeaderText = "ID_Element";
            this.iDElementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDElementDataGridViewTextBoxColumn.Name = "iDElementDataGridViewTextBoxColumn";
            this.iDElementDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDElementDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDElementTypDataGridViewTextBoxColumn
            // 
            this.iDElementTypDataGridViewTextBoxColumn.DataPropertyName = "ID_Element_Typ";
            this.iDElementTypDataGridViewTextBoxColumn.HeaderText = "ID_Element_Typ";
            this.iDElementTypDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDElementTypDataGridViewTextBoxColumn.Name = "iDElementTypDataGridViewTextBoxColumn";
            this.iDElementTypDataGridViewTextBoxColumn.Width = 125;
            // 
            // elementNazwaDataGridViewTextBoxColumn
            // 
            this.elementNazwaDataGridViewTextBoxColumn.DataPropertyName = "Element_Nazwa";
            this.elementNazwaDataGridViewTextBoxColumn.HeaderText = "Element_Nazwa";
            this.elementNazwaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.elementNazwaDataGridViewTextBoxColumn.Name = "elementNazwaDataGridViewTextBoxColumn";
            this.elementNazwaDataGridViewTextBoxColumn.Width = 125;
            // 
            // okresPrzydatnosciMiesiaceDataGridViewTextBoxColumn
            // 
            this.okresPrzydatnosciMiesiaceDataGridViewTextBoxColumn.DataPropertyName = "Okres_Przydatnosci_Miesiace";
            this.okresPrzydatnosciMiesiaceDataGridViewTextBoxColumn.HeaderText = "Okres_Przydatnosci_Miesiace";
            this.okresPrzydatnosciMiesiaceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.okresPrzydatnosciMiesiaceDataGridViewTextBoxColumn.Name = "okresPrzydatnosciMiesiaceDataGridViewTextBoxColumn";
            this.okresPrzydatnosciMiesiaceDataGridViewTextBoxColumn.Width = 125;
            // 
            // Wybor_oferty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 496);
            this.Controls.Add(this.numUpElement);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnWyszukaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblElement);
            this.Controls.Add(this.lblMain);
            this.Name = "Wybor_oferty";
            this.Text = "Wybor_oferty";
            this.Load += new System.EventHandler(this.Wybor_oferty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnWyszukaj;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.NumericUpDown numUpElement;
        private SzwalniaDataSet1 szwalniaDataSet1;
        private System.Windows.Forms.BindingSource elementyBindingSource;
        private SzwalniaDataSet1TableAdapters.ElementyTableAdapter elementyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDElementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDElementTypDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementNazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okresPrzydatnosciMiesiaceDataGridViewTextBoxColumn;
    }
}