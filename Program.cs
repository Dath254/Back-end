using System;

class Program
{
    static void Bai1()
    {
        Console.Write("Nhap ten: ");
        string ten = Console.ReadLine();

        try
        {
            Console.Write("Nhap tuoi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine($"Xin chao {ten}, ban {tuoi} tuoi!");
        }
        catch
        {
            Console.WriteLine("Tuoi phai la so nguyen!");
        }
    }

    static void Bai2()
    {
        try
        {
            Console.Write("Nhap chieu dai: ");
            double dai = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            double rong = double.Parse(Console.ReadLine());
            Console.WriteLine($"Dien tich la: {dai * rong}");
        }
        catch
        {
            Console.WriteLine("Chieu dai va chieu rong phai la so!");
        }
    }

    static void Bai3()
    {
        try
        {
            Console.Write("Nhap nhiet do C: ");
            double c = double.Parse(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine($"Nhiet do F la: {f}");
        }
        catch
        {
            Console.WriteLine("Ban phai nhap mot so!");
        }
    }

    static void Bai4()
    {
        try
        {
            Console.Write("Nhap so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 2 == 0 ? "So chan" : "So le");
        }
        catch
        {
            Console.WriteLine("Ban phai nhap so nguyen!");
        }
    }

    static void Bai5()
    {
        try
        {
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tong: {a + b}, Tich: {a * b}");
        }
        catch
        {
            Console.WriteLine("Hai gia tri phai la so nguyen!");
        }
    }

    static void Bai6()
    {
        try
        {
            Console.Write("Nhap so: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
                Console.WriteLine("So duong");
            else if (n < 0)
                Console.WriteLine("So am");
            else
                Console.WriteLine("So 0");
        }
        catch
        {
            Console.WriteLine("Ban phai nhap mot so nguyen!");
        }
    }

    static void Bai7()
    {
        try
        {
            Console.Write("Nhap nam: ");
            int nam = int.Parse(Console.ReadLine());
            if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                Console.WriteLine($"{nam} la nam nhuan");
            else
                Console.WriteLine($"{nam} khong phai la nam nhuan");
        }
        catch
        {
            Console.WriteLine("Ban phai nhap mot so nguyen!");
        }
    }

    static void Bai8()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\nBang cuu chuong {i}");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
        }
    }

    static void Bai9()
    {
        try
        {
            Console.Write("Nhap so nguyen duong: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("n phai la so duong!");
                return;
            }
            long gt = 1;
            for (int i = 1; i <= n; i++)
                gt *= i;
            Console.WriteLine($"Giai thua cua {n} la: {gt}");
        }
        catch
        {
            Console.WriteLine("Ban phai nhap mot so nguyen!");
        }
    }

    static void Bai10()
    {
        try
        {
            Console.Write("Nhap so: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine("Khong phai so nguyen to");
                return;
            }

            bool nt = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    nt = false;
                    break;
                }
            }
            Console.WriteLine(nt ? "La so nguyen to" : "Khong phai so nguyen to");
        }
        catch
        {
            Console.WriteLine("Ban phai nhap mot so nguyen!");
        }
    }
    static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("\n==== MENU ====");
            Console.WriteLine("1. Chao nguoi dung");
            Console.WriteLine("2. Tinh dien tich hinh chu nhat");
            Console.WriteLine("3. Chuyen doi C -> F");
            Console.WriteLine("4. Kiem tra so chan/le");
            Console.WriteLine("5. Tinh tong va tich hai so");
            Console.WriteLine("6. Kiem tra so am/duong/0");
            Console.WriteLine("7. Kiem tra nam nhuan");
            Console.WriteLine("8. In bang cuu chuong 1–10");
            Console.WriteLine("9. Tinh giai thua");
            Console.WriteLine("10. Kiem tra so nguyen to");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon chuc nang (0-10): ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Bai1(); break;
                case 2: Bai2(); break;
                case 3: Bai3(); break;
                case 4: Bai4(); break;
                case 5: Bai5(); break;
                case 6: Bai6(); break;
                case 7: Bai7(); break;
                case 8: Bai8(); break;
                case 9: Bai9(); break;
                case 10: Bai10(); break;
                case 0: Console.WriteLine("Thoat chuong trinh."); break;
                default: Console.WriteLine("Lua chon khong hop le!"); break;


            }
        } while (choice != 0);
    }

   
}