
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

//Hãy viết 1 hàm có khả năng nhận bao nhiêu phần tử cũng được và trả về tổng các phần tử đó
int sums(params int[] arr){
    int s = 0;
    foreach(int x in arr){
        s += x;
    }
    return s;
}

int s1 = sums(1);
int s2 = sums(1, 8);
int s3 = sums(12, 5, 10);
Console.WriteLine($"s1 = {s1}; s2 = {s2}; s3 = {s3}");
