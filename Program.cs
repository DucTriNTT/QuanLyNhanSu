using System;

namespace QuanLyNhanSu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập để hiển thị tiếng Việt có dấu trong Console
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            EmployeeManager manager = new EmployeeManager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- HỆ THỐNG QUẢN LÝ NHÂN SỰ ---");
                Console.WriteLine("1. Xem danh sách nhân viên");
                Console.WriteLine("2. Thêm nhân viên mới");
                Console.WriteLine("3. Xóa nhân viên");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        manager.DisplayAll();
                        break;
                    case "2":
                        try {
                            Console.Write("Nhập ID: "); 
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Nhập tên: "); 
                            string name = Console.ReadLine();
                            Console.Write("Nhập chức vụ: "); 
                            string pos = Console.ReadLine();
                            Console.Write("Nhập lương: "); 
                            double sal = double.Parse(Console.ReadLine());

                            Employee newEmp = new Employee(id, name, pos, sal);
                            manager.AddEmployee(newEmp);
                        } catch {
                            Console.WriteLine("Lỗi: Vui lòng nhập đúng định dạng số cho ID và Lương!");
                        }
                        break;
                    case "3":
                        Console.Write("Nhập ID nhân viên cần xóa: ");
                        if(int.TryParse(Console.ReadLine(), out int delId)) {
                            manager.DeleteEmployee(delId);
                        }
                        break;
                    case "4":
                        exit = true;
                        Console.WriteLine("Đang thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng thử lại.");
                        break;
                }
            }
        }
    }
}