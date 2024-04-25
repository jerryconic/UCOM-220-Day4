using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ap04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuNewFile_Click(object sender, EventArgs e)
        {
            txtData.Clear();
        }

        private void mnuOpenFile_Click(object sender, EventArgs e)
        {
            if(dlgOpen.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlgOpen.FileName);
                txtData.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void mnuSaveFile_Click(object sender, EventArgs e)
        {
            if(dlgSave.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlgSave.FileName);
                sw.Write(txtData.Text);
                sw.Close();
                MessageBox.Show("存檔完畢", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuForeColor_Click(object sender, EventArgs e)
        {
            if(dlgColor.ShowDialog()==DialogResult.OK)
            {
                txtData.ForeColor = dlgColor.Color;
            }
        }

        private void mnuBackColor_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                txtData.BackColor = dlgColor.Color;
            }
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            if(dlgFont.ShowDialog() == DialogResult.OK)
            {
                txtData.Font = dlgFont.Font;
            }
        }
    }
}
