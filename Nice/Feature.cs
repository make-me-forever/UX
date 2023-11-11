
using System.Globalization;
using System;

namespace Nice
{
    class Feature
    {

        /***************************************************************/
        // 全局变量区

        File g_f = new File();
        /***************************************************************/

        /*
         * log自动清理功能
         * 
         */
        public bool InitLog(int days)
        {
            if(!g_f.IsSupportLog()) { // close log func
                return false;
            }
            g_f.g_logPath = g_f.g_currentPath + g_f.g_libCoreStr + @"\log\note.log";
            if (!System.IO.File.Exists(g_f.g_logPath)) {
                return false;
            }

            String format = " yyyy-MM-dd";
            DateTime date = DateTime.Now;
            // 获取日志初时间 lastTime
            string lastTime = g_f.CutTime(g_f.getLine(g_f.g_logPath, 1));
            if (g_f.getLine(g_f.g_logPath, 1).Length < 10 && lastTime != null) {
                if(g_f.getLine(g_f.g_logPath, 1) != "") {
                    g_f.Replace(g_f.g_logPath, g_f.g_logPath, System.IO.File.ReadAllText(g_f.g_logPath), "");
                    g_f.Log(g_f.g_logPath, "日志已自动清理");
                }
                return false;
            }
            // 获取日志末时间 currTime
            string currTime = date.ToString(format, DateTimeFormatInfo.InvariantInfo);
            //System.Windows.Forms.MessageBox.Show("1:" + g_f.getMaxLine(@"E:\Code\windows\Game\Nice\bin\Debug\Libcore\log\error.log"));
            int total = g_f.DaysDifference(lastTime, currTime); // 获取日志最大时间差
            if (total >= days) {
                bool isInit = g_f.Replace(g_f.g_logPath, g_f.g_logPath, System.IO.File.ReadAllText(g_f.g_logPath), "");
                g_f.Log(g_f.g_logPath, "日志已自动清理");
                if (isInit) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }

        /*
         * 判断是否是我
         */
        public bool IsMe()
        {
            string me = System.Environment.GetEnvironmentVariable("ComputerName");
            if(me == g_f.g_myPCName) {
                return true;
            } else {
                return false;
            }
        }
    }
}
