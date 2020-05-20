namespace Szwalnia
{
    partial class UmowySzczegoly
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
            this.btnWstecz = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtCzas = new System.Windows.Forms.TextBox();
            this.txtKosztKm = new System.Windows.Forms.TextBox();
            this.txtKosztStaly = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(62, 205);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(75, 23);
            this.btnWstecz.TabIndex = 24;
            this.btnWstecz.Text = "Powrót";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Koszt stały";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Koszt (za km)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Czas dostawy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data zawarcia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nazwa kuriera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Dane umowy:";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(190, 49);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(120, 20);
            this.txtNazwa.TabIndex = 25;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(190, 78);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(120, 20);
            this.txtData.TabIndex = 26;
            // 
            // txtCzas
            // 
            this.txtCzas.Location = new System.Drawing.Point(190, 106);
            this.txtCzas.Name = "txtCzas";
            this.txtCzas.Size = new System.Drawing.Size(120, 20);
            this.txtCzas.TabIndex = 27;
            // 
            // txtKosztKm
            // 
            this.txtKosztKm.Location = new System.Drawing.Point(190, 133);
            this.txtKosztKm.Name = "txtKosztKm";
            this.txtKosztKm.Size = new System.Drawing.Size(120, 20);
            this.txtKosztKm.TabIndex = 28;
            // 
            // txtKosztStaly
            // 
            this.txtKosztStaly.Location = new System.Drawing.Point(190, 160);
            this.txtKosztStaly.Name = "txtKosztStaly";
            this.txtKosztStaly.Size = new System.Drawing.Size(120, 20);
            this.txtKosztStaly.TabIndex = 29;
            // 
            // UmowySzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 240);
            this.Controls.Add(this.txtKosztStaly);
            this.Controls.Add(this.txtKosztKm);
            this.Controls.Add(this.txtCzas);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UmowySzczegoly";
            this.Text = "Podgląd danej umowy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UmowySzczegoly_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtCzas;
        private System.Windows.Forms.TextBox txtKosztKm;
        private System.Windows.Forms.TextBox txtKosztStaly;
    }
}