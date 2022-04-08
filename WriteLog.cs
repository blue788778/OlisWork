using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class WriteLog
    {
        public static void WriteLogg(Exception ex, string wrong = "", string LogAddress = "")
        {
            //如果日誌檔案為空，則預設在Debug目錄下新建 YYYY-mm-dd_Log.log檔案
            if (LogAddress == "")
            {
                LogAddress = Environment.CurrentDirectory + '\\' +
                    DateTime.Now.Year + '-' +
                    DateTime.Now.Month + '-' +
                    DateTime.Now.Day + "_Log.log";
            }


            //把異常資訊輸出到檔案
            StreamWriter fs = new StreamWriter(LogAddress, true);
            fs.WriteLine(wrong.ToString());
            fs.WriteLine("當前時間：" + DateTime.Now.ToString());
            fs.WriteLine("異常資訊：" + ex.Message);
            fs.WriteLine("異常物件：" + ex.Source);
            fs.WriteLine("呼叫堆疊：\n" + ex.StackTrace.Trim());
            fs.WriteLine("觸發方法：" + ex.TargetSite);
            fs.WriteLine("---------------------------------------------------------------------");
            fs.WriteLine();
            fs.Close();
        }
    }
}
