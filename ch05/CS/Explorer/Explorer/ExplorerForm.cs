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

namespace Explorer
{
    public partial class ExplorerForm : Form
    {
        public ExplorerForm()
        {
            InitializeComponent();
        }

        private void ExplorerForm_Load(object sender, EventArgs e)
        {
            viewToolStripComboBox.SelectedIndex = 0;

            listView1.Columns.Add("Name", 250);
            listView1.Columns.Add("Last Modified", 150);
            listView1.Columns.Add("Size", 75, HorizontalAlignment.Right);

            var docs = new TreeNode(@"C:\users\Raz Family");
            docs.Tag = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            treeView1.Nodes.Add(docs);

            GetFolders(docs);
            docs.Expand();
        }

        private void GetFolders(TreeNode node)
        {
            var dir = new DirectoryInfo(node.Tag.ToString());
            try
            {
                foreach (var childDir in dir.GetDirectories())
                {
                    if (childDir.Attributes.HasFlag(FileAttributes.Hidden))
                    {
                        continue;
                    }
                    var childNode = new TreeNode(childDir.Name);
                    childNode.Tag = childDir.FullName;
                    node.Nodes.Add(childNode);

                    GetFolders(childNode);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var dir = new DirectoryInfo(e.Node.Tag.ToString());

            listView1.Items.Clear();
            smallImageList.Images.RemoveByKey(".exe");
            largeImageList.Images.RemoveByKey(".exe");
            foreach (var thisFile in dir.GetFiles())
            {
                var item = new ListViewItem(thisFile.Name);
                var lastWrite = thisFile.LastWriteTime.ToShortDateString() + " " + thisFile.LastWriteTime.ToShortTimeString();
                item.SubItems.Add(lastWrite);
                item.SubItems.Add(Math.Ceiling(thisFile.Length / 1024.0) + " KB");

                if (! largeImageList.Images.ContainsKey(thisFile.Extension))
                {
                    var thisIcon = Icon.ExtractAssociatedIcon(thisFile.FullName);
                    smallImageList.Images.Add(thisFile.Extension, thisIcon);
                    largeImageList.Images.Add(thisFile.Extension, thisIcon);
                }
                item.ImageKey = thisFile.Extension;
                listView1.Items.Add(item);
            }
        }

        private void viewToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (viewToolStripComboBox.Text)
            {
                case "Large Icons":
                    listView1.View = View.LargeIcon;
                    break;
                case "Small Icons":
                    listView1.View = View.SmallIcon;
                    break;
                case "Details":
                    listView1.View = View.Details;
                    break;
                default:
                    break;
            }
        }
    }
}
