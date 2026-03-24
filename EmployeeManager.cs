using System;
using System.Collections.Generic;

namespace QuanLyNhanSu
{
    public class EmployeeManager
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
            Console.WriteLine("Thêm thành công!");
        }

        public void DisplayAll()
        {
            if (employees.Count == 0) {
                Console.WriteLine("Danh sách trống!");
                return;
            }
            employees.ForEach(e => Console.WriteLine(e));
        }

        public void DeleteEmployee(int id)
        {
            employees.RemoveAll(e => e.Id == id);
            Console.WriteLine("Đã thực hiện lệnh xóa.");
        }
    }
}