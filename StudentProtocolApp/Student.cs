using System;
using System.Collections.Generic;
using System.Text;
using static StudentProtocolApp.Enums;

namespace StudentProtocolApp
{
    class Student
    {
        public Names Name { get; set; }
        public Surnames Surname { get; set; }
        public University University { get; set; }
        public string Fullname { get { return $"{Surname} {Name}"; } set {; } }
        public byte Age { get; set; }
        public byte Grade { get; set; }
        public int BirthYear { get { return DateTime.Today.Year - Age; } }
        public string Email { get { return Surname.ToString().ToLower() + BirthYear.ToString() + "@gmail.com"; } }
        public int PhoneNumber { get; set; }
        public int Operator { get; set; }
        public string FullNumber { get { return $"(+374) {Operator}-{string.Format("{0:##-##-##}", PhoneNumber)}"; } }

    }
}
