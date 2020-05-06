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
            this.lblNazwa = new System.Windows.Forms.Label();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.lblOkres = new System.Windows.Forms.Label();
            this.dvgListaTyp = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.numOkres = new System.Windows.Forms.NumericUpDown();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListaTyp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOkres)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMain.Location = new System.Drawing.Point(53, 22);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(495, 55);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Dodawanie elementu";
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Location = new System.Drawing.Point(146, 110);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(104, 17);
            this.lblNazwa.TabIndex = 1;
            this.lblNazwa.Text = "Nazwa elmentu";
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(256, 107);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(198, 22);
            this.txtNazwa.TabIndex = 2;
            // 
            // lblOkres
            // 
            this.lblOkres.AutoSize = true;
            this.lblOkres.Location = new System.Drawing.Point(120, 138);
            this.lblOkres.Name = "lblOkres";
            this.lblOkres.Size = new System.Drawing.Size(130, 17);
            this.lblOkres.TabIndex = 3;
            this.lblOkres.Text = "Okres przydatności";
            // 
            // dvgListaTyp
            // 
            this.dvgListaTyp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListaTyp.Location = new System.Drawing.Point(135, 192);
            this.dvgListaTyp.Name = "dvgListaTyp";
            this.dvgListaTyp.RowHeadersWidth = 51;
            this.dvgListaTyp.RowTemplate.Height = 24;
            this.dvgListaTyp.Size = new System.Drawing.Size(336, 142);
            this.dvgListaTyp.TabIndex = 5;
            this.dvgListaTyp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgListaTyp_CellContentClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(381, 349);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(134, 32);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // numOkres
            // 
            this.numOkres.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numOkres.Location = new System.Drawing.Point(257, 138);
            this.numOkres.Name = "numOkres";
            this.numOkres.Size = new System.Drawing.Size(120, 22);
            this.numOkres.TabIndex = 7;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(461, 111);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 8;
            // 
            // DodawanieElementu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 393);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.numOkres);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dvgListaTyp);
            this.Controls.Add(this.lblOkres);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.lblMain);
            this.Name = "DodawanieElementu";
            this.Text = "DodawanieElementu";
            ((System.ComponentModel.ISupportInitialize)(this.dvgListaTyp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOkres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Label lblOkres;
        private System.Windows.Forms.DataGridView dvgListaTyp;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.NumericUpDown numOkres;
        private System.Windows.Forms.Label lblError;
    }
}