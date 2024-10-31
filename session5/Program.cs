internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // gọi hàm
        int ketQua = tinhTong(10,11);
        Console.WriteLine($"tổng 2 số là: {ketQua}");
        Console.WriteLine("Bài 1: nhập vào số n từ bàn phím. In ra các số nguyên tố từ 2 đến n");
Console.WriteLine("Mời bạn nhập số: ");
int number = Convert.ToInt32(Console.ReadLine());
for(int count = 2; count <= number; count++){
    bool checkPrime = isPrime(count);
    

    if(checkPrime == true) {
        Console.Write($"{count} ");
    }
}

        
    }
    // khai báo hàm kiểm tra số nguyên tố
    private static bool isPrime(int number ){
        if (number<2) {
            return false;
        }
        for (int count = 2; count<= Math.Sqrt(number); count++){
            if (number%count==0){
                return false;
            }
        }
        return true;
    }

    
    // khai báo hàm
    private static int tinhTong(int number1, int number2){
        return number1 + number2;
    }
}