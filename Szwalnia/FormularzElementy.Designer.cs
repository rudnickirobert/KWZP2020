namespace Szwalnia
{
    partial class FormularzElementy
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
            this.btnElementy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTypy = new System.Windows.Forms.Button();
            this.btnCechyElementow = new System.Windows.Forms.Button();
            this.btnCechy = new System.Windows.Forms.Button();
            this.btnJednostka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnElementy
            // 
            this.btnElementy.Location = new System.Drawing.Point(46, 74);
            this.btnElementy.Name = "btnElementy";
            this.btnElementy.Size = new System.Drawing.Size(115, 49);
            this.btnElementy.TabIndex = 0;
            this.btnElementy.Text = "Dodoawanie elementów";
            this.btnElementy.UseVisualStyleBackColor = true;
            this.btnElementy.Click += new System.EventHandler(this.btnElementy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formularze dodawania elementu";
            // 
            // btnTypy
            // 
            this.btnTypy.Location = new System.Drawing.Point(211, 74);
            this.btnTypy.Name = "btnTypy";
            this.btnTypy.Size = new System.Drawing.Size(115, 49);
            this.btnTypy.TabIndex = 2;
            this.btnTypy.Text = "Dodoawanie typów";
            this.btnTypy.UseVisualStyleBackColor = true;
            this.btnTypy.Click += new System.EventHandler(this.btnTypy_Click);
            // 
            // btnCechyElementow
            // 
            this.btnCechyElementow.Location = new System.Drawing.Point(211, 140);
            this.btnCechyElementow.Name = "btnCechyElementow";
            this.btnCechyElementow.Size = new System.Drawing.Size(115, 49);
            this.btnCechyElementow.TabIndex = 4;
            this.btnCechyElementow.Text = "Dodoawanie cech elementom";
            this.btnCechyElementow.UseVisualStyleBackColor = true;
            this.btnCechyElementow.Click += new System.EventHandler(this.btnCechyElementow_Click);
            // 
            // btnCechy
            // 
            this.btnCechy.Location = new System.Drawing.Point(46, 140);
            this.btnCechy.Name = "btnCechy";
            this.btnCechy.Size = new System.Drawing.Size(115, 49);
            this.btnCechy.TabIndex = 3;
            this.btnCechy.Text = "Dodoawanie cech";
            this.btnCechy.UseVisualStyleBackColor = true;
            this.btnCechy.Click += new System.EventHandler(this.btnCechy_Click);
            // 
            // btnJednostka
            // 
            this.btnJednostka.Location = new System.Drawing.Point(135, 223);
            this.btnJednostka.Name = "btnJednostka";
            this.btnJednostka.Size = new System.Drawing.Size(115, 49);
            this.btnJednostka.TabIndex = 5;
            this.btnJednostka.Text = "Dodoawanie Jednostek";
            this.btnJednostka.UseVisualStyleBackColor = true;
            this.btnJednostka.Click += new System.EventHandler(this.btnJednostka_Click);
            // 
            // FormularzElementy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 320);
            this.Controls.Add(this.btnJednostka);
            this.Controls.Add(this.btnCechyElementow);
            this.Controls.Add(this.btnCechy);
            this.Controls.Add(this.btnTypy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnElementy);
            this.Name = "FormularzElementy";
            this.Text = "FormularzElementy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnElementy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTypy;
        private System.Windows.Forms.Button btnCechyElementow;
        private System.Windows.Forms.Button btnCechy;
        private System.Windows.Forms.Button btnJednostka;
    }
}