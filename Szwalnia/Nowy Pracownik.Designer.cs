namespace Szwalnia
{
    partial class Nowy_Pracownik
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
            this.dgvUkryty = new System.Windows.Forms.DataGridView();
            this.lblOpisNumer = new System.Windows.Forms.Label();
            this.lblNumerPracownika = new System.Windows.Forms.Label();
            this.lblImie = new System.Windows.Forms.Label();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.lblPesel = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnDalej = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnWyzeruj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUkryty)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUkryty
            // 
            this.dgvUkryty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUkryty.Location = new System.Drawing.Point(13, 13);
            this.dgvUkryty.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUkryty.Name = "dgvUkryty";
            this.dgvUkryty.RowHeadersWidth = 51;
            this.dgvUkryty.Size = new System.Drawing.Size(63, 53);
            this.dgvUkryty.TabIndex = 6;
            this.dgvUkryty.Visible = false;
            // 
            // lblOpisNumer
            // 
            this.lblOpisNumer.AutoSize = true;
            this.lblOpisNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisNumer.Location = new System.Drawing.Point(108, 37);
            this.lblOpisNumer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpisNumer.Name = "lblOpisNumer";
            this.lblOpisNumer.Size = new System.Drawing.Size(264, 29);
            this.lblOpisNumer.TabIndex = 7;
            this.lblOpisNumer.Text = "ID nowego pracownika:";
            // 
            // lblNumerPracownika
            // 
            this.lblNumerPracownika.AutoSize = true;
            this.lblNumerPracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumerPracownika.Location = new System.Drawing.Point(394, 41);
            this.lblNumerPracownika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumerPracownika.Name = "lblNumerPracownika";
            this.lblNumerPracownika.Size = new System.Drawing.Size(64, 25);
            this.lblNumerPracownika.TabIndex = 8;
            this.lblNumerPracownika.Text = "label1";
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(13, 104);
            this.lblImie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(45, 24);
            this.lblImie.TabIndex = 9;
            this.lblImie.Text = "Imię";
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwisko.Location = new System.Drawing.Point(13, 140);
            this.lblNazwisko.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(90, 24);
            this.lblNazwisko.TabIndex = 10;
            this.lblNazwisko.Text = "Nazwisko";
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPesel.Location = new System.Drawing.Point(13, 174);
            this.lblPesel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(57, 24);
            this.lblPesel.TabIndex = 11;
            this.lblPesel.Text = "Pesel";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdres.Location = new System.Drawing.Point(13, 207);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(60, 24);
            this.lblAdres.TabIndex = 12;
            this.lblAdres.Text = "Adres";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTelefon.Location = new System.Drawing.Point(13, 241);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(74, 24);
            this.lblTelefon.TabIndex = 13;
            this.lblTelefon.Text = "Telefon";
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(262, 106);
            this.txtImie.Margin = new System.Windows.Forms.Padding(4);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(251, 22);
            this.txtImie.TabIndex = 14;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(262, 143);
            this.txtNazwisko.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(251, 22);
            this.txtNazwisko.TabIndex = 15;
            // 
            // txtPesel
            // 
            this.txtPesel.Location = new System.Drawing.Point(262, 177);
            this.txtPesel.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(251, 22);
            this.txtPesel.TabIndex = 16;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(262, 210);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(251, 22);
            this.txtAdres.TabIndex = 17;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(262, 241);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(251, 22);
            this.txtTelefon.TabIndex = 18;
            // 
            // btnDalej
            // 
            this.btnDalej.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDalej.Location = new System.Drawing.Point(380, 309);
            this.btnDalej.Margin = new System.Windows.Forms.Padding(4);
            this.btnDalej.Name = "btnDalej";
            this.btnDalej.Size = new System.Drawing.Size(107, 62);
            this.btnDalej.TabIndex = 19;
            this.btnDalej.Text = "Dalej";
            this.btnDalej.UseVisualStyleBackColor = true;
            this.btnDalej.Click += new System.EventHandler(this.btnDalej_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnuluj.Location = new System.Drawing.Point(72, 309);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(107, 62);
            this.btnAnuluj.TabIndex = 20;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnWyzeruj
            // 
            this.btnWyzeruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyzeruj.Location = new System.Drawing.Point(229, 309);
            this.btnWyzeruj.Margin = new System.Windows.Forms.Padding(4);
            this.btnWyzeruj.Name = "btnWyzeruj";
            this.btnWyzeruj.Size = new System.Drawing.Size(107, 62);
            this.btnWyzeruj.TabIndex = 21;
            this.btnWyzeruj.Text = "Wyzeruj";
            this.btnWyzeruj.UseVisualStyleBackColor = true;
            this.btnWyzeruj.Click += new System.EventHandler(this.btnWyzeruj_Click);
            // 
            // Nowy_Pracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.btnWyzeruj);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnDalej);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtPesel);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblPesel);
            this.Controls.Add(this.lblNazwisko);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.lblNumerPracownika);
            this.Controls.Add(this.lblOpisNumer);
            this.Controls.Add(this.dgvUkryty);
            this.Name = "Nowy_Pracownik";
            this.Text = "Nowy_Pracownik";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUkryty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUkryty;
        private System.Windows.Forms.Label lblOpisNumer;
        private System.Windows.Forms.Label lblNumerPracownika;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.Label lblPesel;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnDalej;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnWyzeruj;
    }
}