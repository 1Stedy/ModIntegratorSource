using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ModIntegratorFinal
{
    class Process
    {
        Dictionary<string, List<int>> dicContinents = new Dictionary<string, List<int>>();

        //parsing continents for province ids
        public void parsingContinents(string ContinentsPath)
        {
            string[] cnames = File.ReadAllLines(@"extra\continents_names.txt");
            string[] clines = File.ReadAllLines(ContinentsPath);
            string cstring = "";
            for (int i = 0; i < clines.Length; i++)
            {
                if (clines[i].IndexOf("#") != -1)
                    clines[i].Remove(clines[i].IndexOf("#"));
                cstring += " " + clines[i];

            }
            cstring.Replace("\n", " ");
            string ch;
            foreach (string continentname in cnames)
            {

                int start = cstring.IndexOf("provinces", cstring.IndexOf(continentname));
                start = cstring.IndexOf("{", start);
                int end = cstring.IndexOf("}", start);
                string temprorary = "";
                for (int i = start + 1; i < end; i++)
                {
                    ch = cstring.Substring(i, 1);
                    int n;
                    if (int.TryParse(ch, out n))
                        temprorary += ch;
                    else
                        temprorary += " ";
                }
                string[] split = temprorary.Split(' ');
                List<int> provinces = new List<int>();
                foreach (string i in split)
                {
                    int n;
                    if (int.TryParse(i, out n))
                        provinces.Add(n);

                }
                dicContinents.Add(continentname, provinces);
            }
        }

        private void MergeFile(FileInfo sourcefile, DirectoryInfo target)
        {
            string[] lines = File.ReadAllLines(sourcefile.FullName, Encoding.GetEncoding("windows-1251"));
            StreamWriter writer = new StreamWriter(target.FullName + "\\" + sourcefile.Name, true, Encoding.GetEncoding("windows-1251"));
            foreach (var line in lines)
            {
               writer.WriteLine(line);
            }
            writer.Close();
        }


        private void BatchFiles(FileInfo sourcefile, DirectoryInfo target)
        {
            string[] lines = File.ReadAllLines(sourcefile.FullName, Encoding.GetEncoding("windows-1251"));
            StreamWriter writer = new StreamWriter(target.FullName + "\\" + sourcefile.Name, true, Encoding.GetEncoding("windows-1251"));
            if (target.Name == "decisions")
                writer.WriteLine("political_decisions = {\n");
            foreach (var continent in dicContinents.Keys)
            {
                foreach (int province in dicContinents[continent])
                {
                    foreach (string line in lines)
                    {
                        string buffer = line;
                        buffer = buffer.Replace("$continent$", continent);
                        buffer = buffer.Replace("$province$", Convert.ToString(province));
                        string id = Convert.ToString(province);
                        while (id.Length < 4)
                            id = "0" + id;
                        buffer = buffer.Replace("$id$", id);
                        writer.WriteLine(buffer);
                    }
                }
            }
            if (target.Name == "decisions")
                writer.WriteLine("\n}");
            writer.Close();
        }
        // Код стырен с http://kbyte.ru/ru/Programming/Sources.aspx?id=1132&mode=show и модифицирован
        // Метод копирования: задаем две директории откуда копировать и куда копировать
        public void Copy(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);
            // Вызываем основной метод копирования
            CopyAll(diSource, diTarget);
        }

        private void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            // Если директория для копирования файлов не существует, то создаем ее
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }
            // Для директорий common и localisation делаем отдельные условия
            if (target.Name == "common")
            {
                foreach (FileInfo fi in source.GetFiles())
                {
                    MergeFile(fi, target);
                }
            }
            if (target.Name == "localisation")
            {
                switch (Parameters.Localisation)
                {
                    case "Russian":
                        {
                            foreach (FileInfo fi in source.GetFiles("*MYC_Batch_rus.*"))
                            {
                                BatchFiles(fi, target);

                            }
                            foreach (FileInfo fi in source.GetFiles("*MYC_rus.*"))
                            {
                                fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
                            }
                            break;
                        }
                    case "English":
                        {
                            foreach (FileInfo fi in source.GetFiles("*MYC_Batch_eng.*"))
                            {
                                BatchFiles(fi, target);
                            }
                            foreach (FileInfo fi in source.GetFiles("*MYC_eng.*"))
                            {
                                fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
                            }
                            break;
                        }
                    default: break;
                }
            }
            // Преобразуем и копируем все файлы по маске в новую директорию
            foreach (FileInfo fi in source.GetFiles("*MYC_Batch.*"))
            {
                BatchFiles(fi, target);
            }
            // Копируем все файлы по маске в новую директорию
            foreach (FileInfo fi in source.GetFiles("*MYC.*"))
            {
                fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
            }
            // Копируем рекурсивно все поддиректории
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                // Создаем новую поддиректорию в директории
                DirectoryInfo nextTargetSubDir =
                  target.CreateSubdirectory(diSourceSubDir.Name);
                // Опять вызываем функцию копирования
                // Рекурсия
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        public void DeleteMod (string targetDirectory)
        {
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);
            DeleteAll(diTarget);
        }

        private void DeleteAll(DirectoryInfo target)
        {

            if (target.Name == "common")
            {
                foreach (FileInfo fi in target.GetFiles())
                {
                   CleanFile(fi);
                }
            }
            else
            {
                foreach (FileInfo fi in target.GetFiles("*MYC*"))
                {
                    fi.Delete();
                }

                foreach (DirectoryInfo diTargetSubDir in target.GetDirectories())
                {
                    DeleteAll(diTargetSubDir);
                }
            }
        }
        private void CleanFile(FileInfo targetfile)
        {
            StreamReader reader = new StreamReader(targetfile.FullName, Encoding.GetEncoding("windows-1251"));
            List<String> temp = new List<String>();
            string buffer;
            bool flag = true;
            while (!reader.EndOfStream)
            {
                buffer = reader.ReadLine();
                if (buffer.Contains("Move Your Capital Mod"))
                {
                    if (flag)
                        flag = false;
                    else
                    {
                        flag = true;
                        buffer = reader.ReadLine();
                    }
                }
                if (flag)    
                    temp.Add(buffer);
            }
            reader.Close();
            StreamWriter writer = new StreamWriter(targetfile.FullName, false, Encoding.GetEncoding("windows-1251"));
            foreach (var line in temp)
            {
                writer.WriteLine(line);
            }
            writer.Close();
        }
    }
}
