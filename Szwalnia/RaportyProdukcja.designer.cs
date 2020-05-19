namespace Szwalnia
{
    partial class RaportyProdukcja
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
            this.btnMaterialOdpad = new System.Windows.Forms.Button();
            this.btnKontrolaEfektywnosci = new System.Windows.Forms.Button();
            this.btnWstecz = new System.Windows.Forms.Button();
            this.btnPraownicy = new System.Windows.Forms.Button();
            this.btnMaszyny = new System.Windows.Forms.Button();
            this.btnProcesy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaterialOdpad
            // 
            this.btnMaterialOdpad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMaterialOdpad.Location = new System.Drawing.Point(92, 439);
            this.btnMaterialOdpad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaterialOdpad.Name = "btnMaterialOdpad";
            this.btnMaterialOdpad.Size = new System.Drawing.Size(400, 111);
            this.btnMaterialOdpad.TabIndex = 0;
            this.btnMaterialOdpad.Text = "Niewykorzystany materiał / odpad";
            this.btnMaterialOdpad.UseVisualStyleBackColor = true;
            this.btnMaterialOdpad.Click += new System.EventHandler(this.btnMaterialOdpad_Click);
            // 
            // btnKontrolaEfektywnosci
            // 
            this.btnKontrolaEfektywnosci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKontrolaEfektywnosci.Location = new System.Drawing.Point(92, 558);
            this.btnKontrolaEfektywnosci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKontrolaEfektywnosci.Name = "btnKontrolaEfektywnosci";
            this.btnKontrolaEfektywnosci.Size = new System.Drawing.Size(400, 111);
            this.btnKontrolaEfektywnosci.TabIndex = 2;
            this.btnKontrolaEfektywnosci.Text = "Kontrola efektywności";
            this.btnKontrolaEfektywnosci.UseVisualStyleBackColor = true;
            this.btnKontrolaEfektywnosci.Click += new System.EventHandler(this.btnKontrolaEfektywnosci_Click);
            // 
            // btnWstecz
            // 
            this.btnWstecz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWstecz.Location = new System.Drawing.Point(16, 15);
            this.btnWstecz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(100, 37);
            this.btnWstecz.TabIndex = 9;
            this.btnWstecz.Text = "wstecz";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // btnPraownicy
            // 
            this.btnPraownicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPraownicy.Location = new System.Drawing.Point(92, 203);
            this.btnPraownicy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPraownicy.Name = "btnPraownicy";
            this.btnPraownicy.Size = new System.Drawing.Size(400, 111);
            this.btnPraownicy.TabIndex = 10;
            this.btnPraownicy.Text = "Pracownicy";
            this.btnPraownicy.UseVisualStyleBackColor = true;
            this.btnPraownicy.Click += new System.EventHandler(this.btnPraownicy_Click);
            // 
            // btnMaszyny
            // 
            this.btnMaszyny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMaszyny.Location = new System.Drawing.Point(92, 321);
            this.btnMaszyny.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaszyny.Name = "btnMaszyny";
            this.btnMaszyny.Size = new System.Drawing.Size(400, 111);
            this.btnMaszyny.TabIndex = 11;
            this.btnMaszyny.Text = "Maszyny";
            this.btnMaszyny.UseVisualStyleBackColor = true;
            this.btnMaszyny.Click += new System.EventHandler(this.btnMaszyny_Click);
            // 
            // btnProcesy
            // 
            this.btnProcesy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProcesy.Location = new System.Drawing.Point(92, 85);
            this.btnProcesy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProcesy.Name = "btnProcesy";
            this.btnProcesy.Size = new System.Drawing.Size(400, 111);
            this.btnProcesy.TabIndex = 12;
            this.btnProcesy.Text = "Procesy";
            this.btnProcesy.UseVisualStyleBackColor = true;
            this.btnProcesy.Click += new System.EventHandler(this.btnProcesy_Click);
            // 
            // RaportyProdukcja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(579, 703);
            this.Controls.Add(this.btnProcesy);
            this.Controls.Add(this.btnMaszyny);
            this.Controls.Add(this.btnPraownicy);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.btnKontrolaEfektywnosci);
            this.Controls.Add(this.btnMaterialOdpad);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RaportyProdukcja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporty";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMaterialOdpad;
        private System.Windows.Forms.Button btnKontrolaEfektywnosci;
        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.Button btnPraownicy;
        private System.Windows.Forms.Button btnMaszyny;
        private System.Windows.Forms.Button btnProcesy;
    }
}