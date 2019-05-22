using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static StudentProtocolApp.Enums;

namespace StudentProtocolApp
{
    class StudentListCreater
    {
        public static List<Student> CreateList(int count)
        {
            var op = new List<int> { 93, 91, 43, 99, 55, 10, 94 };
            var stList = new List<Student>(count);
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                stList.Add(new Student
                {
                    Name = (Names)rand.Next(0, Enum.GetValues(typeof(Names)).Cast<Names>().Distinct().Count()),
                    Surname = (Surnames)rand.Next(0, Enum.GetValues(typeof(Surnames)).Cast<Surnames>().Distinct().Count()),
                    Age = (byte)rand.Next(15, 50),
                    Grade = (byte)rand.Next(0, 21),
                    University = (University)rand.Next(0, Enum.GetValues(typeof(University)).Cast<University>().Distinct().Count()),
                    Operator = op[rand.Next(0, op.Count)],
                    PhoneNumber = rand.Next(100000, 999999)
                }
                );
            }
            return stList;
        }
    }
}
