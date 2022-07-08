using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskSpaceAnalyser
{
    public partial class SetupForm : Form
    {

        public SetupForm()
        {
            InitializeComponent();

            _driveList.Items.AddRange(DriveInfo.GetDrives().Where(d => d.IsReady).ToArray());
            _driveList.SelectedIndex = 0;
        }

        private async void _startButton_Click(object sender, EventArgs e)
        {
            DriveInfo drive = (DriveInfo) _driveList.SelectedItem;
            _scanPrograss.Maximum = int.MaxValue;
            decimal scale = int.MaxValue / (decimal) drive.TotalSize;

            _scanPrograss.Visible = true;
            _startButton.Enabled = false;
            _driveList.Enabled = false;

            FolderInfo root = await Task.Run(() => {

                root = new FolderInfo(drive.RootDirectory);

                foreach (FileInfo file in root.Load())
                {
                    IncrementProgress(Convert.ToInt32(file.Length * scale));
                    SetText(file.FullName);
                }

                return root;

            });

            Hide();

            new ViewForm(root).ShowDialog();

            Close();

            void IncrementProgress(int step)
            {
                if (_scanPrograss.InvokeRequired)
                    Invoke(new Action<int>(IncrementProgress), step);
                else
                    _scanPrograss.Increment(step);
            }

            void SetText(string text)
            {
                if (_fileName.InvokeRequired)
                    Invoke(new Action<string>(SetText), text);
                else
                {
                    _fileName.Text = text;
                }
                    
            }
        }
    }
}
