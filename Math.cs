using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar_System
{
    class Math
    {
        public static List<double> par = new List<double>();
        public static List<int> duration = new List<int>();
        public static int h = 0, m = 0, s = 0;


        public static void Start()
        {
            par.Add(120); par.Add(5); par.Add(5); par.Add(1); //RS RE RM K
            duration.Add(120); duration.Add(5); duration.Add(5);  //RS=0 RE=1 RM=2
            duration.Add(30); //TE=TES=3
            duration.Add(10); duration.Add(15); //TM=4 TMS=5
        }
        public static void Timing()
        {
            duration[0] = Int32.Parse(par[0].ToString());
            duration[1] = Int32.Parse(par[1].ToString());
            duration[2] = Int32.Parse(par[2].ToString());
            double c = 0;
            for(int i = 3; i < duration.Count; i++)
            {
                c = duration[i]/ par[3];
                if (c < 1) c = 1;
                duration[i] = Convert.ToInt32(c);
            }
        }

        public static void TimeMath(int c)
        {
            int n = 0;
            s = c % 60;
            n = c / 60;
            if (n >= 60)
            {
                m = n % 60;
                h = n / 60;
            }
            else
            {
                m = n;
                h = 0;
            }
        }
    }
}
