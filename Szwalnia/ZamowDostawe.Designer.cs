namespace Szwalnia
{
    partial class ZamowDostawe
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
            this.dgvZawartoscDostawy = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblNazwaDostawcy = new System.Windows.Forms.Label();
            this.lblTelefonDostawcy = new System.Windows.Forms.Label();
            this.lblEmailDostawcy = new System.Windows.Forms.Label();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.txtNumerTelefonu = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAkceptuj = new System.Windows.Forms.Button();
            this.btnOdrzuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZawartoscDostawy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZawartoscDostawy
            // 
            this.dgvZawartoscDostawy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZawartoscDostawy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZawartoscDostawy.Location = new System.Drawing.Point(12, 64);
            this.dgvZawartoscDostawy.Name = "dgvZawartoscDostawy";
            this.dgvZawartoscDostawy.Size = new System.Drawing.Size(776, 217);
            this.dgvZawartoscDostawy.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(13, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(775, 48);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Lista materiałów do zamówienia w dostawie";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNazwaDostawcy
            // 
            this.lblNazwaDostawcy.Location = new System.Drawing.Point(19, 286);
            this.lblNazwaDostawcy.Name = "lblNazwaDostawcy";
            this.lblNazwaDostawcy.Size = new System.Drawing.Size(90, 48);
            this.lblNazwaDostawcy.TabIndex = 1;
            this.lblNazwaDostawcy.Text = "Nazwa dostawcy";
            this.lblNazwaDostawcy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelefonDostawcy
            // 
            this.lblTelefonDostawcy.Location = new System.Drawing.Point(19, 382);
            this.lblTelefonDostawcy.Name = "lblTelefonDostawcy";
            this.lblTelefonDostawcy.Size = new System.Drawing.Size(90, 48);
            this.lblTelefonDostawcy.TabIndex = 1;
            this.lblTelefonDostawcy.Text = "Numer telefonu";
            this.lblTelefonDostawcy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmailDostawcy
            // 
            this.lblEmailDostawcy.Location = new System.Drawing.Point(19, 334);
            this.lblEmailDostawcy.Name = "lblEmailDostawcy";
            this.lblEmailDostawcy.Size = new System.Drawing.Size(90, 48);
            this.lblEmailDostawcy.TabIndex = 1;
            this.lblEmailDostawcy.Text = "Adres e-mail";
            this.lblEmailDostawcy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(115, 301);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.ReadOnly = true;
            this.txtNazwa.Size = new System.Drawing.Size(282, 20);
            this.txtNazwa.TabIndex = 2;
            // 
            // txtNumerTelefonu
            // 
            this.txtNumerTelefonu.Location = new System.Drawing.Point(115, 397);
            this.txtNumerTelefonu.Name = "txtNumerTelefonu";
            this.txtNumerTelefonu.ReadOnly = true;
            this.txtNumerTelefonu.Size = new System.Drawing.Size(282, 20);
            this.txtNumerTelefonu.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 349);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(282, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // btnAkceptuj
            // 
            this.btnAkceptuj.Location = new System.Drawing.Point(428, 322);
            this.btnAkceptuj.Name = "btnAkceptuj";
            this.btnAkceptuj.Size = new System.Drawing.Size(164, 72);
            this.btnAkceptuj.TabIndex = 3;
            this.btnAkceptuj.Text = "Akceptuj";
            this.btnAkceptuj.UseVisualStyleBackColor = true;
            this.btnAkceptuj.Click += new System.EventHandler(this.btnAkceptuj_Click);
            // 
            // btnOdrzuc
            // 
            this.btnOdrzuc.Location = new System.Drawing.Point(612, 322);
            this.btnOdrzuc.Name = "btnOdrzuc";
            this.btnOdrzuc.Size = new System.Drawing.Size(164, 72);
            this.btnOdrzuc.TabIndex = 3;
            this.btnOdrzuc.Text = "Odrzuć";
            this.btnOdrzuc.UseVisualStyleBackColor = true;
            this.btnOdrzuc.Click += new System.EventHandler(this.btnOdrzuc_Click);
            // 
            // ZamowDostawe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.btnOdrzuc);
            this.Controls.Add(this.btnAkceptuj);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNumerTelefonu);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.lblEmailDostawcy);
            this.Controls.Add(this.lblTelefonDostawcy);
            this.Controls.Add(this.lblNazwaDostawcy);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvZawartoscDostawy);
            this.Name = "ZamowDostawe";
            this.Text = "ZamowDostawe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ZamowDostawe_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZawartoscDostawy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZawartoscDostawy;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblNazwaDostawcy;
        private System.Windows.Forms.Label lblTelefonDostawcy;
        private System.Windows.Forms.Label lblEmailDostawcy;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.TextBox txtNumerTelefonu;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAkceptuj;
        private System.Windows.Forms.Button btnOdrzuc;
    }
}