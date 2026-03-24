using System;

namespace QuanLyNhanSu
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, string position, double salary)
        {
            Id = id;
            Name = name;
            Position = position;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"[{Id}] {Name,-20} | Chức vụ: {Position,-15} | Lương: {Salary:N0} VNĐ";
        }
    }
}