namespace Szwalnia
{
    partial class Maszyny_Proces_Wykonaj
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRodzaj_Maszyny = new System.Windows.Forms.DataGridView();
            this.txtLiczba_rbh = new System.Windows.Forms.TextBox();
            this.txtLiczba = new System.Windows.Forms.TextBox();
            this.txtRodzaj_Maszyny = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodzaj_Maszyny)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 39);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID_Maszyna_Proces";
            // 
            // dgvRodzaj_Maszyny
            // 
            this.dgvRodzaj_Maszyny.AllowUserToAddRows = false;
            this.dgvRodzaj_Maszyny.AllowUserToDeleteRows = false;
            this.dgvRodzaj_Maszyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRodzaj_Maszyny.Location = new System.Drawing.Point(9, 197);
            this.dgvRodzaj_Maszyny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRodzaj_Maszyny.Name = "dgvRodzaj_Maszyny";
            this.dgvRodzaj_Maszyny.ReadOnly = true;
            this.dgvRodzaj_Maszyny.RowHeadersWidth = 51;
            this.dgvRodzaj_Maszyny.RowTemplate.Height = 24;
            this.dgvRodzaj_Maszyny.Size = new System.Drawing.Size(779, 145);
            this.dgvRodzaj_Maszyny.TabIndex = 44;
            // 
            // txtLiczba_rbh
            // 
            this.txtLiczba_rbh.Location = new System.Drawing.Point(127, 167);
            this.txtLiczba_rbh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLiczba_rbh.Name = "txtLiczba_rbh";
            this.txtLiczba_rbh.Size = new System.Drawing.Size(296, 22);
            this.txtLiczba_rbh.TabIndex = 43;
            // 
            // txtLiczba
            // 
            this.txtLiczba.Location = new System.Drawing.Point(127, 134);
            this.txtLiczba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLiczba.Name = "txtLiczba";
            this.txtLiczba.Size = new System.Drawing.Size(296, 22);
            this.txtLiczba.TabIndex = 42;
            // 
            // txtRodzaj_Maszyny
            // 
            this.txtRodzaj_Maszyny.Location = new System.Drawing.Point(127, 102);
            this.txtRodzaj_Maszyny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRodzaj_Maszyny.Name = "txtRodzaj_Maszyny";
            this.txtRodzaj_Maszyny.Size = new System.Drawing.Size(296, 22);
            this.txtRodzaj_Maszyny.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Liczba_rbh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Liczba";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Rodzaj_Maszyny";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(425, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 36);
            this.label8.TabIndex = 37;
            // 
            // Maszyny_Proces_Wykonaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRodzaj_Maszyny);
            this.Controls.Add(this.txtLiczba_rbh);
            this.Controls.Add(this.txtLiczba);
            this.Controls.Add(this.txtRodzaj_Maszyny);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Name = "Maszyny_Proces_Wykonaj";
            this.Text = "Maszyny_Proces_Wykonaj";
            this.Load += new System.EventHandler(this.Maszyny_Proces_Wykonaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodzaj_Maszyny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRodzaj_Maszyny;
        private System.Windows.Forms.TextBox txtLiczba_rbh;
        private System.Windows.Forms.TextBox txtLiczba;
        private System.Windows.Forms.TextBox txtRodzaj_Maszyny;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}