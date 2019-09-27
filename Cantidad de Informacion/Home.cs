﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            splitContMain.Panel2Collapsed = true;

            btnShowHide.Enabled = false;
            btnCalculate.Enabled = false;

            radBtnText.Checked = true;

            chartEntropy.Series.Add("Informacion").Color = Color.RoyalBlue;
            chartEntropy.Series["Informacion"].ChartType = SeriesChartType.Spline;

            chartEntropy.Series.Add("Entropia").Color = Color.DarkMagenta;
            chartEntropy.Series["Entropia"].ChartType = SeriesChartType.Spline;
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
            if( openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                lblFilename.Text = openFileDialog.FileName;

                richTxtBxSource.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            var texto = richTxtBxSource.Text;
            Hashtable caracteres = Cantidad_de_Informacion.analizarTexto(texto);
            decimal entropiaTotal = 0;

            foreach (DictionaryEntry entry in caracteres)
            {
                var element = entry.Value as Element;

                element.probabilidad(texto.Length);
                element.informacion();
                entropiaTotal += element.entropia();

                double x = Double.Parse(entry.Key.ToString());

                chartEntropy.Series["Informacion"].Points.AddXY(x, (double) element.Informacion);
                chartEntropy.Series["Entropia"].Points.AddXY(x, (double) element.Entropia);
                treeInfo.Nodes.Add(entry.Key.ToString(), element.Caracter + " - " + element.probFraccion(texto.Length));
            }

            toolStripStLblEntropy.Text = "Entropia: " + entropiaTotal.ToString();
            toolStripStLblTotal.Text = texto.Length.ToString() + " caracteres analizados";

            btnShowHide.Enabled = true;
            splitContMain.Panel2Collapsed = false;
        }
    }
}
