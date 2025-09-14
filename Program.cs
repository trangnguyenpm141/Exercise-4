using System;
internal class Exercise_04
{
    public static void Main(string[] args)
    {
        Ex01();
        Ex02();
        Ex03();
        Ex04();
        Ex05();
        Ex06();
    }
    // 1. Tim so lon nhat trong 3 so
    static void Ex01()
    {
        static int LargestNumber(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }
        Console.WriteLine("\nBai 1: Tim so lon nhat trong 3 so");
        Console.Write("Nhap so thu nhat: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Nhap so thu hai: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Nhap so thu ba: ");
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine($"So lon nhat trong 3 so la: {LargestNumber(num1, num2, num3)}");
    }

    // 2. Tinh giai thua
    static void Ex02()
    {
        static long Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("So phai la so khong am.");
            }
            if (n == 0)
            {
                return 1;
            }
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        Console.WriteLine("\nBai 2: Tinh giai thua");
        Console.Write("Nhap mot so nguyen khong am: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Giai thua cua {n} la: {Factorial(n)}");
    }

    // 3. Kiem tra so nguyen to
    static void Ex03()
    {
        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        Console.WriteLine("\nBai 3: Kiem tra so nguyen to");
        Console.Write("Nhap mot so nguyen: ");
        int n = int.Parse(Console.ReadLine());
        if (IsPrime(n))
        {
            Console.WriteLine($"{n} la so nguyen to.");
        }
        else
        {
            Console.WriteLine($"{n} khong phai la so nguyen to.");
        }
    }

    // 4. In ra cac so nguyen to
    static void Ex04()
    {
        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void PrintPrimesLessThan(int upperBound)
        {
            for (int i = 2; i < upperBound; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
        static void PrintFirstNPrimes(int n)
        {
            int count = 0;
            int number = 2;
            while (count < n)
            {
                if (IsPrime(number))
                {
                    Console.Write($"{number} ");
                    count++;
                }
                number++;
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nBai 4: In ra cac so nguyen to");
        Console.Write("Nhap mot so: ");
        int so = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Cac so nguyen to nho hơn " + so);
        PrintPrimesLessThan(so);
        Console.WriteLine(so + " so nguyen to dau tien:");
        PrintFirstNPrimes(so);
    }

    // 5. Kiem tra so hoan hao
    static void Ex05()
    {
        static bool IsPerfect(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            int sum = 1;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                    if (i * i != number)
                    {
                        sum += number / i;
                    }
                }
            }
            return sum == number;
        }
        static void PrintPerfectNumbersLessThan(int upperBound)
        {
            for (int i = 1; i < upperBound; i++)
            {
                if (IsPerfect(i))
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nBai 5: Kiem tra so hoan hao");
        Console.Write("Nhap mot so: ");
        int n = int.Parse(Console.ReadLine());
        if (IsPerfect(n))
        {
            Console.WriteLine($"{n} la so hoan hao.");
        }
        else
        {
            Console.WriteLine($"{n} khong phai la so hoan hao.");
        }
        Console.Write("Cac so hoan hao nho hon 1000: ");
        PrintPerfectNumbersLessThan(1000);
    }
    // 6. Kiem tra Pangram
    static void Ex06()
    {
        static bool is_pangram(string s)
        {
            string alp = " ";
            for (int i = 'a'; i <= 'z'; i++)
            {
                alp += (char)i;
            }
            Console.WriteLine(alp);
            s = s.ToLower();
            foreach (char c in alp)
            {
                if (!s.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
        Console.WriteLine("\nBai 6: Kiem tra Pangram");
        Console.Write("Nhap mo chuoi: ");
        string s = Console.ReadLine();
        if (is_pangram(s))
        {
            Console.WriteLine($"\"{s}\" la mot pangram.");
        }
        else
        {
            Console.WriteLine($"\"{s}\" khong phai la mot pangram.");
        }
    }
}
