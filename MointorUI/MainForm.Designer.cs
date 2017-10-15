namespace MointorUI
{
    partial class MainForm
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
            this.renderDocPathText = new System.Windows.Forms.TextBox();
            this.renderdocExeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.limitedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.autoSelectCheckBox = new System.Windows.Forms.CheckBox();
            this.pngSelectCheckBox = new System.Windows.Forms.CheckBox();
            this.depthSelectCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdcFolderBtn = new System.Windows.Forms.Button();
            this.rdcFolderPathText = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.renderExeChooseDialog = new System.Windows.Forms.OpenFileDialog();
            this.rdcFolderChooseDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.limitedNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renderdoc Exe Path:";
            // 
            // renderDocPathText
            // 
            this.renderDocPathText.Location = new System.Drawing.Point(274, 74);
            this.renderDocPathText.Name = "renderDocPathText";
            this.renderDocPathText.Size = new System.Drawing.Size(337, 25);
            this.renderDocPathText.TabIndex = 1;
            // 
            // renderdocExeBtn
            // 
            this.renderdocExeBtn.Location = new System.Drawing.Point(627, 76);
            this.renderdocExeBtn.Name = "renderdocExeBtn";
            this.renderdocExeBtn.Size = new System.Drawing.Size(71, 23);
            this.renderdocExeBtn.TabIndex = 2;
            this.renderdocExeBtn.Text = "..";
            this.renderdocExeBtn.UseVisualStyleBackColor = true;
            this.renderdocExeBtn.Click += new System.EventHandler(this.renderdocExeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max Limited Process:";
            // 
            // limitedNumericUpDown
            // 
            this.limitedNumericUpDown.Location = new System.Drawing.Point(274, 126);
            this.limitedNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.limitedNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.limitedNumericUpDown.Name = "limitedNumericUpDown";
            this.limitedNumericUpDown.Size = new System.Drawing.Size(120, 25);
            this.limitedNumericUpDown.TabIndex = 4;
            this.limitedNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // autoSelectCheckBox
            // 
            this.autoSelectCheckBox.AutoSize = true;
            this.autoSelectCheckBox.Location = new System.Drawing.Point(430, 128);
            this.autoSelectCheckBox.Name = "autoSelectCheckBox";
            this.autoSelectCheckBox.Size = new System.Drawing.Size(117, 19);
            this.autoSelectCheckBox.TabIndex = 5;
            this.autoSelectCheckBox.Text = "auto select";
            this.autoSelectCheckBox.UseVisualStyleBackColor = true;
            this.autoSelectCheckBox.CheckedChanged += new System.EventHandler(this.autoSelectCheckBox_CheckedChanged);
            // 
            // pngSelectCheckBox
            // 
            this.pngSelectCheckBox.AutoSize = true;
            this.pngSelectCheckBox.Checked = true;
            this.pngSelectCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pngSelectCheckBox.Location = new System.Drawing.Point(274, 179);
            this.pngSelectCheckBox.Name = "pngSelectCheckBox";
            this.pngSelectCheckBox.Size = new System.Drawing.Size(83, 19);
            this.pngSelectCheckBox.TabIndex = 6;
            this.pngSelectCheckBox.Text = "输出PNG";
            this.pngSelectCheckBox.UseVisualStyleBackColor = true;
            // 
            // depthSelectCheckBox
            // 
            this.depthSelectCheckBox.AutoSize = true;
            this.depthSelectCheckBox.Checked = true;
            this.depthSelectCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.depthSelectCheckBox.Location = new System.Drawing.Point(430, 179);
            this.depthSelectCheckBox.Name = "depthSelectCheckBox";
            this.depthSelectCheckBox.Size = new System.Drawing.Size(104, 19);
            this.depthSelectCheckBox.TabIndex = 7;
            this.depthSelectCheckBox.Text = "输出深度图";
            this.depthSelectCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Options:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "RDC Folder:";
            // 
            // rdcFolderBtn
            // 
            this.rdcFolderBtn.Location = new System.Drawing.Point(627, 37);
            this.rdcFolderBtn.Name = "rdcFolderBtn";
            this.rdcFolderBtn.Size = new System.Drawing.Size(71, 23);
            this.rdcFolderBtn.TabIndex = 12;
            this.rdcFolderBtn.Text = "..";
            this.rdcFolderBtn.UseVisualStyleBackColor = true;
            this.rdcFolderBtn.Click += new System.EventHandler(this.rdcFolderBtn_Click);
            // 
            // rdcFolderPathText
            // 
            this.rdcFolderPathText.Location = new System.Drawing.Point(274, 35);
            this.rdcFolderPathText.Name = "rdcFolderPathText";
            this.rdcFolderPathText.Size = new System.Drawing.Size(337, 25);
            this.rdcFolderPathText.TabIndex = 11;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(192, 230);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(355, 49);
            this.startBtn.TabIndex = 13;
            this.startBtn.Text = "Click to Run";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // renderExeChooseDialog
            // 
            this.renderExeChooseDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 313);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.rdcFolderBtn);
            this.Controls.Add(this.rdcFolderPathText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.depthSelectCheckBox);
            this.Controls.Add(this.pngSelectCheckBox);
            this.Controls.Add(this.autoSelectCheckBox);
            this.Controls.Add(this.limitedNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.renderdocExeBtn);
            this.Controls.Add(this.renderDocPathText);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Renderdoc UI Monitor Application";
            ((System.ComponentModel.ISupportInitialize)(this.limitedNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox renderDocPathText;
        private System.Windows.Forms.Button renderdocExeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown limitedNumericUpDown;
        private System.Windows.Forms.CheckBox autoSelectCheckBox;
        private System.Windows.Forms.CheckBox pngSelectCheckBox;
        private System.Windows.Forms.CheckBox depthSelectCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rdcFolderBtn;
        private System.Windows.Forms.TextBox rdcFolderPathText;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.OpenFileDialog renderExeChooseDialog;
        private System.Windows.Forms.FolderBrowserDialog rdcFolderChooseDialog;
    }
}

