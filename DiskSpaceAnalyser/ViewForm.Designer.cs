namespace DiskSpaceAnalyser
{
    partial class ViewForm
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
            this._path = new System.Windows.Forms.TextBox();
            this._subfolderList = new System.Windows.Forms.ListBox();
            this._filesList = new System.Windows.Forms.ListBox();
            this._backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _path
            // 
            this._path.Location = new System.Drawing.Point(46, 1);
            this._path.Name = "_path";
            this._path.ReadOnly = true;
            this._path.Size = new System.Drawing.Size(701, 20);
            this._path.TabIndex = 0;
            // 
            // _subfolderList
            // 
            this._subfolderList.FormattingEnabled = true;
            this._subfolderList.Location = new System.Drawing.Point(0, 27);
            this._subfolderList.Name = "_subfolderList";
            this._subfolderList.Size = new System.Drawing.Size(330, 550);
            this._subfolderList.TabIndex = 1;
            this._subfolderList.DoubleClick += new System.EventHandler(this._subfolderList_DoubleClick);
            // 
            // _filesList
            // 
            this._filesList.FormattingEnabled = true;
            this._filesList.Location = new System.Drawing.Point(336, 27);
            this._filesList.Name = "_filesList";
            this._filesList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this._filesList.Size = new System.Drawing.Size(411, 550);
            this._filesList.TabIndex = 2;
            // 
            // _backButton
            // 
            this._backButton.Location = new System.Drawing.Point(0, 1);
            this._backButton.Name = "_backButton";
            this._backButton.Size = new System.Drawing.Size(40, 23);
            this._backButton.TabIndex = 3;
            this._backButton.Text = "..";
            this._backButton.UseVisualStyleBackColor = true;
            this._backButton.Click += new System.EventHandler(this._backButton_Click);
            // 
            // ViewForm
            // 
            this.ClientSize = new System.Drawing.Size(749, 584);
            this.Controls.Add(this._backButton);
            this.Controls.Add(this._filesList);
            this.Controls.Add(this._subfolderList);
            this.Controls.Add(this._path);
            this.Name = "ViewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _path;
        private System.Windows.Forms.ListBox _subfolderList;
        private System.Windows.Forms.ListBox _filesList;
        private System.Windows.Forms.Button _backButton;
    }
}