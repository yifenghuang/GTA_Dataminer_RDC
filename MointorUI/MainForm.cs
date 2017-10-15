using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MointorUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void rdcFolderBtn_Click(object sender, EventArgs e)
        {
            if(rdcFolderChooseDialog.ShowDialog() == DialogResult.OK)
            {
                rdcFolderPathText.Text = rdcFolderChooseDialog.SelectedPath;
            }
        }

        private void renderdocExeBtn_Click(object sender, EventArgs e)
        {
            if(renderExeChooseDialog.ShowDialog() == DialogResult.OK)
            {
                renderDocPathText.Text = renderExeChooseDialog.FileName;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            bool pngCommand = pngSelectCheckBox.Checked;
            bool depthCommand = depthSelectCheckBox.Checked;
            int processCount = (int)limitedNumericUpDown.Value;
            if (autoSelectCheckBox.Checked)
            {
                processCount = Environment.ProcessorCount;
            }
            if (string.IsNullOrEmpty(renderDocPathText.Text)) return;
            if (string.IsNullOrEmpty(rdcFolderPathText.Text)) return;
            string argumentTemplate ="--file={0} --png={1} --depth={2}";
            //创建快捷方式文件夹,以存放不同进程需要处理的文件
            var files = Directory.GetFiles(rdcFolderPathText.Text,"*.rdc");
            processCount = Math.Min(files.Length, processCount);
            //间隔数字,每隔多少个数字建立一个文件夹存放快捷方式
            var interval = files.Length / processCount;
            string rdcFolderPath = rdcFolderPathText.Text;
            Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < processCount; i++)
                {
                    var begin = i * interval;
                    var end = Math.Min(i * interval + interval, files.Length);
                    using(StreamWriter writer = new StreamWriter(Path.Combine(rdcFolderPath, "FileList" + i.ToString())))
                    {
                        for (int j = begin; j < end; j++)
                        {
                            writer.WriteLine(files[j]);
                        }
                    }
                    //开启进程
                    var arguments = string.Format(argumentTemplate,
                        Path.Combine(rdcFolderPath, "FileList" + i.ToString()),
                        pngCommand.ToString(),
                        depthCommand.ToString());
                    StartProcess(renderDocPathText.Text, arguments);
                }

            });
        }

        private void autoSelectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (autoSelectCheckBox.Checked)
            {
                limitedNumericUpDown.Enabled = false;
            }
            else
            {
                limitedNumericUpDown.Enabled = true;
            }
        }

        public void StartProcess(string exePath, string arguments)
        {
            ProcessStartInfo info = new ProcessStartInfo(exePath, arguments);
            info.CreateNoWindow = false;
            info.UseShellExecute = false;
            info.WindowStyle = ProcessWindowStyle.Minimized;
            Process.Start(info);
        }

        private void createAppShortCut(string rootDir, string sonDir, string fileName)
        {
            Directory.CreateDirectory(Path.Combine(rootDir, sonDir));
            using (StreamWriter writer = new StreamWriter(Path.Combine(rootDir, sonDir, fileName + ".url")))
            {
                string app = Path.Combine(rootDir, fileName);
                writer.WriteLine("[InternetShortcut]");
                writer.WriteLine("URL=file:///" + app);
                writer.WriteLine("IconIndex=0");
                string icon = app.Replace('\\', '/');
                writer.WriteLine("IconFile=" + icon);
                writer.Flush();
            }
        }

    }
}
