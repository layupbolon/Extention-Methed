using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionSimple
{
    public static class Extention
    {
        public static string ToSBC(this string input) { throw new NotImplementedException(); }
        public static string ToDBC(this string input) { throw new NotImplementedException(); }
        public static string GetChineseSpell(this string input) { throw new NotImplementedException(); }

        public static bool IsInt(this string input) { throw new NotImplementedException(); }
        public static bool IsDateTime(this string input) { throw new NotImplementedException(); }
        public static bool IsEmpty(this string input) { throw new NotImplementedException(); }
        public static bool IsNull(this string input) { throw new NotImplementedException(); }
        public static bool IsIP(this string input) { throw new NotImplementedException(); }
        public static bool IsNotNullAndEmpty(this string input) { throw new NotImplementedException(); }
        public static bool IsUrl(this string input) { throw new NotImplementedException(); }
        public static bool IsFilePath(this string input) { throw new NotImplementedException(); }

        public static int ToInt(this string input) { throw new NotImplementedException(); }
        public static DateTime ToDateTime(this string input) { throw new NotImplementedException(); }
        public static bool IsMatch(this string input) { throw new NotImplementedException(); }
        public static string Match(this string input) { throw new NotImplementedException(); }
        public static string Replace(this string input) { throw new NotImplementedException(); }

        public static void Print(this string input)
        {
            Console.WriteLine(input);
        }

        #region 文件目录操作

        public static void CreateDirectory(this string path)
        {
            System.IO.Directory.CreateDirectory(path);
        }

        public static void WriteText(this string path, string contents)
        {
            File.WriteAllText(path, contents);
        }

        public static void DeleteFile(this string path)
        {
            if (File.Exists(path)) File.Delete(path);
        }

        #endregion

        #region 打开文件或网址

        public static void Open(this string s)
        {
            Process.Start(s);
        }

        #endregion

        #region 执行DOS命令

        public static string ExecuteDOS(this string cmd)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.StandardInput.WriteLine(cmd);
            process.StandardInput.WriteLine("exit");
            return process.StandardOutput.ReadToEnd();
        }

        #endregion

        //执行SQL
        public static object ExecuteScalar(this string sql, DbConnection conn) { throw new NotImplementedException(); }
    }
}
