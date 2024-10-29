// Console.WriteLine("Hello, World!");

#region  Học phép toán cơ bản
// học + , - , *, / (chia lấy phần nguyên), % (chia lấy phần dư)
// khai báo biến
// int add = 5 + 10;
// System.Console.WriteLine($"kết quả cộng 2 số 5 và 10 là: {add}");

// int minus = 2132431 - 123343;
// System.Console.WriteLine($"kết quả trừ hai số trên là: {minus}");

// float nhan1 = 5 * 10;
// System.Console.WriteLine($"kết quả nhân 2 số là: {nhan1}");

// float chia = 5 / 2;
// System.Console.WriteLine($"kết quả chia lấy phần nguyên 2 số là: {chia}");

#endregion

#region  number toán tử
// int cong = 0; // định nghĩa biến cộng có giá trị mặc định là 0
// cong+=10;
// System.Console.WriteLine($"numberic toán tử cộng: {cong}");

// int nhan = 1; // định nghĩa biến nhân có giá trị mặc định là 1
// nhan*=100;
// System.Console.WriteLine($"numberic toán tử nhân: {nhan}");

#endregion

// #region ép kiểu dữ liệu
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         // convert
//         // nhập dữ liệu từ bàn phím ==> Readline (string)
//         System.Console.WriteLine("mời nhập số");
//         string number = Console.Readline();

//         int convertNumber = Convert.ToInt32(number);
//         System.Console.WriteLine($"value number: {convertNumber}");
//     }
// }

#endregion

#region tính chỉ số PMI
// INPUT 
// chiều cao cân nặng nhập từ bàn phím
System.Console.WriteLine("Mời bạn nhập vào chiều cao (m)");
string chieuCao = Console.Readline();
//convert string sang double
double formatChieucao = Convert.ToDouble(chieuCao);

System.Console.WriteLine("Mời bạn nhập vào cân nặng (kg)");
string canNang = Console.Readline();
double formatCannang = Convert.ToDouble(canNang);

double bmi = 0.0;

// BMI = chieucao /cannang*cannang
bmi = formatCannang / (formatChieucao
    * formatChieucao);
System.Console.WriteLine($"chỉ số BMI của bạn là: {bmi}");


//PROCESS


//OUTPUT
// in ra chỉ số PMI



#endregion