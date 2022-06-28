using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogTool2
{
    public sealed class Class1
    {

        public Class1(
            string strData,
            string strType,
            string strLog1
           
            )
        {
            StrDate = strData;
            StrType = strType;
            StrLog1 = strLog1;
            

        }
        public string StrDate { get; }
        public string StrType { get; }
        public string StrLog1 { get; }
       


    }
}
