namespace Szwalnia
{
    partial class DodajUmoweKurier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajUmoweKurier));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numCzas = new System.Windows.Forms.NumericUpDown();
            this.numKosztKm = new System.Windows.Forms.NumericUpDown();
            this.numKosztStaly = new System.Windows.Forms.NumericUpDown();
            this.dtpDataZawarcia = new System.Windows.Forms.DateTimePicker();
            this.btnWstecz = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.cmbKurier = new System.Windows.Forms.ComboBox();
            this.kurierzyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numCzas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKosztKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKosztStaly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurierzyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wprowadź dane umowy.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa kuriera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data zawarcia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Czas dostawy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Koszt (za km)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Koszt stały";
            // 
            // numCzas
            // 
            this.numCzas.Location = new System.Drawing.Point(157, 103);
            this.numCzas.Name = "numCzas";
            this.numCzas.Size = new System.Drawing.Size(120, 20);
            this.numCzas.TabIndex = 7;
            // 
            // numKosztKm
            // 
            this.numKosztKm.Location = new System.Drawing.Point(158, 129);
            this.numKosztKm.Name = "numKosztKm";
            this.numKosztKm.Size = new System.Drawing.Size(120, 20);
            this.numKosztKm.TabIndex = 8;
            // 
            // numKosztStaly
            // 
            this.numKosztStaly.Location = new System.Drawing.Point(157, 155);
            this.numKosztStaly.Name = "numKosztStaly";
            this.numKosztStaly.Size = new System.Drawing.Size(120, 20);
            this.numKosztStaly.TabIndex = 9;
            // 
            // dtpDataZawarcia
            // 
            this.dtpDataZawarcia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataZawarcia.Location = new System.Drawing.Point(157, 76);
            this.dtpDataZawarcia.Name = "dtpDataZawarcia";
            this.dtpDataZawarcia.Size = new System.Drawing.Size(120, 20);
            this.dtpDataZawarcia.TabIndex = 10;
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(74, 200);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(75, 23);
            this.btnWstecz.TabIndex = 11;
            this.btnWstecz.Text = "Powrót";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(203, 200);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 12;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // cmbKurier
            // 
            this.cmbKurier.DataSource = this.kurierzyBindingSource;
            this.cmbKurier.DisplayMember = "Nazwa";
            this.cmbKurier.FormattingEnabled = true;
            this.cmbKurier.Location = new System.Drawing.Point(157, 50);
            this.cmbKurier.Name = "cmbKurier";
            this.cmbKurier.Size = new System.Drawing.Size(121, 21);
            this.cmbKurier.TabIndex = 6;
            this.cmbKurier.ValueMember = "Nazwa";
            // 
            // DodajUmoweKurier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 246);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.dtpDataZawarcia);
            this.Controls.Add(this.numKosztStaly);
            this.Controls.Add(this.numKosztKm);
            this.Controls.Add(this.numCzas);
            this.Controls.Add(this.cmbKurier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajUmoweKurier";
            this.Text = "Dodaj nową umowę z kurierem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DodajUmoweKurier_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numCzas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKosztKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKosztStaly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurierzyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCzas;
        private System.Windows.Forms.NumericUpDown numKosztKm;
        private System.Windows.Forms.NumericUpDown numKosztStaly;
        private System.Windows.Forms.DateTimePicker dtpDataZawarcia;
        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.ComboBox cmbKurier;
        private System.Windows.Forms.BindingSource kurierzyBindingSource;
    }
}