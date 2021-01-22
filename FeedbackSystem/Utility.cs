using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FeedbackSystem
{
    /*
     * The class contains the static method that can be used from every class without the instance of the object.
     */
    class Utility
    {
        /*
         * This method returns a generic list of string arrays.
         * The method reads the data from the file and then stores it to a generic list.
         * Then, the list is returned.
         * It is made static so that other classes can access the data easily.
         */
        public static List<string[]> GetFiles()
        {
            string csvFile = Path.Combine(@"C:\Users\cenat\source\repos\FeedbackSystem\FeedbackSystem\bin\Debug\file1.csv");
            List<string[]> rows = File.ReadAllLines(csvFile).Select(x => x.Split(',')).ToList();

            return rows;
        }

        /*
         * The method copies the old files to the Old Files directory.
         * The name is set according to the date and time of the method being called.
         * The date and time are manipulated to text format which can be used as a file name.
         * The Copy method of the File class is used to copy the file to the Old Files directory.
         * It is made static so that other classes can access the data easily.
         */
        public static void CopyFiles(string path)
        {
            string dateTime = DateTime.Now.ToString();
            dateTime = dateTime.Replace(":", "-");
            dateTime = dateTime.Replace("/", "-");
            string oldFilePath = path + "\\file1.csv";
            string newFilePath = path + "\\OldFiles\\" + dateTime + ".csv";
            File.Copy(oldFilePath, newFilePath);
        }

        /*
         * The method creates the header of the csv file.
         * The method takes path and a array of string as params.
         * Each string of the array is seperated by a comma and written to the file.
         * It is made static so that other classes can access the data easily.
         */
        public static void CreateFile(string path, string[] arr)
        {
            string fileName = path + "\\file1.csv";
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
            File.WriteAllText(fileName, clientHeader);
        }

        /*
         * The method appends the data of the csv file.
         * The method takes path and a array of string as params.
         * Each data of the array is seperated by a comma and written to the file.
         * It is made static so that other classes can access the data easily.
         */
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
