using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProbTheory
{
    public class Model
    {
        Random rnd = new Random();
        double Lambda;
        public List<double> listRes=new List<double>();

        public Model(double l)
        {
            Lambda = l;
        }

        public double GetValue()
        {
            double r = -1.0 / Lambda * Math.Log(rnd.NextDouble());
            listRes.Add(r);
            return r;
        }

        public double GetE()
        {
            return 1 / Lambda;
        }

        public double GetD()
        {
            return 0;
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
            if (listRes.Count % 2 == 1)
                return listRes[listRes.Count / 2 + 1];
            return (listRes[listRes.Count / 2] + listRes[listRes.Count / 2 + 1]) / 2;
        }
    }
}
