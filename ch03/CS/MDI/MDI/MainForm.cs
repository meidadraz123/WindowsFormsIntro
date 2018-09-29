using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int counter;

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var childForm = new ChildForm();
            childForm.MdiParent = this;
            counter++;
            childForm.Text = "New Document " + counter;
            childForm.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;
                childForm.DocumentTextBox.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;
                childForm.DocumentTextBox.Redo();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;
                childForm.DocumentTextBox.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;
                childForm.DocumentTextBox.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;
                childForm.DocumentTextBox.Paste();
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;
                childForm.DocumentTextBox.SelectAll();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;
                childForm.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;
                var dialog = new SaveFileDialog();
                dialog.Filter = "Rich text file|*.rtf";
                dialog.AddExtension = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    childForm.DocumentTextBox.SaveFile(dialog.FileName);
                    childForm.Text = dialog.FileName;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Rich text file|*.rtf";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var childForm = new ChildForm();
                childForm.DocumentTextBox.LoadFile(dialog.FileName);
                childForm.Text = dialog.FileName;
                childForm.MdiParent = this;
                childForm.Show();
            }
        }
    }
}
