using System.Text;

Console.OutputEncoding = Encoding.UTF8;

string ho = "Nguyễn";
string tenlot = "Văn";
string ten = "Tèo";

string fullten = ho + " " + tenlot + " " + ten;
Console.WriteLine(fullten + "\n");

StringBuilder sb = new StringBuilder();
sb.Append(ho);
sb.Append(" ");
sb.Append(tenlot);
sb.Append(" ");
sb.Append(ten);
string name2 = sb.ToString();
Console.WriteLine(name2);

Console.ReadLine();