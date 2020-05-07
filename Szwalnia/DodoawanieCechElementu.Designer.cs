namespace Szwalnia
{
    partial class DodoawanieCechElementu
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
            this.txtSlowna = new System.Windows.Forms.TextBox();
            this.numWartosc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.dgvListaElementy = new System.Windows.Forms.DataGridView();
            this.dgvListaCecha = new System.Windows.Forms.DataGridView();
            this.dgvListaJednostek = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.szwalniaDataSet = new Szwalnia.SzwalniaDataSet();
            this.elementyJednostkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementy_JednostkiTableAdapter = new Szwalnia.SzwalniaDataSetTableAdapters.Elementy_JednostkiTableAdapter();
            this.iDjednostkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jednostkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szwalniaDataSet1 = new Szwalnia.SzwalniaDataSet1();
            this.elementyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementyTableAdapter = new Szwalnia.SzwalniaDataSet1TableAdapters.ElementyTableAdapter();
            this.iDElementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDElementTypDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementNazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okresPrzydatnosciMiesiaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szwalniaDataSet2 = new Szwalnia.SzwalniaDataSet2();
            this.elementyCechySlownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementy_Cechy_SlownikTableAdapter = new Szwalnia.SzwalniaDataSet2TableAdapters.Elementy_Cechy_SlownikTableAdapter();
            this.iDCechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIDElment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDCechy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDJednostka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numWartosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaElementy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaJednostek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyJednostkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyCechySlownikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSlowna
            // 
            this.txtSlowna.Location = new System.Drawing.Point(160, 115);
            this.txtSlowna.Name = "txtSlowna";
            this.txtSlowna.Size = new System.Drawing.Size(151, 22);
            this.txtSlowna.TabIndex = 9;
            // 
            // numWartosc
            // 
            this.numWartosc.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numWartosc.Location = new System.Drawing.Point(160, 87);
            this.numWartosc.Name = "numWartosc";
            this.numWartosc.Size = new System.Drawing.Size(120, 22);
            this.numWartosc.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wartość cechy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wartość słowna cechy";
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(103, 39);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(194, 17);
            this.lblMain.TabIndex = 5;
            this.lblMain.Text = "Dodawanie cech do elementu";
            // 
            // dgvListaElementy
            // 
            this.dgvListaElementy.AutoGenerateColumns = false;
            this.dgvListaElementy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaElementy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDElementDataGridViewTextBoxColumn,
            this.iDElementTypDataGridViewTextBoxColumn,
            this.elementNazwaDataGridViewTextBoxColumn,
            this.okresPrzydatnosciMiesiaceDataGridViewTextBoxColumn});
            this.dgvListaElementy.DataSource = this.elementyBindingSource;
            this.dgvListaElementy.Location = new System.Drawing.Point(358, 10);
            this.dgvListaElementy.Name = "dgvListaElementy";
            this.dgvListaElementy.RowHeadersWidth = 51;
            this.dgvListaElementy.RowTemplate.Height = 24;
            this.dgvListaElementy.Size = new System.Drawing.Size(240, 150);
            this.dgvListaElementy.TabIndex = 10;
            this.dgvListaElementy.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaElementy_CellContentDoubleClick);
            // 
            // dgvListaCecha
            // 
            this.dgvListaCecha.AutoGenerateColumns = false;
            this.dgvListaCecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCecha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCechaDataGridViewTextBoxColumn,
            this.cechaDataGridViewTextBoxColumn});
            this.dgvListaCecha.DataSource = this.elementyCechySlownikBindingSource;
            this.dgvListaCecha.Location = new System.Drawing.Point(358, 171);
            this.dgvListaCecha.Name = "dgvListaCecha";
            this.dgvListaCecha.RowHeadersWidth = 51;
            this.dgvListaCecha.RowTemplate.Height = 24;
            this.dgvListaCecha.Size = new System.Drawing.Size(240, 150);
            this.dgvListaCecha.TabIndex = 11;
            this.dgvListaCecha.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCecha_CellContentDoubleClick);
            // 
            // dgvListaJednostek
            // 
            this.dgvListaJednostek.AutoGenerateColumns = false;
            this.dgvListaJednostek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaJednostek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDjednostkaDataGridViewTextBoxColumn,
            this.jednostkaDataGridViewTextBoxColumn});
            this.dgvListaJednostek.DataSource = this.elementyJednostkiBindingSource;
            this.dgvListaJednostek.Location = new System.Drawing.Point(358, 327);
            this.dgvListaJednostek.Name = "dgvListaJednostek";
            this.dgvListaJednostek.RowHeadersWidth = 51;
            this.dgvListaJednostek.RowTemplate.Height = 24;
            this.dgvListaJednostek.Size = new System.Drawing.Size(240, 150);
            this.dgvListaJednostek.TabIndex = 12;
            this.dgvListaJednostek.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaJednostek_CellContentDoubleClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(259, 262);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 30);
            this.btnDodaj.TabIndex = 13;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // szwalniaDataSet
            // 
            this.szwalniaDataSet.DataSetName = "SzwalniaDataSet";
            this.szwalniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elementyJednostkiBindingSource
            // 
            this.elementyJednostkiBindingSource.DataMember = "Elementy_Jednostki";
            this.elementyJednostkiBindingSource.DataSource = this.szwalniaDataSet;
            // 
            // elementy_JednostkiTableAdapter
            // 
            this.elementy_JednostkiTableAdapter.ClearBeforeFill = true;
            // 
            // iDjednostkaDataGridViewTextBoxColumn
            // 
            this.iDjednostkaDataGridViewTextBoxColumn.DataPropertyName = "ID_jednostka";
            this.iDjednostkaDataGridViewTextBoxColumn.HeaderText = "ID_jednostka";
            this.iDjednostkaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDjednostkaDataGridViewTextBoxColumn.Name = "iDjednostkaDataGridViewTextBoxColumn";
            this.iDjednostkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDjednostkaDataGridViewTextBoxColumn.Width = 125;
            // 
            // jednostkaDataGridViewTextBoxColumn
            // 
            this.jednostkaDataGridViewTextBoxColumn.DataPropertyName = "Jednostka";
            this.jednostkaDataGridViewTextBoxColumn.HeaderText = "Jednostka";
            this.jednostkaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jednostkaDataGridViewTextBoxColumn.Name = "jednostkaDataGridViewTextBoxColumn";
            this.jednostkaDataGridViewTextBoxColumn.Width = 125;
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
            // szwalniaDataSet2
            // 
            this.szwalniaDataSet2.DataSetName = "SzwalniaDataSet2";
            this.szwalniaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elementyCechySlownikBindingSource
            // 
            this.elementyCechySlownikBindingSource.DataMember = "Elementy_Cechy_Slownik";
            this.elementyCechySlownikBindingSource.DataSource = this.szwalniaDataSet2;
            // 
            // elementy_Cechy_SlownikTableAdapter
            // 
            this.elementy_Cechy_SlownikTableAdapter.ClearBeforeFill = true;
            // 
            // iDCechaDataGridViewTextBoxColumn
            // 
            this.iDCechaDataGridViewTextBoxColumn.DataPropertyName = "ID_Cecha";
            this.iDCechaDataGridViewTextBoxColumn.HeaderText = "ID_Cecha";
            this.iDCechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCechaDataGridViewTextBoxColumn.Name = "iDCechaDataGridViewTextBoxColumn";
            this.iDCechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // cechaDataGridViewTextBoxColumn
            // 
            this.cechaDataGridViewTextBoxColumn.DataPropertyName = "Cecha";
            this.cechaDataGridViewTextBoxColumn.HeaderText = "Cecha";
            this.cechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cechaDataGridViewTextBoxColumn.Name = "cechaDataGridViewTextBoxColumn";
            this.cechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // txtIDElment
            // 
            this.txtIDElment.Location = new System.Drawing.Point(160, 143);
            this.txtIDElment.Name = "txtIDElment";
            this.txtIDElment.Size = new System.Drawing.Size(151, 22);
            this.txtIDElment.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID Elmentu";
            // 
            // txtIDCechy
            // 
            this.txtIDCechy.Location = new System.Drawing.Point(160, 171);
            this.txtIDCechy.Name = "txtIDCechy";
            this.txtIDCechy.Size = new System.Drawing.Size(151, 22);
            this.txtIDCechy.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID Cechy";
            // 
            // txtIDJednostka
            // 
            this.txtIDJednostka.Location = new System.Drawing.Point(160, 199);
            this.txtIDJednostka.Name = "txtIDJednostka";
            this.txtIDJednostka.Size = new System.Drawing.Size(151, 22);
            this.txtIDJednostka.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "ID Jednostki";
            // 
            // DodoawanieCechElementu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 500);
            this.Controls.Add(this.txtIDJednostka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIDCechy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDElment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvListaJednostek);
            this.Controls.Add(this.dgvListaCecha);
            this.Controls.Add(this.dgvListaElementy);
            this.Controls.Add(this.txtSlowna);
            this.Controls.Add(this.numWartosc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMain);
            this.Name = "DodoawanieCechElementu";
            this.Text = "DodoawanieCechElementu";
            this.Load += new System.EventHandler(this.DodoawanieCechElementu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numWartosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaElementy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaJednostek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyJednostkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyCechySlownikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSlowna;
        private System.Windows.Forms.NumericUpDown numWartosc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.DataGridView dgvListaElementy;
        private System.Windows.Forms.DataGridView dgvListaCecha;
        private System.Windows.Forms.DataGridView dgvListaJednostek;
        private System.Windows.Forms.Button btnDodaj;
        private SzwalniaDataSet szwalniaDataSet;
        private System.Windows.Forms.BindingSource elementyJednostkiBindingSource;
        private SzwalniaDataSetTableAdapters.Elementy_JednostkiTableAdapter elementy_JednostkiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDjednostkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jednostkaDataGridViewTextBoxColumn;
        private SzwalniaDataSet1 szwalniaDataSet1;
        private System.Windows.Forms.BindingSource elementyBindingSource;
        private SzwalniaDataSet1TableAdapters.ElementyTableAdapter elementyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDElementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDElementTypDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementNazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okresPrzydatnosciMiesiaceDataGridViewTextBoxColumn;
        private SzwalniaDataSet2 szwalniaDataSet2;
        private System.Windows.Forms.BindingSource elementyCechySlownikBindingSource;
        private SzwalniaDataSet2TableAdapters.Elementy_Cechy_SlownikTableAdapter elementy_Cechy_SlownikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtIDElment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDCechy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDJednostka;
        private System.Windows.Forms.Label label5;
    }
}