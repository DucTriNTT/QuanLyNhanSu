using System;
using System.Text;

namespace QuanLyNhanSu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập font tiếng Việt cho Console
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            EmployeeManager manager = new EmployeeManager();
            
            // Tự động nạp lại dữ liệu cũ ngay khi mở app
            manager.LoadFromFile();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n========== HỆ THỐNG QUẢN LÝ NHÂN SỰ ==========");
                Console.WriteLine("1. Xem danh sách nhân viên");
                Console.WriteLine("2. Thêm nhân viên mới");
                Console.WriteLine("3. Xóa nhân viên theo ID");
                Console.WriteLine("4. Xuất báo cáo ra file (.txt)");
                Console.WriteLine("5. Thoát chương trình");
                Console.Write("Lựa chọn của bạn (1-5): ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        manager.DisplayAll();
                        break;
                    case "2":
                        try {
                            Console.Write("Nhập ID (số): "); int id = int.Parse(Console.ReadLine());
                            Console.Write("Nhập Họ Tên: "); string name = Console.ReadLine();
                            Console.Write("Nhập Chức Vụ: "); string pos = Console.ReadLine();
                            Console.Write("Nhập Lương (số): "); double sal = double.Parse(Console.ReadLine());
                            
                            manager.AddEmployee(new Employee(id, name, pos, sal));
                        } catch {
                            Console.WriteLine("!! Lỗi: ID và Lương phải nhập đúng định dạng số.");
                        }
                        break;
                    case "3":
                        Console.Write("Nhập ID nhân viên cần xóa: ");
                        if (int.TryParse(Console.ReadLine(), out int delId))
                            manager.DeleteEmployee(delId);
                        else
                            Console.WriteLine("!! Lỗi: ID phải là số.");
                        break;
                    case "4":
                        manager.ExportToText();
                        break;
                    case "5":
                        exit = true;
                        Console.WriteLine("Đang thoát... Tạm biệt!");
                        break;
                    default:
                        Console.WriteLine("!! Lựa chọn không hợp lệ, vui lòng chọn từ 1 đến 5.");
                        break;
                }
            }
        }
    }
}