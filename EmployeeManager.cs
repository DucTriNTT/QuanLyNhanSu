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

        // 1. Thêm nhân viên
        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
            SaveToFile();
            Console.WriteLine("=> Đã thêm nhân viên thành công!");
        }

        // 2. Hiển thị danh sách
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

        // 3. Xóa nhân viên
        public void DeleteEmployee(int id)
        {
            int removedCount = employees.RemoveAll(e => e.Id == id);
            if (removedCount > 0)
            {
                SaveToFile();
                Console.WriteLine($"=> Đã xóa nhân viên có ID: {id}");
            }
            else
            {
                Console.WriteLine("=> Không tìm thấy nhân viên với ID này.");
            }
        }

        // 4. Lưu dữ liệu vào file JSON
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

        // 5. Nạp dữ liệu từ file JSON
        public void LoadFromFile()
        {
            try
            {
                if (File.Exists(fileName))
                {
                    string jsonString = File.ReadAllText(fileName);
                    employees = JsonConvert.DeserializeObject<List<Employee>>(jsonString) ?? new List<Employee>();
                    Console.WriteLine("=> Hệ thống: Đã nạp dữ liệu cũ từ file.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        // 6. TÍNH NĂNG NÂNG CẤP: Xuất báo cáo ra file .txt
        public void ExportToText()
        {
            try
            {
                string exportPath = "BaoCaoNhanSu.txt";
                using (StreamWriter writer = new StreamWriter(exportPath))
                {
                    writer.WriteLine("============================================");
                    writer.WriteLine("       BÁO CÁO DANH SÁCH NHÂN VIÊN");
                    writer.WriteLine($"       Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm}");
                    writer.WriteLine("============================================");
                    writer.WriteLine(string.Format("{0,-5} | {1,-20} | {2,-15} | {3,15}", "ID", "Họ Tên", "Chức Vụ", "Lương"));
                    writer.WriteLine("--------------------------------------------");

                    foreach (var e in employees)
                    {
                        writer.WriteLine(string.Format("{0,-5} | {1,-20} | {2,-15} | {3,15:N0} VNĐ", e.Id, e.Name, e.Position, e.Salary));
                    }

                    writer.WriteLine("--------------------------------------------");
                    writer.WriteLine($"Tổng số nhân viên: {employees.Count}");
                }
                Console.WriteLine("=> Thành công: Đã xuất báo cáo ra file BaoCaoNhanSu.txt!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xuất file: " + ex.Message);
            }
        }
    }
}