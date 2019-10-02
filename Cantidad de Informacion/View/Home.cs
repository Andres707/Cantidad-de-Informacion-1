using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            toolStripStLblEntropy.Text = "";
            toolStripStLblTotal.Text = "";

            splitContMain.Panel2Collapsed = true;

            btnShowHide.Enabled = false;
            btnCalculate.Enabled = false;

            radBtnText.Checked = true;

            chartEntropy.Series.Add("Informacion").Color = Color.RoyalBlue;
            chartEntropy.Series["Informacion"].ChartType = SeriesChartType.Spline;
            chartEntropy.Series["Informacion"].BorderWidth = 5;

            chartEntropy.Series.Add("Entropia").Color = Color.DarkMagenta;
            chartEntropy.Series["Entropia"].ChartType = SeriesChartType.Spline;
            chartEntropy.Series["Entropia"].BorderWidth = 3;
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
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                lblFilename.Text = openFileDialog.FileName;

                richTxtBxSource.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            var texto = richTxtBxSource.Text;
            var caracteres = Cantidad_de_Informacion.analizarTexto(texto);
            decimal entropiaTotal = 0;

            chartEntropy.Series["Informacion"].Points.Clear();
            chartEntropy.Series["Entropia"].Points.Clear();

            foreach (DictionaryEntry entry in caracteres)
            {
                var element = entry.Value as Element;

                element.probabilidad(texto.Length);
                element.informacion();
                entropiaTotal += element.entropia();

                var x = double.Parse(entry.Key.ToString());

                chartEntropy.Series["Informacion"].Points.AddXY(x, (double) element.Informacion);
                chartEntropy.Series["Entropia"].Points.AddXY(x, (double) element.Entropia);
                treeInfo.Nodes.Add(entry.Key.ToString(), element.Caracter + " - " + element.probFraccion(texto.Length));
            }
            chartEntropy.Refresh();

            toolStripStLblEntropy.Text = "Entropia: " + entropiaTotal;
            toolStripStLblTotal.Text = texto.Length + " caracteres analizados";

            btnShowHide.Enabled = true;
            splitContMain.Panel2Collapsed = false;
        }

        private void ToolStripStLblAuthor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por: Óskar Calí\n\nSeptiembre 2019", "ABOUT", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }
    }
}