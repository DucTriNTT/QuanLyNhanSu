using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace QuanLyNhanSu
{
    public class EmployeeManager
    {
        private List<Employee> employees = new List<Employee>();
        private readonly string fileName = "data.json";

        // Thêm nhân viên
        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
            SaveToFile(); // Tự động lưu khi thêm
            Console.WriteLine("=> Đã thêm nhân viên thành công!");
        }

        // Hiển thị danh sách
        public void DisplayAll()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("=> Danh sách hiện đang trống.");
                return;
            }
            Console.WriteLine("\n--- DANH SÁCH NHÂN VIÊN ---");
            employees.ForEach(e => Console.WriteLine(e));
        }

        // Xóa nhân viên
        public void DeleteEmployee(int id)
        {
            int removedCount = employees.RemoveAll(e => e.Id == id);
            if (removedCount > 0)
            {
                SaveToFile(); // Tự động lưu khi xóa
                Console.WriteLine($"=> Đã xóa nhân viên có ID: {id}");
            }
            else
            {
                Console.WriteLine("=> Không tìm thấy nhân viên với ID này.");
            }
        }

        // HÀM LƯU FILE
        public void SaveToFile()
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(employees, Formatting.Indented);
                File.WriteAllText(fileName, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }

        // HÀM ĐỌC FILE
        public void LoadFromFile()
        {
            try
            {
                if (File.Exists(fileName))
                {
                    string jsonString = File.ReadAllText(fileName);
                    employees = JsonConvert.DeserializeObject<List<Employee>>(jsonString) ?? new List<Employee>();
                    Console.WriteLine("=> Đã nạp dữ liệu từ file thành công!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
    }
}