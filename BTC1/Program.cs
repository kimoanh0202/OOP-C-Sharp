// Bai 1
class Program
{
    static void Main(string[] args)
    {
        string xephang="";
        Console.Write("Nhap ho ten : ");
        string hoten=Console.ReadLine();
        Console.Write("Lop : ");
        string lop=Console.ReadLine();
        double[]diem=new double[4];
        Console.Write("Diem QTH = ");
        diem[0]=Convert.ToDouble(Console.ReadLine());
        Console.Write("Diem HTTTQL = ");
        diem[1]=Convert.ToDouble(Console.ReadLine());
        Console.Write("Diem CSLT = ");
        diem[2]=Convert.ToDouble(Console.ReadLine());
        Console.Write("Diem Triet = ");
        diem[3]=Convert.ToDouble(Console.ReadLine());
        double GPA=0; //biến, gán biến=0
        double[]Gpamon=new double[4];
        for (int i=0;i<=3;i++)
        {
            if (diem[i]<4)
                Gpamon[i]=0;
            else if (diem[i]<5.5)
                Gpamon[i]=1;
            else if (diem[i]<7)
                Gpamon[i]=2;
            else if (diem[i]<8.5)
                Gpamon[i]=3;
            else
                Gpamon[i]=4;
        GPA=GPA+Gpamon[i];
        }
        GPA=GPA/4;
        if (GPA<2)
            xephang="Yeu";
        else if (GPA<2.5)
            xephang="TB";
        else if (GPA<3.2)
            xephang="Kha";
        else if (GPA<3.6)
            xephang="Gioi";
        else
            xephang="Xuat sac";
    Console.WriteLine("Sinh vien {0}, Lop {1}, Dat GPA {2}, Xep loai {3}", hoten.ToUpper(), lop, GPA, xephang);
    }
}



// -----------------------------------------------------

// // BAI 2

// class Program
// {
//      static void Main(string[] args)
//      {
//           double a,b,dapan; 
//           string kitu;
//           while(true)
//           {
//                nhap(out a, out b, out kitu);
//                inkq(thuchien(a, b, kitu),a,b,kitu);
//                Console.Write("Tiep tuc: ");
//                string tieptuc=Console.ReadLine();
//                if (tieptuc=="T" || tieptuc=="t")
//                     break;
//           }
//      }
//      static void nhap(out double a, out double b, out string kitu)
//      {
//           Console.Write("a=");
//           a= Convert.ToDouble(Console.ReadLine());
//           Console.Write("b=");
//           b= Convert.ToDouble(Console.ReadLine());
//           Console.Write("Toan tu:");
//           kitu= Console.ReadLine();
//      }
//      static double thuchien(double a, double b, string kitu)
//      {
//           double dapan=0;
//           if (kitu=="+")
//                dapan=a+b;
//           else if (kitu=="-")
//                dapan=a-b;
//           else if (kitu=="*")
//                dapan=a*b;
//           else if (kitu=="/")
//                if (b!=0)
//                     dapan=a/b;
//           return dapan;      
//      }
//      static void inkq(double dapan, double a, double b, string kitu)
//      {
//           if (kitu=="*")
//                Console.WriteLine("a*b="+dapan);
//           else if (kitu=="-")
//                Console.WriteLine("a-b="+dapan);
//           else if (kitu=="+")
//                Console.WriteLine("a+b="+dapan);
//           else if (kitu=="/")
//                if (b!=0)
//                     Console.WriteLine("a/b="+dapan);
//      }
// }


// -----------------------------------------------------

// BAI 3
// class program
// {
//     static void Main(string[]args)
//     {
//         int i_max =0; int i_min = 0;
//         double Tong=0, Tich=1;
        
