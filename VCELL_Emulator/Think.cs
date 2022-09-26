using System;
using Microsoft.ML;

namespace VCELL_Emulator
{
     public class Think
     {
         //stimuli
         private Double[] stimTh; // thought(s)
         LinkedIListIterator Linked;
            private Action inMind;
        public double[] StimTh { get => stimTh; set => stimTh = value; }
        public Action InMind { get => inMind; set => inMind = value; }

        public object TraverseData()
         {
             return StimTh[0];
         }
         public void E(int t) // evoke eULER
         {
            var emn = 0.0;
            var deth = 0.0;
             foreach (int o in StimTh)
             {
                Linked.Add(StimTh[o]);
                emn = (int)Math.Cos((double)StimTh[o]) ^ t;
                deth = (int)Math.Cos((double)StimTh[o]) ^ -t;
                StimTh[o] = (emn + deth / 2);
             }
         }
     }
}
