using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteAllRvtGarbageFiles
{
    class Program
    {
        static void FindFiles(string folderPath, out List<FileInfo> files)
        {
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            files = new List<FileInfo>();
            int x;

            foreach (FileInfo item in directory.GetFiles())
            {
                string end = item.Name.Substring(item.Name.Length - 8, 4);

                if (int.TryParse(end, out x) && item.Extension == ".rvt")
                {
                    files.Add(item);
                }
            }                
        }

        static void DeleteFiles(List<FileInfo> files)
        {
            if (files.Count == 0)
            {
                Console.WriteLine("There are not garbage files!");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            foreach (FileInfo item in files)
            {
                Console.WriteLine(item.FullName);
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine(new string('-', 60));
            Console.WriteLine("Do you really want to delete this files ['Y': Yes, 'N': No ]");

            flag:
            string answer = Console.ReadLine();
            if (answer == "Y")
            {
                foreach (FileInfo item in files)
                {
                    item.Delete();
                }
                Console.WriteLine("Files is successfully deleted!");
            }
            else if(answer == "N")
            {
                Console.WriteLine("Files is not deleted!");
            }
            else
            {
                Console.WriteLine("Wrong answer!");
                goto flag;
            }
        }

        static void Main(string[] args)
        {
            List<FileInfo> files;
            string path = null;

            Console.WriteLine("Please input path. For example 'D:\\Users\\Revit\\MyProjects' (For exit input 'E')");

            do
            {
                Console.Write("Path -> ");
                path = Console.ReadLine();
                if (path == "E")
                    break;

                Console.WriteLine(new string('-', 60));
                try
                {
                    FindFiles($@"{path}", out files);
                    DeleteFiles(files);
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong path, please input existing path!");
                    files = null;
                }
            } while (true);

            Console.WriteLine("Press any key to continue... ");
            Console.ReadKey();
        }
    }
}