//         Console.Write("n=");
//         int n=int.Parse(Console.ReadLine());
//         double[]A=new double[n];
//         for (int i=0;i<n;i++)
//         {
//           A[i]=Convert.ToDouble(Console.ReadLine());
//         }
//         Console.Write("A= [");
//         for (int i=0;i<n;i++)
//         {
//             Console.Write(A[i]);
//             if (i != (n-1))
//                 Console.Write(",");
//         }
//         Console.WriteLine("]");
//         // int n = 10;
//         // double[] A= {2,-5,7.6,-12,6.5,-4.5,-9.1,-3.4,15,1};
//         for (int i=0;i<n;i++)
//         {
//             if (A[i]<0)
//                 Tong-=A[i]; //Tong=Tong-A[i]
//         }
//         Console.WriteLine("Tong = {0}",Tong);
        
//         for (int i=0;i<n;i++)
//         {
//             if (A[i]==A.Max())
//                 i_max=i;
//             else if (A[i]==A.Min())
//                 i_min=i;
//         }
//         for (int i=0;i<n;i++)
//         {
//             if (((i_max<i) & (i_min>i)) | ((i_max>i) & (i_min<i)))
//                 Tich*=A[i];
//         }
//         Console.WriteLine("Tich = {0}",Tich);

//         for (int i=0;i<n;i++) 
//         {
//             for (int j=i+1;j<n;j++) 
//             {
//                 if (A[i] > A[j]) 
//                 {
//                     double m=A[i];
//                     A[i]=A[j];
//                     A[j]=m;
//                 }
//             }
//         }
//         Console.Write("A_tang = [");
//         for (int i=0;i<n;i++)
//         {
//             Console.Write(A[i]);
//             if (i != (n-1))
//                 Console.Write(",");
//         }
//         Console.WriteLine("]");
//     }
// }
















// --------------------------------------------------------------------

// 3.
// class Program
// {
//      static void Main(string[] args)
//      {
//           Console.Write("n=");
//           int n = Convert.ToInt32(Console.ReadLine());
//           // int n = 8;
//           double[] A= new double[n];
//           // double[] A= {2,-5,7.6,-12,6.5,-4.5,-9.1,-3.4,15,1};
//           // double[] A= {6,17,-1,-2.5,-8,8.5,-3.5,5};
//           double[] B= new double [n];
//           double[] C= new double [n];
//           Random rand = new Random();
//           for (int i = 0; i<n; i++)
//           {
//               A[i]= Convert.ToDouble(Console.ReadLine());
//               // A[i]= Convert.ToDouble(rand.Next(-20,20));
//           }
//           Console.Write("A = [");
//           for (int i = 0; i<A.Length; i++)
//           {
//                Console.Write("{0}",A[i]);
//                if (i==A.Length-1)
//                     break;
//                Console.Write(",");
//           }
//           Console.WriteLine("]");

//           double tong= 0;
//           double tich= 1;
//           int i_max = 0;
//           int i_min = 0;
//           for (int i = 0; i<n; i++)
//                if (A[i]==A.Max())
//                {
//                     i_max = i;
//                     break;
//                }
//           for (int i = 0; i<n; i++)
//                if (A[i]==A.Min())
//                {
//                     i_min = i;
//                }
//           for (int i = 0; i<n; i++)
//           {
//                if (A[i]<0)
//                     tong-=A[i];
//                if ((i > i_min & i< i_max) | (i < i_min & i > i_max))
//                     tich*=A[i];
//           }
//           Console.WriteLine("Tong = {0}",tong);
//           Console.WriteLine("Tich = {0}",tich);

// // --------------------------------------
//           Array.Copy(A,B,n);
//           for (int i = 0; i < n; i++)
//           {
//                for (int j = i + 1; j < n; j++)
//                {
//                     if (B[i] > B[j])
//                     {
//                          double b = B[i];
//                          B[i] = B[j];
//                          B[j] = b;
//                     }
//                }
//           }
//           Console.Write("A_tang = [");
//           for (int i = 0; i<B.Length; i++)
//           {
//                Console.Write("{0}",B[i]);
//                if (i==B.Length-1)
//                     break;
//                Console.Write(",");
//           }
//           Console.WriteLine("]");

