using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
       // Console.WriteLine("Hello, World!");
    #region Bài tập số 2

    /*
    input: nhập giá tiền, nhập % giảm giá
    */
    // System.Console.WriteLine("mời bạn nhập số tiền trà sữa");
    // string? giaTien = Console.ReadLine();
    // System.Console.WriteLine("mời bạn nhập voucher giảm giá");
    // string? giamGia = Console.ReadLine();

    // output
    // long tienGiam = 0;
    // long tienPhaiTra = 0;


    //process
    // long formatGiaTien = Convert.ToInt64(giaTien);
    // long formatGiamGia = Convert.ToInt64(giamGia);
    // tienGiam = formatGiaTien* formatGiamGia/100;
    // tienPhaiTra = formatGiaTien - tienGiam;

    // System.Console.WriteLine($"số tiền giảm sau khi áp voucher: {tienGiam}");
    // System.Console.WriteLine($"sô tiền phải trả sau khi áp voucher: {tienPhaiTra}");


    



    #endregion


    #region if else statement
    // nhập số nguyên từ bàn phím và in ra số đó là số lẻ hay chẵn
    // int n;
    // Console.OutputEncoding = System.Text.Encoding.UTF8;
    // Console.InputEncoding = System.Text.Encoding.UTF8;
    // System.Console.WriteLine("mời bạn nhập số cần kiểm tra");
    // n = int.Parse(Console.ReadLine());
    //
    // if (n % 2 ==0){
    //     System.Console.WriteLine($"{n} là số chẵn");
    // }
    // else {
    //     System.Console.WriteLine($"{n} là số lẻ");
    // }









    #endregion

    #region tính điểm trung bình
// nhập điểm trung bình của hoc sinh, xuất ra học lực của học sinh đó
// >= 9: xuất sắc
// 8 <= điểm < 9 : giỏi
// 6.5 <= điểm < 8 : khá
// 5 <= điểm < 6.5: trung bình
// 3.5 <= điểm < 5: yếu
// quá kém 
        // double diemTB;
        // Console.WriteLine("mời nhâp điểm trung bình của bạn ");
        // diemTB = double.Parse(Console.ReadLine());
        // Console.WriteLine("điểm trung bình của bạn là {0}", diemTB);
        // if (diemTB >= 9)
        // {
        //     Console.WriteLine("xuất sắc");
        //     
        // }// kết hợp 2 hoặc nhiều điều kiện
        // // && => và
        // // || => hoặc
        // else if (diemTB>=8 && diemTB<9)
        // {
        //     Console.WriteLine("giỏi");
        // }
        // else if (diemTB>= 6.5 && diemTB<8)
        //     
        // {
        //     Console.WriteLine("khá");
        //     
        // }
        // else if (diemTB>=5 && diemTB< 6.5)
        //     
        // {
        //     Console.WriteLine("trung bình");
        //     
        // }
        // else if (diemTB>= 3.5 && diemTB < 5)
        // {
        //     Console.WriteLine("yếu");
        //     
        // }
        // else
        // {
        //     Console.WriteLine("quá yếu");
        //     
        // }
        // {
        //     
        // }
        // {
        //     
        // }
        //

    

    #endregion

    #region luyện tập 5

    /*nhập vào một số có 3 chữ số, tính tổng 3 ký số đó.
     ví dụ: nhập vào 987 => 9+8+7= 24
     nhập vào số có 2 chữ số hoặc 1 chữ số => không hợp lệ
     */
    // int a,b, c, d, tong;
    // Console.WriteLine("mời nhập vào một số có 3 số");
    // a = int.Parse(Console.ReadLine());
    // if (a>99 && a<1000)
    // {
    //     b = a / 100;
    //     Console.WriteLine(b);
    //     c = (a % 100) / 10;
    //     Console.WriteLine(c);
    //     d = (a% 100) % 10;
    //     Console.WriteLine(d);
    //     
    //    tong = b + c + d;
    //    Console.WriteLine($"tổng 3 ký số trong dãy số bạn vừa nhập là {tong}");
    //     
    //     
    //     
    // }
    // else
    // {
    //     Console.WriteLine("không hợp lệ");
    // }
    //     

    #endregion
    
    // nhập số có trong khoảng từ 1 ến 10. Đọc số
    int n;
    Console.WriteLine(" mời nhập số ");
    n = int.Parse(Console.ReadLine());
    switch (n)
    {
        case 1:
            Console.WriteLine("số 1");
            break;
        case 2:
            Console.WriteLine("số 2");
            break;
        case 3:
            Console.WriteLine("số 3");
            break;
        case 4:
            Console.WriteLine("số 4");
            break;
        case 5:
            Console.WriteLine("số 5");
            break;
        case 6:
            Console.WriteLine("số 6");
            break;
        case 7:
            Console.WriteLine("số 7");
            break;
        case 8:
            Console.WriteLine("số 8");
            break;
        case 9:
            Console.WriteLine("số 9");
            break;
        case 10:
            Console.WriteLine("số 10");
            break;
        default:
            Console.WriteLine("không có");
            break;
            
        
    }
    }

}