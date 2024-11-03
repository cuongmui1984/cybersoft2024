internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        #region Kiểm tra số nguyên tố

        // System.Console.WriteLine("mời bạn nhập số: ");
        // string? number = Console.ReadLine();
        // int formatNumber = Convert.ToInt32(number);
        // bool isPrime = Method.checkPrime(formatNumber);
        // if (isPrime == true){
        //     System.Console.WriteLine($"số {number} là số nguyên tố");
        // }
        // else {
        //     System.Console.WriteLine($"số {number} không phải là số nguyên tố");
        // }
        #endregion

        #region in ra tam giác vuông có chiều cao n nhập từ bàn phím

        // System.Console.WriteLine("mời bạn nhập chiều cao tam giác");
        // string? height = Console.ReadLine();
        // int formatHeight = Convert.ToInt32(height);
        // Method.printSquareTriangle(formatHeight);




        #endregion

        #region Collection trong C#
        // data structure
        // list
        List <int> numbers = new List<int>();

        // define  giá trị ban đầu
        List<string> names = new List<string> {"Phuong", "duc", "Linh", "Tri"};
        //                          index       0           1       2       3
        //                      revereIndex     ^4          ^3      ^2      ^1
        System.Console.WriteLine("phần tử thứ 2 là: {0}", names[2]);
        System.Console.WriteLine("phần tử nghịch đảo là: {0}", names[^2]);
        // Lưu ý: Console.WriteLine chỉ in được giá trị cho những kiểu dữ liệu nguyên thủy: int, float, string...
        // Còn kiểu dữ liệu Collection thì chỉ in ra địa chỉ vùng nhớ của biến đó
        System.Console.WriteLine(String.Join(", ", names));


        // bài tập làm quen: nhập n từ bàn phím sau đó sẽ nhập n phần tử và xuất ra n phần tử
        Console.WriteLine(" mời bạn nhập số lượng phần tử");
        string? number = Console.ReadLine();
        int formatNumber = Convert.ToInt32(number);
        // tạo biến chứa danh sách phần tử
        List<int> listNumbers = new List<int>();
        for (int i = 0; i < formatNumber; i ++){
            // C1: dùng insert
            System.Console.WriteLine("nhập phần tử thứ {0} ", i+1);
            int item;
            item = int.Parse(Console.ReadLine());
            listNumbers.Insert(i, item);
                       
        } 
        // in list ra ngoài màn hình
        // sẽ có 2 cách duyệt phần tử: for và foreach
        // C1: for
        System.Console.WriteLine("danh sách phần tử sau khi nhập là:");
        for (int i =0; i < listNumbers.Count; i++) {
            System.Console.WriteLine(listNumbers[i]);
        }
        // cách 2 dùng foreach
        System.Console.WriteLine("Danh sách phần tử dùng foreach: ");
        foreach(int item in listNumbers) {
            System.Console.WriteLine(item);
        }






        #endregion
    }
}