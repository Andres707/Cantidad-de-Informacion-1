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

namespace Cantidad_de_Informacion
{
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            lblFilename.Text = "";

            splitContMain.Panel2Collapsed = true;

            btnShowHide.Enabled = false;
            btnCalculate.Enabled = false;

            radBtnText.Checked = true;
        }

        private void RadBtnText_CheckedChanged(object sender, EventArgs e)
        {
            richTxtBxSource.ReadOnly = false;
            richTxtBxSource.Text = "";

            btnFile.Enabled = false;
            lblFilename.Text = "";

            splitContMain.Panel2Collapsed = true;
        }

        private void RadBtnFile_CheckedChanged(object sender, EventArgs e)
        {
            richTxtBxSource.ReadOnly = true;
            richTxtBxSource.Text = "";

            btnFile.Enabled = true;

            splitContMain.Panel2Collapsed = true;
        }

        private void RichTxtBxSource_TextChanged(object sender, EventArgs e)
        {
            if (!richTxtBxSource.Text.Equals(""))
            {
                btnCalculate.Enabled = true;
                return;
            }

            btnCalculate.Enabled = false;
        }

        private void BtnShowHide_Click(object sender, EventArgs e)
        {
            splitContMain.Panel2Collapsed = !splitContMain.Panel2Collapsed;
            btnShowHide.Text = splitContMain.Panel2Collapsed ? "MOSTRAR" : "OCULTAR";
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog(this);

            if (openFileDialog.CheckFileExists)
            {
                lblFilename.Text = openFileDialog.FileName;

                richTxtBxSource.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {

        }
    }
}
