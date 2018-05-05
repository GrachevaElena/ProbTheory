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
        ModelRandom model;
        ModelCharacteristics modelChar;
        int KHyp = 100;
        int KGist = 100;
        double Alpha = 0.05;

        const int nCol = 4;

        public MainForm()
        {
            InitializeComponent();
            model = new ModelRandom(Lambda);
            modelChar = new ModelCharacteristics(model);
            textBoxLambda.Text = Lambda.ToString();
            for (int i = 0; i < nCol; i++)
                table.Columns.Add("column" + i.ToString(), " ");
            textBoxKHyp.Text = KHyp.ToString();
            textBoxKGist.Text = KGist.ToString();
            textBoxAlpha.Text = Alpha.ToString();
        }

        private bool CheckAll()
        {
            return CheckKGist() && CheckKHyp() && CheckLambda() && CheckNumExperiments() && CheckAlpha();
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
            if (l != Lambda)
                model = new ModelRandom(Lambda);
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

        private bool CheckKHyp()
        {
            bool res = Int32.TryParse(textBoxKHyp.Text, out KHyp);
            if (!res || KHyp <= 0)
            {
                MessageBox.Show("Неверное значение числа отрезков");
                return false;
            }
            return true;
        }

        private bool CheckKGist()
        {
            bool res = Int32.TryParse(textBoxKGist.Text, out KGist);
            if (!res || KGist <= 0)
            {
                MessageBox.Show("Неверное значение числа отрезков");
                return false;
            }
            return true;
        }

        private bool CheckAlpha()
        {
            bool res = Double.TryParse(textBoxAlpha.Text, out Alpha);
            if (!res || Alpha < 0 || Alpha > 1)
            {
                MessageBox.Show("Неверное значение уровня значимости");
                return false;
            }
            return true;
        }

        public double MakeExperiment()
        {
            return model.GetValue();
        }


        private void CreateTable()
        {
            table.Rows.Clear();
            int nRow = model.listRes.Count / nCol + (model.listRes.Count % nCol == 0 ? 0 : 1);
            for (int i = 1; i < nRow; i++)
                table.Rows.Add();
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
                table.Rows.Add();
            for (int i = 0; i < table.Rows.Count; i++)
                for (int j = 0; j < table.Columns.Count; j++)
                    table[j, i].Value = "";
            for (int i = 0; i < model.listRes.Count; i++)
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
            if (!CheckAll()) return;
            double res = MakeExperiment();
            model.Sort();
            labelNumExperiments.Text = model.listRes.Count.ToString();
            AddToTable();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            ClearRes();
        }

        private void buttonDoExperiments_Click(object sender, EventArgs e)
        {
            if (!CheckAll()) return;
            model.listRes.Clear();
            for (int i = 0; i < NumExp; i++)
            {
                double res = MakeExperiment();
            }
            model.Sort();

            ReloadTab1();
            ReloadTab2();
            ReloadTab3();
        }

        private void ReloadTab1()
        {
            if (!CheckAll()) return;
            labelNumExperiments.Text = model.listRes.Count.ToString();
            CreateTable();
        }


        private void ReloadTab2()
        {
            if (!CheckAll()) return;

            double divf = CreateGist();
            double divF = CreateF();

            if (model.listRes.Count == 0) return;
            tableStat[0, 0].Value = divF;
            tableStat[1, 0].Value = divf;
            tableStat[2, 0].Value = model.GetE().ToString();
            tableStat[3, 0].Value = model.GetXCh().ToString();
            tableStat[4, 0].Value = Math.Abs(model.GetE() - model.GetXCh()).ToString();
            tableStat[5, 0].Value = model.GetD().ToString();
            tableStat[6, 0].Value = model.GetS2().ToString();
            tableStat[7, 0].Value = Math.Abs(model.GetD() - model.GetS2()).ToString();
            tableStat[8, 0].Value = model.GetMe().ToString();
            tableStat[9, 0].Value = model.GetR().ToString();
        }
        private void ReloadTab3()
        {
            if (!CheckAll()) return;
            model.Sort();
            ShowTableQ(modelChar.GetArrZ(KHyp), modelChar.GetArrQ(KHyp));
            labelR0.Text = modelChar.CalcR0(modelChar.GetArrZ(KHyp), modelChar.GetArrQ(KHyp)).ToString();
            labelFR0.Text = modelChar.CalcFChR0(KHyp).ToString();
            labelAccept.Text = modelChar.GetAcceptText(modelChar.CalcFChR0(KHyp), Alpha);
        }

        double CreateGist()
        {
            modelChar.GetGistArrs(out double[] x, out double[] y, KGist);
            chartGist.Series[0].Points.DataBindXY(x, y);
            chartGist.ChartAreas[0].AxisX.LabelStyle.Format = "0.####";
            return modelChar.CalcDivf(KGist);
        }

        double CreateF()
        {
            int m = 10000;
            modelChar.GetArrF(out double[] x, out double[] yF, m);
            modelChar.GetArrFCh(x, out double[] yFCh, m);
            chartF.ChartAreas[0].AxisY.Title = "F";
            chartF.Series[0].Points.DataBindXY(x, yF);
            chartF.Series[1].Points.DataBindXY(x, yFCh);
            return modelChar.CalcDivF(m);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            ReloadTab1();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            ReloadTab2();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            ReloadTab3();
        }

        private void buttonCheckGip_Click(object sender, EventArgs e)
        {
            ReloadTab3();        
        }

        void ClearTableQ()
        {
            tableQ.Rows.Clear();
            tableQ.Columns.Clear();
        }
        private void ShowTableQ(double[] arrZ, double[] arrQ)
        {
            ClearTableQ();
            string f = "0.####";
            tableQ.Columns.Add("colName", "П");
            tableQ.Columns.Add("col0", "(-inf;" + arrZ[0].ToString(f) + ")");
            for (int i = 1; i < KHyp - 1; i++)
            {
                tableQ.Columns.Add("col" + i.ToString(), "[" + arrZ[i - 1].ToString(f) + ";" + arrZ[i].ToString(f) + "]");
                tableQ.Columns[i].FillWeight = 1;
            }
            tableQ.Columns.Add("col" + (KHyp - 1).ToString(), "[" + arrZ[KHyp - 2].ToString(f) + "; +inf)");
            tableQ[0, 0].Value = "q";
            for (int i = 1; i < KHyp + 1; i++)
                tableQ[i, 0].Value = arrQ[i - 1];
        }

        private void buttonCalcGist_Click(object sender, EventArgs e)
        {
            if (!CheckKGist()) return;
            ReloadTab2();
        }
    }
}
