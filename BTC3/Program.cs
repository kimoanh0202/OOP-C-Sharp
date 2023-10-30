//Bai1
// class program
// {
//     static void Main(string[]args)
//     {
//         Sach s=new Sach();
//         s.Nhap();
//         s.Xuat();
//     }
// }
// class Sach
// {
//     public string Tensach;   //Tensach,tacgia...la thuoc tinh
//     public string Tacgia;
//     public int NamXB;
//     public int Soluong; 
//     public void Nhap()
//     {
//         Console.Write("Nhap ten sach: " );
//         Tensach=Console.ReadLine();
//         Console.Write("Nhap ten tac gia: " );
//         Tacgia=Console.ReadLine();
//         Console.Write("Nhap Nam Xuat Ban: " );
//         NamXB=int.Parse(Console.ReadLine());
//         Console.Write("Nhap So luong: " );
//         Soluong=int.Parse(Console.ReadLine());
//     }
//     public void Xuat()
//     {
//         Console.WriteLine("Sach {0} cua tac gia {1} xuat ban nam {2} co {3} quyen",Tensach, Tacgia, NamXB, Soluong);
//     }
//     ~Sach()
//     {
//         Console.WriteLine("doi tuong sach da bi huy");
//     }
// }

//-----------------------------------------------

//Bai2

// class Meo
// {
//     public string ten;   //Tensach,tacgia...la thuoc tinh
//     public string giong;
//     public string gioitinh;
//     public int tuoi; 
//     public static int Dem=0;
//     public void Nhap()
//     {
//         Console.Write("Nhap ten: " );
//         ten=Console.ReadLine();
//         Console.Write("Nhap giong: " );
//         giong=Console.ReadLine();
//         Console.Write("Nhap gioi tinh: " );
//         gioitinh=Console.ReadLine();
//         Console.Write("Nhap tuoi: " );
//         tuoi=int.Parse(Console.ReadLine());
//     }
//     public void Xuat()
//     {
//         Console.WriteLine("Meo ten {0} thuoc giong meo {1} co gioi tinh {2} va {3} tuoi",ten,giong,gioitinh,tuoi);
//     }
//     public Meo()
//     {
//         Dem++;
//     }
//     class program
//     {
//         static void Main(string[]args)
//         {
//             Meo m=new Meo();
//             m.Nhap();
//             m.Xuat();
//             Meo m2=new Meo();
//             m2.Nhap();
//             m2.Xuat();
//             Console.WriteLine("So meo:{0}",Meo.Dem);
//         }
//     }
//     ~Meo()
//     {
//         Console.WriteLine("doi tuong Meo da bi huy");
//     }
// }

// class Program
// {
//      static void Main(string[] args)
//      {
//           string tt;
//           Meo[] ds = new Meo[1];
//           Meo[] tam = new Meo[1];
//           for (tt="t";tt=="t";tt = Console.ReadLine())
//           {
//                ds[Meo.Dem] = new Meo();
//                ds[Meo.Dem-1].Nhap();
//                Console.Write("Tiep tuc bam t: ");
//                Them(ref tam,ref  ds);
//           }
//           Console.Write("Kiem tra danh sach meo bam t: ");
//           string kt = Console.ReadLine();
//           if (kt == "t")
//           {
//                for(int i = 0; i< Meo.Dem; i++)
//                {
//                     Console.Write("{0}. ",i+1);
//                     ds[i].Xuat();
//                }
//           }
//           Console.WriteLine("So meo: {0}",Meo.Dem);
//      }
//      static void Them(ref Meo[] tam,ref Meo[] ds)
//      {
//           tam = new Meo[ds.Length];
//           Array.Copy(ds, tam, ds.Length);
//           ds = new Meo[ds.Length+1];
//           Array.Copy(tam, ds, tam.Length);
//      }
//     }
// }

//-----------------------------------------------

