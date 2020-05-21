namespace Szwalnia
{
    partial class SrodkiTrwale
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
            this.dgvSrodki = new System.Windows.Forms.DataGridView();
            this.dgvZamortyzowane = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSrodki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamortyzowane)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSrodki
            // 
            this.dgvSrodki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSrodki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSrodki.Location = new System.Drawing.Point(21, 81);
            this.dgvSrodki.Name = "dgvSrodki";
            this.dgvSrodki.RowHeadersWidth = 51;
            this.dgvSrodki.RowTemplate.Height = 24;
            this.dgvSrodki.Size = new System.Drawing.Size(1289, 222);
            this.dgvSrodki.TabIndex = 0;
            // 
            // dgvZamortyzowane
            // 
            this.dgvZamortyzowane.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZamortyzowane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZamortyzowane.Location = new System.Drawing.Point(21, 426);
            this.dgvZamortyzowane.Name = "dgvZamortyzowane";
            this.dgvZamortyzowane.RowHeadersWidth = 51;
            this.dgvZamortyzowane.RowTemplate.Height = 24;
            this.dgvZamortyzowane.Size = new System.Drawing.Size(1289, 150);
            this.dgvZamortyzowane.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Środki trwałe w przedsiębiorstwie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zamortyzowane środki trwałe";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(522, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(115, 49);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj nowy";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(652, 12);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(115, 49);
            this.btnZamknij.TabIndex = 5;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // SrodkiTrwale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1322, 602);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvZamortyzowane);
            this.Controls.Add(this.dgvSrodki);
            this.Name = "SrodkiTrwale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Środki trwałe";
            this.Activated += new System.EventHandler(this.SrodkiTrwale_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSrodki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZamortyzowane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSrodki;
        private System.Windows.Forms.DataGridView dgvZamortyzowane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnZamknij;
    }
}