namespace Szwalnia
{
    partial class NowyProces
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
            this.lblOpisNumer = new System.Windows.Forms.Label();
            this.lblIdZamowienieElement = new System.Windows.Forms.Label();
            this.lblProponowanaDataDostawy = new System.Windows.Forms.Label();
            this.lblDataRozpoczecia = new System.Windows.Forms.Label();
            this.lblDataZakonczenia = new System.Windows.Forms.Label();
            this.lblUwagi = new System.Windows.Forms.Label();
            this.tbUwagi = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnWyzeruj = new System.Windows.Forms.Button();
            this.lblNumerProcesu = new System.Windows.Forms.Label();
            this.dgvUkryty = new System.Windows.Forms.DataGridView();
            this.mtbProponowanaData = new System.Windows.Forms.MaskedTextBox();
            this.btnDzisProponowana = new System.Windows.Forms.Button();
            this.mtbDataRozpoczecia = new System.Windows.Forms.MaskedTextBox();
            this.btnDzisRozpoczecie = new System.Windows.Forms.Button();
            this.btnDzisZakonczenie = new System.Windows.Forms.Button();
            this.lblGwiazdka = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUkryty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOpisNumer
            // 
            this.lblOpisNumer.AutoSize = true;
            this.lblOpisNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisNumer.Location = new System.Drawing.Point(103, 54);
            this.lblOpisNumer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpisNumer.Name = "lblOpisNumer";
            this.lblOpisNumer.Size = new System.Drawing.Size(254, 29);
            this.lblOpisNumer.TabIndex = 0;
            this.lblOpisNumer.Text = "ID nowego procesu to:";
            // 
            // lblIdZamowienieElement
            // 
            this.lblIdZamowienieElement.AutoSize = true;
            this.lblIdZamowienieElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdZamowienieElement.Location = new System.Drawing.Point(83, 135);
            this.lblIdZamowienieElement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdZamowienieElement.Name = "lblIdZamowienieElement";
            this.lblIdZamowienieElement.Size = new System.Drawing.Size(206, 24);
            this.lblIdZamowienieElement.TabIndex = 1;
            this.lblIdZamowienieElement.Text = "ID zamówienie element";
            // 
            // lblProponowanaDataDostawy
            // 
            this.lblProponowanaDataDostawy.AutoSize = true;
            this.lblProponowanaDataDostawy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProponowanaDataDostawy.Location = new System.Drawing.Point(83, 172);
            this.lblProponowanaDataDostawy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProponowanaDataDostawy.Name = "lblProponowanaDataDostawy";
            this.lblProponowanaDataDostawy.Size = new System.Drawing.Size(326, 24);
            this.lblProponowanaDataDostawy.TabIndex = 1;
            this.lblProponowanaDataDostawy.Text = "Proponowana data dostawy materiału";
            // 
            // lblDataRozpoczecia
            // 
            this.lblDataRozpoczecia.AutoSize = true;
            this.lblDataRozpoczecia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataRozpoczecia.Location = new System.Drawing.Point(83, 208);
            this.lblDataRozpoczecia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataRozpoczecia.Name = "lblDataRozpoczecia";
            this.lblDataRozpoczecia.Size = new System.Drawing.Size(154, 24);
            this.lblDataRozpoczecia.TabIndex = 1;
            this.lblDataRozpoczecia.Text = "Data rozpoczęcia";
            // 
            // lblDataZakonczenia
            // 
            this.lblDataZakonczenia.AutoSize = true;
            this.lblDataZakonczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataZakonczenia.Location = new System.Drawing.Point(83, 244);
            this.lblDataZakonczenia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataZakonczenia.Name = "lblDataZakonczenia";
            this.lblDataZakonczenia.Size = new System.Drawing.Size(157, 24);
            this.lblDataZakonczenia.TabIndex = 1;
            this.lblDataZakonczenia.Text = "Data zakończenia";
            // 
            // lblUwagi
            // 
            this.lblUwagi.AutoSize = true;
            this.lblUwagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUwagi.Location = new System.Drawing.Point(83, 276);
            this.lblUwagi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUwagi.Name = "lblUwagi";
            this.lblUwagi.Size = new System.Drawing.Size(62, 24);
            this.lblUwagi.TabIndex = 1;
            this.lblUwagi.Text = "Uwagi";
            // 
            // tbUwagi
            // 
            this.tbUwagi.Location = new System.Drawing.Point(461, 277);
            this.tbUwagi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUwagi.Name = "tbUwagi";
            this.tbUwagi.Size = new System.Drawing.Size(251, 22);
            this.tbUwagi.TabIndex = 2;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapisz.Location = new System.Drawing.Point(159, 401);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(107, 62);
            this.btnZapisz.TabIndex = 3;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnuluj.Location = new System.Drawing.Point(317, 401);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(107, 62);
            this.btnAnuluj.TabIndex = 3;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnWyzeruj
            // 
            this.btnWyzeruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyzeruj.Location = new System.Drawing.Point(461, 401);
            this.btnWyzeruj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWyzeruj.Name = "btnWyzeruj";
            this.btnWyzeruj.Size = new System.Drawing.Size(107, 62);
            this.btnWyzeruj.TabIndex = 3;
            this.btnWyzeruj.Text = "Wyzeruj";
            this.btnWyzeruj.UseVisualStyleBackColor = true;
            this.btnWyzeruj.Click += new System.EventHandler(this.btnWyzeruj_Click);
            // 
            // lblNumerProcesu
            // 
            this.lblNumerProcesu.AutoSize = true;
            this.lblNumerProcesu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumerProcesu.Location = new System.Drawing.Point(456, 59);
            this.lblNumerProcesu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumerProcesu.Name = "lblNumerProcesu";
            this.lblNumerProcesu.Size = new System.Drawing.Size(64, 25);
            this.lblNumerProcesu.TabIndex = 4;
            this.lblNumerProcesu.Text = "label1";
            // 
            // dgvUkryty
            // 
            this.dgvUkryty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUkryty.Location = new System.Drawing.Point(32, 16);
            this.dgvUkryty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUkryty.Name = "dgvUkryty";
            this.dgvUkryty.RowHeadersWidth = 51;
            this.dgvUkryty.Size = new System.Drawing.Size(63, 53);
            this.dgvUkryty.TabIndex = 5;
            this.dgvUkryty.Visible = false;
            // 
            // mtbProponowanaData
            // 
            this.mtbProponowanaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtbProponowanaData.Location = new System.Drawing.Point(461, 169);
            this.mtbProponowanaData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbProponowanaData.Mask = "0000/00/00 00:00:00";
            this.mtbProponowanaData.Name = "mtbProponowanaData";
            this.mtbProponowanaData.Size = new System.Drawing.Size(251, 29);
            this.mtbProponowanaData.TabIndex = 26;
            // 
            // btnDzisProponowana
            // 
            this.btnDzisProponowana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDzisProponowana.Location = new System.Drawing.Point(721, 171);
            this.btnDzisProponowana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDzisProponowana.Name = "btnDzisProponowana";
            this.btnDzisProponowana.Size = new System.Drawing.Size(57, 28);
            this.btnDzisProponowana.TabIndex = 25;
            this.btnDzisProponowana.Text = "Dziś";
            this.btnDzisProponowana.UseVisualStyleBackColor = true;
            this.btnDzisProponowana.Click += new System.EventHandler(this.btnDzisProponowana_Click);
            // 
            // mtbDataRozpoczecia
            // 
            this.mtbDataRozpoczecia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtbDataRozpoczecia.Location = new System.Drawing.Point(461, 204);
            this.mtbDataRozpoczecia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbDataRozpoczecia.Mask = "0000/00/00 00:00:00";
            this.mtbDataRozpoczecia.Name = "mtbDataRozpoczecia";
            this.mtbDataRozpoczecia.Size = new System.Drawing.Size(251, 29);
            this.mtbDataRozpoczecia.TabIndex = 28;
            // 
            // btnDzisRozpoczecie
            // 
            this.btnDzisRozpoczecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDzisRozpoczecie.Location = new System.Drawing.Point(721, 207);
            this.btnDzisRozpoczecie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDzisRozpoczecie.Name = "btnDzisRozpoczecie";
            this.btnDzisRozpoczecie.Size = new System.Drawing.Size(57, 28);
            this.btnDzisRozpoczecie.TabIndex = 27;
            this.btnDzisRozpoczecie.Text = "Dziś";
            this.btnDzisRozpoczecie.UseVisualStyleBackColor = true;
            this.btnDzisRozpoczecie.Click += new System.EventHandler(this.btnDzisRozpoczecie_Click);
            // 
            // btnDzisZakonczenie
            // 
            this.btnDzisZakonczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDzisZakonczenie.Location = new System.Drawing.Point(721, 242);
            this.btnDzisZakonczenie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDzisZakonczenie.Name = "btnDzisZakonczenie";
            this.btnDzisZakonczenie.Size = new System.Drawing.Size(57, 28);
            this.btnDzisZakonczenie.TabIndex = 29;
            this.btnDzisZakonczenie.Text = "Dziś";
            this.btnDzisZakonczenie.UseVisualStyleBackColor = true;
            this.btnDzisZakonczenie.Click += new System.EventHandler(this.btnDzisZakonczenie_Click);
            // 
            // lblGwiazdka
            // 
            this.lblGwiazdka.AutoSize = true;
            this.lblGwiazdka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGwiazdka.Location = new System.Drawing.Point(721, 135);
            this.lblGwiazdka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGwiazdka.Name = "lblGwiazdka";
            this.lblGwiazdka.Size = new System.Drawing.Size(17, 24);
            this.lblGwiazdka.TabIndex = 31;
            this.lblGwiazdka.Text = "*";
            // 
            // NowyProces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(816, 478);
            this.Controls.Add(this.lblGwiazdka);
            this.Controls.Add(this.btnDzisZakonczenie);
            this.Controls.Add(this.mtbDataRozpoczecia);
            this.Controls.Add(this.btnDzisRozpoczecie);
            this.Controls.Add(this.mtbProponowanaData);
            this.Controls.Add(this.btnDzisProponowana);
            this.Controls.Add(this.dgvUkryty);
            this.Controls.Add(this.lblNumerProcesu);
            this.Controls.Add(this.btnWyzeruj);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.tbUwagi);
            this.Controls.Add(this.lblUwagi);
            this.Controls.Add(this.lblDataZakonczenia);
            this.Controls.Add(this.lblDataRozpoczecia);
            this.Controls.Add(this.lblProponowanaDataDostawy);
            this.Controls.Add(this.lblIdZamowienieElement);
            this.Controls.Add(this.lblOpisNumer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NowyProces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nowy proces";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NowyProces_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUkryty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpisNumer;
        private System.Windows.Forms.Label lblIdZamowienieElement;
        private System.Windows.Forms.Label lblProponowanaDataDostawy;
        private System.Windows.Forms.Label lblDataRozpoczecia;
        private System.Windows.Forms.Label lblDataZakonczenia;
        private System.Windows.Forms.Label lblUwagi;
        private System.Windows.Forms.TextBox tbUwagi;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnWyzeruj;
        private System.Windows.Forms.Label lblNumerProcesu;
        private System.Windows.Forms.DataGridView dgvUkryty;
        private System.Windows.Forms.MaskedTextBox mtbProponowanaData;
        private System.Windows.Forms.Button btnDzisProponowana;
        private System.Windows.Forms.MaskedTextBox mtbDataRozpoczecia;
        private System.Windows.Forms.Button btnDzisRozpoczecie;
        private System.Windows.Forms.Button btnDzisZakonczenie;
        private System.Windows.Forms.Label lblGwiazdka;
    }
}