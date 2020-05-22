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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnWstecz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTyp = new System.Windows.Forms.ComboBox();
            this.chbOkres = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numOkres)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMain.Location = new System.Drawing.Point(61, 27);
            this.lblMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(268, 31);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Dodawanie elementu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa elementu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Okres przydatności [mies]";
            // 
            // numOkres
            // 
            this.numOkres.Location = new System.Drawing.Point(146, 98);
            this.numOkres.Margin = new System.Windows.Forms.Padding(2);
            this.numOkres.Name = "numOkres";
            this.numOkres.Size = new System.Drawing.Size(113, 20);
            this.numOkres.TabIndex = 2;
            this.numOkres.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(146, 76);
            this.txtNazwa.Margin = new System.Windows.Forms.Padding(2);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(114, 20);
            this.txtNazwa.TabIndex = 1;
            this.txtNazwa.TextChanged += new System.EventHandler(this.txtNazwa_TextChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Enabled = false;
            this.btnDodaj.Location = new System.Drawing.Point(282, 154);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(56, 24);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(32, 154);
            this.btnWstecz.Margin = new System.Windows.Forms.Padding(2);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(58, 24);
            this.btnWstecz.TabIndex = 24;
            this.btnWstecz.Text = "Wstecz";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Typ elementu";
            // 
            // cmbTyp
            // 
            this.cmbTyp.FormattingEnabled = true;
            this.cmbTyp.Location = new System.Drawing.Point(146, 119);
            this.cmbTyp.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTyp.Name = "cmbTyp";
            this.cmbTyp.Size = new System.Drawing.Size(114, 21);
            this.cmbTyp.TabIndex = 4;
            // 
            // chbOkres
            // 
            this.chbOkres.AutoSize = true;
            this.chbOkres.Location = new System.Drawing.Point(272, 99);
            this.chbOkres.Margin = new System.Windows.Forms.Padding(2);
            this.chbOkres.Name = "chbOkres";
            this.chbOkres.Size = new System.Drawing.Size(81, 17);
            this.chbOkres.TabIndex = 3;
            this.chbOkres.Text = "Nie dotyczy";
            this.chbOkres.UseVisualStyleBackColor = true;
            this.chbOkres.CheckedChanged += new System.EventHandler(this.chbOkres_CheckedChanged);
            // 
            // DodawanieElementu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 197);
            this.Controls.Add(this.chbOkres);
            this.Controls.Add(this.cmbTyp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.numOkres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DodawanieElementu";
            this.Text = "Dodawanie elementu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DodawanieElementu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numOkres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numOkres;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnWstecz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTyp;
        private System.Windows.Forms.CheckBox chbOkres;
    }
}