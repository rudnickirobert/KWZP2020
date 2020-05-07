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
            this.tbIdZamowienieElement = new System.Windows.Forms.TextBox();
            this.lblProponowanaDataDostawy = new System.Windows.Forms.Label();
            this.tbProponowanaData = new System.Windows.Forms.TextBox();
            this.lblDataRozpoczecia = new System.Windows.Forms.Label();
            this.tbDataRozpoczecia = new System.Windows.Forms.TextBox();
            this.lblDataZakonczenia = new System.Windows.Forms.Label();
            this.tbDataZakonczenia = new System.Windows.Forms.TextBox();
            this.lblUwagi = new System.Windows.Forms.Label();
            this.tbUwagi = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnWyzeruj = new System.Windows.Forms.Button();
            this.lblNumerProcesu = new System.Windows.Forms.Label();
            this.dgvUkryty = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUkryty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOpisNumer
            // 
            this.lblOpisNumer.AutoSize = true;
            this.lblOpisNumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisNumer.Location = new System.Drawing.Point(77, 44);
            this.lblOpisNumer.Name = "lblOpisNumer";
            this.lblOpisNumer.Size = new System.Drawing.Size(200, 24);
            this.lblOpisNumer.TabIndex = 0;
            this.lblOpisNumer.Text = "ID nowego procesu to:";
            // 
            // lblIdZamowienieElement
            // 
            this.lblIdZamowienieElement.AutoSize = true;
            this.lblIdZamowienieElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdZamowienieElement.Location = new System.Drawing.Point(62, 107);
            this.lblIdZamowienieElement.Name = "lblIdZamowienieElement";
            this.lblIdZamowienieElement.Size = new System.Drawing.Size(161, 18);
            this.lblIdZamowienieElement.TabIndex = 1;
            this.lblIdZamowienieElement.Text = "ID zamówienie element";
            // 
            // tbIdZamowienieElement
            // 
            this.tbIdZamowienieElement.Location = new System.Drawing.Point(332, 105);
            this.tbIdZamowienieElement.Name = "tbIdZamowienieElement";
            this.tbIdZamowienieElement.Size = new System.Drawing.Size(189, 20);
            this.tbIdZamowienieElement.TabIndex = 2;
            // 
            // lblProponowanaDataDostawy
            // 
            this.lblProponowanaDataDostawy.AutoSize = true;
            this.lblProponowanaDataDostawy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProponowanaDataDostawy.Location = new System.Drawing.Point(62, 133);
            this.lblProponowanaDataDostawy.Name = "lblProponowanaDataDostawy";
            this.lblProponowanaDataDostawy.Size = new System.Drawing.Size(256, 18);
            this.lblProponowanaDataDostawy.TabIndex = 1;
            this.lblProponowanaDataDostawy.Text = "Proponowana data dostawy materiału";
            // 
            // tbProponowanaData
            // 
            this.tbProponowanaData.Location = new System.Drawing.Point(332, 131);
            this.tbProponowanaData.Name = "tbProponowanaData";
            this.tbProponowanaData.Size = new System.Drawing.Size(189, 20);
            this.tbProponowanaData.TabIndex = 2;
            // 
            // lblDataRozpoczecia
            // 
            this.lblDataRozpoczecia.AutoSize = true;
            this.lblDataRozpoczecia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataRozpoczecia.Location = new System.Drawing.Point(62, 159);
            this.lblDataRozpoczecia.Name = "lblDataRozpoczecia";
            this.lblDataRozpoczecia.Size = new System.Drawing.Size(125, 18);
            this.lblDataRozpoczecia.TabIndex = 1;
            this.lblDataRozpoczecia.Text = "Data rozpoczęcia";
            // 
            // tbDataRozpoczecia
            // 
            this.tbDataRozpoczecia.Location = new System.Drawing.Point(332, 157);
            this.tbDataRozpoczecia.Name = "tbDataRozpoczecia";
            this.tbDataRozpoczecia.Size = new System.Drawing.Size(189, 20);
            this.tbDataRozpoczecia.TabIndex = 2;
            // 
            // lblDataZakonczenia
            // 
            this.lblDataZakonczenia.AutoSize = true;
            this.lblDataZakonczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataZakonczenia.Location = new System.Drawing.Point(62, 185);
            this.lblDataZakonczenia.Name = "lblDataZakonczenia";
            this.lblDataZakonczenia.Size = new System.Drawing.Size(127, 18);
            this.lblDataZakonczenia.TabIndex = 1;
            this.lblDataZakonczenia.Text = "Data zakończenia";
            // 
            // tbDataZakonczenia
            // 
            this.tbDataZakonczenia.Location = new System.Drawing.Point(332, 183);
            this.tbDataZakonczenia.Name = "tbDataZakonczenia";
            this.tbDataZakonczenia.Size = new System.Drawing.Size(189, 20);
            this.tbDataZakonczenia.TabIndex = 2;
            // 
            // lblUwagi
            // 
            this.lblUwagi.AutoSize = true;
            this.lblUwagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUwagi.Location = new System.Drawing.Point(62, 211);
            this.lblUwagi.Name = "lblUwagi";
            this.lblUwagi.Size = new System.Drawing.Size(49, 18);
            this.lblUwagi.TabIndex = 1;
            this.lblUwagi.Text = "Uwagi";
            // 
            // tbUwagi
            // 
            this.tbUwagi.Location = new System.Drawing.Point(332, 209);
            this.tbUwagi.Name = "tbUwagi";
            this.tbUwagi.Size = new System.Drawing.Size(189, 20);
            this.tbUwagi.TabIndex = 2;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapisz.Location = new System.Drawing.Point(119, 281);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(80, 50);
            this.btnZapisz.TabIndex = 3;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnuluj.Location = new System.Drawing.Point(238, 281);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(80, 50);
            this.btnAnuluj.TabIndex = 3;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnWyzeruj
            // 
            this.btnWyzeruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyzeruj.Location = new System.Drawing.Point(346, 281);
            this.btnWyzeruj.Name = "btnWyzeruj";
            this.btnWyzeruj.Size = new System.Drawing.Size(80, 50);
            this.btnWyzeruj.TabIndex = 3;
            this.btnWyzeruj.Text = "Wyzeruj";
            this.btnWyzeruj.UseVisualStyleBackColor = true;
            this.btnWyzeruj.Click += new System.EventHandler(this.btnWyzeruj_Click);
            // 
            // lblNumerProcesu
            // 
            this.lblNumerProcesu.AutoSize = true;
            this.lblNumerProcesu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumerProcesu.Location = new System.Drawing.Point(342, 48);
            this.lblNumerProcesu.Name = "lblNumerProcesu";
            this.lblNumerProcesu.Size = new System.Drawing.Size(51, 20);
            this.lblNumerProcesu.TabIndex = 4;
            this.lblNumerProcesu.Text = "label1";
            // 
            // dgvUkryty
            // 
            this.dgvUkryty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUkryty.Location = new System.Drawing.Point(24, 13);
            this.dgvUkryty.Name = "dgvUkryty";
            this.dgvUkryty.Size = new System.Drawing.Size(47, 43);
            this.dgvUkryty.TabIndex = 5;
            this.dgvUkryty.Visible = false;
            // 
            // NowyProces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 362);
            this.Controls.Add(this.dgvUkryty);
            this.Controls.Add(this.lblNumerProcesu);
            this.Controls.Add(this.btnWyzeruj);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.tbUwagi);
            this.Controls.Add(this.lblUwagi);
            this.Controls.Add(this.tbDataZakonczenia);
            this.Controls.Add(this.lblDataZakonczenia);
            this.Controls.Add(this.tbDataRozpoczecia);
            this.Controls.Add(this.lblDataRozpoczecia);
            this.Controls.Add(this.tbProponowanaData);
            this.Controls.Add(this.lblProponowanaDataDostawy);
            this.Controls.Add(this.tbIdZamowienieElement);
            this.Controls.Add(this.lblIdZamowienieElement);
            this.Controls.Add(this.lblOpisNumer);
            this.Name = "NowyProces";
            this.Text = "Nowy Proces";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUkryty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpisNumer;
        private System.Windows.Forms.Label lblIdZamowienieElement;
        private System.Windows.Forms.TextBox tbIdZamowienieElement;
        private System.Windows.Forms.Label lblProponowanaDataDostawy;
        private System.Windows.Forms.TextBox tbProponowanaData;
        private System.Windows.Forms.Label lblDataRozpoczecia;
        private System.Windows.Forms.TextBox tbDataRozpoczecia;
        private System.Windows.Forms.Label lblDataZakonczenia;
        private System.Windows.Forms.TextBox tbDataZakonczenia;
        private System.Windows.Forms.Label lblUwagi;
        private System.Windows.Forms.TextBox tbUwagi;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnWyzeruj;
        private System.Windows.Forms.Label lblNumerProcesu;
        private System.Windows.Forms.DataGridView dgvUkryty;
    }
}