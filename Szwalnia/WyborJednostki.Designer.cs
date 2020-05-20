namespace Szwalnia
{
    partial class WyborJednostki
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
            this.lblNazwa = new System.Windows.Forms.Label();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.btnDodawanie = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnWstecz = new System.Windows.Forms.Button();
            this.dgvListaJednostek = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaJednostek)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Location = new System.Drawing.Point(17, 82);
            this.lblNazwa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(110, 17);
            this.lblNazwa.TabIndex = 52;
            this.lblNazwa.Text = "Nazwa jednostki";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(135, 82);
            this.txtNazwa.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(93, 22);
            this.txtNazwa.TabIndex = 51;
            // 
            // btnDodawanie
            // 
            this.btnDodawanie.Location = new System.Drawing.Point(268, 75);
            this.btnDodawanie.Name = "btnDodawanie";
            this.btnDodawanie.Size = new System.Drawing.Size(146, 30);
            this.btnDodawanie.TabIndex = 50;
            this.btnDodawanie.Text = "Dodaj jednostkę";
            this.btnDodawanie.UseVisualStyleBackColor = true;
            this.btnDodawanie.Click += new System.EventHandler(this.btnDodawanie_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(268, 111);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(146, 30);
            this.btnUsun.TabIndex = 49;
            this.btnUsun.Text = "Usuń jednostkę";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(268, 147);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(146, 30);
            this.btnWstecz.TabIndex = 48;
            this.btnWstecz.Text = "Wstecz";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // dgvListaJednostek
            // 
            this.dgvListaJednostek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaJednostek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaJednostek.Location = new System.Drawing.Point(13, 195);
            this.dgvListaJednostek.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaJednostek.Name = "dgvListaJednostek";
            this.dgvListaJednostek.RowHeadersWidth = 51;
            this.dgvListaJednostek.Size = new System.Drawing.Size(397, 202);
            this.dgvListaJednostek.TabIndex = 47;
            this.dgvListaJednostek.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaJednostek_CellContentDoubleClick);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(127, 44);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 46;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfo.Location = new System.Drawing.Point(25, 16);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(389, 39);
            this.lblInfo.TabIndex = 45;
            this.lblInfo.Text = "Wybierz jednostkę z listy";
            // 
            // WyborJednostki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 418);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.btnDodawanie);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.dgvListaJednostek);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblInfo);
            this.Name = "WyborJednostki";
            this.Text = "WyborJednostki";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaJednostek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Button btnDodawanie;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.DataGridView dgvListaJednostek;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblInfo;
    }
}