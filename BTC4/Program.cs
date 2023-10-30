// BÀI 1
// class phanso
// {
//     private int tuso,mauso,uc;
//     public int UC=1;
//     public void nhap()
//     {
//         Console.Write("Nhap tu so: ");
//         tuso=int.Parse(Console.ReadLine());
//         Console.Write("Nhap mau so: ");
//         mauso=int.Parse(Console.ReadLine());
//     }
//     public void UCLN()
//     {
//     for (int i = mauso;i>0;i--)
//         {
//             if (mauso%i==0 & tuso%i==0)
//             {
//             uc=i;
//                 break;
//             }
//         }
//     }
//     public void rutgon()
//     {
//         UCLN();
//         tuso=tuso/uc;
//         mauso=mauso/uc;
//     }
//     public void xuat()
//     {
//         Console.WriteLine("Phan so co tu so={0}, mauso={1}",tuso,mauso);
//     }
//     public phanso Tong(phanso q)
//     {
//         phanso kq = new phanso();  //chỉ hđ trong hàm tổng
//         kq.tuso=tuso*q.mauso+q.tuso*mauso;
//         kq.mauso=mauso*q.mauso;
//         kq.rutgon();
//         return kq;
//     }
//     public phanso Hieu(phanso q)
//     {
//         phanso kq = new phanso();
//         kq.tuso=tuso*q.mauso-q.tuso*mauso;
//         kq.mauso=mauso*q.mauso;
//         kq.rutgon();
//         return kq;
//     }
//     public phanso Tich(phanso q)
//     {
//         phanso kq = new phanso();  //chỉ hđ trong hàm tổng
//         kq.tuso=tuso*q.tuso;
//         kq.mauso=mauso*q.mauso;
//         kq.rutgon();
//         return kq;
//     }
//     public phanso Thuong(phanso q)
//     {
//         phanso kq = new phanso();
//         kq.tuso=tuso*q.mauso;
//         kq.mauso=mauso*q.tuso;
//         kq.rutgon();
//         return kq;
//     }
// class program
//     {
//         static void Main(string[] args)
//         {
//             phanso p = new phanso();
//             phanso q = new phanso();
//             p.nhap();
//             p.xuat();
//             q.nhap();
//             q.xuat();
//             Console.WriteLine("Tong cua 2 ps la {0}/{1}",p.Tong(q).tuso,p.Tong(q).mauso);
//             Console.WriteLine("Hieu cua 2 ps la {0}/{1}",p.Hieu(q).tuso,p.Hieu(q).mauso);
//             Console.WriteLine("Tich cua 2 ps la {0}/{1}",p.Tich(q).tuso,p.Tich(q).mauso);
//             Console.WriteLine("Hieu cua 2 ps la {0}/{1}",p.Thuong(q).tuso,p.Thuong(q).mauso);
//         }
//     }
// }



// //----------------------------------------------------------------

// // BÀI 2
// // class sophuc
// // {
// //     public double phanthuc, phanao;
// //     public void nhap()
// //     {
// //         Console.Write("Phan thuc: ");
// //         phanthuc=Double.Parse(Console.ReadLine());
// //         Console.Write("Phan ao: ");
// //         phanao=Double.Parse(Console.ReadLine());
// //     }
// //     public void xuat()
// //     {
// //         Console.WriteLine("So phuc co phan thuc={0}, phan ao={1}",phanthuc,phanao);
// //     }
// //     public sophuc Cong(sophuc s1)
// //     {
// //         sophuc kq=new sophuc();
// //         kq.phanthuc=phanthuc+s1.phanthuc;
// //         kq.phanao=phanao+s1.phanao;
// //         return kq;
// //     }
// //     public sophuc Tru(sophuc s1)
// //     {
// //         sophuc kq=new sophuc();
// //         kq.phanthuc=phanthuc-s1.phanthuc;
// //         kq.phanao=phanao-s1.phanao;
// //         return kq;
// //     }
// //     public sophuc Nhan(sophuc s1)
// //     {
// //         sophuc kq=new sophuc();
// //         kq.phanthuc=phanthuc*s1.phanthuc-phanao*s1.phanao;
// //         kq.phanao=phanao*s1.phanthuc+s1.phanao*phanthuc;
// //         return kq;
// //     }
// //     public sophuc Chia(sophuc s1)
// //      {
// //           sophuc kq=new sophuc(); //thuộc sính
// //           sophuc tam = new sophuc();
// //           sophuc s1lh = s1; //
// //           s1lh.phanao=-s1.phanao;
// //           tam=Nhan(s1lh);
// //           kq.phanthuc=Math.Round(tam.phanthuc/(s1.phanao*s1.phanao+s1.phanthuc*s1.phanthuc),2);
// //           kq.phanao=Math.Round(tam.phanao/(s1.phanao*s1.phanao+s1.phanthuc*s1.phanthuc),2);
// //           return kq;
// //      }
// // }
// // class program
// //     {
// //         public static void Main(string[]args)
// //         {
// //             sophuc s=new sophuc();
// //             sophuc s1=new sophuc();
// //             s.nhap();
// //             s.xuat();
// //             s1.nhap();
// //             s1.xuat();
// //             Console.WriteLine("Tong cua 2 so phuc la {0}+{1}i",s.Cong(s1).phanthuc,s.Cong(s1).phanao);
// //             Console.WriteLine("Hieu cua 2 so phuc la {0}+{1}i",s.Tru(s1).phanthuc,s.Tru(s1).phanao);
// //             Console.WriteLine("Tich cua 2 so phuc la {0}+{1}i",s.Nhan(s1).phanthuc,s.Nhan(s1).phanao);
// //             Console.WriteLine("Thuong cua 2 so phuc la {0}+{1}i",s.Chia(s1).phanthuc,s.Chia(s1).phanao);
// //         }
// //     }


