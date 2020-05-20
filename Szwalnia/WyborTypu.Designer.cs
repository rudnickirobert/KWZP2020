namespace Szwalnia
{
    partial class WyborTypu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WyborTypu));
            this.btnWstecz = new System.Windows.Forms.Button();
            this.dgvListaTypow = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnUsun = new System.Windows.Forms.Button();
            this.lblOkres = new System.Windows.Forms.Label();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.btnDodawanie = new System.Windows.Forms.Button();
            this.txtWlasny = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTypow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(302, 104);
            this.btnWstecz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(80, 24);
            this.btnWstecz.TabIndex = 28;
            this.btnWstecz.Text = "Wstecz";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // dgvListaTypow
            // 
            this.dgvListaTypow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaTypow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTypow.Location = new System.Drawing.Point(10, 147);
            this.dgvListaTypow.Name = "dgvListaTypow";
            this.dgvListaTypow.RowHeadersWidth = 51;
            this.dgvListaTypow.Size = new System.Drawing.Size(373, 164);
            this.dgvListaTypow.TabIndex = 27;
            this.dgvListaTypow.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaTypow_CellContentDoubleClick);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(104, 41);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 26;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfo.Location = new System.Drawing.Point(32, 17);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(232, 31);
            this.lblInfo.TabIndex = 25;
            this.lblInfo.Text = "Wybierz typ z listy";
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(302, 75);
            this.btnUsun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(80, 24);
            this.btnUsun.TabIndex = 29;
            this.btnUsun.Text = "Usuń typ";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // lblOkres
            // 
            this.lblOkres.AutoSize = true;
            this.lblOkres.Location = new System.Drawing.Point(16, 97);
            this.lblOkres.Name = "lblOkres";
            this.lblOkres.Size = new System.Drawing.Size(119, 13);
            this.lblOkres.TabIndex = 33;
            this.lblOkres.Text = "Czy to element własny?";
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Location = new System.Drawing.Point(72, 73);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(63, 13);
            this.lblNazwa.TabIndex = 34;
            this.lblNazwa.Text = "Nazwa typu";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(139, 71);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(100, 20);
            this.txtNazwa.TabIndex = 32;
            // 
            // btnDodawanie
            // 
            this.btnDodawanie.Location = new System.Drawing.Point(302, 46);
            this.btnDodawanie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodawanie.Name = "btnDodawanie";
            this.btnDodawanie.Size = new System.Drawing.Size(80, 24);
            this.btnDodawanie.TabIndex = 30;
            this.btnDodawanie.Text = "Dodaj typ";
            this.btnDodawanie.UseVisualStyleBackColor = true;
            this.btnDodawanie.Click += new System.EventHandler(this.btnDodawanie_Click);
            // 
            // txtWlasny
            // 
            this.txtWlasny.Location = new System.Drawing.Point(139, 95);
            this.txtWlasny.Name = "txtWlasny";
            this.txtWlasny.Size = new System.Drawing.Size(59, 20);
            this.txtWlasny.TabIndex = 31;
            // 
            // WyborTypu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 322);
            this.Controls.Add(this.lblOkres);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.txtWlasny);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.btnDodawanie);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.dgvListaTypow);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WyborTypu";
            this.Text = "Wybór typu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTypow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.DataGridView dgvListaTypow;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Label lblOkres;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Button btnDodawanie;
        private System.Windows.Forms.TextBox txtWlasny;
    }
}