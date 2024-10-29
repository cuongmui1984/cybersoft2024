// See https://aka.ms/new-console-template for more information

/* bài tập 1: tính số ngày trong tuần và số ngày lẻ
 yêu cầu người dùng nhập số ngày và tính toán bao nhiêu tuần và bao nhiêu ngày lẻ còn lại
 
 */
int days, weeks, excessDays;
System.Console.WriteLine("nhập vào số ngày bạn cần tính số tuần và ngày dư còn lại");
days = int.Parse(Console.ReadLine());
if (days >= 7)
{
 weeks = days / 7;
 excessDays = days % 7;
 System.Console.WriteLine($"kết quả: {weeks} tuần và {excessDays} ngày");

}
else
{
 System.Console.WriteLine("một tuần có 7 ngày má ơi, làm ơn nhập từ 7 ngày trở lên ");
}

/* Bài tập 2:
Yêu cầu người dùng nhập vào giá trị của một đơn hàng và phần trăm giảm giá. tính toán số tiền giảm giá và tổng số tiền phải thanh toán sau khi áp dung giảm giá
*/
System.Console.WriteLine("mời bạn nhập số tiền trà sữa");
     string? giaTien = Console.ReadLine();
     System.Console.WriteLine("mời bạn nhập voucher giảm giá");
     string? giamGia = Console.ReadLine();

    // output
     long tienGiam = 0;
     long tienPhaiTra = 0;


    //process
     long formatGiaTien = Convert.ToInt64(giaTien);
     long formatGiamGia = Convert.ToInt64(giamGia);
     tienGiam = formatGiaTien* formatGiamGia/100;
     tienPhaiTra = formatGiaTien - tienGiam;

     System.Console.WriteLine($"số tiền giảm sau khi áp voucher: {tienGiam}");
     System.Console.WriteLine($"sô tiền phải trả sau khi áp voucher: {tienPhaiTra}");

//Bài tập 3:
int phut, gio, phutdu;
System.Console.WriteLine("nhập vào số phút cần chuyển đổi");
phut = int.Parse(Console.ReadLine());
gio = phut / 60;
phutdu = phut % 60;
System.Console.WriteLine($"{gio} giờ và {phutdu} phút");
// Bài tập 4:
float gia, vat, thue, tienThanhToan;
System.Console.WriteLine(" nhập giá ");
gia = float.Parse(Console.ReadLine());
System.Console.WriteLine(" nhập mức thuế VAT ");
vat = float.Parse(Console.ReadLine());
thue = gia * (vat / 100);
tienThanhToan = gia + thue;
System.Console.WriteLine("số tiền cần phải trả là {0}", tienThanhToan);

// Bài tập 5
float usd, vnd, tiGia;
System.Console.WriteLine("nhập vào số USD cần chuyển sang VND ");
usd = float.Parse(Console.ReadLine());
System.Console.WriteLine(" nhập vào tỉ giá chuyển đổi ");
tiGia = float.Parse(Console.ReadLine());
vnd = usd * tiGia;
System.Console.WriteLine("số tiền VND là {0}", vnd);



 