// //----------------------------------------------------------------

// // // BÀI 3
// // class tamgiac
// // {
// //     public double a,b,c;
// //     public void nhap()
// //     {
// //         Console.Write("a=");
// //         a=double.Parse(Console.ReadLine());
// //         Console.Write("b=");
// //         b=double.Parse(Console.ReadLine());
// //         Console.Write("c=");
// //         c=double.Parse(Console.ReadLine());
// //     }
// //     public void xuat()
// //     {
// //         Console.WriteLine("Do dai ba canh tam giac la a={0}, b={1}, c={2}",a,b,c);
// //     }
// //     public void kiemtra()
// //     {
// //         if (a+b>c && b+c>a && c+a>b)
// //             if (a==b && b==c)
// //             {
// //                 Console.WriteLine("Day la tam giac deu");
// //             }
// //             else if (a==b || a==c || b==c)
// //             {
// //                 Console.WriteLine("Day la tam giac can");
// //             }
// //             else if (((c==Math.Sqrt(a*a + b*b)) || (a==Math.Sqrt(c*c + b*b)) || (b==Math.Sqrt(a*a + c*c))) && ((a==b || a==c || b==c)))
// //             {
// //                 Console.WriteLine("Day la tam giac vuong can");
// //             }
// //             else if ((c==Math.Sqrt(a*a + b*b)) || (a==Math.Sqrt(c*c + b*b)) || (b==Math.Sqrt(a*a + c*c)))
// //             {
// //                 Console.WriteLine("Day la tam giac vuong");
// //             }
// //             else
// //             {
// //                 Console.WriteLine("Day la tam giac thuong");
// //             }
// //         else
// //         {
// //             Console.WriteLine("Khong hop le !");
// //         }
// //     }
// //     class program
// //     {
// //         static void Main(string[]args)
// //         {
// //             tamgiac h=new tamgiac();
// //             h.nhap();
// //             h.xuat();
// //             h.kiemtra();
// //         }
// //     }
// // }

// //----------------------------------------------------------------

// // BÀI 4
// // class info
// // {
// //     public string id,hoten,group;
// //     public void nhap()
// //     {
// //         Console.Write("MSSV: ");
// //         id=Console.ReadLine();
// //         Console.Write("Ho ten: ");
// //         hoten=Console.ReadLine();
// //         Console.Write("Lop SH: ");
// //         group=Console.ReadLine();
// //     }
// // }
// // class DiemTp
// // {
// //     static public int dem=0;
// //     public info a = new info();
// //     public double tp1,tp2,tp3; private double TB;
// //     public DiemTp()
// //     {
// //         dem++;
// //     }
// //     public void Nhap()
// //     {
// //         Console.Write("TP1: ");
// //         tp1=Double.Parse(Console.ReadLine());
// //         Console.Write("TP2: ");
// //         tp2=Double.Parse(Console.ReadLine());
// //         Console.Write("TP3: ");
// //         tp3=Double.Parse(Console.ReadLine());
// //         TB=tp1*0.1+tp2*0.3+tp3*0.6;
// //     }
// //     public void xuat()
// //     {
// //         Console.WriteLine("Sinh vien {0}, MSSV {1}, Lop {2}",a.hoten,a.id,a.group);
// //         Console.WriteLine("Diem TB {0}",TB);
// //     }
// // }
// // class program
// // {
// //     static void Main(string[]args)
// //     {
// //         DiemTp[] ds = new DiemTp[2]; // tạo list nhập vào 2 đối tượng, DiemTP cx là kiểu dữ liệu
// //         ds[0]=new DiemTp(); //tạo đối tượng, 
// //         ds[0].a.nhap();
// //         ds[1]=new DiemTp();
// //         ds[1].a.nhap();
// //         Console.WriteLine("So luong sinh vien la {0}",DiemTp.dem);
// //         Console.WriteLine("{0},{1},{2}",ds[0].a.id,ds[0].a.hoten,ds[0].a.group);
// //         ds[0].Nhap();
// //         Console.WriteLine("{0},{1},{2}",ds[1].a.id,ds[1].a.hoten,ds[1].a.group);
// //         ds[1].Nhap();
// //         foreach(DiemTp i in ds) //foreach là for i in L
// //         {
// //             i.xuat();
// //         }
// //     }
// // }

