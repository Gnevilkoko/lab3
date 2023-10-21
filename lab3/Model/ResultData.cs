using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Model
{
    public class ResultData
    {

        public double ResultSize { get; set; }
        public double SpirytusSize { get; set; }

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
