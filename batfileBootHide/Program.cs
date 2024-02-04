//C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe /target:winexe /out:batfileBootHide.exe *.cs
using System.Diagnostics;
using System.IO;
using System.Text;

namespace batfileBootHide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //バッチファイルのファイルパス
            string filepath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = Path.GetDirectoryName(filepath);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filepath);
            string batfile = directory + @"\" + fileNameWithoutExtension + ".bat";

            //引数
            string cmd = "";
            if (args.Length > 0)
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (var arg in args)
                {
                    //空白が含まれるかどうか
                    string space = arg.Contains(" ") ? "\"" : "";

                    //引数を結合
                    stringBuilder.Append(space);
                    stringBuilder.Append(arg);
                    stringBuilder.Append(space);
                    stringBuilder.Append(" ");
                }
                cmd = stringBuilder.ToString();
            }

            if (File.Exists(batfile))
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = batfile,
                    Arguments = cmd,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                Process.Start(psi);
            }
        }
    }
}
