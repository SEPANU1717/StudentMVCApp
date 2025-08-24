using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMVCApp.View.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void studentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 studentForm = new Form1();
            studentForm.MdiParent = this;
            studentForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
    }
}
