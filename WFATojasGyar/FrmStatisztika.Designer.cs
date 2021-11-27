namespace WFATojasGyar
{
    partial class FrmStatisztika
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNev = new System.Windows.Forms.ComboBox();
            this.nudHonap = new System.Windows.Forms.NumericUpDown();
            this.dgvStat = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaxSzin = new System.Windows.Forms.TextBox();
            this.tbMaxSuly = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudHonap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 525);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A hónapban legtöbbet gyártott tojás színe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kiválasztott hónap sorszáma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Termelési napló:";
            // 
            // cbNev
            // 
            this.cbNev.FormattingEnabled = true;
            this.cbNev.Location = new System.Drawing.Point(187, 45);
            this.cbNev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNev.Name = "cbNev";
            this.cbNev.Size = new System.Drawing.Size(239, 28);
            this.cbNev.TabIndex = 3;
            this.cbNev.SelectedIndexChanged += new System.EventHandler(this.cbNev_SelectedIndexChanged);
            // 
            // nudHonap
            // 
            this.nudHonap.Enabled = false;
            this.nudHonap.Location = new System.Drawing.Point(777, 46);
            this.nudHonap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudHonap.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudHonap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHonap.Name = "nudHonap";
            this.nudHonap.ReadOnly = true;
            this.nudHonap.Size = new System.Drawing.Size(44, 26);
            this.nudHonap.TabIndex = 4;
            this.nudHonap.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudHonap.ValueChanged += new System.EventHandler(this.nudHonap_ValueChanged);
            // 
            // dgvStat
            // 
            this.dgvStat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Color,
            this.Count});
            this.dgvStat.Location = new System.Drawing.Point(21, 162);
            this.dgvStat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvStat.Name = "dgvStat";
            this.dgvStat.RowHeadersVisible = false;
            this.dgvStat.Size = new System.Drawing.Size(800, 322);
            this.dgvStat.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "A munkás neve:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 589);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adott hónapban termelt tojások összsúlya:";
            // 
            // tbMaxSzin
            // 
            this.tbMaxSzin.Enabled = false;
            this.tbMaxSzin.Location = new System.Drawing.Point(673, 519);
            this.tbMaxSzin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMaxSzin.Name = "tbMaxSzin";
            this.tbMaxSzin.ReadOnly = true;
            this.tbMaxSzin.Size = new System.Drawing.Size(148, 26);
            this.tbMaxSzin.TabIndex = 6;
            // 
            // tbMaxSuly
            // 
            this.tbMaxSuly.Enabled = false;
            this.tbMaxSuly.Location = new System.Drawing.Point(673, 583);
            this.tbMaxSuly.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMaxSuly.Name = "tbMaxSuly";
            this.tbMaxSuly.ReadOnly = true;
            this.tbMaxSuly.Size = new System.Drawing.Size(148, 26);
            this.tbMaxSuly.TabIndex = 7;
            // 
            // Date
            // 
            this.Date.HeaderText = "Dátum";
            this.Date.Name = "Date";
            // 
            // Color
            // 
            this.Color.HeaderText = "Szín";
            this.Color.Name = "Color";
            // 
            // Count
            // 
            this.Count.HeaderText = "Mennyiség";
            this.Count.Name = "Count";
            // 
            // FrmStatisztika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 629);
            this.Controls.Add(this.tbMaxSuly);
            this.Controls.Add(this.tbMaxSzin);
            this.Controls.Add(this.dgvStat);
            this.Controls.Add(this.nudHonap);
            this.Controls.Add(this.cbNev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmStatisztika";
            this.Text = "FrmStatisztika";
            this.Load += new System.EventHandler(this.FrmStatisztika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHonap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNev;
        private System.Windows.Forms.NumericUpDown nudHonap;
        private System.Windows.Forms.DataGridView dgvStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaxSzin;
        private System.Windows.Forms.TextBox tbMaxSuly;
    }
}