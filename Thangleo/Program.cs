using System;
using System.IO;

class DanhsachThangleo
{
    public string[,] Thangleo = new string[60, 5];

    public void Nhapds()
    {
        int i = 0;
        string[] lines = File.ReadAllLines("Thangleo.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            for (int j = 0; j < 5 && j < parts.Length; j++)
            {
                Thangleo[i, j] = parts[j];
            }
            i++;
        }
    }

    public void Xuat()
    {
        int i, j;
        for (i = 0; i < 60; i++)
        {
            for (j = 0; j < 5; j++)
            {
                if (Thangleo[i, j] != null)
                {
                    Console.Write(Thangleo[i, j] + " ");
                }
            }
            Console.WriteLine();
            if (Thangleo[i + 1, 0] == null)
            {
                break;
            }
        }
    }

    public void Them()
    {
        int i;
        for (i = 0; i < 60; i++)
        {
            if (Thangleo[i, 0] == null)
            {
                Console.WriteLine("Nhap ma Thang muon them");
                Thangleo[i, 0] = Console.ReadLine();
                Console.Write("Ten LoaiThang :");
                Thangleo[i, 1] = Console.ReadLine();
                Console.Write("Chieu cao :");
                Thangleo[i, 2] = Console.ReadLine();
                Console.Write("So luong :");
                Thangleo[i, 3] = Console.ReadLine();
                Console.Write("Gia ban :");
                Thangleo[i, 4] = Console.ReadLine();
                break;
            }
        }
    }

    public void Tim()
    {
        int i = 0;
        Console.WriteLine(@"
                NHAP SO
                1. Tim theo MaThang
                2. Tim theo LoaiThang
                3. Tim theo chieu cao
                4. Tim theo So luong
                5. Tim theo gia ban
                0. EXIT
                ");
        string a = Console.ReadLine();
        string b;
        if (a == "1")
        {
            Console.Write("Nhap ten MaThang muon tim: ");
            b = Console.ReadLine();
            for (i = 0; i < 60; i++)
            {
                if (Thangleo[i, 0] == b)
                {
                    Console.WriteLine("Ma Thangleo " + Thangleo[i, 0] + " ,Loai Thang " + Thangleo[i, 1] + " ,Chieu cao " + Thangleo[i, 2] + " ,So luong " + Thangleo[i, 3] + " ,Gia ban " + Thangleo[i, 4]);
                    break; // Thêm break để dừng sau khi tìm thấy kết quả.
                }
            }
            if (i == 60)
            {
                Console.WriteLine("Khong co MaThang can tim!!!");
            }
        }
        // Các trường hợp tìm theo LoaiThang, chieu cao, So luong và gia ban cũng cần thêm break tương tự.
    }

    public void Kiemtra()
    {
        int i = 0;
        string a, b;
        Console.WriteLine("Nhap Ma Thang can tim: ");
        a = Console.ReadLine();
        Console.WriteLine("Nhap So luong can tim: ");
        b = Console.ReadLine();
        if (int.TryParse(b, out int soLuong))
        {
            for (i = 0; i < 60; i++)
            {
                if (Thangleo[i, 0] == a)
                {
                    if (int.TryParse(Thangleo[i, 3], out int soLuongThang))
                    {
                        if (soLuongThang >= soLuong)
                        {
                            Console.WriteLine("OK!");
                        }
                        else
                        {
                            Console.WriteLine("CHI CON " + soLuongThang + " THANG. KHONG DU HANG!!!");
                        }
                    }
                }
            }
            if (i == 60)
            {
                Console.WriteLine("Khong tim thay Ma Thang can kiem tra!");
            }
        }
        else
        {
            Console.WriteLine("So luong nhap khong hop le.");
        }
    }

    public void Sosanh()
    {
        int i, Max = int.MinValue, Min = int.MaxValue;
        string a, b;
        Console.Write("Nhap loai thang: ");
        a = Console.ReadLine();
        Console.Write("Nhap chieu cao: ");
        b = Console.ReadLine();
        for (i = 0; i < 60; i++)
        {
            if (int.TryParse(Thangleo[i, 1], out int loaiThang) && int.TryParse(Thangleo[i, 2], out int chieuCao))
            {
                if (loaiThang == int.Parse(a) && chieuCao == int.Parse(b))
                {
                    if (int.TryParse(Thangleo[i, 4], out int giaBan))
                    {
                        if (giaBan > Max)
                        {
                            Max = giaBan;
                        }
                        if (giaBan < Min)
                        {
                            Min = giaBan;
                        }
                    }
                }
            }
        }

        if (Max == int.MinValue)
        {
            Console.WriteLine("Khong co san pham thoa dieu kien.");
        }
        else
        {
            Console.WriteLine("Gia ban lon nhat: " + Max);
            Console.WriteLine("Gia ban nho nhat: " + Min);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        DanhsachThangleo a = new DanhsachThangleo();
        a.Nhapds();
        while (true)
        {
            Console.WriteLine("\nCHUONG TRINH QUAN LY THANG LEO");
            Console.WriteLine("***********************MENU************************");
            Console.WriteLine("*  1. Them moi danh sach.                           *");
            Console.WriteLine("*  2. Xuat danh sach.                                *");
            Console.WriteLine("*  3. Tim san pham.                                *");
            Console.WriteLine("*  4. Kiem tra.                               *");
            Console.WriteLine("*  5. So sanh.                               *");
            Console.WriteLine("*  0. Exit.                                         *");
            Console.WriteLine("***************************************************");
            Console.Write("Nhap tuy chon: ");
            string t = Console.ReadLine();
            if (t == "1")
            {
                Console.WriteLine("Them moi danh sach");
                a.Them();
                Console.WriteLine("Da them");
            }
            if (t == "2")
            {
                Console.WriteLine("Xuat danh sach");
                a.Xuat();
                Console.WriteLine("Da xuat");
            }
            if (t == "3")
            {
                Console.WriteLine("Tim san pham");
                a.Tim();
                Console.WriteLine("Da tim");
            }
            if (t == "4")
            {
                Console.WriteLine("Kiem tra");
                a.Kiemtra();
            }
            if (t == "5")
            {
                Console.WriteLine("So sanh");
                a.Sosanh();
            }
            if (t == "0")
            {
                break;
            }
        }
    }
}
