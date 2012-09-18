namespace SolarCalculator
{
    partial class GUI
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
            this.numDaytimeUsage = new System.Windows.Forms.NumericUpDown();
            this.numImportPrice = new System.Windows.Forms.NumericUpDown();
            this.numExportPrice = new System.Windows.Forms.NumericUpDown();
            this.numPanelOutput = new System.Windows.Forms.NumericUpDown();
            this.numPanelEfficiency = new System.Windows.Forms.NumericUpDown();
            this.numInverterEfficiency = new System.Windows.Forms.NumericUpDown();
            this.numNumberOfPanels = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numHoursOfDaylight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaytimeUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numImportPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExportPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPanelOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPanelEfficiency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInverterEfficiency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfPanels)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Panels";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(394, 172);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 40);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.Calculate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hours of Daylight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Daytime Usage (KWh)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Panel Output (W/h)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Panel Efficiency (%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Inverter Efficiency (%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Power Generated (KWh)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(573, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Money Saved/Made ($)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Power Generated Per Day:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Power Generated Per Month:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Power Generated Per Year:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(454, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Money Saved Per Year:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(454, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Money Saved Per Month:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(454, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Money Saved Per Day:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Export Price (¢ / KWh)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 20);
            this.label16.TabIndex = 23;
            this.label16.Text = "Import Price (¢ / KWh)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(368, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(165, 20);
            this.label17.TabIndex = 27;
            this.label17.Text = "System Information";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(65, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(170, 20);
            this.label18.TabIndex = 28;
            this.label18.Text = "General Information";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(675, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 20);
            this.label19.TabIndex = 29;
            this.label19.Text = "Other Information";
            // 
            // numHoursOfDaylight
            // 
            this.numHoursOfDaylight.Location = new System.Drawing.Point(184, 40);
            this.numHoursOfDaylight.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numHoursOfDaylight.Name = "numHoursOfDaylight";
            this.numHoursOfDaylight.Size = new System.Drawing.Size(120, 20);
            this.numHoursOfDaylight.TabIndex = 30;
            // 
            // numDaytimeUsage
            // 
            this.numDaytimeUsage.Location = new System.Drawing.Point(184, 70);
            this.numDaytimeUsage.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numDaytimeUsage.Name = "numDaytimeUsage";
            this.numDaytimeUsage.Size = new System.Drawing.Size(120, 20);
            this.numDaytimeUsage.TabIndex = 31;
            // 
            // numImportPrice
            // 
            this.numImportPrice.Location = new System.Drawing.Point(184, 100);
            this.numImportPrice.Name = "numImportPrice";
            this.numImportPrice.Size = new System.Drawing.Size(120, 20);
            this.numImportPrice.TabIndex = 32;
            // 
            // numExportPrice
            // 
            this.numExportPrice.Location = new System.Drawing.Point(184, 130);
            this.numExportPrice.Name = "numExportPrice";
            this.numExportPrice.Size = new System.Drawing.Size(120, 20);
            this.numExportPrice.TabIndex = 33;
            // 
            // numPanelOutput
            // 
            this.numPanelOutput.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numPanelOutput.Location = new System.Drawing.Point(487, 40);
            this.numPanelOutput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPanelOutput.Name = "numPanelOutput";
            this.numPanelOutput.Size = new System.Drawing.Size(120, 20);
            this.numPanelOutput.TabIndex = 34;
            // 
            // numPanelEfficiency
            // 
            this.numPanelEfficiency.Location = new System.Drawing.Point(487, 70);
            this.numPanelEfficiency.Name = "numPanelEfficiency";
            this.numPanelEfficiency.Size = new System.Drawing.Size(120, 20);
            this.numPanelEfficiency.TabIndex = 35;
            // 
            // numInverterEfficiency
            // 
            this.numInverterEfficiency.Location = new System.Drawing.Point(487, 100);
            this.numInverterEfficiency.Name = "numInverterEfficiency";
            this.numInverterEfficiency.Size = new System.Drawing.Size(120, 20);
            this.numInverterEfficiency.TabIndex = 36;
            // 
            // numNumberOfPanels
            // 
            this.numNumberOfPanels.Location = new System.Drawing.Point(487, 130);
            this.numNumberOfPanels.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numNumberOfPanels.Name = "numNumberOfPanels";
            this.numNumberOfPanels.Size = new System.Drawing.Size(120, 20);
            this.numNumberOfPanels.TabIndex = 37;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 318);
            this.Controls.Add(this.numNumberOfPanels);
            this.Controls.Add(this.numInverterEfficiency);
            this.Controls.Add(this.numPanelEfficiency);
            this.Controls.Add(this.numPanelOutput);
            this.Controls.Add(this.numExportPrice);
            this.Controls.Add(this.numImportPrice);
            this.Controls.Add(this.numDaytimeUsage);
            this.Controls.Add(this.numHoursOfDaylight);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(300, 20);
            this.Name = "GUI";
            this.Text = "Solar Calculator";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHoursOfDaylight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaytimeUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numImportPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExportPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPanelOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPanelEfficiency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInverterEfficiency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfPanels)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numDaytimeUsage;
        private System.Windows.Forms.NumericUpDown numImportPrice;
        private System.Windows.Forms.NumericUpDown numExportPrice;
        private System.Windows.Forms.NumericUpDown numPanelOutput;
        private System.Windows.Forms.NumericUpDown numPanelEfficiency;
        private System.Windows.Forms.NumericUpDown numInverterEfficiency;
        private System.Windows.Forms.NumericUpDown numNumberOfPanels;
    }
}

