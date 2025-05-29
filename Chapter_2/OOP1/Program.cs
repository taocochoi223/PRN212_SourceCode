using System.Text;
using OOP1;
Console.OutputEncoding = Encoding.UTF8;

Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nước Mắm";
c1.PrintInfo();
Console.WriteLine("-------------------------------");

Employee e1 = new Employee();
e1.Id = 2;
e1.Name = "Tri";
e1.Email = "tri@gmail.com";
e1.Phone = "113";

Console.WriteLine($"Employee Id = {e1.Id}");
Console.WriteLine($"Name = {e1.Name}");
Console.WriteLine($"Email = {e1.Email}");
Console.WriteLine($"Phone = {e1.Phone}");
Console.WriteLine("-------------------------------");

e1.PrintInfo();
Console.WriteLine("-------------------------------");

Console.WriteLine(e1);
Console.WriteLine("-------------------------------");

//Vừa tạo đối tượng vauwf khởi tạo già trị cho hệ thống
Employee e2 = new Employee(2, "Tri", "tri@gmail.com", "0356702429");
Console.WriteLine(e2);
Console.WriteLine("-------------------------------");

//Hoặc ta có thể coding như sau
Employee e3 = new Employee()
{
    Id = 3,
    Name = "Tủn",
    Email = "Tun@",
    Phone = "1215"
};
Console.WriteLine(e3);



