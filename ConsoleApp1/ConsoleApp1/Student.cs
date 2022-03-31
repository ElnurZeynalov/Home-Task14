using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Student
    {
        public int No {get; private set;}
        public string FullName {get;set;}
        public Student()
        {
            No++;
        }
        public string ShowInfo()
        {
            return $"No: {No} - Fulname: {FullName}";
        }
    }
}
