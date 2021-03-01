using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;

namespace FolderCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;//lol
            string defaultFolderName = "NewFolder";
            Console.Write("Set folder name: ");
            string folderName = Console.ReadLine();
            if (folderName == "" || folderName == null)
               folderName = defaultFolderName;
           
            string curDate = GetFormatDate();
            string path = GetCurrentPath();

            string fullPath = CreateFullPath(path, folderName, curDate);

            CreateDirectory(fullPath);

            OpenFolder(fullPath);

            Console.ReadKey();
        }

        public static string GetFormatDate()
        {
            return DateTime.Now.ToString("MM-dd-yyyy-hh-mm-ss");
        }

        public static string GetCurrentPath()
        {
            return Environment.CurrentDirectory;
        }

        static string CreateFullPath(string _path, string _folderName, string _date)
        {
            string fullPath = _path + @"\" + _folderName + "-" + _date;
            return fullPath;
        }

        public static void CreateDirectory(string _fullPath)
        {
            Directory.CreateDirectory(_fullPath);
            Console.Write("Folder created. \nPath = " + _fullPath);
        }

        public static void OpenFolder(string _path)
        {
            Process.Start(@_path);
        }
    }
}
