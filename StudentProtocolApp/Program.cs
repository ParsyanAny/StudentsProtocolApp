using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using static StudentProtocolApp.Enums;

namespace StudentProtocolApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string writePath = @"C:\Users\Any\Desktop\Protocol.txt";
            string readPath = @"C:\Users\Any\Desktop\1.txt";

            var list = StudentListCreater.CreateList(45);


            WriteStudentsList(list, writePath);

            ReadStudentsList(writePath);

            Console.Read();
        }
        static void WriteStudentsList(List<Student> list, string path)
        {
            using (var s = new StreamWriter(path))
            {
                
                    foreach (var item in list)
                    {
                       s.WriteLine($"{item.University}\t\t{item.Grade}\t{item.Fullname}     \t{item.Age} \t{item.Email}    \t {item.FullNumber} ");
                    } 
            }
        }
        static void ReadStudentsList(string path)
        {
            using(StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
