using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskSpaceAnalyser
{
    public partial class ViewForm : Form
    {

        private FolderInfo _root;
        private FolderInfo _current;

        public ViewForm(FolderInfo target)
        {
            _root = target;

            InitializeComponent();

            MoveTo(_root);
        }

        private void MoveTo(FolderInfo target)
        {
            if (target == null)
                return;
            _current = target;
            _subfolderList.Items.Clear();
            _subfolderList.Items.AddRange(_current.Children
                .Select(c => c.ToString()).ToArray());
            _filesList.Items.Clear();
            _filesList.Items.AddRange(_current.Directory.EnumerateFiles().OrderByDescending(
                f => -f.Length
                ).Select(
                f => String.Format("{0} ({1})", f.Name, FolderInfo.SizeString(f.Length))
                ).ToArray());
            _path.Text = _current.Directory.FullName;
            _backButton.Enabled = _current.Parent != null;
        }

        private void _backButton_Click(object sender, EventArgs e)
        {
            MoveTo(_current.Parent);
        }

        private void _subfolderList_DoubleClick(object sender, EventArgs e)
        {
            if (_subfolderList.SelectedItem == null)
                return;

            MoveTo(_current.Children[_subfolderList.SelectedIndex]);
        }
    }
}
