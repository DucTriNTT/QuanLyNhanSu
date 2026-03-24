using System;
using System.Text;

namespace QuanLyNhanSu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hỗ trợ gõ tiếng Việt có dấu trong Console
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            EmployeeManager manager = new EmployeeManager();
            
            // Tự động nạp dữ liệu cũ khi vừa mở app
            manager.LoadFromFile();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n========== QUẢN LÝ NHÂN SỰ ==========");
                Console.WriteLine("1. Xem danh sách nhân viên");
                Console.WriteLine("2. Thêm nhân viên mới");
                Console.WriteLine("3. Xóa nhân viên theo ID");
                Console.WriteLine("4. Thoát");
                Console.Write("Lựa chọn của bạn (1-4): ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        manager.DisplayAll();
                        break;
                    case "2":
                        try {
                            Console.Write("Nhập ID: "); int id = int.Parse(Console.ReadLine());
                            Console.Write("Nhập Họ Tên: "); string name = Console.ReadLine();
                            Console.Write("Nhập Chức Vụ: "); string pos = Console.ReadLine();
                            Console.Write("Nhập Lương: "); double sal = double.Parse(Console.ReadLine());
                            
                            manager.AddEmployee(new Employee(id, name, pos, sal));
                        } catch {
                            Console.WriteLine("!! Lỗi: ID và Lương phải là số.");
                        }
                        break;
                    case "3":
                        Console.Write("Nhập ID cần xóa: ");
                        if (int.TryParse(Console.ReadLine(), out int delId))
                            manager.DeleteEmployee(delId);
                        break;
                    case "4":
                        exit = true;
                        Console.WriteLine("Cảm ơn bạn đã sử dụng phần mềm!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}