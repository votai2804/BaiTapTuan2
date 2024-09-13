using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapbuoi2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student st1 = new Student(123, "Võ Tấn Tài", 21);
            Student st2 = new Student(456, "Nguyễn Trường Giang", 18);
            Student st3 = new Student(789, "Hồ Hữu Luân", 15);
            Student st4 = new Student(159, "A Bùi Quang Vinh", 30);
            Student st5 = new Student(357, "A Phạm Mạnh Phi", 20);
            List<Student> list = new List<Student>();
            list.Add(st1);
            list.Add(st2);
            list.Add(st3);
            list.Add(st4);
            list.Add(st5);

            int choice;

            do
            {
                
                Console.WriteLine("=======Menu=======:");
                Console.WriteLine("1. In danh sách sinh viên");
                Console.WriteLine("2. In sinh viên tuổi từ 15 đến 18");
                Console.WriteLine("3. In sinh viên tên bắt đầu bằng 'A'");
                Console.WriteLine("4. Tính tổng tuổi của sinh viên");
                Console.WriteLine("5. In sinh viên lớn tuổi nhất");
                Console.WriteLine("6. In sinh viên sau sắp xếp tăng dần");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Danh sách học sinh : ");
                        InHocSinh(list);
                        break;
                    case 2:
                        InHocSinhtuoi1518(list);
                        break;
                    case 3:
                        InHocSinhtuoichuA(list);
                        break;
                    case 4:
                        TongtuoicuaHocSinh(list);
                        break;
                    case 5:
                        InHocSinhtuoiMax(list);
                        break;
                    case 6:
                        InHocSinhsausapxeptang(list);
                        break;
                    case 0:
                        Console.WriteLine("Kết thúc chương trình.");
                        break;
                    default:
                        Console.WriteLine("Chức năng không hợp lệ.");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            } while (choice != 0);

        }
            static void InHocSinh(List<Student> st)
        {
            st.ForEach(student => Console.WriteLine($"ID: {student.Id}, Tên: {student.Name}, Tuổi: {student.Age}"));
           
        }
        static void InHocSinhtuoi1518(List<Student> st)
        {
            var list2 = st.Where(student => student.Age >=15 && student.Age <=18)
                        .ToList();
            Console.WriteLine("Danh sách học sinh có độ tuổi từ 15 tới 18: ");
            InHocSinh(list2);
        }
        static void InHocSinhtuoichuA(List<Student> st)
        {
            var list2 = st.Where(student => student.Name.StartsWith("A"))
                        .ToList();
            Console.WriteLine("Danh sách học sinh có chữ A là chữ cái đầu tiên: ");
            InHocSinh(list2);
        }
        static void TongtuoicuaHocSinh(List<Student> st)
        {
            var list2 = st.Sum(student => student.Age);
            Console.WriteLine("Tổng tuổi của các học sinh là: "+ list2);
        }
        static void InHocSinhtuoiMax(List<Student> st)
        {
            var list2 = st.Where(student => student.Age == st.Max(student2=> student2.Age))
                       .ToList();
            Console.WriteLine("Học sinh có tuổi lớn nhất là là: " );
            InHocSinh(list2);
        }
        static void InHocSinhsausapxeptang(List<Student> st)
        {
            var list2 = st.OrderBy(student => student.Age)
                       .ToList();
            Console.WriteLine("Danh sách học sinh đã được sắp xếp tăng dần: ");
            InHocSinh(list2);
        }
    }
}
