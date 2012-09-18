namespace SolarCalculator
{
    partial class CostCalculation
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSysCon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSysStat = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblNumPan = new System.Windows.Forms.Label();
            this.lblPanOut = new System.Windows.Forms.Label();
            this.numNumPan = new System.Windows.Forms.NumericUpDown();
            this.numPanOut = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numNumPan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPanOut)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 250);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 39);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(279, 250);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 39);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblSysCon
            // 
            this.lblSysCon.AutoSize = true;
            this.lblSysCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSysCon.Location = new System.Drawing.Point(12, 33);
            this.lblSysCon.Name = "lblSysCon";
            this.lblSysCon.Size = new System.Drawing.Size(181, 20);
            this.lblSysCon.TabIndex = 2;
            this.lblSysCon.Text = "System Configuration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // lblSysStat
            // 
            this.lblSysStat.AutoSize = true;
            this.lblSysStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSysStat.Location = new System.Drawing.Point(220, 33);
            this.lblSysStat.Name = "lblSysStat";
            this.lblSysStat.Size = new System.Drawing.Size(148, 20);
            this.lblSysStat.TabIndex = 4;
            this.lblSysStat.Text = "System Statistics";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 123);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(86, 39);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // lblNumPan
            // 
            this.lblNumPan.AutoSize = true;
            this.lblNumPan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumPan.Location = new System.Drawing.Point(12, 63);
            this.lblNumPan.Name = "lblNumPan";
            this.lblNumPan.Size = new System.Drawing.Size(135, 20);
            this.lblNumPan.TabIndex = 8;
            this.lblNumPan.Text = "Number of Panels";
            // 
            // lblPanOut
            // 
            this.lblPanOut.AutoSize = true;
            this.lblPanOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPanOut.Location = new System.Drawing.Point(221, 63);
            this.lblPanOut.Name = "lblPanOut";
            this.lblPanOut.Size = new System.Drawing.Size(147, 20);
            this.lblPanOut.TabIndex = 9;
            this.lblPanOut.Text = "Panel Output (W/H)";
            // 
            // numNumPan
            // 
            this.numNumPan.Location = new System.Drawing.Point(16, 97);
            this.numNumPan.Name = "numNumPan";
            this.numNumPan.Size = new System.Drawing.Size(120, 20);
            this.numNumPan.TabIndex = 10;
            // 
            // numPanOut
            // 
            this.numPanOut.Location = new System.Drawing.Point(224, 97);
            this.numPanOut.Name = "numPanOut";
            this.numPanOut.Size = new System.Drawing.Size(120, 20);
            this.numPanOut.TabIndex = 11;
            // 
            // CostCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 301);
            this.Controls.Add(this.numPanOut);
            this.Controls.Add(this.numNumPan);
            this.Controls.Add(this.lblPanOut);
            this.Controls.Add(this.lblNumPan);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblSysStat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSysCon);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CostCalculation";
            this.Text = "CostCalculation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CostCalculation_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numNumPan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPanOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSysCon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSysStat;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblNumPan;
        private System.Windows.Forms.Label lblPanOut;
        private System.Windows.Forms.NumericUpDown numNumPan;
        private System.Windows.Forms.NumericUpDown numPanOut;
    }
}