using System;
using System.Linq;

namespace NedenMetotKullaniyoruz
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 23;
            int number2 = 56;
            int result = Add(30);
            //ref keyword'ü gerçek hayatta müşteriye verilecek kredinin fazi oranı için kullanılabilinir.
            Console.WriteLine(result);
            var result2 = Add2(ref number1, number2);
            Console.WriteLine(result2+"****");
            Console.WriteLine(number1);
        }

        static int Add(int number1,int number2= 20)
        {
            var result = number1 + number2;
            return result;

        }
        static int Add2(ref int number1,int number2)
        {
            //out keyword'ü kullanılsaydı sadece burada number1 atanmış şekilde olmalıydı.
            //başka yerde bir set etmeye gerek yoktu.
            number1 = 75;
            return number1 + number2;
        }
        //Overloading
        static int Multiply(int num1,int num2)
        {
            return num1 * num2;
        }
        static int Multiply(int num1,int num2,int num3)
        {
            return num1 * num2 * num3;
        }
        static int Add3(params int [] nums)
        {
            return nums.Sum();
        }

    }
}
