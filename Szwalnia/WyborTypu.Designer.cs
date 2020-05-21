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
            this.btnWstecz = new System.Windows.Forms.Button();
            this.dgvListaTypow = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnUsun = new System.Windows.Forms.Button();
            this.lblOkres = new System.Windows.Forms.Label();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.txtWlasny = new System.Windows.Forms.TextBox();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.btnDodawanie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTypow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(387, 128);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(123, 30);
            this.btnWstecz.TabIndex = 28;
            this.btnWstecz.Text = "Wstecz";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // dgvListaTypow
            // 
            this.dgvListaTypow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaTypow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTypow.Location = new System.Drawing.Point(13, 181);
            this.dgvListaTypow.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaTypow.Name = "dgvListaTypow";
            this.dgvListaTypow.RowHeadersWidth = 51;
            this.dgvListaTypow.Size = new System.Drawing.Size(497, 202);
            this.dgvListaTypow.TabIndex = 27;
            this.dgvListaTypow.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaTypow_CellContentDoubleClick);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(139, 51);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 26;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfo.Location = new System.Drawing.Point(43, 21);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(288, 39);
            this.lblInfo.TabIndex = 25;
            this.lblInfo.Text = "Wybierz typ z listy";
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(387, 92);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(123, 30);
            this.btnUsun.TabIndex = 29;
            this.btnUsun.Text = "Usuń typ";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // lblOkres
            // 
            this.lblOkres.AutoSize = true;
            this.lblOkres.Location = new System.Drawing.Point(22, 119);
            this.lblOkres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOkres.Name = "lblOkres";
            this.lblOkres.Size = new System.Drawing.Size(155, 17);
            this.lblOkres.TabIndex = 33;
            this.lblOkres.Text = "Czy to element własny?";
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Location = new System.Drawing.Point(96, 90);
            this.lblNazwa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(81, 17);
            this.lblNazwa.TabIndex = 34;
            this.lblNazwa.Text = "Nazwa typu";
            // 
            // txtWlasny
            // 
            this.txtWlasny.Location = new System.Drawing.Point(185, 117);
            this.txtWlasny.Margin = new System.Windows.Forms.Padding(4);
            this.txtWlasny.Name = "txtWlasny";
            this.txtWlasny.ReadOnly = true;
            this.txtWlasny.Size = new System.Drawing.Size(77, 22);
            this.txtWlasny.TabIndex = 31;
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(185, 87);
            this.txtNazwa.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.ReadOnly = true;
            this.txtNazwa.Size = new System.Drawing.Size(132, 22);
            this.txtNazwa.TabIndex = 32;
            // 
            // btnDodawanie
            // 
            this.btnDodawanie.Location = new System.Drawing.Point(387, 56);
            this.btnDodawanie.Name = "btnDodawanie";
            this.btnDodawanie.Size = new System.Drawing.Size(123, 30);
            this.btnDodawanie.TabIndex = 30;
            this.btnDodawanie.Text = "Dodaj nowy typ";
            this.btnDodawanie.UseVisualStyleBackColor = true;
            this.btnDodawanie.Click += new System.EventHandler(this.btnDodawanie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Wybierz typ z listy:";
            // 
            // WyborTypu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 396);
            this.Controls.Add(this.label1);
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
            this.Name = "WyborTypu";
            this.Text = "WyborTypu";
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
        private System.Windows.Forms.TextBox txtWlasny;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Button btnDodawanie;
        private System.Windows.Forms.Label label1;
    }
}