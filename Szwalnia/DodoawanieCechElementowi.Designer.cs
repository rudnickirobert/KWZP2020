namespace Szwalnia
{
    partial class DodoawanieCechElementowi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodoawanieCechElementowi));
            this.dgvListaCech = new System.Windows.Forms.DataGridView();
            this.dgvListaJednostek = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtSlowna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.numCecha = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCechy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJednostka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWstecz = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRejestr = new System.Windows.Forms.Button();
            this.txtTyp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaJednostek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCecha)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaCech
            // 
            this.dgvListaCech.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaCech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCech.Location = new System.Drawing.Point(302, 186);
            this.dgvListaCech.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListaCech.Name = "dgvListaCech";
            this.dgvListaCech.RowHeadersWidth = 51;
            this.dgvListaCech.RowTemplate.Height = 24;
            this.dgvListaCech.Size = new System.Drawing.Size(248, 154);
            this.dgvListaCech.TabIndex = 1;
            this.dgvListaCech.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCech_CellContentDoubleClick);
            // 
            // dgvListaJednostek
            // 
            this.dgvListaJednostek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaJednostek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaJednostek.Location = new System.Drawing.Point(302, 27);
            this.dgvListaJednostek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListaJednostek.Name = "dgvListaJednostek";
            this.dgvListaJednostek.RowHeadersWidth = 51;
            this.dgvListaJednostek.RowTemplate.Height = 24;
            this.dgvListaJednostek.Size = new System.Drawing.Size(248, 154);
            this.dgvListaJednostek.TabIndex = 2;
            this.dgvListaJednostek.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaJednostek_CellContentDoubleClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(9, 254);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(146, 24);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj ceche elementowi";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtSlowna
            // 
            this.txtSlowna.Location = new System.Drawing.Point(128, 137);
            this.txtSlowna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSlowna.Name = "txtSlowna";
            this.txtSlowna.Size = new System.Drawing.Size(126, 20);
            this.txtSlowna.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Wartość słowna cechy";
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(79, 28);
            this.lblMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(142, 13);
            this.lblMain.TabIndex = 11;
            this.lblMain.Text = "Dodawanie cech elementom";
            // 
            // numCecha
            // 
            this.numCecha.Location = new System.Drawing.Point(128, 160);
            this.numCecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numCecha.Name = "numCecha";
            this.numCecha.Size = new System.Drawing.Size(102, 20);
            this.numCecha.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Wartość cechy";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Enabled = false;
            this.txtNazwa.Location = new System.Drawing.Point(128, 74);
            this.txtNazwa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.ReadOnly = true;
            this.txtNazwa.Size = new System.Drawing.Size(126, 20);
            this.txtNazwa.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nazwa Elementu";
            // 
            // txtCechy
            // 
            this.txtCechy.Enabled = false;
            this.txtCechy.Location = new System.Drawing.Point(128, 116);
            this.txtCechy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCechy.Name = "txtCechy";
            this.txtCechy.ReadOnly = true;
            this.txtCechy.Size = new System.Drawing.Size(126, 20);
            this.txtCechy.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nazwa cechy";
            // 
            // txtJednostka
            // 
            this.txtJednostka.Enabled = false;
            this.txtJednostka.Location = new System.Drawing.Point(128, 182);
            this.txtJednostka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJednostka.Name = "txtJednostka";
            this.txtJednostka.ReadOnly = true;
            this.txtJednostka.Size = new System.Drawing.Size(126, 20);
            this.txtJednostka.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Jednostka";
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(9, 310);
            this.btnWstecz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(146, 23);
            this.btnWstecz.TabIndex = 23;
            this.btnWstecz.Text = "Wstecz";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Wybierz nazwę cechy i jednostki:";
            // 
            // btnRejestr
            // 
            this.btnRejestr.Location = new System.Drawing.Point(9, 281);
            this.btnRejestr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRejestr.Name = "btnRejestr";
            this.btnRejestr.Size = new System.Drawing.Size(146, 24);
            this.btnRejestr.TabIndex = 25;
            this.btnRejestr.Text = "Dodaj cechę do typu";
            this.btnRejestr.UseVisualStyleBackColor = true;
            this.btnRejestr.Click += new System.EventHandler(this.btnRejestr_Click);
            // 
            // txtTyp
            // 
            this.txtTyp.Enabled = false;
            this.txtTyp.Location = new System.Drawing.Point(128, 95);
            this.txtTyp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.ReadOnly = true;
            this.txtTyp.Size = new System.Drawing.Size(126, 20);
            this.txtTyp.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nazwa typu";
            // 
            // DodoawanieCechElementowi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 350);
            this.Controls.Add(this.txtTyp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRejestr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.txtJednostka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCechy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numCecha);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtSlowna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.dgvListaJednostek);
            this.Controls.Add(this.dgvListaCech);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DodoawanieCechElementowi";
            this.Text = "Dodawanie cech elementowi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaJednostek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListaCech;
        private System.Windows.Forms.DataGridView dgvListaJednostek;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtSlowna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.NumericUpDown numCecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCechy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJednostka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRejestr;
        private System.Windows.Forms.TextBox txtTyp;
        private System.Windows.Forms.Label label7;
    }
}