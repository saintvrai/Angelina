namespace UI
{
    partial class ExternalImpulse
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
			this.panel3 = new System.Windows.Forms.Panel();
			this.Frequency = new System.Windows.Forms.NumericUpDown();
			this.ImpulseStrength = new System.Windows.Forms.NumericUpDown();
			this.ImpulseAmp = new System.Windows.Forms.NumericUpDown();
			this.ImpulseDuration = new System.Windows.Forms.NumericUpDown();
			this.FieldStrength = new System.Windows.Forms.NumericUpDown();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.DecreaseTime = new System.Windows.Forms.NumericUpDown();
			this.Duration = new System.Windows.Forms.NumericUpDown();
			this.IncreaseTime = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.Edit = new System.Windows.Forms.Button();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Frequency)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImpulseStrength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImpulseAmp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImpulseDuration)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FieldStrength)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DecreaseTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Duration)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.IncreaseTime)).BeginInit();
			this.SuspendLayout();
			// 
			// Cancel
			// 
			this.Cancel.BackColor = System.Drawing.Color.Salmon;
			this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Cancel.Location = new System.Drawing.Point(585, 405);
			this.Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(110, 46);
			this.Cancel.TabIndex = 14;
			this.Cancel.Text = "Отмена";
			this.Cancel.UseVisualStyleBackColor = false;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(22, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(683, 29);
			this.label1.TabIndex = 11;
			this.label1.Text = "Введите параметры внешнего импульсного воздействия";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Bisque;
			this.panel3.Controls.Add(this.Frequency);
			this.panel3.Controls.Add(this.ImpulseStrength);
			this.panel3.Controls.Add(this.ImpulseAmp);
			this.panel3.Controls.Add(this.ImpulseDuration);
			this.panel3.Controls.Add(this.FieldStrength);
			this.panel3.Controls.Add(this.label21);
			this.panel3.Controls.Add(this.label20);
			this.panel3.Controls.Add(this.label16);
			this.panel3.Controls.Add(this.label17);
			this.panel3.Controls.Add(this.label18);
			this.panel3.Controls.Add(this.label19);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(28, 70);
			this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(667, 154);
			this.panel3.TabIndex = 68;
			// 
			// Frequency
			// 
			this.Frequency.DecimalPlaces = 1;
			this.Frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Frequency.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.Frequency.Location = new System.Drawing.Point(443, 33);
			this.Frequency.Name = "Frequency";
			this.Frequency.Size = new System.Drawing.Size(169, 30);
			this.Frequency.TabIndex = 105;
			// 
			// ImpulseStrength
			// 
			this.ImpulseStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ImpulseStrength.Location = new System.Drawing.Point(229, 100);
			this.ImpulseStrength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.ImpulseStrength.Name = "ImpulseStrength";
			this.ImpulseStrength.Size = new System.Drawing.Size(169, 30);
			this.ImpulseStrength.TabIndex = 104;
			// 
			// ImpulseAmp
			// 
			this.ImpulseAmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ImpulseAmp.Location = new System.Drawing.Point(229, 33);
			this.ImpulseAmp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.ImpulseAmp.Name = "ImpulseAmp";
			this.ImpulseAmp.Size = new System.Drawing.Size(169, 30);
			this.ImpulseAmp.TabIndex = 103;
			// 
			// ImpulseDuration
			// 
			this.ImpulseDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ImpulseDuration.Location = new System.Drawing.Point(10, 100);
			this.ImpulseDuration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.ImpulseDuration.Name = "ImpulseDuration";
			this.ImpulseDuration.Size = new System.Drawing.Size(169, 30);
			this.ImpulseDuration.TabIndex = 102;
			// 
			// FieldStrength
			// 
			this.FieldStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FieldStrength.Location = new System.Drawing.Point(10, 33);
			this.FieldStrength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.FieldStrength.Name = "FieldStrength";
			this.FieldStrength.Size = new System.Drawing.Size(169, 30);
			this.FieldStrength.TabIndex = 56;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label21.Location = new System.Drawing.Point(617, 39);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(44, 20);
			this.label21.TabIndex = 55;
			this.label21.Text = "GHz";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label20.Location = new System.Drawing.Point(439, 8);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(158, 20);
			this.label20.TabIndex = 54;
			this.label20.Text = "Частота сигнала:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label16.Location = new System.Drawing.Point(398, 106);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(39, 20);
			this.label16.TabIndex = 52;
			this.label16.Text = "V/m";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label17.Location = new System.Drawing.Point(221, 74);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(185, 20);
			this.label17.TabIndex = 50;
			this.label17.Text = "Мощность импульса:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label18.Location = new System.Drawing.Point(182, 106);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(32, 20);
			this.label18.TabIndex = 49;
			this.label18.Text = "ms";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label19.Location = new System.Drawing.Point(4, 74);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(220, 20);
			this.label19.TabIndex = 47;
			this.label19.Text = "Длительность импульса:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(398, 39);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 20);
			this.label4.TabIndex = 46;
			this.label4.Text = "V/m";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(225, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(192, 20);
			this.label5.TabIndex = 44;
			this.label5.Text = "Амплитуда импульса:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(182, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 20);
			this.label3.TabIndex = 43;
			this.label3.Text = "V/m";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(193, 20);
			this.label2.TabIndex = 41;
			this.label2.Text = "Напряженность поля:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightBlue;
			this.panel1.Controls.Add(this.DecreaseTime);
			this.panel1.Controls.Add(this.Duration);
			this.panel1.Controls.Add(this.IncreaseTime);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Location = new System.Drawing.Point(31, 257);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(664, 91);
			this.panel1.TabIndex = 70;
			// 
			// DecreaseTime
			// 
			this.DecreaseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DecreaseTime.Location = new System.Drawing.Point(440, 51);
			this.DecreaseTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.DecreaseTime.Name = "DecreaseTime";
			this.DecreaseTime.Size = new System.Drawing.Size(177, 30);
			this.DecreaseTime.TabIndex = 105;
			// 
			// Duration
			// 
			this.Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Duration.Location = new System.Drawing.Point(226, 51);
			this.Duration.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.Duration.Name = "Duration";
			this.Duration.Size = new System.Drawing.Size(177, 30);
			this.Duration.TabIndex = 104;
			this.Duration.ValueChanged += new System.EventHandler(this.Duration_ValueChanged);
			// 
			// IncreaseTime
			// 
			this.IncreaseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.IncreaseTime.Location = new System.Drawing.Point(7, 51);
			this.IncreaseTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.IncreaseTime.Name = "IncreaseTime";
			this.IncreaseTime.Size = new System.Drawing.Size(177, 30);
			this.IncreaseTime.TabIndex = 103;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label14.Location = new System.Drawing.Point(617, 57);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(27, 20);
			this.label14.TabIndex = 55;
			this.label14.Text = "ns";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label15.Location = new System.Drawing.Point(436, 26);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(124, 20);
			this.label15.TabIndex = 53;
			this.label15.Text = "Время спада:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(405, 57);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(27, 20);
			this.label12.TabIndex = 52;
			this.label12.Text = "ns";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label13.Location = new System.Drawing.Point(222, 26);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(194, 20);
			this.label13.TabIndex = 50;
			this.label13.Text = "Время длительности:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(189, 57);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(27, 20);
			this.label10.TabIndex = 49;
			this.label10.Text = "ns";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(3, 26);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(172, 20);
			this.label11.TabIndex = 47;
			this.label11.Text = "Время нарастания:";
			// 
			// Edit
			// 
			this.Edit.BackColor = System.Drawing.Color.Orange;
			this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Edit.Location = new System.Drawing.Point(440, 405);
			this.Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Edit.Name = "Edit";
			this.Edit.Size = new System.Drawing.Size(125, 48);
			this.Edit.TabIndex = 101;
			this.Edit.Text = "Изменить";
			this.Edit.UseVisualStyleBackColor = false;
			this.Edit.Click += new System.EventHandler(this.Edit_Click);
			// 
			// ExternalImpulse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(707, 462);
			this.Controls.Add(this.Edit);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "ExternalImpulse";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Внешнее импульсное воздействие";
			this.Load += new System.EventHandler(this.ExternalImpulse_Load);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Frequency)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImpulseStrength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImpulseAmp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImpulseDuration)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FieldStrength)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DecreaseTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Duration)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.IncreaseTime)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button Edit;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown FieldStrength;
        private System.Windows.Forms.NumericUpDown Frequency;
        private System.Windows.Forms.NumericUpDown ImpulseStrength;
        private System.Windows.Forms.NumericUpDown ImpulseAmp;
        private System.Windows.Forms.NumericUpDown ImpulseDuration;
        private System.Windows.Forms.NumericUpDown DecreaseTime;
        private System.Windows.Forms.NumericUpDown Duration;
        private System.Windows.Forms.NumericUpDown IncreaseTime;
    }
}