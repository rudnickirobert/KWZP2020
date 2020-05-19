namespace Szwalnia
{
    partial class DodawanieElementu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodawanieElementu));
            this.lblMain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numOkres = new System.Windows.Forms.NumericUpDown();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.dgvListaTypy = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnWstecz = new System.Windows.Forms.Button();
            this.txtTyp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOkres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTypy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(163, 50);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(140, 17);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Dodawanie elementu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa elementu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Okres przydatności";
            // 
            // numOkres
            // 
            this.numOkres.Location = new System.Drawing.Point(194, 121);
            this.numOkres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numOkres.Name = "numOkres";
            this.numOkres.Size = new System.Drawing.Size(120, 22);
            this.numOkres.TabIndex = 3;
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(194, 93);
            this.txtNazwa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(151, 22);
            this.txtNazwa.TabIndex = 4;
            // 
            // dgvListaTypy
            // 
            this.dgvListaTypy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTypy.Location = new System.Drawing.Point(62, 190);
            this.dgvListaTypy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListaTypy.Name = "dgvListaTypy";
            this.dgvListaTypy.RowHeadersWidth = 51;
            this.dgvListaTypy.RowTemplate.Height = 24;
            this.dgvListaTypy.Size = new System.Drawing.Size(377, 174);
            this.dgvListaTypy.TabIndex = 5;
            this.dgvListaTypy.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaTypy_CellContentDoubleClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(62, 386);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 30);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(384, 386);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(77, 30);
            this.btnWstecz.TabIndex = 24;
            this.btnWstecz.Text = "Wstecz";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // txtTyp
            // 
            this.txtTyp.Location = new System.Drawing.Point(194, 147);
            this.txtTyp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTyp.Name = "txtTyp";
            this.txtTyp.ReadOnly = true;
            this.txtTyp.Size = new System.Drawing.Size(151, 22);
            this.txtTyp.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Typ elementu";
            // 
            // DodawanieElementu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.txtTyp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvListaTypy);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.numOkres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DodawanieElementu";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DodawanieElementu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numOkres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTypy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numOkres;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.DataGridView dgvListaTypy;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.TextBox txtTyp;
        private System.Windows.Forms.Label label3;
    }
}