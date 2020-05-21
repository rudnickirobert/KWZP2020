namespace Szwalnia
{
    partial class WybierzZamowienie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WybierzZamowienie));
            this.cmbListaZamowien = new System.Windows.Forms.ComboBox();
            this.btnAkceptuj = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbListaZamowien
            // 
            this.cmbListaZamowien.FormattingEnabled = true;
            this.cmbListaZamowien.Location = new System.Drawing.Point(29, 79);
            this.cmbListaZamowien.Name = "cmbListaZamowien";
            this.cmbListaZamowien.Size = new System.Drawing.Size(244, 21);
            this.cmbListaZamowien.TabIndex = 0;
            // 
            // btnAkceptuj
            // 
            this.btnAkceptuj.Location = new System.Drawing.Point(279, 79);
            this.btnAkceptuj.Name = "btnAkceptuj";
            this.btnAkceptuj.Size = new System.Drawing.Size(75, 23);
            this.btnAkceptuj.TabIndex = 1;
            this.btnAkceptuj.Text = "Akceptuj";
            this.btnAkceptuj.UseVisualStyleBackColor = true;
            this.btnAkceptuj.Click += new System.EventHandler(this.btnAkceptuj_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(29, 29);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(325, 30);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Wybierz dostawę którą chcesz zamówić";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WybierzZamowienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 124);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnAkceptuj);
            this.Controls.Add(this.cmbListaZamowien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WybierzZamowienie";
            this.Text = "Wybierz zamówienie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WybierzZamowienie_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbListaZamowien;
        private System.Windows.Forms.Button btnAkceptuj;
        private System.Windows.Forms.Label lblInfo;
    }
}