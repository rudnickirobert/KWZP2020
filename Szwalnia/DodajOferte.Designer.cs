namespace Szwalnia
{
    partial class DodajOferte
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOznacz = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.numIloscPoj = new System.Windows.Forms.NumericUpDown();
            this.cmbDostawca = new System.Windows.Forms.ComboBox();
            this.szwalniaDataSet4 = new Szwalnia.SzwalniaDataSet4();
            this.cmbJednostka = new System.Windows.Forms.ComboBox();
            this.elementyJednostkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jednostki = new Szwalnia.Jednostki();
            this.numCenaJedn = new System.Windows.Forms.NumericUpDown();
            this.numIloscMin = new System.Windows.Forms.NumericUpDown();
            this.numIloscMax = new System.Windows.Forms.NumericUpDown();
            this.numIloscZbiorcza = new System.Windows.Forms.NumericUpDown();
            this.szwalniaDataSet = new Szwalnia.SzwalniaDataSet();
            this.szwalniaDataSet1 = new Szwalnia.SzwalniaDataSet1();
            this.szwalniaOferta = new Szwalnia.SzwalniaOferta();
            this.cmbElement = new System.Windows.Forms.ComboBox();
            this.elementyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.szwalniaDataSet5 = new Szwalnia.SzwalniaDataSet5();
            this.szwalniaDataSet3 = new Szwalnia.SzwalniaDataSet3();
            this.elementyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementyTableAdapter = new Szwalnia.SzwalniaDataSet3TableAdapters.ElementyTableAdapter();
            this.dostawcyZaopatrzenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dostawcy_ZaopatrzenieTableAdapter = new Szwalnia.SzwalniaDataSet4TableAdapters.Dostawcy_ZaopatrzenieTableAdapter();
            this.elementy_JednostkiTableAdapter = new Szwalnia.JednostkiTableAdapters.Elementy_JednostkiTableAdapter();
            this.elementyTableAdapter1 = new Szwalnia.SzwalniaDataSet5TableAdapters.ElementyTableAdapter();
            this.numCzasDostawy = new System.Windows.Forms.NumericUpDown();
            this.dtpDataOferty = new System.Windows.Forms.DateTimePicker();
            this.btnWstecz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numIloscPoj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyJednostkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jednostki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCenaJedn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIloscMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIloscMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIloscZbiorcza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaOferta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawcyZaopatrzenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCzasDostawy)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(313, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 35);
            this.label12.TabIndex = 38;
            this.label12.Text = "Deklarowany czas dostawy (w godz)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(313, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Ilość w opak. zbiorczym";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Jednostka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Ilość w opak.poj.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Ilość max.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Ilość min.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Data oferty";
            // 
            // txtOznacz
            // 
            this.txtOznacz.Location = new System.Drawing.Point(117, 109);
            this.txtOznacz.Name = "txtOznacz";
            this.txtOznacz.Size = new System.Drawing.Size(100, 20);
            this.txtOznacz.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Cena jedn.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Dostawca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Oznaczenie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Element";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(208, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Wprowadź dane oferty:";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(460, 233);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(92, 34);
            this.btnZapisz.TabIndex = 47;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // numIloscPoj
            // 
            this.numIloscPoj.Location = new System.Drawing.Point(460, 77);
            this.numIloscPoj.Name = "numIloscPoj";
            this.numIloscPoj.Size = new System.Drawing.Size(100, 20);
            this.numIloscPoj.TabIndex = 48;
            // 
            // cmbDostawca
            // 
            this.cmbDostawca.DataSource = this.szwalniaDataSet4;
            this.cmbDostawca.DisplayMember = "Dostawcy_Zaopatrzenie.Nazwa";
            this.cmbDostawca.FormattingEnabled = true;
            this.cmbDostawca.Location = new System.Drawing.Point(117, 143);
            this.cmbDostawca.Name = "cmbDostawca";
            this.cmbDostawca.Size = new System.Drawing.Size(100, 21);
            this.cmbDostawca.TabIndex = 49;
            // 
            // szwalniaDataSet4
            // 
            this.szwalniaDataSet4.DataSetName = "SzwalniaDataSet4";
            this.szwalniaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbJednostka
            // 
            this.cmbJednostka.DataSource = this.elementyJednostkiBindingSource;
            this.cmbJednostka.DisplayMember = "Jednostka";
            this.cmbJednostka.FormattingEnabled = true;
            this.cmbJednostka.Location = new System.Drawing.Point(460, 109);
            this.cmbJednostka.Name = "cmbJednostka";
            this.cmbJednostka.Size = new System.Drawing.Size(100, 21);
            this.cmbJednostka.TabIndex = 50;
            // 
            // elementyJednostkiBindingSource
            // 
            this.elementyJednostkiBindingSource.DataMember = "Elementy_Jednostki";
            this.elementyJednostkiBindingSource.DataSource = this.jednostki;
            // 
            // jednostki
            // 
            this.jednostki.DataSetName = "Jednostki";
            this.jednostki.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numCenaJedn
            // 
            this.numCenaJedn.Location = new System.Drawing.Point(117, 178);
            this.numCenaJedn.Name = "numCenaJedn";
            this.numCenaJedn.Size = new System.Drawing.Size(100, 20);
            this.numCenaJedn.TabIndex = 51;
            // 
            // numIloscMin
            // 
            this.numIloscMin.Location = new System.Drawing.Point(117, 252);
            this.numIloscMin.Name = "numIloscMin";
            this.numIloscMin.Size = new System.Drawing.Size(100, 20);
            this.numIloscMin.TabIndex = 52;
            // 
            // numIloscMax
            // 
            this.numIloscMax.Location = new System.Drawing.Point(117, 284);
            this.numIloscMax.Name = "numIloscMax";
            this.numIloscMax.Size = new System.Drawing.Size(100, 20);
            this.numIloscMax.TabIndex = 53;
            // 
            // numIloscZbiorcza
            // 
            this.numIloscZbiorcza.Location = new System.Drawing.Point(460, 144);
            this.numIloscZbiorcza.Name = "numIloscZbiorcza";
            this.numIloscZbiorcza.Size = new System.Drawing.Size(100, 20);
            this.numIloscZbiorcza.TabIndex = 54;
            // 
            // szwalniaDataSet
            // 
            this.szwalniaDataSet.DataSetName = "SzwalniaDataSet";
            this.szwalniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // szwalniaDataSet1
            // 
            this.szwalniaDataSet1.DataSetName = "SzwalniaDataSet1";
            this.szwalniaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // szwalniaOferta
            // 
            this.szwalniaOferta.DataSetName = "SzwalniaOferta";
            this.szwalniaOferta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbElement
            // 
            this.cmbElement.DataSource = this.elementyBindingSource1;
            this.cmbElement.DisplayMember = "Element_Nazwa";
            this.cmbElement.FormattingEnabled = true;
            this.cmbElement.Location = new System.Drawing.Point(117, 76);
            this.cmbElement.Name = "cmbElement";
            this.cmbElement.Size = new System.Drawing.Size(100, 21);
            this.cmbElement.TabIndex = 46;
            this.cmbElement.ValueMember = "ID_Element_Typ";
            // 
            // elementyBindingSource1
            // 
            this.elementyBindingSource1.DataMember = "Elementy";
            this.elementyBindingSource1.DataSource = this.szwalniaDataSet5;
            // 
            // szwalniaDataSet5
            // 
            this.szwalniaDataSet5.DataSetName = "SzwalniaDataSet5";
            this.szwalniaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // szwalniaDataSet3
            // 
            this.szwalniaDataSet3.DataSetName = "SzwalniaDataSet3";
            this.szwalniaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elementyBindingSource
            // 
            this.elementyBindingSource.DataMember = "Elementy";
            this.elementyBindingSource.DataSource = this.szwalniaDataSet3;
            // 
            // elementyTableAdapter
            // 
            this.elementyTableAdapter.ClearBeforeFill = true;
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
            // elementy_JednostkiTableAdapter
            // 
            this.elementy_JednostkiTableAdapter.ClearBeforeFill = true;
            // 
            // elementyTableAdapter1
            // 
            this.elementyTableAdapter1.ClearBeforeFill = true;
            // 
            // numCzasDostawy
            // 
            this.numCzasDostawy.Location = new System.Drawing.Point(460, 173);
            this.numCzasDostawy.Name = "numCzasDostawy";
            this.numCzasDostawy.Size = new System.Drawing.Size(100, 20);
            this.numCzasDostawy.TabIndex = 55;
            // 
            // dtpDataOferty
            // 
            this.dtpDataOferty.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataOferty.Location = new System.Drawing.Point(117, 213);
            this.dtpDataOferty.Name = "dtpDataOferty";
            this.dtpDataOferty.Size = new System.Drawing.Size(100, 20);
            this.dtpDataOferty.TabIndex = 56;
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(316, 233);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(53, 34);
            this.btnWstecz.TabIndex = 57;
            this.btnWstecz.Text = "button1";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // DodajOferte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 329);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.dtpDataOferty);
            this.Controls.Add(this.numCzasDostawy);
            this.Controls.Add(this.numIloscZbiorcza);
            this.Controls.Add(this.numIloscMax);
            this.Controls.Add(this.numIloscMin);
            this.Controls.Add(this.numCenaJedn);
            this.Controls.Add(this.cmbJednostka);
            this.Controls.Add(this.cmbDostawca);
            this.Controls.Add(this.numIloscPoj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.cmbElement);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOznacz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajOferte";
            this.Text = "Dodaj nową ofertę";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DodajOferte_FormClosed);
            this.Load += new System.EventHandler(this.DodajOferte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numIloscPoj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyJednostkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jednostki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCenaJedn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIloscMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIloscMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIloscZbiorcza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaOferta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szwalniaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dostawcyZaopatrzenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCzasDostawy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOznacz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.NumericUpDown numIloscPoj;
        private System.Windows.Forms.ComboBox cmbDostawca;
        private System.Windows.Forms.ComboBox cmbJednostka;
        private System.Windows.Forms.NumericUpDown numCenaJedn;
        private System.Windows.Forms.NumericUpDown numIloscMin;
        private System.Windows.Forms.NumericUpDown numIloscMax;
        private System.Windows.Forms.NumericUpDown numIloscZbiorcza;
        private SzwalniaDataSet szwalniaDataSet;
        private SzwalniaDataSet1 szwalniaDataSet1;
        private SzwalniaOferta szwalniaOferta;
        private System.Windows.Forms.ComboBox cmbElement;
        private SzwalniaDataSet3 szwalniaDataSet3;
        private System.Windows.Forms.BindingSource elementyBindingSource;
        private SzwalniaDataSet3TableAdapters.ElementyTableAdapter elementyTableAdapter;
        private SzwalniaDataSet4 szwalniaDataSet4;
        private System.Windows.Forms.BindingSource dostawcyZaopatrzenieBindingSource;
        private SzwalniaDataSet4TableAdapters.Dostawcy_ZaopatrzenieTableAdapter dostawcy_ZaopatrzenieTableAdapter;
        private Jednostki jednostki;
        private System.Windows.Forms.BindingSource elementyJednostkiBindingSource;
        private JednostkiTableAdapters.Elementy_JednostkiTableAdapter elementy_JednostkiTableAdapter;
        private SzwalniaDataSet5 szwalniaDataSet5;
        private System.Windows.Forms.BindingSource elementyBindingSource1;
        private SzwalniaDataSet5TableAdapters.ElementyTableAdapter elementyTableAdapter1;
        private System.Windows.Forms.NumericUpDown numCzasDostawy;
        private System.Windows.Forms.DateTimePicker dtpDataOferty;
        private System.Windows.Forms.Button btnWstecz;
    }
}