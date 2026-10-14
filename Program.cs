// 1

// PrintHeader(Console.ReadLine());

// static void PrintLine() {
//     Console.WriteLine("0_0 :-) :0 ^-^ <-<");
// }
// static void PrintHeader(string title){
//     PrintLine();
//     Console.WriteLine(title);
//     PrintLine();
// } 

// 2.1

// int a = Max(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
// Console.WriteLine(a);
// static int Max(int a, int b){
//     if (a > b) return a;
//     else return b;
// }

// 2.2

// bool a = even(Convert.ToInt32(Console.ReadLine()));
// Console.WriteLine(a);
// static bool even(int a){
//     if (a % 2 == 0) return true;
//     else return false;
// }

// 3

// int[] spis = [120, 45, 300, 80, 15, 210];
// int avr = Convert.ToInt32(Average(spis));
// int count = CountGreater(spis, avr);
// Console.WriteLine(avr);
// Console.WriteLine(count);

// static double Average(int[] arr){
// return arr.Sum() / arr.Length;
// }

// static int CountGreater(int[] arr, int limit){
//     int cc = 0;
//     foreach (int i in arr)
//     {
//         if (i > limit) cc++;
//     }
//     return cc;
// }

// 4

// double c1 = 0;
// Console.WriteLine($"{c1} *C = {tofah(c1)} *F");
// double c2 = 100;
// Console.WriteLine($"{c2} *C = {tofah(c2)} *F");
// double c3 = 37;
// Console.WriteLine($"{c3} *C = {tofah(c3)} *F");
// static double tofah(double celsius){
//     return celsius * 9 / 5 + 32;
// }

// 5

// Console.WriteLine("Напишите число для факториала");
// Console.WriteLine(Factorial(Convert.ToInt32(Console.ReadLine())));
// Console.WriteLine("Напишите другое число");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++){
//     bool a = isprime(i);
//     if (a == true) Console.WriteLine(i);
// }

// static long Factorial(int n){
//     int sum = 1;
//     for (int i = 1; i <= n; i++){
//         sum*=i;
//     }
//     return sum;
// }

// static bool isprime(int n){
//     int cc = 0;
//     for (int i = 1; i <= n; i++){
//         if (n%i==0) cc++;
//     }
//     if (cc == 2) return true;
//     else return false;
//     }

// 6

// int n1 = ReadPositive("Введите положительное число: ");
// int n2 = ReadPositive("Введите положительное число: ");
// int sum = n1 + n2;
// Console.WriteLine(sum);

// static int ReadPositive(string message)
// {
//      int n3 = 0;
//      do {
//         Console.Write(message);
//         n3 = Convert.ToInt32(Console.ReadLine());
//     } while (n3 <= 0); 
//     return n3;
// }

// int choice = -1;
// while (choice != 0){
//     Console.WriteLine("1 - Сумма двух чисел");
//     Console.WriteLine("2 - большее из двух чисел");
//     Console.WriteLine("3 - факториал");
//     Console.WriteLine("0 - выход");
    
//     choice = Convert.ToInt32(Console.ReadLine());
//     switch (choice)
//     {
//         case 1:
//             Console.WriteLine("Введите два числа: ");
//             Console.WriteLine(Sum(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
//             break;
//         case 2:
//             Console.WriteLine("Введите два числа: ");
//             Console.WriteLine(Max(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
//             break;
//         case 3:
//             Console.WriteLine("Введите число");
//             Console.WriteLine(Factorial(Convert.ToInt32(Console.ReadLine())));
//             break;
//         case 0:
//             Console.WriteLine("До свидания!");
//             break;
//         default:
//             Console.WriteLine("Нет такого выбора");
//             break;
//     }
// }

// static int Sum(int a, int b){
//     return a+b;
// }

// static int Max(int a, int b){
//     if (a > b) return a;
//     else return b;
// }

// static long Factorial(int a){
//     int sum = 1;
//     for (int i = 1; i <= a; i++){
//         sum*=i;
//     }
//     return sum;
// }

Console.WriteLine($"Gcd(48, 18) = {GCD(48, 18)}");
Console.WriteLine($"Lcm(4, 6) = {LCM(4, 6)}");

static int GCD(int a, int b){
    while (b != 0){
    int N = b;
    b = a%b;
    a = N;
    }
    return a;
}

static int LCM(int a, int b){
    return a / GCD(a, b) * b;
    }