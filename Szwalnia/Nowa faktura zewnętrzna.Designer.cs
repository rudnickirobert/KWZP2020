namespace Szwalnia
{
    partial class NowaFakturaZewnetrzna
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
            this.lblNumerFaktury = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvUkryty = new System.Windows.Forms.DataGridView();
            this.cbGrupa = new System.Windows.Forms.ComboBox();
            this.txtGrupa = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.txtWartoscPodatku = new System.Windows.Forms.TextBox();
            this.txtKosztBrutto = new System.Windows.Forms.TextBox();
            this.txtKosztNetto = new System.Windows.Forms.TextBox();
            this.txtNazwaFirmy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNrFaktury = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUkryty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumerFaktury
            // 
            this.lblNumerFaktury.AutoSize = true;
            this.lblNumerFaktury.Location = new System.Drawing.Point(131, 9);
            this.lblNumerFaktury.Name = "lblNumerFaktury";
            this.lblNumerFaktury.Size = new System.Drawing.Size(46, 17);
            this.lblNumerFaktury.TabIndex = 33;
            this.lblNumerFaktury.Text = "label7";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(108, 17);
            this.lblId.TabIndex = 32;
            this.lblId.Text = "ID nowej faktury";
            // 
            // dgvUkryty
            // 
            this.dgvUkryty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUkryty.Location = new System.Drawing.Point(379, 9);
            this.dgvUkryty.Name = "dgvUkryty";
            this.dgvUkryty.RowHeadersWidth = 51;
            this.dgvUkryty.RowTemplate.Height = 24;
            this.dgvUkryty.Size = new System.Drawing.Size(17, 17);
            this.dgvUkryty.TabIndex = 31;
            // 
            // cbGrupa
            // 
            this.cbGrupa.FormattingEnabled = true;
            this.cbGrupa.Location = new System.Drawing.Point(134, 215);
            this.cbGrupa.Name = "cbGrupa";
            this.cbGrupa.Size = new System.Drawing.Size(262, 24);
            this.cbGrupa.TabIndex = 30;
            // 
            // txtGrupa
            // 
            this.txtGrupa.AutoSize = true;
            this.txtGrupa.Location = new System.Drawing.Point(12, 222);
            this.txtGrupa.Name = "txtGrupa";
            this.txtGrupa.Size = new System.Drawing.Size(48, 17);
            this.txtGrupa.TabIndex = 29;
            this.txtGrupa.Text = "Grupa";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(133, 256);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 36);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(15, 256);
            this.btnZamknij.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(101, 36);
            this.btnZamknij.TabIndex = 27;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // txtWartoscPodatku
            // 
            this.txtWartoscPodatku.Location = new System.Drawing.Point(133, 182);
            this.txtWartoscPodatku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWartoscPodatku.Name = "txtWartoscPodatku";
            this.txtWartoscPodatku.Size = new System.Drawing.Size(263, 22);
            this.txtWartoscPodatku.TabIndex = 26;
            // 
            // txtKosztBrutto
            // 
            this.txtKosztBrutto.Location = new System.Drawing.Point(133, 147);
            this.txtKosztBrutto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKosztBrutto.Name = "txtKosztBrutto";
            this.txtKosztBrutto.Size = new System.Drawing.Size(263, 22);
            this.txtKosztBrutto.TabIndex = 25;
            // 
            // txtKosztNetto
            // 
            this.txtKosztNetto.Location = new System.Drawing.Point(133, 107);
            this.txtKosztNetto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKosztNetto.Name = "txtKosztNetto";
            this.txtKosztNetto.Size = new System.Drawing.Size(263, 22);
            this.txtKosztNetto.TabIndex = 24;
            // 
            // txtNazwaFirmy
            // 
            this.txtNazwaFirmy.Location = new System.Drawing.Point(133, 70);
            this.txtNazwaFirmy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNazwaFirmy.Name = "txtNazwaFirmy";
            this.txtNazwaFirmy.Size = new System.Drawing.Size(263, 22);
            this.txtNazwaFirmy.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Wartość Podatku";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Koszt Brutto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Koszt Netto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nazwa Firmy";
            // 
            // txtNrFaktury
            // 
            this.txtNrFaktury.Location = new System.Drawing.Point(133, 35);
            this.txtNrFaktury.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNrFaktury.Name = "txtNrFaktury";
            this.txtNrFaktury.Size = new System.Drawing.Size(263, 22);
            this.txtNrFaktury.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nr. Faktury";
            // 
            // NowaFakturaZewnetrzna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 303);
            this.Controls.Add(this.lblNumerFaktury);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvUkryty);
            this.Controls.Add(this.cbGrupa);
            this.Controls.Add(this.txtGrupa);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.txtWartoscPodatku);
            this.Controls.Add(this.txtKosztBrutto);
            this.Controls.Add(this.txtKosztNetto);
            this.Controls.Add(this.txtNazwaFirmy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNrFaktury);
            this.Controls.Add(this.label1);
            this.Name = "NowaFakturaZewnetrzna";
            this.Text = "Nowa faktura zewnętrzna";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUkryty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumerFaktury;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvUkryty;
        private System.Windows.Forms.ComboBox cbGrupa;
        private System.Windows.Forms.Label txtGrupa;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.TextBox txtWartoscPodatku;
        private System.Windows.Forms.TextBox txtKosztBrutto;
        private System.Windows.Forms.TextBox txtKosztNetto;
        private System.Windows.Forms.TextBox txtNazwaFirmy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNrFaktury;
        private System.Windows.Forms.Label label1;
    }
}