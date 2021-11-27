namespace WFATojasGyar
{
    partial class FrmMain
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
            this.pbKep = new System.Windows.Forms.PictureBox();
            this.btnTermeles = new System.Windows.Forms.Button();
            this.btnStatisztika = new System.Windows.Forms.Button();
            this.btnKimutatas = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).BeginInit();
            this.SuspendLayout();
            // 
            // pbKep
            // 
            this.pbKep.Location = new System.Drawing.Point(397, 12);
            this.pbKep.Name = "pbKep";
            this.pbKep.Size = new System.Drawing.Size(391, 320);
            this.pbKep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKep.TabIndex = 0;
            this.pbKep.TabStop = false;
            // 
            // btnTermeles
            // 
            this.btnTermeles.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTermeles.Location = new System.Drawing.Point(12, 12);
            this.btnTermeles.Name = "btnTermeles";
            this.btnTermeles.Size = new System.Drawing.Size(379, 76);
            this.btnTermeles.TabIndex = 1;
            this.btnTermeles.Text = "Termelés";
            this.btnTermeles.UseVisualStyleBackColor = true;
            this.btnTermeles.Click += new System.EventHandler(this.btnTermeles_Click);
            // 
            // btnStatisztika
            // 
            this.btnStatisztika.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStatisztika.Location = new System.Drawing.Point(12, 94);
            this.btnStatisztika.Name = "btnStatisztika";
            this.btnStatisztika.Size = new System.Drawing.Size(379, 76);
            this.btnStatisztika.TabIndex = 1;
            this.btnStatisztika.Text = "Statisztika";
            this.btnStatisztika.UseVisualStyleBackColor = true;
            this.btnStatisztika.Click += new System.EventHandler(this.btnStatisztika_Click);
            // 
            // btnKimutatas
            // 
            this.btnKimutatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKimutatas.Location = new System.Drawing.Point(12, 176);
            this.btnKimutatas.Name = "btnKimutatas";
            this.btnKimutatas.Size = new System.Drawing.Size(379, 76);
            this.btnKimutatas.TabIndex = 1;
            this.btnKimutatas.Text = "Kimutatás";
            this.btnKimutatas.UseVisualStyleBackColor = true;
            // 
            // btnKilepes
            // 
            this.btnKilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKilepes.Location = new System.Drawing.Point(12, 258);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(379, 76);
            this.btnKilepes.TabIndex = 1;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.ControlBox = false;
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnKimutatas);
            this.Controls.Add(this.btnStatisztika);
            this.Controls.Add(this.btnTermeles);
            this.Controls.Add(this.pbKep);
            this.Name = "FrmMain";
            this.Text = "TojasManufaktura";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbKep;
        private System.Windows.Forms.Button btnTermeles;
        private System.Windows.Forms.Button btnStatisztika;
        private System.Windows.Forms.Button btnKimutatas;
        private System.Windows.Forms.Button btnKilepes;
    }
}

