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
        List<double> listRes = new List<double>();
        Random rnd = new Random();

        const int nCol = 4;

        public MainForm()
        {
            InitializeComponent();
            textBoxLambda.Text = "1";
            for (int i = 0; i < nCol; i++)
                table.Columns.Add("column" + i.ToString(), " ");
        }

        private bool CheckLambda()
        {
            bool res = Double.TryParse(textBoxLambda.Text, out Lambda);
            if (!res || Lambda <= 0)
            {
                MessageBox.Show("Неверное значение λ");
                return false;
            }
            return true;
        }

        public double MakeExperiment()
        {
            double u = rnd.NextDouble();
            return -1.0/Lambda*Math.Log(u);
        }

        private void AddRowToTable()
        {
            table.Rows.Add();
        }

        private void ClearTable()
        {
            table.Rows.Clear();
        }

        private void FillTable()
        {
            int nRow = table.Rows.Count;
            if (listRes.Count / nCol + (listRes.Count % nCol == 0 ? 0 : 1) > nRow)
                AddRowToTable();
            for (int i = 0; i < table.Rows.Count; i++)
                for (int j = 0; j < table.Columns.Count; j++)
                    table[j, i].Value = "";
            for (int i=0; i<listRes.Count; i++)
            {
                int col = i - (i / nCol) * nCol;
                int row = (i + 1) / nCol + ((i + 1) % nCol == 0 ? 0 : 1) - 1;
                table[col, row].Value = listRes[i].ToString();
            }
        }

        private void ClearRes()
        {
            listRes.Clear();
            labelNumExperiments.Text = "0";
        }

        private void buttonExperiment_Click(object sender, EventArgs e)
        {
            if (!CheckLambda()) return;
            double res=MakeExperiment();
            listRes.Add(res);
            listRes.Sort();
            labelNumExperiments.Text = listRes.Count.ToString();
            FillTable();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ClearTable();
            ClearRes();
        }
    }
}
