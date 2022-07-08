namespace DiskSpaceAnalyser
{
    partial class SetupForm
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
            this._driveList = new System.Windows.Forms.ComboBox();
            this._startButton = new System.Windows.Forms.Button();
            this._scanPrograss = new System.Windows.Forms.ProgressBar();
            this._fileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _driveList
            // 
            this._driveList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._driveList.FormattingEnabled = true;
            this._driveList.Location = new System.Drawing.Point(12, 12);
            this._driveList.Name = "_driveList";
            this._driveList.Size = new System.Drawing.Size(71, 21);
            this._driveList.TabIndex = 0;
            // 
            // _startButton
            // 
            this._startButton.Location = new System.Drawing.Point(89, 12);
            this._startButton.Name = "_startButton";
            this._startButton.Size = new System.Drawing.Size(93, 23);
            this._startButton.TabIndex = 2;
            this._startButton.Text = "Start Analysis";
            this._startButton.UseVisualStyleBackColor = true;
            this._startButton.Click += new System.EventHandler(this._startButton_Click);
            // 
            // _scanPrograss
            // 
            this._scanPrograss.Location = new System.Drawing.Point(188, 12);
            this._scanPrograss.Name = "_scanPrograss";
            this._scanPrograss.Size = new System.Drawing.Size(1100, 23);
            this._scanPrograss.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this._scanPrograss.TabIndex = 3;
            // 
            // _fileName
            // 
            this._fileName.AutoSize = true;
            this._fileName.Location = new System.Drawing.Point(12, 36);
            this._fileName.Name = "_fileName";
            this._fileName.Size = new System.Drawing.Size(0, 13);
            this._fileName.TabIndex = 4;
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 54);
            this.Controls.Add(this._fileName);
            this.Controls.Add(this._scanPrograss);
            this.Controls.Add(this._startButton);
            this.Controls.Add(this._driveList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SetupForm";
            this.Text = "Setup Disk Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _driveList;
        private System.Windows.Forms.Button _startButton;
        private System.Windows.Forms.ProgressBar _scanPrograss;
        private System.Windows.Forms.Label _fileName;
    }
}

