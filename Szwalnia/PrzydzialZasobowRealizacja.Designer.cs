namespace Szwalnia
{
    partial class PrzydzialZasobowRealizacja
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
            this.dgvPrzydzialZasobowRealizacja = new System.Windows.Forms.DataGridView();
            this.lblRealizacja = new System.Windows.Forms.Label();
            this.btnNowy = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrzydzialZasobowRealizacja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrzydzialZasobowRealizacja
            // 
            this.dgvPrzydzialZasobowRealizacja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrzydzialZasobowRealizacja.Location = new System.Drawing.Point(60, 95);
            this.dgvPrzydzialZasobowRealizacja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPrzydzialZasobowRealizacja.Name = "dgvPrzydzialZasobowRealizacja";
            this.dgvPrzydzialZasobowRealizacja.RowHeadersWidth = 51;
            this.dgvPrzydzialZasobowRealizacja.Size = new System.Drawing.Size(985, 411);
            this.dgvPrzydzialZasobowRealizacja.TabIndex = 0;
            // 
            // lblRealizacja
            // 
            this.lblRealizacja.AutoSize = true;
            this.lblRealizacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRealizacja.Location = new System.Drawing.Point(281, 42);
            this.lblRealizacja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRealizacja.Name = "lblRealizacja";
            this.lblRealizacja.Size = new System.Drawing.Size(64, 25);
            this.lblRealizacja.TabIndex = 2;
            this.lblRealizacja.Text = "label1";
            // 
            // btnNowy
            // 
            this.btnNowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNowy.Location = new System.Drawing.Point(396, 545);
            this.btnNowy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNowy.Name = "btnNowy";
            this.btnNowy.Size = new System.Drawing.Size(107, 62);
            this.btnNowy.TabIndex = 9;
            this.btnNowy.Text = "Nowy";
            this.btnNowy.UseVisualStyleBackColor = true;
            this.btnNowy.Click += new System.EventHandler(this.btnNowy_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnuluj.Location = new System.Drawing.Point(713, 545);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(107, 62);
            this.btnAnuluj.TabIndex = 7;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapisz.Location = new System.Drawing.Point(552, 545);
            this.btnZapisz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(107, 62);
            this.btnZapisz.TabIndex = 8;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // PrzydzialZasobowRealizacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1097, 633);
            this.Controls.Add(this.btnNowy);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.lblRealizacja);
            this.Controls.Add(this.dgvPrzydzialZasobowRealizacja);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PrzydzialZasobowRealizacja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przydział zasobów";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrzydzialZasobowRealizacja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrzydzialZasobowRealizacja;
        private System.Windows.Forms.Label lblRealizacja;
        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZapisz;
    }
}