namespace SolarCalculator
{
    partial class PowerCalculation
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.numHoursOfDaylight = new System.Windows.Forms.NumericUpDown();
            this.numMonthlyUsage = new System.Windows.Forms.NumericUpDown();
            this.numImportPrice = new System.Windows.Forms.NumericUpDown();
            this.numExportPrice = new System.Windows.Forms.NumericUpDown();
            this.numPanelOutput = new System.Windows.Forms.NumericUpDown();
            this.numPanelEfficiency = new System.Windows.Forms.NumericUpDown();
            this.numInverterEfficiency = new System.Windows.Forms.NumericUpDown();
            this.numNumberOfPanels = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numHoursOfDaylight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthlyUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numImportPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExportPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPanelOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPanelEfficiency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInverterEfficiency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfPanels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Panels";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 372);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(172, 40);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.Calculate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hours of Daylight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monthly Usage (kWh)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Panel Output (W)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Panel Efficiency (%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Inverter Efficiency (%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Power Generated";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(106, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Money Made";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Per Day:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Per Month:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Per Year:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Per Year:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Per Month:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(39, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Per Day:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Export Price (¢ / kWh)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 20);
            this.label16.TabIndex = 23;
            this.label16.Text = "Import Price (¢ / kWh)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(102, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(165, 20);
            this.label17.TabIndex = 27;
            this.label17.Text = "System Information";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(99, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(170, 20);
            this.label18.TabIndex = 28;
            this.label18.Text = "General Information";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(86, 216);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 20);
            this.label19.TabIndex = 29;
            this.label19.Text = "Other Information";
            // 
            // numHoursOfDaylight
            // 
            this.numHoursOfDaylight.Location = new System.Drawing.Point(193, 44);
            this.numHoursOfDaylight.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numHoursOfDaylight.Name = "numHoursOfDaylight";
            this.numHoursOfDaylight.Size = new System.Drawing.Size(120, 20);
            this.numHoursOfDaylight.TabIndex = 30;
            this.numHoursOfDaylight.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // numMonthlyUsage
            // 
            this.numMonthlyUsage.Location = new System.Drawing.Point(193, 70);
            this.numMonthlyUsage.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numMonthlyUsage.Name = "numMonthlyUsage";
            this.numMonthlyUsage.Size = new System.Drawing.Size(120, 20);
            this.numMonthlyUsage.TabIndex = 31;
            this.numMonthlyUsage.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numImportPrice
            // 
            this.numImportPrice.DecimalPlaces = 2;
            this.numImportPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numImportPrice.Location = new System.Drawing.Point(193, 96);
            this.numImportPrice.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numImportPrice.Name = "numImportPrice";
            this.numImportPrice.Size = new System.Drawing.Size(120, 20);
            this.numImportPrice.TabIndex = 32;
            this.numImportPrice.Value = new decimal(new int[] {
            16,
            0,
            0,
            131072});
            // 
            // numExportPrice
            // 
            this.numExportPrice.DecimalPlaces = 2;
            this.numExportPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numExportPrice.Location = new System.Drawing.Point(193, 122);
            this.numExportPrice.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numExportPrice.Name = "numExportPrice";
            this.numExportPrice.Size = new System.Drawing.Size(120, 20);
            this.numExportPrice.TabIndex = 33;
            this.numExportPrice.Value = new decimal(new int[] {
            20,
            0,
            0,
            131072});
            // 
            // numPanelOutput
            // 
            this.numPanelOutput.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPanelOutput.Location = new System.Drawing.Point(193, 211);
            this.numPanelOutput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPanelOutput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPanelOutput.Name = "numPanelOutput";
            this.numPanelOutput.Size = new System.Drawing.Size(120, 20);
            this.numPanelOutput.TabIndex = 34;
            this.numPanelOutput.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // numPanelEfficiency
            // 
            this.numPanelEfficiency.Location = new System.Drawing.Point(193, 237);
            this.numPanelEfficiency.Name = "numPanelEfficiency";
            this.numPanelEfficiency.Size = new System.Drawing.Size(120, 20);
            this.numPanelEfficiency.TabIndex = 35;
            this.numPanelEfficiency.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numInverterEfficiency
            // 
            this.numInverterEfficiency.Location = new System.Drawing.Point(193, 263);
            this.numInverterEfficiency.Name = "numInverterEfficiency";
            this.numInverterEfficiency.Size = new System.Drawing.Size(120, 20);
            this.numInverterEfficiency.TabIndex = 36;
            this.numInverterEfficiency.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            // 
            // numNumberOfPanels
            // 
            this.numNumberOfPanels.Location = new System.Drawing.Point(193, 289);
            this.numNumberOfPanels.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumberOfPanels.Name = "numNumberOfPanels";
            this.numNumberOfPanels.Size = new System.Drawing.Size(120, 20);
            this.numNumberOfPanels.TabIndex = 37;
            this.numNumberOfPanels.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(33, 244);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 20);
            this.label20.TabIndex = 40;
            this.label20.Text = "System Cost:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(9, 264);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(127, 20);
            this.label21.TabIndex = 41;
            this.label21.Text = "Breakeven Time:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SolarCalculator.Properties.Resources.Desktop_Banner;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 186);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numNumberOfPanels);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.numInverterEfficiency);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.numPanelEfficiency);
            this.panel1.Controls.Add(this.numHoursOfDaylight);
            this.panel1.Controls.Add(this.numPanelOutput);
            this.panel1.Controls.Add(this.numMonthlyUsage);
            this.panel1.Controls.Add(this.numImportPrice);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.numExportPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(190, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 206);
            this.panel1.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(190, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 147);
            this.panel2.TabIndex = 44;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 418);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 40);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Miramonte", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(12, 201);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(173, 80);
            this.label22.TabIndex = 46;
            this.label22.Text = "All values generated by the \r\nsolar power calculator are \r\nestimates only and don" +
    "\'t \r\nnecessarily indicate \r\nreal-world values.";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 326);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(172, 40);
            this.btnAbout.TabIndex = 47;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // PowerCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 470);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label22);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(300, 20);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PowerCalculation";
            this.Text = "Solar Panel Power Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PowerCalculation_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numHoursOfDaylight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthlyUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numImportPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExportPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPanelOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPanelEfficiency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInverterEfficiency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfPanels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numHoursOfDaylight;
        private System.Windows.Forms.NumericUpDown numMonthlyUsage;
        private System.Windows.Forms.NumericUpDown numImportPrice;
        private System.Windows.Forms.NumericUpDown numExportPrice;
        private System.Windows.Forms.NumericUpDown numPanelOutput;
        private System.Windows.Forms.NumericUpDown numPanelEfficiency;
        private System.Windows.Forms.NumericUpDown numInverterEfficiency;
        private System.Windows.Forms.NumericUpDown numNumberOfPanels;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnAbout;
    }
}

