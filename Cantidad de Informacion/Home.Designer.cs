namespace Cantidad_de_Informacion
{
    partial class formHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpBxInfo = new System.Windows.Forms.GroupBox();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblFilename = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.radBtnFile = new System.Windows.Forms.RadioButton();
            this.radBtnText = new System.Windows.Forms.RadioButton();
            this.toolStripCont = new System.Windows.Forms.ToolStripContainer();
            this.stStrip = new System.Windows.Forms.StatusStrip();
            this.splitContMain = new System.Windows.Forms.SplitContainer();
            this.richTxtBxSource = new System.Windows.Forms.RichTextBox();
            this.splitContResult = new System.Windows.Forms.SplitContainer();
            this.treeInfo = new System.Windows.Forms.TreeView();
            this.chartEntropy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpBxInfo.SuspendLayout();
            this.toolStripCont.BottomToolStripPanel.SuspendLayout();
            this.toolStripCont.ContentPanel.SuspendLayout();
            this.toolStripCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContMain)).BeginInit();
            this.splitContMain.Panel1.SuspendLayout();
            this.splitContMain.Panel2.SuspendLayout();
            this.splitContMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContResult)).BeginInit();
            this.splitContResult.Panel1.SuspendLayout();
            this.splitContResult.Panel2.SuspendLayout();
            this.splitContResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEntropy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1162, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CANTIDAD DE INFORMACION";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBxInfo
            // 
            this.grpBxInfo.Controls.Add(this.btnShowHide);
            this.grpBxInfo.Controls.Add(this.btnCalculate);
            this.grpBxInfo.Controls.Add(this.lblFilename);
            this.grpBxInfo.Controls.Add(this.btnFile);
            this.grpBxInfo.Controls.Add(this.radBtnFile);
            this.grpBxInfo.Controls.Add(this.radBtnText);
            this.grpBxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBxInfo.Location = new System.Drawing.Point(0, 69);
            this.grpBxInfo.Name = "grpBxInfo";
            this.grpBxInfo.Size = new System.Drawing.Size(1162, 102);
            this.grpBxInfo.TabIndex = 1;
            this.grpBxInfo.TabStop = false;
            this.grpBxInfo.Text = "Cantidad de Informacion";
            // 
            // btnShowHide
            // 
            this.btnShowHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowHide.Location = new System.Drawing.Point(991, 26);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(100, 40);
            this.btnShowHide.TabIndex = 5;
            this.btnShowHide.Text = "MOSTRAR";
            this.btnShowHide.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(778, 26);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 40);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "CALCULAR";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(439, 38);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(129, 17);
            this.lblFilename.TabIndex = 3;
            this.lblFilename.Text = "Nombre de Archivo";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(306, 28);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(100, 40);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "ARCHIVO";
            this.btnFile.UseVisualStyleBackColor = true;
            // 
            // radBtnFile
            // 
            this.radBtnFile.AutoSize = true;
            this.radBtnFile.Location = new System.Drawing.Point(126, 38);
            this.radBtnFile.Name = "radBtnFile";
            this.radBtnFile.Size = new System.Drawing.Size(76, 21);
            this.radBtnFile.TabIndex = 1;
            this.radBtnFile.TabStop = true;
            this.radBtnFile.Text = "Archivo";
            this.radBtnFile.UseVisualStyleBackColor = true;
            // 
            // radBtnText
            // 
            this.radBtnText.AutoSize = true;
            this.radBtnText.Location = new System.Drawing.Point(24, 38);
            this.radBtnText.Name = "radBtnText";
            this.radBtnText.Size = new System.Drawing.Size(64, 21);
            this.radBtnText.TabIndex = 0;
            this.radBtnText.TabStop = true;
            this.radBtnText.Text = "Texto";
            this.radBtnText.UseVisualStyleBackColor = true;
            // 
            // toolStripCont
            // 
            // 
            // toolStripCont.BottomToolStripPanel
            // 
            this.toolStripCont.BottomToolStripPanel.Controls.Add(this.stStrip);
            // 
            // toolStripCont.ContentPanel
            // 
            this.toolStripCont.ContentPanel.Controls.Add(this.splitContMain);
            this.toolStripCont.ContentPanel.Size = new System.Drawing.Size(1162, 480);
            this.toolStripCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripCont.Location = new System.Drawing.Point(0, 171);
            this.toolStripCont.Name = "toolStripCont";
            this.toolStripCont.Size = new System.Drawing.Size(1162, 502);
            this.toolStripCont.TabIndex = 2;
            this.toolStripCont.Text = "toolStripContainer1";
            // 
            // stStrip
            // 
            this.stStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.stStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stStrip.Location = new System.Drawing.Point(0, 0);
            this.stStrip.Name = "stStrip";
            this.stStrip.Size = new System.Drawing.Size(1162, 22);
            this.stStrip.TabIndex = 0;
            // 
            // splitContMain
            // 
            this.splitContMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContMain.Location = new System.Drawing.Point(0, 0);
            this.splitContMain.Name = "splitContMain";
            this.splitContMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContMain.Panel1
            // 
            this.splitContMain.Panel1.Controls.Add(this.richTxtBxSource);
            this.splitContMain.Panel1MinSize = 150;
            // 
            // splitContMain.Panel2
            // 
            this.splitContMain.Panel2.Controls.Add(this.splitContResult);
            this.splitContMain.Panel2MinSize = 250;
            this.splitContMain.Size = new System.Drawing.Size(1162, 480);
            this.splitContMain.SplitterDistance = 210;
            this.splitContMain.TabIndex = 0;
            // 
            // richTxtBxSource
            // 
            this.richTxtBxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBxSource.Location = new System.Drawing.Point(0, 0);
            this.richTxtBxSource.Name = "richTxtBxSource";
            this.richTxtBxSource.Size = new System.Drawing.Size(1162, 210);
            this.richTxtBxSource.TabIndex = 0;
            this.richTxtBxSource.Text = "";
            // 
            // splitContResult
            // 
            this.splitContResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContResult.Location = new System.Drawing.Point(0, 0);
            this.splitContResult.Name = "splitContResult";
            // 
            // splitContResult.Panel1
            // 
            this.splitContResult.Panel1.Controls.Add(this.treeInfo);
            this.splitContResult.Panel1MinSize = 450;
            // 
            // splitContResult.Panel2
            // 
            this.splitContResult.Panel2.Controls.Add(this.chartEntropy);
            this.splitContResult.Panel2MinSize = 660;
            this.splitContResult.Size = new System.Drawing.Size(1162, 266);
            this.splitContResult.SplitterDistance = 497;
            this.splitContResult.TabIndex = 0;
            // 
            // treeInfo
            // 
            this.treeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeInfo.Location = new System.Drawing.Point(0, 0);
            this.treeInfo.Name = "treeInfo";
            this.treeInfo.Size = new System.Drawing.Size(497, 266);
            this.treeInfo.TabIndex = 0;
            // 
            // chartEntropy
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEntropy.ChartAreas.Add(chartArea1);
            this.chartEntropy.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartEntropy.Legends.Add(legend1);
            this.chartEntropy.Location = new System.Drawing.Point(0, 0);
            this.chartEntropy.Name = "chartEntropy";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEntropy.Series.Add(series1);
            this.chartEntropy.Size = new System.Drawing.Size(661, 266);
            this.chartEntropy.TabIndex = 0;
            this.chartEntropy.Text = "Entropia";
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 673);
            this.Controls.Add(this.toolStripCont);
            this.Controls.Add(this.grpBxInfo);
            this.Controls.Add(this.lblTitle);
            this.MinimumSize = new System.Drawing.Size(1180, 720);
            this.Name = "formHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.grpBxInfo.ResumeLayout(false);
            this.grpBxInfo.PerformLayout();
            this.toolStripCont.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripCont.BottomToolStripPanel.PerformLayout();
            this.toolStripCont.ContentPanel.ResumeLayout(false);
            this.toolStripCont.ResumeLayout(false);
            this.toolStripCont.PerformLayout();
            this.splitContMain.Panel1.ResumeLayout(false);
            this.splitContMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContMain)).EndInit();
            this.splitContMain.ResumeLayout(false);
            this.splitContResult.Panel1.ResumeLayout(false);
            this.splitContResult.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContResult)).EndInit();
            this.splitContResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEntropy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpBxInfo;
        private System.Windows.Forms.RadioButton radBtnText;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.RadioButton radBtnFile;
        private System.Windows.Forms.ToolStripContainer toolStripCont;
        private System.Windows.Forms.StatusStrip stStrip;
        private System.Windows.Forms.SplitContainer splitContMain;
        private System.Windows.Forms.RichTextBox richTxtBxSource;
        private System.Windows.Forms.SplitContainer splitContResult;
        private System.Windows.Forms.TreeView treeInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEntropy;
    }
}

