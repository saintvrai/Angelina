namespace UI
{
    partial class Enviroment
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
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SourceX = new System.Windows.Forms.NumericUpDown();
            this.SourceY = new System.Windows.Forms.NumericUpDown();
            this.SourceZ = new System.Windows.Forms.NumericUpDown();
            this.VectorX = new System.Windows.Forms.NumericUpDown();
            this.VectorY = new System.Windows.Forms.NumericUpDown();
            this.MaxFrequency = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourceX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VectorX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VectorY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Salmon;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(578, 471);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(110, 46);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(95, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Экспериментальные параметры воздействия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Верхняя граница частотного диапазона:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(519, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "GHz";
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.Orange;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit.Location = new System.Drawing.Point(447, 471);
            this.Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(125, 46);
            this.Edit.TabIndex = 102;
            this.Edit.Text = "Изменить";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.VectorY);
            this.panel2.Controls.Add(this.VectorX);
            this.panel2.Controls.Add(this.SourceZ);
            this.panel2.Controls.Add(this.SourceY);
            this.panel2.Controls.Add(this.SourceX);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(40, 226);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 205);
            this.panel2.TabIndex = 103;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(222, 169);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(24, 20);
            this.label24.TabIndex = 58;
            this.label24.Text = "Y:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(3, 169);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 20);
            this.label23.TabIndex = 56;
            this.label23.Text = "X:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(3, 121);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(362, 20);
            this.label22.TabIndex = 54;
            this.label22.Text = "Координаты точки вектора воздействия:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(446, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Z:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(222, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "X:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(327, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Координаты источника воздействия:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Bisque;
            this.panel3.Controls.Add(this.MaxFrequency);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(37, 112);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 87);
            this.panel3.TabIndex = 104;
            // 
            // SourceX
            // 
            this.SourceX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SourceX.Location = new System.Drawing.Point(34, 67);
            this.SourceX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SourceX.Name = "SourceX";
            this.SourceX.Size = new System.Drawing.Size(151, 30);
            this.SourceX.TabIndex = 105;
            // 
            // SourceY
            // 
            this.SourceY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SourceY.Location = new System.Drawing.Point(252, 67);
            this.SourceY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SourceY.Name = "SourceY";
            this.SourceY.Size = new System.Drawing.Size(151, 30);
            this.SourceY.TabIndex = 106;
            // 
            // SourceZ
            // 
            this.SourceZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SourceZ.Location = new System.Drawing.Point(475, 67);
            this.SourceZ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SourceZ.Name = "SourceZ";
            this.SourceZ.Size = new System.Drawing.Size(151, 30);
            this.SourceZ.TabIndex = 107;
            // 
            // VectorX
            // 
            this.VectorX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VectorX.Location = new System.Drawing.Point(34, 164);
            this.VectorX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.VectorX.Name = "VectorX";
            this.VectorX.Size = new System.Drawing.Size(151, 30);
            this.VectorX.TabIndex = 108;
            // 
            // VectorY
            // 
            this.VectorY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VectorY.Location = new System.Drawing.Point(252, 164);
            this.VectorY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.VectorY.Name = "VectorY";
            this.VectorY.Size = new System.Drawing.Size(151, 30);
            this.VectorY.TabIndex = 109;
            // 
            // MaxFrequency
            // 
            this.MaxFrequency.DecimalPlaces = 2;
            this.MaxFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxFrequency.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MaxFrequency.Location = new System.Drawing.Point(370, 25);
            this.MaxFrequency.Name = "MaxFrequency";
            this.MaxFrequency.Size = new System.Drawing.Size(143, 30);
            this.MaxFrequency.TabIndex = 106;
            // 
            // Enviroment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(715, 541);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Enviroment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экспериментальные параметры воздействия";
            this.Load += new System.EventHandler(this.Enviroment_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourceX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VectorX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VectorY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFrequency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Edit;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown VectorY;
        private System.Windows.Forms.NumericUpDown VectorX;
        private System.Windows.Forms.NumericUpDown SourceZ;
        private System.Windows.Forms.NumericUpDown SourceY;
        private System.Windows.Forms.NumericUpDown SourceX;
        private System.Windows.Forms.NumericUpDown MaxFrequency;
    }
}