// // class program
// // {
// //     public static void Main(string[]args)
// //     {
// //         DiemTp[] ds = new DiemTp[0]; //tạo ds đối tượng, lớp cũng là 1 kiểu dữ liệu, chưa nhập nên size=0
// //         DiemTp[] tam = new DiemTp[0]; //
// //         while(true)
// //         {
// //             tam=new DiemTp[ds.Length];
// //             Array.Copy(ds,tam,ds.Length); //copy dữ liệu ds sang tam
// //             ds = new DiemTp[ds.Length+1]; ///khi tạo 1 ds mới, sẽ mất đi all dữ liệu,nên phải 
// //             Array.Copy(tam,ds,tam.Length);
// //             ds[DiemTp.dem]=new DiemTp();
// //             ds[DiemTp.dem-1].a.nhap();
// //             Console.Write("Nhap 1 de tiep tuc: ");
// //             string tt = Console.ReadLine();
// //             if (tt != "1")
// //                 break;
// //         }
// //         Console.WriteLine("Co {0} sinh vien",DiemTp.dem);
// //         foreach(DiemTp i in ds)
// //         {
// //             Console.WriteLine("{0},{1},{2}",i.a.id,i.a.hoten,i.a.group); //tên đối tượng.thuộc tính, (a là thuộc tính của i, bản thân a cx là đối tượng)
// //             i.Nhap();
// //         }
// //         Console.WriteLine();
// //         foreach(DiemTp i in ds)
// //         {
// //             i.xuat();
// //         }
// //     }
// // }

// //----------------------------------------------------------------

// // BÀI 5

class Doanhnghiep 
{

    //properties - thuoc tinh
    public string tendn, mst, diachi;

    //constructor - ham khoi tao
    public Doanhnghiep(string tendn, string mst, string diachi) //ham khoi tao tham so
    {
        this.tendn = tendn;
        this.mst = mst;
        this.diachi = diachi; //this dung de goi thuoc tinh
    }
}

class DSDN
{
    Doanhnghiep[] danhsach = new Doanhnghiep[100]; //tao mang 1 chieu, mang doi tuong
    public int soluong;
    public void nhap()
    {
        Console.Write("Nhap ten DN: ");
        string tendn = Console.ReadLine();
        Console.Write("Nhap ma so thue: ");
        string mst = Console.ReadLine();
        Console.Write("Nhap dia chi: ");
        string diachi = Console.ReadLine();

        danhsach[soluong] = new Doanhnghiep(tendn, mst, diachi); //tai cau truc object, 
    }
    public void xuat()
    {
        for (int i = 0; i <= soluong; i++) 
        {
            Console.WriteLine("Doanh nghiep ten {0}, MST {1}, Dia chi {2}",danhsach[i].tendn, danhsach[i].mst, danhsach[i].diachi);
        }
    }
    public void timMST()
    {
        Console.Write("Nhap ten DN: ");
        string tendn = Console.ReadLine();
        for (int i = 0; i <= soluong; i++) 
        {
            if (tendn == danhsach[i].tendn)
            {
                Console.WriteLine("- MST: " + danhsach[i].mst);
                break;
            }
        }
    }
    public void tim()
    {
        Console.Write("Nhap MST: ");
        string mst = Console.ReadLine();
        for (int i = 0; i <= soluong; i++)
        {
            if (mst == danhsach[i].mst)
            {
                Console.WriteLine("- Ten DN: " + danhsach[i].tendn);
                Console.WriteLine("- Dia chi DN: " + danhsach[i].diachi);
                break;
            }
        }
    }

}

class program
{
    public static void Main(string[]args)
    {
        DSDN ds = new DSDN();
        ds.nhap();
        
        while (Console.ReadLine() != "c") 
        {
            ds.soluong += 1;

            ds.nhap();
        }
        ds.xuat();
        ds.timMST();
        ds.tim();
    }
}