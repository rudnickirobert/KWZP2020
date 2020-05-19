namespace Szwalnia
{
    partial class DodawanieTypu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodawanieTypu));
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.chBoxWlasny = new System.Windows.Forms.CheckBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnWstecz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(140, 79);
            this.txtNazwa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(151, 22);
            this.txtNazwa.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nazwa typu";
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(139, 33);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(109, 17);
            this.lblMain.TabIndex = 5;
            this.lblMain.Text = "Dodawanie typu";
            // 
            // chBoxWlasny
            // 
            this.chBoxWlasny.AutoSize = true;
            this.chBoxWlasny.Location = new System.Drawing.Point(141, 110);
            this.chBoxWlasny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chBoxWlasny.Name = "chBoxWlasny";
            this.chBoxWlasny.Size = new System.Drawing.Size(151, 21);
            this.chBoxWlasny.TabIndex = 10;
            this.chBoxWlasny.Text = "Czy własny produkt";
            this.chBoxWlasny.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(59, 174);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(266, 170);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(77, 30);
            this.btnWstecz.TabIndex = 25;
            this.btnWstecz.Text = "Wstecz";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // DodawanieTypu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 234);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.chBoxWlasny);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DodawanieTypu";
            this.Text = "DodawanieTypu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DodawanieTypu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.CheckBox chBoxWlasny;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnWstecz;
    }
}