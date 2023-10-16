using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Model
{
    class ResultData
    {
        private int resultSize;
        private double spirytusSize;

        int ResultSize { get; set; }
        double SpirytusSize { get; set; }

        public ResultData() 
        { 

        }

        public ResultData(int resultSize, double spirytusSize)
        {
            ResultSize = resultSize;
            SpirytusSize = spirytusSize;
        }
    }
}
