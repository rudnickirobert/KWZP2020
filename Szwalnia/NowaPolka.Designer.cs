namespace Szwalnia
{
    partial class NowaPolka
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
            this.btnDodajRegal = new System.Windows.Forms.Button();
            this.lblOznaczenie = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNumerPolki = new System.Windows.Forms.Label();
            this.cmbOznaczenie = new System.Windows.Forms.ComboBox();
            this.btnNowyRegal = new System.Windows.Forms.Button();
            this.lblNumerNowejPolki = new System.Windows.Forms.Label();
            this.btnNowyRozmiarPolki = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodajRegal
            // 
            this.btnDodajRegal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDodajRegal.Location = new System.Drawing.Point(169, 237);
            this.btnDodajRegal.Name = "btnDodajRegal";
            this.btnDodajRegal.Size = new System.Drawing.Size(86, 32);
            this.btnDodajRegal.TabIndex = 12;
            this.btnDodajRegal.Text = "Dodaj";
            this.btnDodajRegal.UseVisualStyleBackColor = true;
            // 
            // lblOznaczenie
            // 
            this.lblOznaczenie.AutoSize = true;
            this.lblOznaczenie.Location = new System.Drawing.Point(73, 129);
            this.lblOznaczenie.Name = "lblOznaczenie";
            this.lblOznaczenie.Size = new System.Drawing.Size(40, 13);
            this.lblOznaczenie.TabIndex = 10;
            this.lblOznaczenie.Text = "Regał:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.Location = new System.Drawing.Point(100, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(229, 31);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Dodaj nową półkę";
            // 
            // lblNumerPolki
            // 
            this.lblNumerPolki.AutoSize = true;
            this.lblNumerPolki.Location = new System.Drawing.Point(39, 93);
            this.lblNumerPolki.Name = "lblNumerPolki";
            this.lblNumerPolki.Size = new System.Drawing.Size(99, 13);
            this.lblNumerPolki.TabIndex = 13;
            this.lblNumerPolki.Text = "Numer nowej półki:";
            // 
            // cmbOznaczenie
            // 
            this.cmbOznaczenie.FormattingEnabled = true;
            this.cmbOznaczenie.Location = new System.Drawing.Point(141, 126);
            this.cmbOznaczenie.Name = "cmbOznaczenie";
            this.cmbOznaczenie.Size = new System.Drawing.Size(99, 21);
            this.cmbOznaczenie.TabIndex = 15;
            // 
            // btnNowyRegal
            // 
            this.btnNowyRegal.Location = new System.Drawing.Point(264, 120);
            this.btnNowyRegal.Name = "btnNowyRegal";
            this.btnNowyRegal.Size = new System.Drawing.Size(121, 30);
            this.btnNowyRegal.TabIndex = 16;
            this.btnNowyRegal.Text = "Nowy regał?";
            this.btnNowyRegal.UseVisualStyleBackColor = true;
            // 
            // lblNumerNowejPolki
            // 
            this.lblNumerNowejPolki.AutoSize = true;
            this.lblNumerNowejPolki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumerNowejPolki.Location = new System.Drawing.Point(174, 88);
            this.lblNumerNowejPolki.Name = "lblNumerNowejPolki";
            this.lblNumerNowejPolki.Size = new System.Drawing.Size(33, 20);
            this.lblNumerNowejPolki.TabIndex = 17;
            this.lblNumerNowejPolki.Text = "(nr)";
            // 
            // btnNowyRozmiarPolki
            // 
            this.btnNowyRozmiarPolki.Location = new System.Drawing.Point(264, 159);
            this.btnNowyRozmiarPolki.Name = "btnNowyRozmiarPolki";
            this.btnNowyRozmiarPolki.Size = new System.Drawing.Size(121, 30);
            this.btnNowyRozmiarPolki.TabIndex = 20;
            this.btnNowyRozmiarPolki.Text = "Nowy rozmiar półki?";
            this.btnNowyRozmiarPolki.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Rozmiar:";
            // 
            // NowaPolka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 298);
            this.Controls.Add(this.btnNowyRozmiarPolki);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNumerNowejPolki);
            this.Controls.Add(this.btnNowyRegal);
            this.Controls.Add(this.cmbOznaczenie);
            this.Controls.Add(this.lblNumerPolki);
            this.Controls.Add(this.btnDodajRegal);
            this.Controls.Add(this.lblOznaczenie);
            this.Controls.Add(this.lblTitle);
            this.Name = "NowaPolka";
            this.Text = "Dodaj półkę";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajRegal;
        private System.Windows.Forms.Label lblOznaczenie;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNumerPolki;
        private System.Windows.Forms.ComboBox cmbOznaczenie;
        private System.Windows.Forms.Button btnNowyRegal;
        private System.Windows.Forms.Label lblNumerNowejPolki;
        private System.Windows.Forms.Button btnNowyRozmiarPolki;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}