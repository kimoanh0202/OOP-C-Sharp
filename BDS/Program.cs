// //NHẬP XUẤT DANH SÁCH//
// //---------CÁCH 1-----------//
// // class BDS
// // {
// //     public string mabds; //nếu kh dùng public thì chỉ dùng trong mảng này được thôi
// //     public string tenbds,huong,diachi;
// //     public double dientich,giaban;
// //     public void xuat()
// //     {
// //         Console.WriteLine("{0} {1} {2} {3} {4} {5}",mabds,tenbds,huong,diachi,dientich,giaban);
// //     }
// // }
// // class DSBDS
// // {
// //     public static BDS[] ds=new BDS[0]; //danh sách đối tượng
// //     static public void nhap() //phương thức để nhập
// //     {
// //         String input = File.ReadAllText( @"E:\University\Semester 1 year 2\OOP\BT các chương\thongtinbds.txt"); 
// //         int i = 0, j = 0; 
// //         string[,] res = new string[100, 100]; //tạo mảng 2 chiều, số dòng 100, số cột 100, dòng trước cột sau
// //         foreach (var row in input.Split('\n')) //foreach giống for i in L, var là một kiểu dữ liệu, nhập dữ liệu vào hàng, input.split để ngăn cách từng dòng ra
// //         {
// //             j = 0;
// //             foreach (var col in row.Trim().Split(';')) //Trim là hàm xóa dấu cách ở 2 bên
// //             {
// //                 res[i, j]=col.Trim(); //i là hàng, j là cột
// //                 j++;
// //             }
// //             i++;
// //         }
// //         Console.WriteLine(i);
// //         ds=new BDS[i]; //tạo ds đối tượng mới có độ dài i
// //         for (int t=0;t<ds.GetLength(0);t++)
// //         {
// //             ds[t] = new BDS();
// //             ds[t].mabds = res[t,0];
// //             ds[t].tenbds = res[t,1];
// //             ds[t].huong = res[t,2];
// //             ds[t].diachi = res[t,3];
// //             ds[t].dientich = Convert.ToDouble(res[t,4]);
// //             ds[t].giaban = Convert.ToDouble(res[t,5]);
// //         }
// //     }
// //     public static void xuat()
// //     {
// //         foreach (BDS i in ds)
// //         {
// //             i.xuat();
// //         }
// //     }
// // }
// // class program
// // {
// //     static void Main(string[] args)
// //     {
// //         DSBDS dsbds = new DSBDS();
// //         DSBDS.nhap();
// //         DSBDS.xuat();
// //     }
// // }

// //---------CÁCH 2-----------//


// // class DanhsachBDS
// // {
// //     public string[,] BDS = new string[60, 6]; //tạo mảng 2 chiều, 60 dòng, 6 cột
// //     public void Nhapds()
// //     {
// //         int i = 0, j = 0;
// //         string[] input = File.ReadAllLines(@"test.txt"); 
// //         foreach (string s in input)
// //         {
// //             j = 0;
// //             string[] authorsList = s.Split(";");
// //             foreach (string author in authorsList)
// //             {
// //                 if (j == 6)
// //                 {
// //                     break;
// //                 }
// //                 BDS[i,j] = Convert.ToString(author);
// //                 j++;
// //             }
// //             i++;
// //         }
// //     }
// //     public void Xuat()
// //     {
// //         int i, j;
// //         for (i = 0; i < 60; i++)
// //         {
// //             for (j = 0; j < 6; j++)
// //             {
// //                 Console.Write(BDS[i, j] + " ");
// //             }
// //             Console.WriteLine();
// //             if (BDS[i+1,0]==null)
// //             {
// //                 break;
// //             }  
// //         }
// //     }
// // }
// // class program
// // {
// //     static void Main(string[] args)
// //     {
// //         DanhsachBDS a = new DanhsachBDS();
// //         a.Nhapds();
// //         a.Xuat();
// //     }
// // }


