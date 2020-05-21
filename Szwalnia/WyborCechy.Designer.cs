namespace Szwalnia
{
    partial class WyborCechy
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
            this.dgvListaCech = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCech)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Location = new System.Drawing.Point(28, 78);
            this.lblNazwa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(91, 17);
            this.lblNazwa.TabIndex = 44;
            this.lblNazwa.Text = "Nazwa cechy";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(127, 78);
            this.txtNazwa.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.ReadOnly = true;
            this.txtNazwa.Size = new System.Drawing.Size(132, 22);
            this.txtNazwa.TabIndex = 42;
            // 
            // btnDodawanie
            // 
            this.btnDodawanie.Location = new System.Drawing.Point(304, 74);
            this.btnDodawanie.Name = "btnDodawanie";
            this.btnDodawanie.Size = new System.Drawing.Size(107, 30);
            this.btnDodawanie.TabIndex = 40;
            this.btnDodawanie.Text = "Dodaj ceche";
            this.btnDodawanie.UseVisualStyleBackColor = true;
            this.btnDodawanie.Click += new System.EventHandler(this.btnDodawanie_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(304, 110);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(107, 30);
            this.btnUsun.TabIndex = 39;
            this.btnUsun.Text = "Usuń ceche";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(304, 146);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(107, 30);
            this.btnWstecz.TabIndex = 38;
            this.btnWstecz.Text = "Wstecz";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // dgvListaCech
            // 
            this.dgvListaCech.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaCech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCech.Location = new System.Drawing.Point(13, 208);
            this.dgvListaCech.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaCech.Name = "dgvListaCech";
            this.dgvListaCech.RowHeadersWidth = 51;
            this.dgvListaCech.Size = new System.Drawing.Size(397, 202);
            this.dgvListaCech.TabIndex = 37;
            this.dgvListaCech.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCech_CellContentDoubleClick);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(128, 43);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 36;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfo.Location = new System.Drawing.Point(26, 15);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(334, 39);
            this.lblInfo.TabIndex = 35;
            this.lblInfo.Text = "Wybierz ceche z listy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Wybierz cechy z listy:";
            // 
            // WyborCechy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.btnDodawanie);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.dgvListaCech);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblInfo);
            this.Name = "WyborCechy";
            this.Text = "WyborCechy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCech)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Button btnDodawanie;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.DataGridView dgvListaCech;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label1;
    }
}