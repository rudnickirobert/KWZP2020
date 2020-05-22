namespace Szwalnia
{
    partial class ElementyZamowienia
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
            this.btnNowy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIlosc = new System.Windows.Forms.TextBox();
            this.cbElement = new System.Windows.Forms.ComboBox();
            this.lblStary = new System.Windows.Forms.Label();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.cbIDZamowienia = new System.Windows.Forms.ComboBox();
            this.lblIDZamowienia = new System.Windows.Forms.Label();
            this.btnNastepny = new System.Windows.Forms.Button();
            this.btnNowyTyp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNowy
            // 
            this.btnNowy.Location = new System.Drawing.Point(210, 145);
            this.btnNowy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNowy.Name = "btnNowy";
            this.btnNowy.Size = new System.Drawing.Size(183, 32);
            this.btnNowy.TabIndex = 0;
            this.btnNowy.Text = "Dodaj nowy element";
            this.btnNowy.UseVisualStyleBackColor = true;
            this.btnNowy.Click += new System.EventHandler(this.btnNowy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ilość";
            // 
            // txtIlosc
            // 
            this.txtIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIlosc.Location = new System.Drawing.Point(83, 145);
            this.txtIlosc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(123, 32);
            this.txtIlosc.TabIndex = 2;
            // 
            // cbElement
            // 
            this.cbElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbElement.FormattingEnabled = true;
            this.cbElement.Location = new System.Drawing.Point(9, 95);
            this.cbElement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbElement.Name = "cbElement";
            this.cbElement.Size = new System.Drawing.Size(385, 34);
            this.cbElement.TabIndex = 3;
            // 
            // lblStary
            // 
            this.lblStary.AutoSize = true;
            this.lblStary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStary.Location = new System.Drawing.Point(9, 54);
            this.lblStary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStary.Name = "lblStary";
            this.lblStary.Size = new System.Drawing.Size(399, 26);
            this.lblStary.TabIndex = 5;
            this.lblStary.Text = "Wybierz  element z listy lub dodaj nowy ";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(11, 229);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(70, 44);
            this.btnAnuluj.TabIndex = 6;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(318, 229);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 44);
            this.btnZapisz.TabIndex = 7;
            this.btnZapisz.Text = "Zapisz i zamknij";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // cbIDZamowienia
            // 
            this.cbIDZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbIDZamowienia.FormattingEnabled = true;
            this.cbIDZamowienia.Location = new System.Drawing.Point(248, 10);
            this.cbIDZamowienia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbIDZamowienia.Name = "cbIDZamowienia";
            this.cbIDZamowienia.Size = new System.Drawing.Size(55, 34);
            this.cbIDZamowienia.TabIndex = 8;
            // 
            // lblIDZamowienia
            // 
            this.lblIDZamowienia.AutoSize = true;
            this.lblIDZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIDZamowienia.Location = new System.Drawing.Point(7, 15);
            this.lblIDZamowienia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDZamowienia.Name = "lblIDZamowienia";
            this.lblIDZamowienia.Size = new System.Drawing.Size(244, 26);
            this.lblIDZamowienia.TabIndex = 9;
            this.lblIDZamowienia.Text = "Wybierz nr. zamówienia";
            // 
            // btnNastepny
            // 
            this.btnNastepny.Location = new System.Drawing.Point(98, 229);
            this.btnNastepny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNastepny.Name = "btnNastepny";
            this.btnNastepny.Size = new System.Drawing.Size(75, 44);
            this.btnNastepny.TabIndex = 10;
            this.btnNastepny.Text = "Dodaj następny";
            this.btnNastepny.UseVisualStyleBackColor = true;
            this.btnNastepny.Click += new System.EventHandler(this.btnNastepny_Click);
            // 
            // btnNowyTyp
            // 
            this.btnNowyTyp.Location = new System.Drawing.Point(210, 181);
            this.btnNowyTyp.Margin = new System.Windows.Forms.Padding(2);
            this.btnNowyTyp.Name = "btnNowyTyp";
            this.btnNowyTyp.Size = new System.Drawing.Size(183, 32);
            this.btnNowyTyp.TabIndex = 11;
            this.btnNowyTyp.Text = "Dodaj nowy typ";
            this.btnNowyTyp.UseVisualStyleBackColor = true;
            this.btnNowyTyp.Click += new System.EventHandler(this.btnNowyTyp_Click);
            // 
            // ElementyZamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(418, 284);
            this.Controls.Add(this.btnNowyTyp);
            this.Controls.Add(this.btnNastepny);
            this.Controls.Add(this.lblIDZamowienia);
            this.Controls.Add(this.cbIDZamowienia);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.lblStary);
            this.Controls.Add(this.cbElement);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNowy);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ElementyZamowienia";
            this.Text = "Elementy zamówienia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIlosc;
        private System.Windows.Forms.ComboBox cbElement;
        private System.Windows.Forms.Label lblStary;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.ComboBox cbIDZamowienia;
        private System.Windows.Forms.Label lblIDZamowienia;
        private System.Windows.Forms.Button btnNastepny;
        private System.Windows.Forms.Button btnNowyTyp;
    }
}