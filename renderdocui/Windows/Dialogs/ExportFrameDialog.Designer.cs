namespace renderdocui.Windows.Dialogs
{
    partial class ExportFrameDialog
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
            this.pathBox = new System.Windows.Forms.TextBox();
            this.directoryDialogButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory Path:";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(164, 41);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(172, 25);
            this.pathBox.TabIndex = 1;
            // 
            // directoryDialogButton
            // 
            this.directoryDialogButton.BackColor = System.Drawing.SystemColors.Control;
            this.directoryDialogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.directoryDialogButton.Location = new System.Drawing.Point(342, 44);
            this.directoryDialogButton.Name = "directoryDialogButton";
            this.directoryDialogButton.Size = new System.Drawing.Size(40, 23);
            this.directoryDialogButton.TabIndex = 2;
            this.directoryDialogButton.Text = "..";
            this.directoryDialogButton.UseVisualStyleBackColor = false;
            this.directoryDialogButton.Click += new System.EventHandler(this.directoryDialogButton_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.DesktopDirectory;
            this.folderBrowserDialog.SelectedPath = "C:\\Users\\HYF\\Desktop\\testRDCout\\2rdcfilebugtest";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start Export!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExportFrameDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 180);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.directoryDialogButton);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.label1);
            this.Name = "ExportFrameDialog";
            this.Text = "ExportFrameDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button directoryDialogButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button button1;
    }
}