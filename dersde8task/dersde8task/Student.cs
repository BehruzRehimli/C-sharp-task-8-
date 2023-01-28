using System;
using System.Collections.Generic;
using System.Text;

namespace dersde8task
{
    internal class Student : Human
    {
        public string GroupNo;
        public Student(string name,string groupNo):base(name) 
        {
            GroupNo = groupNo;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Telebenin adi ve soyadi: {FullName}\nTelebenin Group Nomresi: {GroupNo}\n\n");
        }
    }
}
