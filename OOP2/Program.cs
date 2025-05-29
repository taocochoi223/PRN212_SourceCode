using OOP2;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

FulltimeEmployee teo = new FulltimeEmployee();
teo.Id = 1;
teo.Name = "Tèo";
Console.WriteLine(teo.calSalary());

ParttimeEmployee ty = new ParttimeEmployee();
ty.WorkingHour = 2;
ty.Name = "Tý khốn khổ";
ty.Id = 2;
Console.WriteLine("Lương của Tý = " + ty.calSalary());

FulltimeEmployee obama = new FulltimeEmployee()
{
    Id = 100,
    Name = "Barar Obama",
    Birthday = new DateTime(1960, 1, 25),
    IdCard = "123"

};
Console.WriteLine("\t============Thông tin Obama=============");
Console.WriteLine(obama);

ParttimeEmployee trump = new ParttimeEmployee()
{
    Id = 100,
    IdCard = "123",
    Name = " Donal Trump",
    Birthday = new DateTime(1940, 12, 26),
    WorkingHour = 3
};

Console.WriteLine("\t============Thông tin Trump==============");
Console.WriteLine(trump);
