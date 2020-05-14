namespace Szwalnia
{
    partial class Oferty
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
            this.dgvOferty = new System.Windows.Forms.DataGridView();
            this.iDOfertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDElementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementOznaczenieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDostawcyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaJednDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataOfertyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscMinimalnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscMaksymalnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscWOpakowaniuPojedynczymDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDJednostkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscWOpakowaniuZbiorczymDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deklarowanyczasdostawyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofertaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.szwalniaOferta = new Szwalnia.SzwalniaOferta();
            this.btnDodajOferte = new System.Windows.Forms.Button();
            this.ofertaTableAdapter = new Szwalnia.SzwalniaOfertaTableAdapters.OfertaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOferty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaOferta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz z listy ofertę";
            // 
            // dgvOferty
            // 
            this.dgvOferty.AutoGenerateColumns = false;
            this.dgvOferty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOferty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOfertaDataGridViewTextBoxColumn,
            this.iDElementDataGridViewTextBoxColumn,
            this.elementOznaczenieDataGridViewTextBoxColumn,
            this.iDDostawcyDataGridViewTextBoxColumn,
            this.cenaJednDataGridViewTextBoxColumn,
            this.dataOfertyDataGridViewTextBoxColumn,
            this.iloscMinimalnaDataGridViewTextBoxColumn,
            this.iloscMaksymalnaDataGridViewTextBoxColumn,
            this.iloscWOpakowaniuPojedynczymDataGridViewTextBoxColumn,
            this.iDJednostkaDataGridViewTextBoxColumn,
            this.iloscWOpakowaniuZbiorczymDataGridViewTextBoxColumn,
            this.deklarowanyczasdostawyDataGridViewTextBoxColumn});
            this.dgvOferty.DataSource = this.ofertaBindingSource;
            this.dgvOferty.Location = new System.Drawing.Point(30, 67);
            this.dgvOferty.Name = "dgvOferty";
            this.dgvOferty.Size = new System.Drawing.Size(731, 253);
            this.dgvOferty.TabIndex = 3;
            this.dgvOferty.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOferty_CellDoubleClick);
            // 
            // iDOfertaDataGridViewTextBoxColumn
            // 
            this.iDOfertaDataGridViewTextBoxColumn.DataPropertyName = "ID_Oferta";
            this.iDOfertaDataGridViewTextBoxColumn.HeaderText = "ID_Oferta";
            this.iDOfertaDataGridViewTextBoxColumn.Name = "iDOfertaDataGridViewTextBoxColumn";
            this.iDOfertaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDElementDataGridViewTextBoxColumn
            // 
            this.iDElementDataGridViewTextBoxColumn.DataPropertyName = "ID_Element";
            this.iDElementDataGridViewTextBoxColumn.HeaderText = "ID_Element";
            this.iDElementDataGridViewTextBoxColumn.Name = "iDElementDataGridViewTextBoxColumn";
            // 
            // elementOznaczenieDataGridViewTextBoxColumn
            // 
            this.elementOznaczenieDataGridViewTextBoxColumn.DataPropertyName = "Element_Oznaczenie";
            this.elementOznaczenieDataGridViewTextBoxColumn.HeaderText = "Element_Oznaczenie";
            this.elementOznaczenieDataGridViewTextBoxColumn.Name = "elementOznaczenieDataGridViewTextBoxColumn";
            // 
            // iDDostawcyDataGridViewTextBoxColumn
            // 
            this.iDDostawcyDataGridViewTextBoxColumn.DataPropertyName = "ID_Dostawcy";
            this.iDDostawcyDataGridViewTextBoxColumn.HeaderText = "ID_Dostawcy";
            this.iDDostawcyDataGridViewTextBoxColumn.Name = "iDDostawcyDataGridViewTextBoxColumn";
            // 
            // cenaJednDataGridViewTextBoxColumn
            // 
            this.cenaJednDataGridViewTextBoxColumn.DataPropertyName = "Cena_Jedn";
            this.cenaJednDataGridViewTextBoxColumn.HeaderText = "Cena_Jedn";
            this.cenaJednDataGridViewTextBoxColumn.Name = "cenaJednDataGridViewTextBoxColumn";
            // 
            // dataOfertyDataGridViewTextBoxColumn
            // 
            this.dataOfertyDataGridViewTextBoxColumn.DataPropertyName = "Data_Oferty";
            this.dataOfertyDataGridViewTextBoxColumn.HeaderText = "Data_Oferty";
            this.dataOfertyDataGridViewTextBoxColumn.Name = "dataOfertyDataGridViewTextBoxColumn";
            // 
            // iloscMinimalnaDataGridViewTextBoxColumn
            // 
            this.iloscMinimalnaDataGridViewTextBoxColumn.DataPropertyName = "Ilosc_Minimalna";
            this.iloscMinimalnaDataGridViewTextBoxColumn.HeaderText = "Ilosc_Minimalna";
            this.iloscMinimalnaDataGridViewTextBoxColumn.Name = "iloscMinimalnaDataGridViewTextBoxColumn";
            // 
            // iloscMaksymalnaDataGridViewTextBoxColumn
            // 
            this.iloscMaksymalnaDataGridViewTextBoxColumn.DataPropertyName = "Ilosc_Maksymalna";
            this.iloscMaksymalnaDataGridViewTextBoxColumn.HeaderText = "Ilosc_Maksymalna";
            this.iloscMaksymalnaDataGridViewTextBoxColumn.Name = "iloscMaksymalnaDataGridViewTextBoxColumn";
            // 
            // iloscWOpakowaniuPojedynczymDataGridViewTextBoxColumn
            // 
            this.iloscWOpakowaniuPojedynczymDataGridViewTextBoxColumn.DataPropertyName = "Ilosc_W_Opakowaniu_Pojedynczym";
            this.iloscWOpakowaniuPojedynczymDataGridViewTextBoxColumn.HeaderText = "Ilosc_W_Opakowaniu_Pojedynczym";
            this.iloscWOpakowaniuPojedynczymDataGridViewTextBoxColumn.Name = "iloscWOpakowaniuPojedynczymDataGridViewTextBoxColumn";
            // 
            // iDJednostkaDataGridViewTextBoxColumn
            // 
            this.iDJednostkaDataGridViewTextBoxColumn.DataPropertyName = "ID_Jednostka";
            this.iDJednostkaDataGridViewTextBoxColumn.HeaderText = "ID_Jednostka";
            this.iDJednostkaDataGridViewTextBoxColumn.Name = "iDJednostkaDataGridViewTextBoxColumn";
            // 
            // iloscWOpakowaniuZbiorczymDataGridViewTextBoxColumn
            // 
            this.iloscWOpakowaniuZbiorczymDataGridViewTextBoxColumn.DataPropertyName = "Ilosc_W_Opakowaniu_Zbiorczym";
            this.iloscWOpakowaniuZbiorczymDataGridViewTextBoxColumn.HeaderText = "Ilosc_W_Opakowaniu_Zbiorczym";
            this.iloscWOpakowaniuZbiorczymDataGridViewTextBoxColumn.Name = "iloscWOpakowaniuZbiorczymDataGridViewTextBoxColumn";
            // 
            // deklarowanyczasdostawyDataGridViewTextBoxColumn
            // 
            this.deklarowanyczasdostawyDataGridViewTextBoxColumn.DataPropertyName = "Deklarowany_czas_dostawy";
            this.deklarowanyczasdostawyDataGridViewTextBoxColumn.HeaderText = "Deklarowany_czas_dostawy";
            this.deklarowanyczasdostawyDataGridViewTextBoxColumn.Name = "deklarowanyczasdostawyDataGridViewTextBoxColumn";
            // 
            // ofertaBindingSource
            // 
            this.ofertaBindingSource.DataMember = "Oferta";
            this.ofertaBindingSource.DataSource = this.szwalniaOferta;
            // 
            // szwalniaOferta
            // 
            this.szwalniaOferta.DataSetName = "SzwalniaOferta";
            this.szwalniaOferta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDodajOferte
            // 
            this.btnDodajOferte.Location = new System.Drawing.Point(517, 12);
            this.btnDodajOferte.Name = "btnDodajOferte";
            this.btnDodajOferte.Size = new System.Drawing.Size(122, 35);
            this.btnDodajOferte.TabIndex = 4;
            this.btnDodajOferte.Text = "Dodaj nową ofertę";
            this.btnDodajOferte.UseVisualStyleBackColor = true;
            this.btnDodajOferte.Click += new System.EventHandler(this.btnDodajOferte_Click);
            // 
            // ofertaTableAdapter
            // 
            this.ofertaTableAdapter.ClearBeforeFill = true;
            // 
            // Oferty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.btnDodajOferte);
            this.Controls.Add(this.dgvOferty);
            this.Controls.Add(this.label1);
            this.Name = "Oferty";
            this.Text = "Oferty";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Oferty_FormClosed);
            this.Load += new System.EventHandler(this.Oferty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOferty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaOferta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOferty;
        private System.Windows.Forms.Button btnDodajOferte;
        private SzwalniaOferta szwalniaOferta;
        private System.Windows.Forms.BindingSource ofertaBindingSource;
        private SzwalniaOfertaTableAdapters.OfertaTableAdapter ofertaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOfertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDElementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementOznaczenieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDostawcyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaJednDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOfertyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscMinimalnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscMaksymalnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscWOpakowaniuPojedynczymDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDJednostkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscWOpakowaniuZbiorczymDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deklarowanyczasdostawyDataGridViewTextBoxColumn;
    }
}