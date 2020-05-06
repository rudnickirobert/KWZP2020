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
            this.lblMain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numOkres = new System.Windows.Forms.NumericUpDown();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.dgvListaTypy = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOkres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTypy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(163, 51);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(140, 17);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Dodawanie elementu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa elementu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Okres przydatności";
            // 
            // numOkres
            // 
            this.numOkres.Location = new System.Drawing.Point(194, 134);
            this.numOkres.Name = "numOkres";
            this.numOkres.Size = new System.Drawing.Size(120, 22);
            this.numOkres.TabIndex = 3;
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(194, 106);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(151, 22);
            this.txtNazwa.TabIndex = 4;
            // 
            // dgvListaTypy
            // 
            this.dgvListaTypy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTypy.Location = new System.Drawing.Point(105, 205);
            this.dgvListaTypy.Name = "dgvListaTypy";
            this.dgvListaTypy.RowHeadersWidth = 51;
            this.dgvListaTypy.RowTemplate.Height = 24;
            this.dgvListaTypy.Size = new System.Drawing.Size(240, 150);
            this.dgvListaTypy.TabIndex = 5;
            this.dgvListaTypy.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaTypy_CellContentDoubleClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(269, 371);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // DodawanieElementu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvListaTypy);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.numOkres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMain);
            this.Name = "DodawanieElementu";
            this.Text = "Form1";
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
    }
}