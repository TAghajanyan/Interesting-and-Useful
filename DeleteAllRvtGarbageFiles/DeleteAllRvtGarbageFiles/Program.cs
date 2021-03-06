﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteAllRvtGarbageFiles
{
    class Program
    {
        static int pos = 0;

        static void FindeFolders(DirectoryInfo directory, ref List<FileInfo> files)
        {
            if (FindFiles(directory, ref files))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(new string(' ', pos) + directory.Name);
                PrintFiles(directory);
            }
            else pos -= 3;

            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (DirectoryInfo item in directory.GetDirectories())
            {
                try
                {
                    pos += 3;
                    FindeFolders(item, ref files);
                }
                catch (Exception e) when(e is PathTooLongException || e is UnauthorizedAccessException)
                {
                    Console.WriteLine(e.Message);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static bool FindFiles(DirectoryInfo directory, ref List<FileInfo> files)
        {
            int x;
            string end = string.Empty;
            bool b = false;
            foreach (FileInfo item in directory.GetFiles())
            {
                try
                {
                    end = item.Name.Substring(item.Name.Length - 8, 4);
                    if (int.TryParse(end, out x) && item.Extension == ".rvt" && item.Name[item.Name.Length - 9] == '.')
                    {
                        files.Add(item);
                        b = true;
                    }
                }
                catch { }
            }
            return b;
        }

        static void DeleteFiles(List<FileInfo> files)
        {
            if (files.Count == 0)
            {
                Console.WriteLine("There are not garbage files!");
                return;
            }

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
        static void PrintFiles(DirectoryInfo directory)
        {
            int x;
            string end = string.Empty;

            foreach (FileInfo item in directory.GetFiles())
            {
                try
                {
                    end = item.Name.Substring(item.Name.Length - 8, 4);
                    if (int.TryParse(end, out x) && item.Extension == ".rvt" && item.Name[item.Name.Length - 9] == '.')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(new string(' ', pos + 3) + item.Name);
                    }
                }
                catch { }
            }
        }

        static string GetFilesSize(List<FileInfo> files)
        {
            string size = "0 Dytes";
            double len = 0;
            foreach (FileInfo item in files)
            {
                len += item.Length;
            }

            if (len >= 1073741824.0)
                size = String.Format("{0:##.##}", len / 1073741824.0) + "GB";
            else if (len >= 1048576.0)
                size = String.Format("{0:##.##}", len / 1048576.0) + "MB";
            else if (len >= 1024.0)
                size = String.Format("{0:##.##}", len / 1024.0) + "KB";
            else if (len > 0 && len < 1024.0)
                size = String.Format("{0:##.##}", len / 1024.0) + "KB";

            return size;
        }


        static void Main(string[] args)
        {
            List<FileInfo> files = new List<FileInfo>();
            DirectoryInfo directory;
            string path = string.Empty;

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
                    directory = new DirectoryInfo(path);
                    Console.WriteLine(path);
                    try
                    {
                        FindeFolders(directory, ref files);
                        Console.WriteLine("Files size: " + GetFilesSize(files));
                    }
                    catch { }
                    finally
                    {
                        DeleteFiles(files);
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Wrong path, please input existing path!");
                }
            } while (true);

            Console.WriteLine("Press any key to continue... ");
            Console.ReadKey();
        }
    }
}
