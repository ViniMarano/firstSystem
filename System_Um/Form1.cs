using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Um
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnLinks.Visible = false;
            pnTasks.Visible = false;
            pnAbout.Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            pnPanel.Visible = true;
            pnLinks.Visible = false;
            pnTasks.Visible = false;
            pnAbout.Visible = false;
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            pnTasks.Visible = true;
            pnPanel.Visible = false;
            pnLinks.Visible = false;
            pnAbout.Visible = false;
        }

        private void btnLinks_Click(object sender, EventArgs e)
        {
            pnLinks.Visible = true;
            pnPanel.Visible = false;
            pnTasks.Visible = false;
            pnAbout.Visible = false;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            pnAbout.Visible = true;
            pnPanel.Visible = false;
            pnLinks.Visible = false;
            pnTasks.Visible = false;
        }
    }
}
