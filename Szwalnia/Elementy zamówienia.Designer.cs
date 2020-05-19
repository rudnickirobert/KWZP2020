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
            this.SuspendLayout();
            // 
            // btnNowy
            // 
            this.btnNowy.Location = new System.Drawing.Point(280, 179);
            this.btnNowy.Name = "btnNowy";
            this.btnNowy.Size = new System.Drawing.Size(244, 39);
            this.btnNowy.TabIndex = 0;
            this.btnNowy.Text = "Dodaj nowy element";
            this.btnNowy.UseVisualStyleBackColor = true;
            this.btnNowy.Click += new System.EventHandler(this.btnNowy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ilość";
            // 
            // txtIlosc
            // 
            this.txtIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIlosc.Location = new System.Drawing.Point(111, 179);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(163, 38);
            this.txtIlosc.TabIndex = 2;
            // 
            // cbElement
            // 
            this.cbElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbElement.FormattingEnabled = true;
            this.cbElement.Location = new System.Drawing.Point(12, 117);
            this.cbElement.Name = "cbElement";
            this.cbElement.Size = new System.Drawing.Size(512, 39);
            this.cbElement.TabIndex = 3;
            // 
            // lblStary
            // 
            this.lblStary.AutoSize = true;
            this.lblStary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStary.Location = new System.Drawing.Point(12, 66);
            this.lblStary.Name = "lblStary";
            this.lblStary.Size = new System.Drawing.Size(515, 32);
            this.lblStary.TabIndex = 5;
            this.lblStary.Text = "Wybierz  element z listy lub dodaj nowy ";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(15, 258);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(94, 54);
            this.btnAnuluj.TabIndex = 6;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(424, 258);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(100, 54);
            this.btnZapisz.TabIndex = 7;
            this.btnZapisz.Text = "Zapisz i zamknij";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // cbIDZamowienia
            // 
            this.cbIDZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbIDZamowienia.FormattingEnabled = true;
            this.cbIDZamowienia.Location = new System.Drawing.Point(330, 12);
            this.cbIDZamowienia.Name = "cbIDZamowienia";
            this.cbIDZamowienia.Size = new System.Drawing.Size(72, 39);
            this.cbIDZamowienia.TabIndex = 8;
            // 
            // lblIDZamowienia
            // 
            this.lblIDZamowienia.AutoSize = true;
            this.lblIDZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIDZamowienia.Location = new System.Drawing.Point(9, 18);
            this.lblIDZamowienia.Name = "lblIDZamowienia";
            this.lblIDZamowienia.Size = new System.Drawing.Size(315, 32);
            this.lblIDZamowienia.TabIndex = 9;
            this.lblIDZamowienia.Text = "Wybierz nr. zamówienia";
            // 
            // btnNastepny
            // 
            this.btnNastepny.Location = new System.Drawing.Point(130, 258);
            this.btnNastepny.Name = "btnNastepny";
            this.btnNastepny.Size = new System.Drawing.Size(100, 54);
            this.btnNastepny.TabIndex = 10;
            this.btnNastepny.Text = "Dodaj następny";
            this.btnNastepny.UseVisualStyleBackColor = true;
            this.btnNastepny.Click += new System.EventHandler(this.btnNastepny_Click);
            // 
            // ElementyZamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(557, 340);
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
    }
}