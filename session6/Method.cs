using System.Data;

class Method {

    public static bool checkPrime (int number) {
        if (number < 2) {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++) {
            if (number % i == 0) {
                return false;
            }
        }
        
        return true;
    }

    public static void printSquareTriangle(int height){
        for (int i = 1; i <= height; i++) {
            for (int j = 1; j <=i; j ++){
                Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }

}