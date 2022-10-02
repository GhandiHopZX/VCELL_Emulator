using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Internal.Utilities;
using Microsoft.ML.Runtime;

namespace VCELL_Emulator
{
    public class Differential
    {
        InputData InputData { get; set; }
        Microsoft.ML.MLContext context;
        InputOutputColumnPair InputOutputColumnPair { get; set; }
        TransformsCatalog catalog;

        public Differential(MLContext context)
        {
            this.context = context;
            // create columns and rows here

            //.catalog.
            //InputOutputColumnPair;

            context.Regression.Evaluate(InputData.Datar1.Load(InputData.Stream),
                InputOutputColumnPair.OutputColumnName, 
                InputOutputColumnPair.InputColumnName);
        }
    }
}
