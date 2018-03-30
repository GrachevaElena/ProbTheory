using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProbTheory
{
    public partial class MainForm : Form
    {
        double Lambda = 1;
        int NumExp = 0;
        Model model;

        const int nCol = 4;

        public MainForm()
        {
            InitializeComponent();
            model = new Model(1);
            textBoxLambda.Text = "1";
            for (int i = 0; i < nCol; i++)
                table.Columns.Add("column" + i.ToString(), " ");
        }

        private bool CheckLambda()
        {
            double l = Lambda;
            bool res = Double.TryParse(textBoxLambda.Text, out Lambda);
            if (!res || Lambda <= 0)
            {
                MessageBox.Show("Неверное значение λ");
                return false;
            }
            if (l != Lambda) model = new Model(Lambda);
            return true;
        }

        private bool CheckNumExperiments()
        {
            bool res = Int32.TryParse(textBoxNumExp.Text, out NumExp);
            if (!res || NumExp <= 0)
            {
                MessageBox.Show("Неверное значение числа экспериментов");
                return false;
            }
            return true;
        }

        public double MakeExperiment()
        {
            return model.GetValue();
        }

        private void AddRowToTable()
        {
            table.Rows.Add();
        }

        private void ClearTable()
        {
            table.Rows.Clear();
        }

        private void CreateTable()
        {
            table.Rows.Clear();
            int nRow = model.listRes.Count / nCol + (model.listRes.Count % nCol == 0 ? 0 : 1);
            for (int i = 1; i < nRow; i++)
                AddRowToTable();
            for (int i = 0; i < model.listRes.Count; i++)
            {
                int col = i - (i / nCol) * nCol;
                int row = (i + 1) / nCol + ((i + 1) % nCol == 0 ? 0 : 1) - 1;
                table[col, row].Value = model.listRes[i].ToString();
            }
        }

        private void AddToTable()
        {
            int nRow = table.Rows.Count;
            if (model.listRes.Count / nCol + (model.listRes.Count % nCol == 0 ? 0 : 1) > nRow)
                AddRowToTable();
            for (int i = 0; i < table.Rows.Count; i++)
                for (int j = 0; j < table.Columns.Count; j++)
                    table[j, i].Value = "";
            for (int i=0; i < model.listRes.Count; i++)
            {
                int col = i - (i / nCol) * nCol;
                int row = (i + 1) / nCol + ((i + 1) % nCol == 0 ? 0 : 1) - 1;
                table[col, row].Value = model.listRes[i].ToString();
            }
        }

        private void ClearRes()
        {
            model.listRes.Clear();
            labelNumExperiments.Text = "0";
        }

        private void buttonExperiment_Click(object sender, EventArgs e)
        {
            if (!CheckLambda()) return;
            double res=MakeExperiment();
            model.Sort();
            labelNumExperiments.Text = model.listRes.Count.ToString();
            AddToTable();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ClearTable();
            ClearRes();
        }

        private void buttonDoExperiments_Click(object sender, EventArgs e)
        {
            if (!CheckLambda()) return;
            if (!CheckNumExperiments()) return;
            model.listRes.Clear();
            for (int i=0; i<NumExp; i++)
            {
                double res = MakeExperiment();
            }
            model.Sort();

            ReloadTab1();
            ReloadTab2();
        }
        
        private void ReloadTab1()
        {
            labelNumExperiments.Text = model.listRes.Count.ToString();
            CreateTable();
        }


        private void ReloadTab2()
        {
            if (model.listRes.Count == 0) return;
            tableStat[0, 0].Value = model.GetE().ToString();
            tableStat[3, 0].Value = model.GetD().ToString();
            tableStat[7, 0].Value = model.GetR().ToString();
            tableStat[6, 0].Value = model.GetMe().ToString();
            tableStat[1, 0].Value = model.GetXCh().ToString();
            tableStat[4, 0].Value = model.GetS2().ToString();
            tableStat[5, 0].Value = Math.Abs(model.GetD() - model.GetS2()).ToString();
            tableStat[2, 0].Value = Math.Abs(model.GetE() - model.GetXCh()).ToString();

            CreateGist();
            CreateF();
        }

        void CreateGist()
        {
            int m = 100, n = model.listRes.Count;
            model.Sort();
            double delta = (model.listRes[n - 1] - model.listRes[0]) / m;
            int[] arr = new int[m];
            int j = 0;
            for (int i = 0; i < m; i++)
                while (j < n && model.listRes[j] < (i + 1) * delta)
                {
                    arr[i]++;
                    j++;
                }
            double[] y = new double[m], x = new double[m];
            for (int i = 0; i < m; i++)
            {
                x[i] = i * delta;
                y[i] = arr[i] / (n * delta);
            }
            chartGist.Series[0].Points.DataBindXY(x, y);
        }

        void CreateF()
        {
            int m = 1000;
            double minExp=0.001;
            double xMax = -Math.Log(minExp) / model.Lambda;
            double delta = (xMax - 0) / m;
            double[] yF= new double[m], yFCh=new double[m], x = new double[m];
            for (int i = 0; i < m; i++)
            {
                x[i] = i * delta;
                yF[i] = model.GetF(x[i]);
                yFCh[i] = model.GetFCh(x[i]);
            }
            chartF.ChartAreas[0].AxisY.Title = "F";
            chartF.Series[0].Points.DataBindXY(x, yF);
            chartF.Series[1].Points.DataBindXY(x, yFCh);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            ReloadTab2();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            ReloadTab1();
        }
    }
}
