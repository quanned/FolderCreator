using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            string defaultFolderName = "NewFolder";
            string folderName = Console.ReadLine();
            if (folderName == "" || folderName == null)
                folderName = defaultFolderName;
            
            string curDate = GetFormatDate();
            string path = GetFullPath();

            CreateDirectory(path, folderName, curDate);
        }

        private static string GetFormatDate()
        {
            DateTime date = DateTime.Now;
            return date.ToString("MM-dd-yyyy-hh-mm-ss");
        }

        private static string GetFullPath()
        {
            string path = Environment.CurrentDirectory;
            return path;
        }

        private static void CreateDirectory(string _path, string _folderName, string _date)
        {
            Directory.CreateDirectory(_path + @"\" + _folderName + "-" + _date);
        }
    }
}