//Bai 3
// class Organization
//     {
//         public string Name, Country, City, Address, Telephone;
//         public void Nhap()
//         {
//             Console.Write("Ten doanh nghiep: ");
//             Name = Console.ReadLine();
//             while (Name=="")
//             {
//                 Console.Write("Thong tin bi sai, vui long nhap lai: ");
//                 Name = Console.ReadLine();
//             }

//             Console.Write("Quoc gia: ");
//             Country = Console.ReadLine();
//             while (Country=="")
//             {
//                 Console.Write("Thong tin bi sai, vui long nhap lai: ");
//                 Country = Console.ReadLine();
//             }

//             Console.Write("Thanh pho: ");
//             City = Console.ReadLine();
//             while (City=="")
//             {
//                 Console.Write("Thong tin bi sai, vui long nhap lai: ");
//                 City = Console.ReadLine();
//             }

//             Console.Write("Dia chi: ");
//             Address = Console.ReadLine();
//             while (Address=="")
//             {
//                 Console.Write("Thong tin bi sai, vui long nhap lai: ");
//                 Address = Console.ReadLine();
//             }

//             Console.Write("So dien thoai: ");
//             Telephone = Console.ReadLine();
//             int t=1;
//             foreach (char i in Telephone)
//             {
//                 if (Char.IsNumber(i)!=true)
//                 {
//                     t=0;
//                     break;
//                 }
//             }
//             while (Telephone=="" | Telephone.Length<10 | t==0)
//             {
//                 Console.Write("Thong tin bi sai, vui long nhap lai: ");
//                 Telephone = Console.ReadLine();
//                 t=1;
//                 foreach (char i in Telephone)
//                 {
//                     if (Char.IsNumber(i)!=true)
//                     {
//                         t=0;
//                         break;
//                     }
//                 }
//             }
//         }
//          public void Xuat()
//         {
//           Console.WriteLine("Doanh nghiep ten {0} o quoc gia {1} thuoc thanh pho {2} co dia chi {3} va so dien thoai la {4}",Name,Country,City,Address,Telephone);
          
//         }
//     }
// class program
//     {
//         static void Main(string[] args)
//         {
//             Organization c = new Organization();
//             c.Nhap();
//             c.Xuat();
//         }
//     }


//-----------------------------------------------

//Bai 4
// class Triangle
// {
//     public int a,b,c;
//     public void nhap()
//     {
//         Console.Write("Canh a=");
//         a=int.Parse(Console.ReadLine());
//         Console.Write("Canh b=");
//         b=int.Parse(Console.ReadLine());
//         Console.Write("Canh c=");
//         c=int.Parse(Console.ReadLine());
//     }
//     public double cv,s;
//     public void tinh()
//     {
//         cv=a+b+c;
//         s=(Math.Sqrt((a+b+c)*(a+b-c)*(-a+b+c)*(a-b+c)))/4;
//     }
//     public void xuat()
//     {
//         if (a+b>c & b+c>a & a+c>b)
//         {
//             Console.WriteLine("Tam giac co do dai ba canh la a={0}, b={1}, c={2}",a,b,c);
//             Console.WriteLine("Chu vi tam giac={0}, Dien tich tam giac={1}",cv,s);
//         } 
//         else 
//         {
//             Console.WriteLine("Khong hop le!");
//         }
//     }
// }
// class program
// {
//     static void Main(string[]args)
//     {
//         Triangle t=new Triangle();
//         Console.Write("Menu");
//         Console.WriteLine("");
//         int i;
//         while(true)
//         {
//             Console.Write("Vui long chon chuc nang:");
//             i=int.Parse(Console.ReadLine());
//             if (i==1)
//             {
//                 t.nhap();
//             }
//             if (i==2)
//             {
//                 t.tinh();
//             }
//             if (i==3)
//             {
//                 t.tinh();
//                 t.xuat();
//             }
//             if (i==0)
//             {
//                 break;
//             }
//         }
//     }
// }