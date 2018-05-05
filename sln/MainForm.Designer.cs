namespace ProbTheory
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDoExperiments = new System.Windows.Forms.Button();
            this.textBoxNumExp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLambda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelNumExperiments = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.DataGridView();
            this.buttonExperiment = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonCalcGist = new System.Windows.Forms.Button();
            this.textBoxKGist = new System.Windows.Forms.TextBox();
            this.labelKGist = new System.Windows.Forms.Label();
            this.chartF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGist = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableStat = new System.Windows.Forms.DataGridView();
            this.DF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Divf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XCh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E_XCh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D_S2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Me = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonCheckGip = new System.Windows.Forms.Button();
            this.labelAccept = new System.Windows.Forms.Label();
            this.labelFR0 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableQ = new System.Windows.Forms.DataGridView();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKHyp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelR0 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableStat)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableQ)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = " С.в. η — время обслуживания покупателя в кассе магазина; распределена показатель" +
    "но с параметром λ.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDoExperiments);
            this.panel1.Controls.Add(this.textBoxNumExp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxLambda);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(9, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 464);
            this.panel1.TabIndex = 1;
            // 
            // buttonDoExperiments
            // 
            this.buttonDoExperiments.Location = new System.Drawing.Point(24, 280);
            this.buttonDoExperiments.Name = "buttonDoExperiments";
            this.buttonDoExperiments.Size = new System.Drawing.Size(181, 31);
            this.buttonDoExperiments.TabIndex = 5;
            this.buttonDoExperiments.Text = "Провести эксперименты";
            this.buttonDoExperiments.UseVisualStyleBackColor = true;
            this.buttonDoExperiments.Click += new System.EventHandler(this.buttonDoExperiments_Click);
            // 
            // textBoxNumExp
            // 
            this.textBoxNumExp.Location = new System.Drawing.Point(59, 245);
            this.textBoxNumExp.Name = "textBoxNumExp";
            this.textBoxNumExp.Size = new System.Drawing.Size(115, 20);
            this.textBoxNumExp.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Задать количество экспериментов:";
            // 
            // textBoxLambda
            // 
            this.textBoxLambda.Location = new System.Drawing.Point(58, 168);
            this.textBoxLambda.Name = "textBoxLambda";
            this.textBoxLambda.Size = new System.Drawing.Size(116, 20);
            this.textBoxLambda.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "λ=";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 102);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(263, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(491, 464);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonReset);
            this.tabPage1.Controls.Add(this.labelNumExperiments);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.table);
            this.tabPage1.Controls.Add(this.buttonExperiment);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(483, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Моделирование";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(287, 387);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(187, 45);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Сбросить результаты";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelNumExperiments
            // 
            this.labelNumExperiments.AutoSize = true;
            this.labelNumExperiments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumExperiments.Location = new System.Drawing.Point(305, 359);
            this.labelNumExperiments.Name = "labelNumExperiments";
            this.labelNumExperiments.Size = new System.Drawing.Size(16, 17);
            this.labelNumExperiments.TabIndex = 3;
            this.labelNumExperiments.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество проведенных экспериментов: ";
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(13, 13);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(454, 333);
            this.table.TabIndex = 1;
            // 
            // buttonExperiment
            // 
            this.buttonExperiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExperiment.Location = new System.Drawing.Point(93, 387);
            this.buttonExperiment.Name = "buttonExperiment";
            this.buttonExperiment.Size = new System.Drawing.Size(187, 45);
            this.buttonExperiment.TabIndex = 0;
            this.buttonExperiment.Text = "Провести эксперимент";
            this.buttonExperiment.UseVisualStyleBackColor = true;
            this.buttonExperiment.Click += new System.EventHandler(this.buttonExperiment_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonCalcGist);
            this.tabPage2.Controls.Add(this.textBoxKGist);
            this.tabPage2.Controls.Add(this.labelKGist);
            this.tabPage2.Controls.Add(this.chartF);
            this.tabPage2.Controls.Add(this.chartGist);
            this.tabPage2.Controls.Add(this.tableStat);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(483, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статистические характеристики";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // buttonCalcGist
            // 
            this.buttonCalcGist.Location = new System.Drawing.Point(284, 397);
            this.buttonCalcGist.Name = "buttonCalcGist";
            this.buttonCalcGist.Size = new System.Drawing.Size(175, 33);
            this.buttonCalcGist.TabIndex = 12;
            this.buttonCalcGist.Text = "Пересчитать гистограмму";
            this.buttonCalcGist.UseVisualStyleBackColor = true;
            this.buttonCalcGist.Click += new System.EventHandler(this.buttonCalcGist_Click);
            // 
            // textBoxKGist
            // 
            this.textBoxKGist.Location = new System.Drawing.Point(83, 404);
            this.textBoxKGist.Name = "textBoxKGist";
            this.textBoxKGist.Size = new System.Drawing.Size(116, 20);
            this.textBoxKGist.TabIndex = 6;
            // 
            // labelKGist
            // 
            this.labelKGist.AutoSize = true;
            this.labelKGist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKGist.Location = new System.Drawing.Point(52, 404);
            this.labelKGist.Name = "labelKGist";
            this.labelKGist.Size = new System.Drawing.Size(26, 20);
            this.labelKGist.TabIndex = 5;
            this.labelKGist.Text = "k=";
            // 
            // chartF
            // 
            chartArea1.Name = "ChartArea1";
            this.chartF.ChartAreas.Add(chartArea1);
            this.chartF.Location = new System.Drawing.Point(14, 88);
            this.chartF.Name = "chartF";
            this.chartF.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series2";
            this.chartF.Series.Add(series1);
            this.chartF.Series.Add(series2);
            this.chartF.Size = new System.Drawing.Size(455, 154);
            this.chartF.TabIndex = 3;
            this.chartF.Text = "chart1";
            // 
            // chartGist
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGist.ChartAreas.Add(chartArea2);
            this.chartGist.Location = new System.Drawing.Point(18, 237);
            this.chartGist.Name = "chartGist";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.chartGist.Series.Add(series3);
            this.chartGist.Size = new System.Drawing.Size(452, 161);
            this.chartGist.TabIndex = 2;
            // 
            // tableStat
            // 
            this.tableStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableStat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DF,
            this.Divf,
            this.E,
            this.XCh,
            this.E_XCh,
            this.D,
            this.S2,
            this.D_S2,
            this.Me,
            this.R});
            this.tableStat.Location = new System.Drawing.Point(13, 15);
            this.tableStat.Name = "tableStat";
            this.tableStat.Size = new System.Drawing.Size(458, 67);
            this.tableStat.TabIndex = 1;
            // 
            // DF
            // 
            this.DF.HeaderText = "Divergence F";
            this.DF.Name = "DF";
            this.DF.ReadOnly = true;
            // 
            // Divf
            // 
            this.Divf.HeaderText = "Divergence f";
            this.Divf.Name = "Divf";
            this.Divf.ReadOnly = true;
            // 
            // E
            // 
            this.E.HeaderText = "E";
            this.E.Name = "E";
            this.E.ReadOnly = true;
            // 
            // XCh
            // 
            this.XCh.HeaderText = "x^";
            this.XCh.Name = "XCh";
            this.XCh.ReadOnly = true;
            // 
            // E_XCh
            // 
            this.E_XCh.HeaderText = "|E-x^|";
            this.E_XCh.Name = "E_XCh";
            this.E_XCh.ReadOnly = true;
            // 
            // D
            // 
            this.D.HeaderText = "D";
            this.D.Name = "D";
            this.D.ReadOnly = true;
            // 
            // S2
            // 
            this.S2.HeaderText = "S^2";
            this.S2.Name = "S2";
            this.S2.ReadOnly = true;
            // 
            // D_S2
            // 
            this.D_S2.HeaderText = "|D-S^2|";
            this.D_S2.Name = "D_S2";
            this.D_S2.ReadOnly = true;
            // 
            // Me
            // 
            this.Me.HeaderText = "Me^";
            this.Me.Name = "Me";
            this.Me.ReadOnly = true;
            // 
            // R
            // 
            this.R.HeaderText = "R^";
            this.R.Name = "R";
            this.R.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelR0);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.buttonCheckGip);
            this.tabPage3.Controls.Add(this.labelAccept);
            this.tabPage3.Controls.Add(this.labelFR0);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.tableQ);
            this.tabPage3.Controls.Add(this.textBoxAlpha);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textBoxKHyp);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(483, 438);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Проверка гипотезы о виде распределения";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // buttonCheckGip
            // 
            this.buttonCheckGip.Location = new System.Drawing.Point(281, 384);
            this.buttonCheckGip.Name = "buttonCheckGip";
            this.buttonCheckGip.Size = new System.Drawing.Size(175, 33);
            this.buttonCheckGip.TabIndex = 11;
            this.buttonCheckGip.Text = "Проверить гипотезу";
            this.buttonCheckGip.UseVisualStyleBackColor = true;
            this.buttonCheckGip.Click += new System.EventHandler(this.buttonCheckGip_Click);
            // 
            // labelAccept
            // 
            this.labelAccept.AutoSize = true;
            this.labelAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAccept.Location = new System.Drawing.Point(125, 343);
            this.labelAccept.Name = "labelAccept";
            this.labelAccept.Size = new System.Drawing.Size(0, 20);
            this.labelAccept.TabIndex = 10;
            // 
            // labelFR0
            // 
            this.labelFR0.AutoSize = true;
            this.labelFR0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFR0.Location = new System.Drawing.Point(191, 289);
            this.labelFR0.Name = "labelFR0";
            this.labelFR0.Size = new System.Drawing.Size(0, 20);
            this.labelFR0.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(125, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "F^(R0)=";
            // 
            // tableQ
            // 
            this.tableQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableQ.Location = new System.Drawing.Point(19, 143);
            this.tableQ.Name = "tableQ";
            this.tableQ.Size = new System.Drawing.Size(458, 68);
            this.tableQ.TabIndex = 7;
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(188, 71);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(116, 20);
            this.textBoxAlpha.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(125, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "alpha=";
            // 
            // textBoxKHyp
            // 
            this.textBoxKHyp.Location = new System.Drawing.Point(188, 31);
            this.textBoxKHyp.Name = "textBoxKHyp";
            this.textBoxKHyp.Size = new System.Drawing.Size(116, 20);
            this.textBoxKHyp.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(157, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "k=";
            // 
            // labelR0
            // 
            this.labelR0.AutoSize = true;
            this.labelR0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR0.Location = new System.Drawing.Point(166, 245);
            this.labelR0.Name = "labelR0";
            this.labelR0.Size = new System.Drawing.Size(0, 20);
            this.labelR0.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(125, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "R0=";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 516);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Моделирование случайных величин";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableStat)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxLambda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExperiment;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label labelNumExperiments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxNumExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDoExperiments;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView tableStat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGist;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartF;
        private System.Windows.Forms.DataGridViewTextBoxColumn DF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Divf;
        private System.Windows.Forms.DataGridViewTextBoxColumn E;
        private System.Windows.Forms.DataGridViewTextBoxColumn XCh;
        private System.Windows.Forms.DataGridViewTextBoxColumn E_XCh;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn S2;
        private System.Windows.Forms.DataGridViewTextBoxColumn D_S2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Me;
        private System.Windows.Forms.DataGridViewTextBoxColumn R;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelAccept;
        private System.Windows.Forms.Label labelFR0;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView tableQ;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKHyp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCheckGip;
        private System.Windows.Forms.TextBox textBoxKGist;
        private System.Windows.Forms.Label labelKGist;
        private System.Windows.Forms.Button buttonCalcGist;
        private System.Windows.Forms.Label labelR0;
        private System.Windows.Forms.Label label9;
    }
}