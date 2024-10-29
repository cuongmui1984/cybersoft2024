// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region MyRegion

/*
 * có 3 vòng lặp chính
 * while: dùng khi không rõ số lần lặp
 * for: dùng khi biết rõ số lần lặp
 * do ... while: làm một lần trước khi vào vòng lặp
 * quan trọng nhất vẫn là xác định được điều kiện dừng
 */

// in ra các số từ 1 đến n với n là số được nhập từ bàn phím
// B1: khởi tạo giá trị lặp
// B2: xác định điều kiện lặp (tính tới trường hợp dừng)
// B3: thay đổi điều kiện lặp

// int n;
// System.Console.WriteLine("Enter a number: ");
// n = int.Parse(Console.ReadLine());
// int count = 1; // khởi tạo giá trị lặp
// while (count <= n) // xác định điều kiện lặp
// {
//  System.Console.WriteLine(count);
//  count++; // thay đổi điều kiện lặp
// }
#endregion

/* nhập số n từ bàn phím, in ra tổng các số từ 1 đến n
 S = 1 + 2 + 3 + ... + n
 */

#region cộng các số từ 1 đến n

// int number;
// int sum = 0;
// System.Console.WriteLine(" mời nhập vào số ");
// number = int.Parse(Console.ReadLine());
// int count = 1;
// while (count <= number)
// {
//  sum += count;
//  count++;
// }
//
// System.Console.WriteLine($"tổng các số từ 1 đến number là {sum}");
#endregion
#region tính giai thừa

// tính giai thừa của một số nhập từ bàn phím
// int n;
// int giaiThua = 1;
// int count = 1;
// System.Console.WriteLine("mời nhập số");
// n = int.Parse(Console.ReadLine());
// while (count <= n)
// {
//  giaiThua *= count;
//  count++;
// }
// System.Console.WriteLine($"giai thừa từ 1 đến n là {giaiThua} ");
#endregion

#region bảng cửu chương

// int n;
// int count = 1;
// int plus = 0;
// System.Console.WriteLine("mời nhập vào số cần tính");
// n = int.Parse(Console.ReadLine());
// while (count <= 10)
// {
//  plus = n * count;
//
//  System.Console.WriteLine($"{n} X {count} = {plus}");
//  count++;
// }

#endregion

#region số nguyên tố
// nhập vào một số kiểm tra xem có phải số nguyên tố hay không
// int n;
// int count = 2;
//
// System.Console.WriteLine(" mời nhập số cần kiểm tra");
// n = int.Parse(Console.ReadLine());
// while (count < n)
// {
//  if (n % count == 0)
//   
//  {
//   System.Console.WriteLine($"số {n} không phải là số nguyên tố");
//   break; // chú ý
//  }
//  count++; // quan trọng
//  if (count == n )
//  {
//   System.Console.WriteLine($"số {n} là số nguyên tố");
//  }
// }


#endregion

#region for statement
// in bảng cửu chương
// int number = Convert.ToInt32(Console.ReadLine());
// for (int count = 1; count <= 10; count++)
// {
//  System.Console.WriteLine($"{count} X {number} = {count*number}");
// }


#endregion

#region for so nguyen to

int n = Convert.ToInt32(Console.ReadLine());

for (int count =2; )


#endregion




 



