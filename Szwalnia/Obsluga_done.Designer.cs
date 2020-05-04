namespace Szwalnia
{
    partial class Obsluga_done
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
            this.dgvObsluga = new System.Windows.Forms.DataGridView();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtPracownik = new System.Windows.Forms.TextBox();
            this.txtMaszyna = new System.Windows.Forms.TextBox();
            this.txtRodzaj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObsluga)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObsluga
            // 
            this.dgvObsluga.AllowUserToAddRows = false;
            this.dgvObsluga.AllowUserToDeleteRows = false;
            this.dgvObsluga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObsluga.Location = new System.Drawing.Point(12, 268);
            this.dgvObsluga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvObsluga.Name = "dgvObsluga";
            this.dgvObsluga.ReadOnly = true;
            this.dgvObsluga.RowHeadersWidth = 51;
            this.dgvObsluga.RowTemplate.Height = 24;
            this.dgvObsluga.Size = new System.Drawing.Size(836, 231);
            this.dgvObsluga.TabIndex = 39;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(126, 222);
            this.txtData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(296, 22);
            this.txtData.TabIndex = 38;
            // 
            // txtPracownik
            // 
            this.txtPracownik.Location = new System.Drawing.Point(126, 193);
            this.txtPracownik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPracownik.Name = "txtPracownik";
            this.txtPracownik.Size = new System.Drawing.Size(296, 22);
            this.txtPracownik.TabIndex = 37;
            // 
            // txtMaszyna
            // 
            this.txtMaszyna.Location = new System.Drawing.Point(126, 158);
            this.txtMaszyna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaszyna.Name = "txtMaszyna";
            this.txtMaszyna.Size = new System.Drawing.Size(296, 22);
            this.txtMaszyna.TabIndex = 36;
            // 
            // txtRodzaj
            // 
            this.txtRodzaj.Location = new System.Drawing.Point(126, 126);
            this.txtRodzaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRodzaj.Name = "txtRodzaj";
            this.txtRodzaj.Size = new System.Drawing.Size(296, 22);
            this.txtRodzaj.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Data Wykonania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Pracownik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Maszyna";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Rodzaj";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(28, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 36);
            this.lblTitle.TabIndex = 30;
            // 
            // Obsluga_done
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 514);
            this.Controls.Add(this.dgvObsluga);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtPracownik);
            this.Controls.Add(this.txtMaszyna);
            this.Controls.Add(this.txtRodzaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Obsluga_done";
            this.Text = "Obsluga_done";
            this.Load += new System.EventHandler(this.Obsluga_done_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObsluga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObsluga;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtPracownik;
        private System.Windows.Forms.TextBox txtMaszyna;
        private System.Windows.Forms.TextBox txtRodzaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
    }
}