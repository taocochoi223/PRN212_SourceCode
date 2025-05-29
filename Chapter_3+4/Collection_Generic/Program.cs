/*
    Ứng dụng Generic đẻ quản lý nhân viên, thực hiện các thao tác CRUD
    C : create -> thêm mới
    R : Read -> Truy vấn: xem, sắp xếp, lọc
    U : Update -> Cập nhật
    D : Delete -> Xoá
 */

//Câu 1: Tạo 5 nhân viên, trong đó 4 full time 1 part time
using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;
List<Employee> employees = new List<Employee>();
FulltimeEmployee fe1 = new FulltimeEmployee()
{
    Id = 1,
    Name = "Name 1",
    IdCard = "123",
    Birthday = new DateTime(1989, 2, 3)
};

FulltimeEmployee fe2 = new FulltimeEmployee()
{
    Id = 2,
    Name = "Name 2",
    IdCard = "124",
    Birthday = new DateTime(1999, 9, 7)
};

FulltimeEmployee fe3 = new FulltimeEmployee()
{
    Id = 3,
    Name = "Name 3",
    IdCard ="125",
    Birthday = new DateTime(1969, 2, 3)
};

FulltimeEmployee fe4 = new FulltimeEmployee()
{
    Id = 4,
    Name = "Name 4",
    IdCard = "126",
    Birthday = new DateTime(2000, 7, 3)
};

ParttimeEmployee pe1 = new ParttimeEmployee()
{
    Id = 5,
    Name = "Name 5",
    IdCard = "127",
    Birthday = new DateTime(2004, 9, 10),
    WorkingHour = 2
    
};
employees.Add(fe1);
employees.Add(fe2);
employees.Add(fe3);
employees.Add(fe4);
employees.Add(pe1);


//Câu 2: Xuất thông tin toàn bộ nhân sự
Console.WriteLine("Thông tin toàn bộ nhân sự");
employees.ForEach(e => Console.WriteLine(e));

Console.WriteLine("------------------------------------------------------\n");
foreach (var employee in employees)
{
    Console.WriteLine(employee);
}

Console.WriteLine("------------------------------------------------------\n");
//Câu 3: Sắp xếp nhân viên theo năm sinh tăng dần
for (int i = 0; i < employees.Count; i++)
{
    for (int j = i + 1; j < employees.Count; j++)
    {
        Employee e1 = employees[i];
        Employee e2 = employees[j];
        if(e1.Birthday < e2.Birthday)
        {
            employees[i] = e2;
            employees[j] = e1;
        }
    }
}
Console.WriteLine("------------------------------------------------------\n");
Console.WriteLine("Sau khi sắp xếp");
employees.ForEach(e => Console.WriteLine(e));

// Update: Cập nhật thông tin nhân viên theo ID do người dùng nhập
Console.WriteLine("\nNhập ID nhân viên cần cập nhật:");
int updateId = int.Parse(Console.ReadLine());

Employee empToUpdate = employees.FirstOrDefault(e => e.Id == updateId);
if (empToUpdate != null)
{
    Console.WriteLine($"Name (hiện tại: {empToUpdate.Name}):");
    string input = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(input))
        empToUpdate.Name = input;

    Console.WriteLine($"Id card (hiện tại: {empToUpdate.IdCard}):");
    input = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(input))
        empToUpdate.IdCard = input;

    Console.WriteLine($"Birthday (yyyy-MM-dd) (hiện tại: {empToUpdate.Birthday:yyyy-MM-dd}):");
    input = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(input))
        empToUpdate.Birthday = DateTime.Parse(input);

    if (empToUpdate is ParttimeEmployee partEmp)
    {
        Console.WriteLine($"Số giờ làm (hiện tại: {partEmp.WorkingHour}):");
        input = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(input))
            partEmp.WorkingHour = int.Parse(input);
    }

    Console.WriteLine("\nThông tin nhân viên sau khi cập nhật:");
    Console.WriteLine(empToUpdate);
}
else
{
    Console.WriteLine($"Không tìm thấy nhân viên có ID = {updateId}");
}


// Delete employee
Console.WriteLine("List trước khi xoá:");
employees.ForEach(e => Console.WriteLine(e));

Console.WriteLine("\nNhập ID nhân viên cần xoá:");
int deleteId = int.Parse(Console.ReadLine());

Employee empToDelete = employees.FirstOrDefault(e => e.Id == deleteId);
if (empToDelete != null)
{
    employees.Remove(empToDelete);
    Console.WriteLine($"\nĐã xoá nhân viên có ID = {deleteId}");
}
else
{
    Console.WriteLine($"\nKhông tìm thấy nhân viên có ID = {deleteId}");
}

Console.WriteLine("\nDanh sách sau khi xoá:");
employees.ForEach(e => Console.WriteLine(e));



