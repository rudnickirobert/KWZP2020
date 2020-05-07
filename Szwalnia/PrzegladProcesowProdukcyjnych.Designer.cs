namespace Szwalnia
{
    partial class PrzegladProcesowProdukcyjnych
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
            this.btnWszystkieProcesy = new System.Windows.Forms.Button();
            this.btnNumerProcesu = new System.Windows.Forms.Button();
            this.btnNumerZamowienia = new System.Windows.Forms.Button();
            this.btnNumerZamowienieElement = new System.Windows.Forms.Button();
            this.btnRozpoczeteProcesy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWszystkieProcesy
            // 
            this.btnWszystkieProcesy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWszystkieProcesy.Location = new System.Drawing.Point(72, 23);
            this.btnWszystkieProcesy.Name = "btnWszystkieProcesy";
            this.btnWszystkieProcesy.Size = new System.Drawing.Size(300, 80);
            this.btnWszystkieProcesy.TabIndex = 0;
            this.btnWszystkieProcesy.Text = "Wszystkie";
            this.btnWszystkieProcesy.UseVisualStyleBackColor = true;
            this.btnWszystkieProcesy.Click += new System.EventHandler(this.btnWszystkieProcesy_Click);
            // 
            // btnNumerProcesu
            // 
            this.btnNumerProcesu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNumerProcesu.Location = new System.Drawing.Point(72, 109);
            this.btnNumerProcesu.Name = "btnNumerProcesu";
            this.btnNumerProcesu.Size = new System.Drawing.Size(300, 80);
            this.btnNumerProcesu.TabIndex = 0;
            this.btnNumerProcesu.Text = "Numer procesu";
            this.btnNumerProcesu.UseVisualStyleBackColor = true;
            // 
            // btnNumerZamowienia
            // 
            this.btnNumerZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNumerZamowienia.Location = new System.Drawing.Point(72, 195);
            this.btnNumerZamowienia.Name = "btnNumerZamowienia";
            this.btnNumerZamowienia.Size = new System.Drawing.Size(300, 80);
            this.btnNumerZamowienia.TabIndex = 0;
            this.btnNumerZamowienia.Text = "Numer zamówienia";
            this.btnNumerZamowienia.UseVisualStyleBackColor = true;
            this.btnNumerZamowienia.Click += new System.EventHandler(this.btnNumerZamowienia_Click);
            // 
            // btnNumerZamowienieElement
            // 
            this.btnNumerZamowienieElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNumerZamowienieElement.Location = new System.Drawing.Point(72, 281);
            this.btnNumerZamowienieElement.Name = "btnNumerZamowienieElement";
            this.btnNumerZamowienieElement.Size = new System.Drawing.Size(300, 80);
            this.btnNumerZamowienieElement.TabIndex = 0;
            this.btnNumerZamowienieElement.Text = "Numer zamowienie element";
            this.btnNumerZamowienieElement.UseVisualStyleBackColor = true;
            // 
            // btnRozpoczeteProcesy
            // 
            this.btnRozpoczeteProcesy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRozpoczeteProcesy.Location = new System.Drawing.Point(72, 367);
            this.btnRozpoczeteProcesy.Name = "btnRozpoczeteProcesy";
            this.btnRozpoczeteProcesy.Size = new System.Drawing.Size(300, 80);
            this.btnRozpoczeteProcesy.TabIndex = 0;
            this.btnRozpoczeteProcesy.Text = "Rozpoczęte";
            this.btnRozpoczeteProcesy.UseVisualStyleBackColor = true;
            // 
            // PrzegladProcesowProdukcyjnych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 478);
            this.Controls.Add(this.btnRozpoczeteProcesy);
            this.Controls.Add(this.btnNumerZamowienieElement);
            this.Controls.Add(this.btnNumerZamowienia);
            this.Controls.Add(this.btnNumerProcesu);
            this.Controls.Add(this.btnWszystkieProcesy);
            this.Name = "PrzegladProcesowProdukcyjnych";
            this.Text = "Przeglad Procesow Produkcyjnych";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWszystkieProcesy;
        private System.Windows.Forms.Button btnNumerProcesu;
        private System.Windows.Forms.Button btnNumerZamowienia;
        private System.Windows.Forms.Button btnNumerZamowienieElement;
        private System.Windows.Forms.Button btnRozpoczeteProcesy;
    }
}