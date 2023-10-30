//BÀI 1

// class hinhtron
// {
//     protected int r, d, dientich;
// }

// class hinhcau : hinhtron 
// {
//     public hinhcau(int r) //int r: tham chiếu
//     {
//         this.r = r;
//         this.d = r * 2;
//     }
//     public double tinhdientich()
//     {
//         return 4.0 * 3.14 * Math.Pow(r, 2);
//     }
//     public double tinhthetich() 
//     {
//         return (4.0 * 3.14 * Math.Pow(r, 3)) / 3;
//     }
// }
// class hinhtrutron : hinhtron
// {
//     int h;
//     public hinhtrutron(int r,int h)
//     {
//         this.r = r;
//         this.h = h;
//         this.d = r*2;
//     }
//     public double chuviday()
//     {
//         return 2*3.14*d;
//     }
//     public double dientichday()
//     {
//         return 2*3.14*Math.Pow(r,2);
//     }
//     public double dientichxq()
//     {
//         return dientichday()*h;
//     }
//     public double dientichtp()
//     {
//         return dientichday()*2+dientichxq();
//     }
//     public double thetich()
//     {
//         return 3.14*Math.Pow(r,2)*h;
//     }
// }
// class program
// {
//     static void Main(string[] args)
//     {
        
//         int n = int.Parse(Console.ReadLine());
//         hinhcau hc = new hinhcau(n);
//         int r = int.Parse(Console.ReadLine());
//         int h = int.Parse(Console.ReadLine());
//         hinhtrutron htc = new hinhtrutron(r,h);
//         Console.WriteLine(hc.tinhdientich() + " " + hc.tinhthetich());
//         Console.WriteLine(htc.chuviday() + " " + htc.dientichday()+ " " + htc.dientichxq()+ " " + htc.dientichtp()+ " " + htc.thetich());
//     }
// }


//CÁCH 2
// class HinhTron
//     {
//         public float BanKinh;
//         public float DuongKinh;
//         public double DienTich;
//         public HinhTron(float r)
//         {
//             BanKinh=r;
//             DuongKinh=2*r;
//             DienTich=Math.PI*(Math.Pow(r,2));
//         }
//         public void Xuat()
//         {
//             Console.Write("Hinh co ban kinh {0} cm, duong kinh {1} cm",BanKinh, DuongKinh);
//         }
//         public void XuatS()
//         {
//             Console.WriteLine(", dien tich {0} cm2.",Math.Round(DienTich,2));
//         }
//     }
//     class HinhCau: HinhTron
//     {
//         double sHinhCau;
//         double TheTichHinhCau;
//         public HinhCau(float r): base(r)
//         {
//             sHinhCau = 4*DienTich;
//             TheTichHinhCau = (4/3)*DienTich*r;
//         }
//         public new void Xuat()
//         {
//             base.Xuat();
//             Console.WriteLine(", dien tich mat cau {0} cm2, the tich hinh cau {1} cm3",Math.Round(sHinhCau,2),Math.Round(TheTichHinhCau,2));
//         }
//     }
//     class HinhTru: HinhTron
//     {
//         double cvDay;
//         double sDay;
//         double Sxq;
//         double Stp;
//         double ttHinhTru;
//         public HinhTru(float r, float h):base(r)
//         {
//             cvDay = 2*r*Math.PI;
//             sDay = DienTich;
//             Sxq  = 2*r*h*Math.PI;
//             Stp  = 2*sDay+Sxq;
//             ttHinhTru = sDay*h;
//         }
//         public new void Xuat()
//         {
//             base.Xuat();
//             Console.WriteLine(", chu vi mat day {0} cm, dien tich mat day {1} cm2, dien tich xung quanh {2} cm2, dien tich toan phan {3} cm2, the tich {4} cm3",Math.Round(cvDay,2),Math.Round(sDay,2),Math.Round(Sxq,2),Math.Round(Stp,2),Math.Round(ttHinhTru,2));
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Ban kinh hinh tron (cm): ");
//             float r_tron = float.Parse(Console.ReadLine());
//             HinhTron htron = new HinhTron(r_tron);
//             htron.Xuat();
//             htron.XuatS();
//             Console.Write("Ban kinh hinh cau (cm): ");
//             float r_cau = float.Parse(Console.ReadLine());
//             HinhCau hcau = new HinhCau(r_cau);
//             hcau.Xuat();
//             Console.Write("Ban kinh hinh tru (cm): ");
//             float r_tru = float.Parse(Console.ReadLine());
//             Console.Write("Chieu cao (cm): ");
//             float h = float.Parse(Console.ReadLine());
//             HinhTru htru = new HinhTru(r_tru,h);
//             htru.Xuat();
//         }
//     }

                                            


//BÀI 2
// class people
// {
//     protected string ID, Hoten, Diachi;
//     protected int Tuoi;
//     public people()
//     {

