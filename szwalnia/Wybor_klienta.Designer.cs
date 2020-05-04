namespace Szwalnia
{
    partial class Wybor_klienta
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
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.lblInformacja = new System.Windows.Forms.Label();
            this.davListaKlientow = new System.Windows.Forms.DataGridView();
            this.txtNazwaFirmy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.davListaKlientow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzukaj.Location = new System.Drawing.Point(530, 116);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(222, 70);
            this.btnSzukaj.TabIndex = 0;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            // 
            // lblInformacja
            // 
            this.lblInformacja.AutoSize = true;
            this.lblInformacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInformacja.Location = new System.Drawing.Point(102, 34);
            this.lblInformacja.Name = "lblInformacja";
            this.lblInformacja.Size = new System.Drawing.Size(650, 39);
            this.lblInformacja.TabIndex = 1;
            this.lblInformacja.Text = "Wprowadz nazwę firmy szukanego klienta";
            // 
            // davListaKlientow
            // 
            this.davListaKlientow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.davListaKlientow.Location = new System.Drawing.Point(12, 201);
            this.davListaKlientow.Name = "davListaKlientow";
            this.davListaKlientow.RowHeadersWidth = 51;
            this.davListaKlientow.RowTemplate.Height = 24;
            this.davListaKlientow.Size = new System.Drawing.Size(776, 237);
            this.davListaKlientow.TabIndex = 2;
            // 
            // txtNazwaFirmy
            // 
            this.txtNazwaFirmy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwaFirmy.Location = new System.Drawing.Point(65, 134);
            this.txtNazwaFirmy.Name = "txtNazwaFirmy";
            this.txtNazwaFirmy.Size = new System.Drawing.Size(411, 38);
            this.txtNazwaFirmy.TabIndex = 3;
            // 
            // Wybor_klienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNazwaFirmy);
            this.Controls.Add(this.davListaKlientow);
            this.Controls.Add(this.lblInformacja);
            this.Controls.Add(this.btnSzukaj);
            this.Name = "Wybor_klienta";
            this.Text = "Wybor_klienta";
            ((System.ComponentModel.ISupportInitialize)(this.davListaKlientow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Label lblInformacja;
        private System.Windows.Forms.DataGridView davListaKlientow;
        private System.Windows.Forms.TextBox txtNazwaFirmy;
    }
}