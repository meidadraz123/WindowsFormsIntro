using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDICS
{
    public partial class DocForm : Form
    {
        public DocForm()
        {
            InitializeComponent();
        }

        private static int counter;

        public static DocForm CreateForm()
        {
            var form = new DocForm();
            counter++;
            form.Text = "New Document " + counter;
            SdiApplication.Instance.ApplicationContext.MainForm = form;
            form.Show();

            return form;
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DocumentTextBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DocumentTextBox.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DocumentTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DocumentTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DocumentTextBox.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DocumentTextBox.SelectAll();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Rich text file|*.rtf";
            dialog.AddExtension = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.DocumentTextBox.SaveFile(dialog.FileName);
                this.Text = dialog.FileName;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Rich text file|*.rtf";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.DocumentTextBox.LoadFile(dialog.FileName);
                this.Text = dialog.FileName;
            }
        }

        private void windowToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (windowToolStripMenuItem.DropDownItems.Count > 0)
            {
                windowToolStripMenuItem.DropDown.Dispose();
            }

            windowToolStripMenuItem.DropDown = new ToolStripDropDown();
            foreach (Form openForm in Application.OpenForms)
            {
                var childItem = new ToolStripMenuItem();
                childItem.Text = openForm.Text;
                childItem.Tag = openForm;
                windowToolStripMenuItem.DropDownItems.Add(childItem);
                childItem.Click += WindowMenuItemClick;
            }
        }

        private void WindowMenuItemClick(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            var form = (Form)menuItem.Tag;
            form.Activate();
        }
    }
}
