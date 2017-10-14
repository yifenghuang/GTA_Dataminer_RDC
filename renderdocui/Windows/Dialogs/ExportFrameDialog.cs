using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace renderdocui.Windows.Dialogs
{
    public partial class ExportFrameDialog : Form
    {
        public string folderPath = "";
        public ExportFrameDialog()
        {
            InitializeComponent();
        }

        private void directoryDialogButton_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = folderBrowserDialog.SelectedPath;
                folderPath = pathBox.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(folderPath))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
