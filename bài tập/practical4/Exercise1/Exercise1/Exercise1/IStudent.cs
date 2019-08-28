using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1.Exercise1
{
    interface IStudent
    {
         string FullName { get; set; }
         int ID { get; set; }
         DateTime DateOfBirth { get; set; }
         string Native { get; set; }
         string ClassName { get; set; }
         string PhoneNo { get; set; }
         int Mobile { get; set; }
        void Display();
    }
}
