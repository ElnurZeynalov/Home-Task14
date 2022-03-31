using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Group
    {
        public string No { get; private set; }
        private Student[] _students = new Student[0];
        public Type Type { get; set; }

        private static int _programming_count;
        private static int _desigin_count;
        private static int _system_count;
        public Group(Type Type)
        {
            if (Type == Type.Programming)
            {
                _programming_count++;
                int programing_NumNo = 100 + _programming_count;
                No = "AP" + programing_NumNo;
            }
            
            if (Type == Type.Desigin)
            {
                _desigin_count++;
                int desigin_NumNo = 100 + _desigin_count;
                No = "AD" + desigin_NumNo;
            }

            if (Type ==  Type.System)
            {
                _system_count++;
                int system_NumNo = 100 + _system_count;
                No = "AS" + system_NumNo;
            }   
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref _students, _students.Length+1);
            _students[_students.Length-1] = student;
        }
        public Student GetStudentByNo(int? no)
        {
            foreach (var item in _students)
            {
                if (item.No == no)
                    return item;
            }
            return null;
        }
    }
}
