using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1.Exercise1
{
    public class Student : IStudent
    {
        private string fullName;
        private int iD;
        private DateTime dateOfBirth;
        private string native;
        private string className;
        private string phoneNo;
        private int mobile;
        public string FullName { get => fullName; set => fullName = value; }
        public int ID { get =>iD; set => iD = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set =>dateOfBirth = value; }
        public string Native { get => native; set => native = value; }
        public string ClassName { get =>className; set =>className = value; }
        public string PhoneNo { get => phoneNo; set =>phoneNo = value; }
        public int Mobile { get => mobile; set => mobile = value; }

        public void Display()
        {
            Console.WriteLine("FullName: {0} | ID: {1}| DateOfBirth: {2}| Native: {3}| Class: {4}| PhoneNo: {5}| Mobile: {6}", FullName, ID, DateOfBirth, Native, ClassName, PhoneNo, Mobile);
        }
        public override string ToString()
        {
            return $"fullname: {FullName} ID: {FullName} DateOfBirth: {DateOfBirth} Native: {Native} Class: {ClassName} PhoneNo: {PhoneNo} Number: {Mobile}";
        }
    }
}