//           Array.Copy(A,C,n);
//           for (int i = 0; i < n; i++)
//           {
//                if (B[i]>=0)
//                     if (B[i]%1>=0.5)
//                          C[i]=Convert.ToInt32(B[i]-1+B[i]%1);
//                     else    
//                          C[i]=Convert.ToInt32(B[i]);
//                else
//                     if (B[i]%1<=-0.5)
//                          C[i]=Convert.ToInt32(B[i]-B[i]%1);
//                     else    
//                          C[i]=Convert.ToInt32(B[i]);
//           }
//           int[] C_final = new int[n];
//           int i_chan = 0;
//           foreach (int i in C)
//           {
//                if (i%2==0)
//                {
//                     C_final[i_chan]=i;
//                     i_chan++;
//                }     
//           }
//           int i_le = i_chan;
//           foreach (int i in C)
//           {
//                if (i%2!=0)
//                {
//                     C_final[i_le]=i;
//                     i_le++;
//                }
//           }

//           Console.Write("A_biendoi = [");
//           for (int i = 0; i<C_final.Length; i++)
//           {
//                Console.Write("{0}",C_final[i]);
//                if (i==C_final.Length-1)
//                     break;
//                Console.Write(",");
//           }
//           Console.WriteLine("]");
//      }
// }

//4.
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Bang dau bao gom bao nhieu doi: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         int[,] A = new int[n,n];
//         Random Rand = new Random();
//         for (int i = 0; i < n; i++)
//             for (int j = i+1; j < n; j++)
//             {
//                 // Console.Write("Doi {0} sau khi da voi doi {1} co bao nhieu diem: ",i+1,j+1);
//                 // A[i,j] = Convert.ToInt16(Console.ReadLine());
//                 A[i,j]=Rand.Next(0,3);
//                 if (A[i,j]==2)
//                     A[i,j]=3;
//                 if (A[i,j]==3)
//                     A[j,i]=0;
//                 else if (A[i,j]==1)
//                     A[j,i]=1;
//                 else if (A[i,j]==0)
//                     A[j,i]=3;
//                 A[i,i]=0;
//             }
//         Console.WriteLine("Cac doi co so diem la: ");
//         for (int i = 0; i < A.GetLength(0) ; i++)
//             {
//                 for (int j = 0; j < A.GetLength(1); j++)
//                 {
//                     Console.Write(A[i,j]+" ");
//                 }
//                 Console.WriteLine();
//             }
//         int max=1;
//         for (int i = 0; i < n ; i++)
//             if (diem(A,i)>diem(A,max))
//                 max=i+1;
//         Console.Write("Cac doi co diem cao nhat la: ");
//         for (int i = 0; i < n ; i++)
//             if (diem(A,i)==diem(A,max))
//                 Console.Write("{0} ",i+1);
//         Console.WriteLine();
//         Console.Write("Cac doi co so tran thang hon so tran thua la: ");
//         for (int i = 0; i < n ; i++)
//             if (thang(A,i)>thua(A,i))
//                 Console.Write("{0} ",i+1);
//         Console.WriteLine();
//         Console.Write("Cac doi khong thua tran nao la: ");
//         for (int i = 0; i < n ; i++)
//             if (thua(A,i)==0)
//                 Console.Write("{0} ",i+1);
//         Console.WriteLine();
//     }
//     static int thang(int[,] A,int i)
//     {
//         int dem =0;
//         for (int j = 0; j<A.GetLength(0); j++)
//         {
//             if (A[i,j]==3)
//                 dem++;
//         }
//         return dem;
//     }
//     static int thua(int[,] A,int i)
//     {
//         int dem =0;
//         for (int j = 0; j<A.GetLength(0); j++)
//         {
//             if (i==j)
//                 continue;
//             if (A[i,j]==0)
//                 dem++;
//         }
//         return dem;
//     }
//     static int hoa(int[,] A,int i)
//     {
//         int dem =0;
//         for (int j = 0; j<A.GetLength(0); j++)
//         {
//             if (A[i,j]==1)
//                 dem++;
//         }
//         return dem;
//     }
//     static int diem(int[,] A,int i)
//     {
//         int dem=thang(A,i)*3+hoa(A,i);
//         return dem;
//     }
// }