// //---------------TRỌN VẸN CẢ BÀI------------------
class DanhsachBDS
{
    public string[,] BDS = new string[60, 6]; //tạo mảng 2 chiều, 60 dòng, 6 cột
    public void Nhapds()
    {
        int i = 0, j = 0;
        string[] lines = File.ReadAllLines(@"test.txt");
        foreach (string s in lines)
        {
            j = 0;
            string[] authorsList = s.Split(";");
            foreach (string author in authorsList)
            {
                if (j == 6)
                {
                    break;
                }
                BDS[i,j] = Convert.ToString(author);
                j++;
            }
            i++;
        }
    }
    public void Xuat()
    {
        int i, j;
        for (i = 0; i < 60; i++)
        {
            for (j = 0; j < 6; j++)
            {
                Console.Write(BDS[i, j] + " ");
            }
            Console.WriteLine();
            if (BDS[i+1,0]==null)
            {
                break;
            }  
        }
    }
    public void Sua()
    {
        int i;
        Console.Write("Nhap ma BDS muon sua :");
        string a = Console.ReadLine();
        for (i = 0; i < 60; i++)
        {
            if (BDS[i,0]==a)
            {
                
                Console.Write("Ten BDS: ");
                BDS[i, 1] = Console.ReadLine();
                Console.Write("Huong: ");
                BDS[i, 2] = Console.ReadLine();
                Console.Write("Dia chi: ");
                BDS[i, 3] = Console.ReadLine();
                Console.Write("Dien tich: ");
                BDS[i, 4] = Console.ReadLine();
                Console.Write("Gia ban: ");
                BDS[i, 5] = Console.ReadLine();
                break;
                
            }    
            else if (BDS[i,0]!=a)
            {
                Console.WriteLine("Khong co ma BDS muon sua");
                break;
            }
        } 
    }
    public void Them()
    {
        int i;
        string a;
        for (i = 0; i < 60; i++)
        {
            if (BDS[i, 0] ==null)
            {
                Console.WriteLine("Nhap ma BDS muon them");
                BDS[i, 0] = Console.ReadLine();
                Console.Write("Ten BDS :");
                BDS[i, 1] = Console.ReadLine();
                Console.Write("Huong :");
                BDS[i, 2] = Console.ReadLine();
                Console.Write("Dia chi :");
                BDS[i, 3] = Console.ReadLine();
                Console.Write("Dien tich :");
                BDS[i, 4] = Console.ReadLine();
                Console.Write("Gia ban :");
                BDS[i, 5] = Console.ReadLine();
                break;
                
            }
            
        }  

    }
    public void TimtheoTen()
    {
        int i = 0;
        string a;
        Console.Write("Nhap ten BDS muon tim :");
        a = Console.ReadLine();
        for (i = 0; i < 60; i++)
        {
            if (BDS[i, 1] == a)
            {
                Console.WriteLine("Ma BDS " + BDS[i, 0] + " ,Ten BDS " + BDS[i, 1] + " ,Huong BDS " + BDS[i, 2] + " ,Dia chi " + BDS[i, 3] + " ,Dien tich " + BDS[i, 4] + " ,Gia ban BDS " + BDS[i, 5]);
            } 
            else if (BDS[i, 1] != a) 
            {
                Console.WriteLine("Khong co ten BDS can tim");
                break;
            }
        }  

    }
    public void XoatheomaBDS()
    {
        
        Console.Write("Nhap ma BDS muon xoa :");
        string a = Console.ReadLine();
        for (int i = 0; i < 60; i++)
        {
            if (BDS[i,0]==a)
            {
                BDS[i, 0] = "";
                BDS[i, 1] = "";
                BDS[i, 2] = "";
                BDS[i, 3] = "";
                BDS[i, 4] = "";
                BDS[i, 5] = "";
                break;
                Console.WriteLine("Da xoa BDS ma so " + a);
            } 
            else if (BDS[i, 0] != a) 
            {
                Console.WriteLine("Khong co ma bds muon xoa");
                break;
            }   
        }

    }
    public void TimtheoHuong()
    {
        int i = 0;
        string a;
        Console.Write("Nhap huong BDS muon tim :");
        a = Console.ReadLine();
        for (i = 0; i < 60; i++)
        {
            if (BDS[i, 2] == a)
            {
                Console.WriteLine("Ma BDS " + BDS[i, 0] + " ,Ten BDS " + BDS[i, 1] + " ,Huong BDS " + BDS[i, 2] + " ,Dia chi " + BDS[i, 3] + " ,Dien tich " + BDS[i, 4] + " ,Gia ban BDS " + BDS[i, 5]);
            }
            else if (BDS[i, 2] != a) 
            {
                Console.WriteLine("Khong co huong bds muon tim");
                break;
            }  
            
        }
    }
    public void TimtheoGia()
    {
        int i = 0;
        int j = 0;
        double a,b,tmp;
        double[] B= new double[60];
        Console.WriteLine("BDS ban muon tim nam trong khoang gia:");
        Console.Write("Tu: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Den: ");
        b = Convert.ToDouble(Console.ReadLine());
        for (i = 0; i < 60; i++)
        {
            B[i] = 0;
        }    
        for (i = 0; i < 60; i++)
        {
            if ((a <= Convert.ToDouble(BDS[i, 5])) & (Convert.ToDouble(BDS[i, 5]) <= b))
            {
                B[j] = Convert.ToDouble(BDS[i, 5]);
                j++;
            }
        }    
        for (i = 0; i < 60; i++)
        {
            for (j = i + 1; j < 60; j++)
            {
                if (B[j] < B[i])
                {
                    tmp = B[i];
                    B[i] = B[j];
                    B[j] = tmp;
                }
            }
        }
        for (i = 0; i < 60; i++)
        {
            for (j = i + 1; j < 60; j++)
            {
                if ((B[j] == B[i])&(B[j] != 0))
                {
                    B[j] = 0;
                }
            }
        }

        foreach (double q in B)
        {
            if (q==0)
            {
                continue;
            }    
            for (i = 0; i < 60; i++)
            {
                if (Convert.ToDouble(BDS[i, 5]) == q)
                {
                    Console.WriteLine("Ma BDS " + BDS[i, 0] + " ,Ten BDS " + BDS[i, 1] + " ,Huong BDS " + BDS[i, 2] + " ,Dia chi " + BDS[i, 3] + " ,Dien tich " + BDS[i, 4] + " ,Gia ban BDS " + BDS[i, 5]);
                }
            }
        }
    }
}
class program
{
    static void Main(string[] args)
    {
        DanhsachBDS a = new DanhsachBDS();
        a.Nhapds();
        while (true) //lặp vô tận
        {
            Console.WriteLine("\nCHUONG TRINH QUAN LY BDS C#");
            Console.WriteLine("***********************MENU************************");
            Console.WriteLine("*  1. Them moi danh sach.                           *");
            Console.WriteLine("*  2. Sua thong tin.                                *");
            Console.WriteLine("*  3. Xoa thong tin.                                *");
            Console.WriteLine("*  4. Xuat danh sach.                               *");
            Console.WriteLine("*  5. Tim theo ten.                                 *");
            Console.WriteLine("*  6. Tim theo huong.                               *");
            Console.WriteLine("*  7. Tim theo gia.                                 *");
            Console.WriteLine("*  0. Exit.                                         *");
            Console.WriteLine("***************************************************");
            Console.Write("Nhap tuy chon: ");
            int t = Convert.ToInt32(Console.ReadLine());
            if (t == 1)
            {
                Console.WriteLine("-----------Them moi danh sach-----------");
                a.Them();
                Console.WriteLine("-----------Them BDS thanh cong----------");
            }
            else if (t == 2)
            {
                Console.WriteLine("-----Sua Bat Dong San-----");
                a.Sua();
                Console.WriteLine("--------------------------");
            }
            else if (t == 3)
            {
                Console.WriteLine("-----Xoa Bat dong san-----");
                a.XoatheomaBDS();
                Console.WriteLine("--------------------------");
            }
            else if (t == 4)
            {
                Console.WriteLine("-----Xuat danh sach BDS-----");
                a.Xuat();
                Console.WriteLine("----------------------------");
            }
            else if (t == 5)
            {
                Console.WriteLine("-----Tim BDS the0 ten-----");
                a.TimtheoTen();
                Console.WriteLine("--------------------------");
            }
            else if (t == 6)
            {
                Console.WriteLine("-----Tim BDS theo huong-----");
                a.TimtheoHuong();
                Console.WriteLine("----------------------------");
            }
            else if (t == 7)
            {
                Console.WriteLine("-----Tim BDS theo gia-----");
                a.TimtheoGia();
                Console.WriteLine("--------------------------");
            }
            else if ((   t != 7) & (   t != 6) & (   t != 5) & (   t != 4) & (   t != 3) & (   t != 2) & (   t != 1) & (   t != 0))
            {
                Console.WriteLine("-----Cau lenh khong co trong menu!!!!-----");
                Console.WriteLine("-----Moi nhap lai!!!-----");
            }
            else if (   t == 0)
            {
                Console.WriteLine("-----Tam biet !!!!!!!!-----");
                break;
            }
        }
    }
}