//     }
//     public void nhap()
//     {
//         Console.Write("ID: ");
//         ID=Console.ReadLine();
//         Console.Write("Ho ten: ");
//         Hoten=Console.ReadLine();
//         Console.Write("Tuoi: ");
//         Tuoi=int.Parse(Console.ReadLine());
//         Console.Write("Dia chi: ");
//         Diachi=Console.ReadLine();  
//     }
//     public void xuat()
//     {
//         Console.WriteLine("ID: {0}, Ho ten: {1}, Tuoi: {2}, Diachi: {3}",ID,Hoten,Tuoi,Diachi);
//     }
//     public void xuat(int index)
//     {
//         Console.WriteLine("ID: {0}, Ho ten: {1}, Tuoi: {2}, Diachi: {3}",ID,Hoten,Tuoi,Diachi);
//     }
// }  

// class Students : people
// {
//     private string Term, xephang; //thuộc tính
//     private double TP1,TP2,TP3,dtb, gpa;
//     public new void nhap()
//     {
//         base.nhap();
//         Console.Write ("Nhap ten mon hoc: ");
//         Term = Console.ReadLine();
//         Console.Write ("TP1 = ");
//         TP1 = double.Parse(Console.ReadLine());
//         Console.Write ("TP2 = ");
//         TP2 = double.Parse(Console.ReadLine());
//         Console.Write ("TP3 = ");
//         TP3 = double.Parse(Console.ReadLine());
//         dtb = (TP1 + TP2 + TP3)/3;
//         for(int i = 0; i < 4 ; i++)
//         {
//             if (8.5 <= dtb & dtb <= 10)  
//                 gpa=4;
//             else if (7 <= dtb & dtb <= 8.4) 
//                 gpa=3;
//             else if (5.5 <= dtb & dtb <= 6.9) 
//                 gpa=2;
//             else if (4 <= dtb & dtb <= 5.4) 
//                 gpa=1;
//             else gpa=0;
//         }
//         if (gpa >= 3.6)
//         {
//             xephang = ("Xuat Sac");
//         }
//         else if (3.2 <= gpa & gpa < 3.6)
//         {
//             xephang = ("Gioi");
//         }
//         else if (2.5 <= gpa & gpa < 3.2)
//         {
//             xephang = ("Kha");
//         }
//         else if (2 <= gpa & gpa < 2.5)
//         {
//             xephang = ("Trung Binh");
//         }
//         else if (gpa < 2)
//         {
//             xephang = ("Yeu");
//         }
//     }
//     public new void xuat()
//     {
//         base.xuat();
//         Console.Write("TP1: {0} diem, TP2: {1} diem, TP3: {2} diem, co diem TB la {3} diem",TP1,TP2,TP3,Math.Round(dtb,2));
//         Console.WriteLine(", Dat GPA: {0}, Xep xephang: {1} ",gpa,xephang);
//     }
// }

// class Lecture : people
// {
//     public string chucvu, hocvi;
//     public int sonamkinhnghiem;
//     public Lecture()
//     {
//         chucvu = "";
//         hocvi = "";
//         sonamkinhnghiem = 0;
//     }
//     public new void nhap()
//     {
//         base.nhap();
//         Console.Write("So nam kinh nghiem lam viec: ");
//         sonamkinhnghiem = int.Parse(Console.ReadLine());
//         Console.Write("Hoc vi dat duoc: ");
//         hocvi= Console.ReadLine();
//         Console.Write("Chuc vu cong viec: ");
//         chucvu = Console.ReadLine();
//     }
//     public new void xuat()
//     {
//         base.xuat();
//         Console.WriteLine("Chuc vu: {0}, Co hoc vi {1}, Co {2} nam kinh nghiem lam viec", chucvu, hocvi, sonamkinhnghiem);
//     }
//     /*
//     public void sapxep(Lecture[] nv)
//     {
//         Console.WriteLine(nv.Length);
//         for (int i = 0; i < nv.Length - 1; i++)
//         {
//             if (nv[i].sonamkinhnghiem > nv[i + 1].sonamkinhnghiem)
//             {
//                 Lecture temp = nv[i];
//                 nv[i] = nv[i + 1];
//                 nv[i + 1] = temp;
//             }
//         }
//     }*/
// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Students sv = new Students();
//         Lecture[] nv = new Lecture[100];
//         int soluong = 0;
//         while(true)
//         {
//             Console.WriteLine(@"
//             ---------MENU----------
//             1. Students
//             2. Lecture
//             0. Exit ");
//             Console.Write("Nhap tuy chon: ");
//             int n = int.Parse(Console.ReadLine());
//             if (n==1)
//             {
//                 sv.nhap();
//                 sv.xuat();
//             }
//             else if (n==2)
//             {
//                 nv[soluong] = new Lecture();
//                 nv[soluong].nhap();
//                 nv[soluong].xuat();
//                 soluong++;
//             }
//             else if (n==0)
//             {
//                 //nv[0].sapxep(nv);
//                 for (int i = 0; i <= soluong; i++)
//                 {
//                     nv[i].xuat();
                    
//                 }
//                 Console.WriteLine("EXIT");
//                 break;
//             }
//         }
//     }
// }
