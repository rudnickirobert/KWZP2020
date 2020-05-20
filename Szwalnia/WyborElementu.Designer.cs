namespace Szwalnia
{
    partial class WyborElementu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WyborElementu));
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.dgvListaElementow = new System.Windows.Forms.DataGridView();
            this.btnWstecz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaElementow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfo.Location = new System.Drawing.Point(17, 12);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(364, 39);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Wybierz element z listy";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(113, 69);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 4;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvListaElementow
            // 
            this.dgvListaElementow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaElementow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaElementow.Location = new System.Drawing.Point(24, 69);
            this.dgvListaElementow.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaElementow.Name = "dgvListaElementow";
            this.dgvListaElementow.RowHeadersWidth = 51;
            this.dgvListaElementow.Size = new System.Drawing.Size(632, 462);
            this.dgvListaElementow.TabIndex = 5;
            this.dgvListaElementow.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaElementow_CellDoubleClick);
            // 
            // btnWstecz
            // 
            this.btnWstecz.Location = new System.Drawing.Point(562, 21);
            this.btnWstecz.Name = "btnWstecz";
            this.btnWstecz.Size = new System.Drawing.Size(77, 30);
            this.btnWstecz.TabIndex = 24;
            this.btnWstecz.Text = "Wstecz";
            this.btnWstecz.UseVisualStyleBackColor = true;
            this.btnWstecz.Click += new System.EventHandler(this.btnWstecz_Click);
            // 
            // WyborElementu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 545);
            this.Controls.Add(this.btnWstecz);
            this.Controls.Add(this.dgvListaElementow);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WyborElementu";
            this.Text = "Okno wyboru elementow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WyborElementu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaElementow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dgvListaElementow;
        private System.Windows.Forms.Button btnWstecz;
    }
}