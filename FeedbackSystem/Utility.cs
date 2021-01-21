using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FeedbackSystem
{
    class Utility
    {
        public static List<string[]> GetFiles()
        {
            string csvFile = Path.Combine(@"C:\Users\cenat\source\repos\FeedbackSystem\FeedbackSystem\bin\Debug\file1.csv");
            List<string[]> rows = File.ReadAllLines(csvFile).Select(x => x.Split(',')).ToList();

            return rows;
        }

        public static void CopyFiles(string path)
        {
            string name = (new Random()).Next(1000, 99000).ToString();
            string oldFilePath = path + "\\file1.csv";
            string newFilePath = path + "\\OldFiles\\" + name + ".csv";
            File.Copy(oldFilePath, newFilePath);
        }

        public static void CreateFile(string path, string[] arr)
        {
            string fileName = path + "\\file1.csv";
            /*string clientHeader = "Customer Name" + "," + "Phone Number" + "," + "Email Address" + "," ;*/
            string clientHeader = "";
            for (int i=0; i<arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    clientHeader = clientHeader + arr[i] + "\n";
                }
                else
                {
                    clientHeader = clientHeader + arr[i] + ",";
                }
            }
            Console.WriteLine(clientHeader);
            File.WriteAllText(fileName, clientHeader);
            Console.WriteLine("Written");
        }

        public static void WriteToFile(string path, string[] arr)
        {
            string fileName = path + "\\file1.csv";
            string clientDeatils = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    clientDeatils = clientDeatils + arr[i] + "\n";
                }
                else
                {
                    clientDeatils = clientDeatils + arr[i] + ",";
                }
            }
            File.AppendAllText(fileName, clientDeatils);
        }
    }
}
