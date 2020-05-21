namespace Szwalnia
{
    partial class PanelFinansow
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
            this.btnZamknij = new System.Windows.Forms.Button();
            this.dgvPrzychody = new System.Windows.Forms.DataGridView();
            this.dgvRozchody = new System.Windows.Forms.DataGridView();
            this.dgvBilans = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrzychody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRozchody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilans)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(416, 423);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(101, 36);
            this.btnZamknij.TabIndex = 3;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // dgvPrzychody
            // 
            this.dgvPrzychody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrzychody.Location = new System.Drawing.Point(217, 32);
            this.dgvPrzychody.Name = "dgvPrzychody";
            this.dgvPrzychody.RowHeadersWidth = 51;
            this.dgvPrzychody.RowTemplate.Height = 24;
            this.dgvPrzychody.Size = new System.Drawing.Size(208, 87);
            this.dgvPrzychody.TabIndex = 4;
            // 
            // dgvRozchody
            // 
            this.dgvRozchody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRozchody.Location = new System.Drawing.Point(217, 159);
            this.dgvRozchody.Name = "dgvRozchody";
            this.dgvRozchody.RowHeadersWidth = 51;
            this.dgvRozchody.RowTemplate.Height = 24;
            this.dgvRozchody.Size = new System.Drawing.Size(340, 87);
            this.dgvRozchody.TabIndex = 5;
            // 
            // dgvBilans
            // 
            this.dgvBilans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilans.Location = new System.Drawing.Point(217, 301);
            this.dgvBilans.Name = "dgvBilans";
            this.dgvBilans.RowHeadersWidth = 51;
            this.dgvBilans.RowTemplate.Height = 24;
            this.dgvBilans.Size = new System.Drawing.Size(469, 87);
            this.dgvBilans.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Przychody";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(32, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rozchody";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(32, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bilans";
            // 
            // PanelFinansow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(735, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBilans);
            this.Controls.Add(this.dgvRozchody);
            this.Controls.Add(this.dgvPrzychody);
            this.Controls.Add(this.btnZamknij);
            this.Name = "PanelFinansow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel_finansów";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrzychody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRozchody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.DataGridView dgvPrzychody;
        private System.Windows.Forms.DataGridView dgvRozchody;
        private System.Windows.Forms.DataGridView dgvBilans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}