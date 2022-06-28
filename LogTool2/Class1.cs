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
            string strLog
            )
        {
            StrDate = strData;
            StrType = strType;
            StrLog = strLog;
        }
        public string StrDate { get; }
        public string StrType { get; }
        public string StrLog { get; }

    }
}
