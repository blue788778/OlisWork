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
        public static void OliWriteLog(Exception ex, string wrong = "")
        {
            string LogAddress = "";

            // 如果日誌檔案為空，則預設在Debug目錄下新建 YYYY-mm-dd_Log.log檔案
            if (LogAddress == "")
            {
                LogAddress = Environment.CurrentDirectory + '\\' +
                    DateTime.Now.Year + '-' +
                    DateTime.Now.Month + '-' +
                    DateTime.Now.Day + "_Log.log";
            }

            string MyRead = "";
            string ErrorInfo = "";

            // 把異常資訊輸出到檔案
            ErrorInfo = wrong.ToString() + Environment.NewLine;
            ErrorInfo += "當前時間：" + DateTime.Now.ToString() + Environment.NewLine;
            ErrorInfo += "異常資訊：" + ex.Message + Environment.NewLine;
            ErrorInfo += "異常物件：" + ex.Source + Environment.NewLine;
            ErrorInfo += "呼叫堆疊：\n" + ex.StackTrace.Trim() + Environment.NewLine;
            ErrorInfo += "觸發方法：" + ex.TargetSite + Environment.NewLine;
            ErrorInfo += "--------------------------------------" + Environment.NewLine;

            using (StreamReader sr = new StreamReader(LogAddress))
            {
                MyRead = sr.ReadToEnd();
            }
            File.WriteAllText(LogAddress, ErrorInfo + MyRead);
        }
    }
}
