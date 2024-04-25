using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() != DialogResult.Cancel)
                txtFileName.Text = dlgSave.FileName;
            else
                txtFileName.Text = "<Cancel>";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(dlgOpen.ShowDialog() != DialogResult.Cancel)
                txtFileName.Text = dlgOpen.FileName;
            else
                txtFileName.Text = "<Cancel>";
        }
    }
}
