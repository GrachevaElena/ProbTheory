using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProbTheory
{
    public class ModelRandom
    {
        Random rnd = new Random();
        public double Lambda;
        public List<double> listRes=new List<double>();

        public ModelRandom(double l)
        {
            Lambda = l;
        }

        public double GetValue()
        {
            double r = -1.0 / Lambda * Math.Log(rnd.NextDouble());
            listRes.Add(r);
            return r;
        }

        public void Sort()
        {
            listRes.Sort();
        }

        public double GetE()
        {
            return 1 / Lambda;
        }

        public double GetD()
        {
            return 1/(Lambda*Lambda);
        }


        public double GetXCh()
        {
            double s = 0;
            for (int i = 0; i < listRes.Count; i++)
                s += listRes[i];
            return s / listRes.Count;
        }

        public double GetS2()
        {
            double xCh = GetXCh();
            double s = 0;
            for (int i = 0; i < listRes.Count; i++)
                s += (listRes[i] - xCh) * (listRes[i] - xCh);
            return s / listRes.Count;
        }

        public double GetR()
        {
            return listRes.Max() - listRes.Min();
        }

        public double GetMe()
        {
		if (listRes.Count<=0) return 0;
            if (listRes.Count % 2 == 1)
                return listRes[listRes.Count / 2];
            return (listRes[listRes.Count / 2-1] + listRes[listRes.Count / 2]) / 2;
        }

        public double GetF(double x)
        {
            if (x < 0) return 0;
            return 1 - Math.Exp(-Lambda * x);
        }

        public double GetFCh(double x)
        {
            double s = 0;
            for (int i = 0; (i<listRes.Count)&&(listRes[i] < x); i++)
                s += 1;
            return s/listRes.Count;
        }

        public double Getf(double x)
        {
            if (x < 0) return 0;
            return Lambda*Math.Exp(-Lambda*x);
        }
    }
}
