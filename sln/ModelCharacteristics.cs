using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProbTheory
{
    public class ModelCharacteristics
    {
        ModelRandom model;

        public ModelCharacteristics(ModelRandom _model)
        {
            this.model = _model;
        }

        public int[] CalcArrNumInLineSegments(double[] arrLS)
        {
            int[] arr = new int[arrLS.Length - 1];
            double n = model.listRes.Count;
            int j = 0;
            for (int i = 0; i < arrLS.Length - 1; i++)
                while (j < n && model.listRes[j] < arrLS[i+1])
                {
                    arr[i]++;
                    j++;
                }
            return arr;
        }

        private int[] CalcArrNumInLineSegments(double a, double delta, int n)
        {
            double[] arrLS = new double[n + 1];
            arrLS[0] = a;
            for (int i=1; i<n+1; i++)
            {
                arrLS[i] = a + delta * i;
            }
            return CalcArrNumInLineSegments(arrLS);
        }

        public void GetGistArrs(out double[] x, out double[] y, int kGist)
        {
            x = new double[kGist];
            y = new double[kGist];
            double delta = (model.listRes[model.listRes.Count - 1] - 0) / (kGist-1);
            model.Sort();
            int[] arr = CalcArrNumInLineSegments(0, delta, kGist);
            for (int i = 0; i < kGist; i++)
            {
                x[i] = i * delta;
                y[i] = arr[i] / (model.listRes.Count * delta);
            }
        }

        public void GetArrF(out double[] x, out double[] y, int m)
        {
            x = new double[m];
            y = new double[m];
            double minExp = 0.001;
            double xMax = -Math.Log(minExp) / model.Lambda;
            double delta = (xMax - 0) / m;
            for (int i = 0; i < m; i++)
            {
                x[i] = i * delta;
                y[i] = model.GetF(x[i]);
            }
        }

        public void GetArrFCh(double[] x, out double[] y, int m)
        {
            y = new double[m];
            double minExp = 0.001;
            double xMax = -Math.Log(minExp) / model.Lambda;
            double delta = (xMax - 0) / m;
            for (int i = 0; i < m; i++)
            {
                y[i] = model.GetFCh(x[i]);
            }
        }

        public double CalcDivF(int m)
        {
            GetArrF(out double[] x, out double[] F, m);
            GetArrFCh(x, out double[] FCh, m);
            double max = 0;
            for (int i = 0; i < x.Length; i++)
                max = Math.Max(max, Math.Abs(F[i] - FCh[i]));
            return max;
        }

        public double CalcDivf(int m)
        {
            GetGistArrs(out double[] x, out double[] fCh, m);
            double max = 0;
            for (int i = 0; i < x.Length; i++)
                max = Math.Max(max, Math.Abs(model.Getf(x[i]) - fCh[i]));
            return max;
        }

        public double CalcR0(double[] arrZ, double[] arrQ)
        {
            int k = arrQ.Length;
            double delta = arrZ[1] - arrZ[0];
            int[] arr = CalcArrNumInLineSegments(0, delta, k);
            double R0 = 0;
            int n = model.listRes.Count;
            for (int j = 0; j < k; j++)
                R0 += (arr[j] - n * arrQ[j]) * (arr[j] - n * arrQ[j]) / (n * arrQ[j]);
            return R0;
        }

        public double[] GetArrZ(int k)
        {
            double[] arrZ = new double[k - 1];
            arrZ[k - 2] = model.listRes[model.listRes.Count - 1];
            double d = (arrZ[k - 2] - 0) / (k - 1);
            arrZ[0] = d;
            for (int i = 1; i < k - 2; i++)
            {
                arrZ[i] = arrZ[0] + d * i;
            }
            return arrZ;
        }

        public double[] GetArrQ(int k)
        {
            double[] arrZ = GetArrZ(k);
            double[] arrQ = new double[k];
            arrQ[0] = model.GetF(arrZ[0]);
            arrQ[k - 1] = 1 - model.GetF(arrZ[k - 2]);
            for (int i = 1; i < k - 1; i++)
            {
                arrQ[i] = model.GetF(arrZ[i]) - model.GetF(arrZ[i - 1]);
            }
            return arrQ;
        }

        public double CalcFChR0(int k)
        {
            double[] arrZ = GetArrZ(k);
            double[] arrQ = GetArrQ(k);
            double R0 = CalcR0(arrZ, arrQ);
            return 1-CalcIntegr(0, R0, k-1);
        }

        public string GetAcceptText(double FChR0, double alpha)
        {
            if (FChR0 < alpha) return "Гипотеза отвергается";
            else return "Гипотеза принимается";
        }
        
        private double Gamma(int arg2)
        {
            if (arg2 == 2) return 1;
            if (arg2 == 1) return Math.Sqrt(Math.PI);
            return (arg2 / 2.0 - 1) * Gamma(arg2 - 2);
        }

        private double fHi(double x, int r)
        {
            if (x <= 0) return 0;
            return Math.Pow(2, -r / 2.0) * Math.Pow(Gamma(r), -1) * Math.Pow(x, r / 2.0 - 1) * Math.Exp(-x / 2.0);
        }

        private double CalcIntegr(double a, double b, int r)
        {
            int n = 1000;
            double s = 0;
            for (int k = 1; k <= n; k++)
                s += (fHi(a + (b - a) * (k - 1) / n, r) + fHi(a + (b - a) * k / n, r)) * (b - a) / (2 * n);
            return s;
        }
    }
}
