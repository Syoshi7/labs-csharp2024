using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

internal class Programm
{
    public static void Main()
    {

        int num_zadanie;
        bool isValid_zadanie = false;
        bool continue_programm = true;

        {
            while (!isValid_zadanie)                  // проверка на ввод
            {
                Console.WriteLine("1. Дробная часть. 2. Букву в число. 3. Двузначное. 4. Диапазон. 5. Равенство.");    // да, можно было сделать в одну строку, но тогда код не будет видно
                Console.WriteLine("6. Модуль числа. 7. Тридцать пять. 8. Тройной максимум. 9. Двойная сумма. 10. День недели.");
                Console.WriteLine("11. Числа подряд. 12. Чётные числа. 13. Длина числа. 14. Квадрат. 15. Правый треугольник.");
                Console.WriteLine("16. Поиск первого значения. 17. Поиск максимального. 18. Добавление массива в массив. 19. Возвратный реверс. 20. Все вхождения.");
                Console.WriteLine("Введите число от 1 до 20, соответствующее номеру требуемого задания: ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out num_zadanie))
                {
                    if (num_zadanie >= 1 && num_zadanie <= 20)
                    {
                        isValid_zadanie = true;
                    }
                    else
                        Console.WriteLine("\nОшибка ввода. \n ");
                }
                else
                    Console.WriteLine("\nОшибка ввода.\n");


            switch (num_zadanie)
                {
                    case 1:
                        {
                            Console.WriteLine("Возвращаем только дробную часть числа.");
                            double a1;
                            while (true)
                            {
                                Console.WriteLine("Введите число х (типа double)");
                                string input1 = Console.ReadLine();

                                if (double.TryParse(input1, out double result1))
                                {
                                    a1 = result1;
                                    break;
                                }
                                else
                                    Console.WriteLine("Неверный ввод.");
                            }
                            Console.WriteLine("Вывод: " + fraction(a1));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Перевод соответствующего символа в соответствующее число");
                            while (true)
                            {
                                Console.WriteLine("Введите символ: ");
                                string input2 = Console.ReadLine();

                                if (char.TryParse(input2, out char result2) && (result2 >= '0') && (result2 <= '9'))
                                {
                                    Console.WriteLine("Вывод: " + charToNum(result2));
                                    break;
                                }
                                else
                                    Console.WriteLine("Неверный ввод");                                
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Проверка, является ли число х двузначным");
                            int x3 = IntEnter();
                            bool result3 = is2Digits(x3);
                            Console.WriteLine("Вывод: " + result3);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Проверить, входит ли число num в указанные границы между числами a и b");
                            Console.WriteLine("Число а");
                            int a4 = IntEnter();
                            Console.WriteLine("Число b");
                            int b4 = IntEnter();
                            Console.WriteLine("Число num");
                            int num = IntEnter();
                            bool result4 = isInRange(a4, b4, num);
                            Console.WriteLine("Вывод: " + result4);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Проверка, равны ли все три введённых числа.");
                            Console.WriteLine("Число а");
                            int a5 = IntEnter();
                            Console.WriteLine("Число b");
                            int b5 = IntEnter();
                            Console.WriteLine("Число c");
                            int c5 = IntEnter();
                            bool result5 = isEqual(a5, b5, c5);
                            Console.WriteLine("Вывод: " + result5);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Вывод модуля числа.");
                            int a6 = IntEnter();
                            int result6 = abs(a6);
                            Console.WriteLine("Вывод: " + result6);
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Тридцать пять. Проверка, делится ли число нацело на 5 или 3, и делится ли оно одновременно на 5 и 3");
                            int a7 = IntEnter();
                            bool result7 = is35(a7);
                            Console.WriteLine("Вывод: " + result7);
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Тройной максимум. Возвращаем из трёх чисел максимальное.");
                            Console.WriteLine("Первое число");
                            int a8 = IntEnter();
                            Console.WriteLine("Второе число");
                            int b8 = IntEnter();
                            Console.WriteLine("Третье число");
                            int c8 = IntEnter();
                            int result8 = max3(a8, b8, c8);
                            Console.WriteLine("Вывод: " + result8);
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Двойная сумма. Возвращаем сумму 1 и 2 числа, но если сумма лежит в диапазоне от 10 до 19, то возвращаем 20");
                            Console.WriteLine("Первое число");
                            int a9 = IntEnter();
                            Console.WriteLine("Второе число");
                            int b9 = IntEnter();
                            int result9 = sum2(a9, b9);
                            Console.WriteLine("Вывод: " + result9);
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("День недели. Возврат строки с днём недели, соответствующим введённому числу. Если число не от 1 до 7, то выводим, что введён не день недели.");
                            int a10 = IntEnter();
                            string result10 = day(a10);
                            Console.WriteLine("Вывод: " + result10);
                            break;
                        }
                    case 11:
                        {
                            Console.WriteLine("Возвращаем строку, в которой записаны все числа от x до 0");
                            int a11 = IntEnter();
                            string result11 = listNums(a11);
                            Console.WriteLine("Вывод: " + result11);
                            break;
                        }
                    case 12:
                        {
                            Console.WriteLine("Возвращаем строку, в которой записаны всё чётные числа от 0 до х, включительно");
                            int a12 = IntEnter();
                            string result12 = chet(a12);
                            Console.WriteLine("Вывод: " + result12);
                            break;
                        }
                    case 13:
                        {
                            Console.WriteLine("Возвращаем количество знаков в числе х");

                            long a13;
                            while (true)
                            {
                                Console.WriteLine("Введите число x (тип long)");
                                string input13 = Console.ReadLine();

                                if (long.TryParse(input13, out long result13))
                                {
                                    a13 = result13;
                                    break;
                                }
                                else
                                    Console.WriteLine("Неверный ввод.");

                            }
                            Console.WriteLine("Вывод: " + numLen(a13));
                            break;
                        }
                    case 14:
                        {
                            Console.WriteLine("Выводим на экран квадрат из звёздочек со стороной х");
                            int a14 = IntEnter();
                            square(a14);
                            break;
                        }
                    case 15:
                        {
                            Console.WriteLine("Выводим на экран правый треугольник из звёздочек, с основанием х");
                            int a15 = IntEnter();
                            rightTriangle(a15);
                            break;
                        }
                    case 16:
                        {
                            Console.WriteLine("Поиск первого значения. Возвращает индекс первого вхождения икса в массив arr.");
                            Console.WriteLine("Число х");
                            int a16 = IntEnter();
                            int[] arr16 = MassiveEnter();
                            Console.WriteLine("Вывод: " + findFirst(arr16, a16));
                            break;
                        }
                    case 17:
                        {
                            Console.WriteLine("Поиск максимального элемента в массиве по модулю.");
                            int[] arr17 = MassiveEnter();
                            Console.WriteLine("Вывод: " + maxAbs(arr17));
                            break;
                        }
                    case 18:
                        {
                            Console.WriteLine("Добавление массива в массив с указанием позиции, куда будет вставляться массив");
                            Console.WriteLine("Основной массив");
                            int[] arr18 = MassiveEnter();
                            Console.WriteLine("Массив, который будем вставлять");
                            int[] ins18 = MassiveEnter();
                            Console.WriteLine("Позиция, куда будет вставлен второй массив в первом. (считать с нуля)");
                            int pos = IntEnter();
                            int[] result18 = add(arr18, ins18, pos);
                            for (int i = 0; i < result18.Length; i++)
                                Console.Write(result18[i] + ",  ");
                            break;
                        }
                    case 19:
                        {
                            Console.WriteLine("Возвращаем ревёрснутый массив");
                            int[] arr19 = MassiveEnter();
                            int[] result19 = reverseBack(arr19);
                            for (int i = 0; i < result19.Length; i++)
                                Console.Write(result19[i] + ", ");
                            break;
                        }
                    case 20:
                        {
                            Console.WriteLine("Возвращается новый массив, в котором все элементы старого, кроме отрицательных.");
                            int[] arr20 = MassiveEnter();
                            int[] result20 = deleteNegative(arr20);
                            for (int i = 0; i < result20.Length; i++)
                                Console.Write(result20[i] + ", ");
                            break;
                        }
                    case 21:
                        continue_programm = false;
                        break;
                }
            }
        }
    }

    //////////////////////////////////////////////////

    public static int[] MassiveEnter()                            // метод для ввода массива и проверки всех чисел на ввод сразу же. господи помогите 
    
    {
        int lenght;

        while (true)
        {
            Console.WriteLine("Чему равна длина массива.");
            int len = IntEnter();

            if (len <= 0)
            {
                Console.WriteLine("Некорректная длина амссива.");
            }
            else
            {
                lenght = len;
                int[] arr = new int[len];
                Console.WriteLine("Заполните ваш массив");
                for (int i = 0; i < lenght; i++)
                {
                    arr[i] = IntEnter();
                }
                return arr;
            }
        }
    }

    public static int IntEnter()                         // Метод для проверки числа на правильность ввода.
    {
        int number;
        while (true)
        {
            Console.WriteLine("Введите целое число: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out number))
                return number;
            else
                Console.WriteLine("Ошибка ввода.");
        }
    }

    public static double fraction(double x)                               // 1
    {
        int IntegerPart = (int)x;
        double result = Math.Round(x - IntegerPart, 10);
        return result;
    }

    public static int charToNum(char x)                                   // 2
    {
        return x - '0';
    }

    public static bool is2Digits(int x)                                   // 3
    {
        return (x >= 10 && x <= 99) || (x >= -99 && x <= -10); 
    }

    public static bool isInRange(int a, int b, int num)                   // 4
    {
        int min = Math.Min(a, b);
        int max = Math.Max(a, b);

        return num >= min && num <= max;
    }

    public static bool isEqual(int a, int b, int c)                       // 5
    {
        return a == b && b == c;
    }

    ///////////////////////////////////////////////////

    public static int abs(int x)                                         // 6
    {
        if (x < 0)
            return -x;
        else
            return x;
    }

    public static bool is35(int x)   // 7
    {
        if (((x % 5 == 0) && (x % 3 != 0)) || ((x % 5 != 0) && (x % 3 == 0)))
            return true;
        else
            return false;
    }

    public static int max3(int x, int y, int z)  // 8
    {
        if ((x > y) && (x > z))
            return x;
        if ((y > x) && (y > z))
            return y;
        else
            return z;
    }

    public static int sum2(int x, int y)   // 9
    {
        if (x + y >= 10 && x + y <= 19)
            return 20;
        else
            return x + y;
    }

    public static String day(int x)   // 10
    {
        switch(x)
        {
            case 1:
                return "Понедельник";
            case 2:
                return "Вторник";
            case 3:
                return "Среда";
            case 4:
                return "Четверг";
            case 5:
                return "Пятница";
            case 6:
                return "Суббота";
            case 7:
                return "Воскресенье";
            default:
                return "Это не день недели";
        }
    }
    /////////////////////////////////////////////////////

    public static String listNums(int x)  // 11
    {
        string s = "";
        string s0 = "0";
        if (x <= 0)
        {
            return s0;
        }
        else
        {
            for (int i = x; i >= 0; i--)
            {
                s += i;
                s += " ";
            }
            return s;
        }
    }

    public static String chet(int x)  // 12
    {
        string s = "";
        string s0 = "0";
        if (x == 0)
        {
            return s0;
        }
        else
        {
            for (int i = 0; i <= x; i = i + 2)
            {
                s += i;
                s += " ";
            }
            return s;
        }
    }

    public static int numLen(long x)    // 13
    {
        int x_count = 0;
        while (Math.Abs(x) > 0)
        {
            x = x / 10;
            x_count++;
        }
        return x_count;
    }

    public static void square(int x)    // 14
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
                Console.Write('*');
            Console.WriteLine();
        }
    }

    public static void rightTriangle(int x)  // 15
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j <= x - i; j++)
            {
                Console.Write(' ');
            }
            for (int k = 0; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    ///////////////////////////////////////////////////////

    public static int findFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
    }

    public static int maxAbs(int[] arr)
    {
        int max = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (Math.Abs(arr[i]) > Math.Abs(max))
                max = arr[i];
        }
        return max;
    }

    public static int[] add(int[] arr, int[] ins, int pos)
    {
        int[] result = new int[arr.Length + ins.Length];
        Array.Copy(arr, 0, result, 0, pos);   // копируем до pos массиав аrr и вставляем его в резалт
        Array.Copy(ins, 0, result, pos, ins.Length); // копируем весь ins и вставляем его начиная с pos
        Array.Copy(arr, pos, result, pos + ins.Length, arr.Length - pos);  // добавляем оставшиеся элементы arr в резалт, индекс - pos + кол-во элементов в ins
        return result;
    }

    public static int[] reverseBack(int[] arr)
    {
        int[] reversedArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            reversedArr[i] = arr[arr.Length - 1 - i];
        }
        return reversedArr;
    }

    public static int[] deleteNegative(int[] arr)
    {
        int[] positiveArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
                positiveArr[i] = arr[i]; 
        }
        return positiveArr;
    }









}