using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Model
{
    class ResultData
    {
        private double resultSize;
        private double spirytusSize;

        double ResultSize { get; set; }
        double SpirytusSize { get; set; }

        public ResultData() 
        { 

        }

        public ResultData(double resultSize, double spirytusSize)
        {
            ResultSize = resultSize;
            SpirytusSize = spirytusSize;
        }

    }
}
