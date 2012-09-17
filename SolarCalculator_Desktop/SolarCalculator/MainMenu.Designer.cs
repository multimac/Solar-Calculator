namespace SolarCalculator
{
    partial class MainMenu
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
            this.btnCost = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCost
            // 
            this.btnCost.Location = new System.Drawing.Point(104, 208);
            this.btnCost.Name = "btnCost";
            this.btnCost.Size = new System.Drawing.Size(75, 42);
            this.btnCost.TabIndex = 0;
            this.btnCost.Text = "Cost";
            this.btnCost.UseVisualStyleBackColor = true;
            this.btnCost.Click += new System.EventHandler(this.btnCost_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(12, 208);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 42);
            this.btnOutput.TabIndex = 1;
            this.btnOutput.Text = "Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 208);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnCost);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Solar Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCost;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnExit;
    }
}