//BÀI 1
// abstract class Hinhhoc
// {
//     abstract public void Chuvi();
//     abstract public void Dientich();
// } 
// class Hinhchunhat: Hinhhoc
// {
//     private double dai, rong;
//     public void Nhap()
//     {
//         Console.WriteLine("---HINH CHU NHAT---");
        // Console.Write("Nhap chieu dai HCN: ");
        // dai = double.Parse(Console.ReadLine());
        // Console.Write("Nhap chieu rong HCN: ");
        // rong = double.Parse(Console.ReadLine());
//     }
//     public override void Chuvi()
//     {
//         Console.WriteLine("Chu vi hinh chu nhat = " + (dai + rong) * 2);
//     }
//     public override void Dientich()
//     {
//         Console.WriteLine("Dien tich hinh chu nhat = " + (dai * rong));
//     }
// }
// class Hinhtron: Hinhhoc
// {
//     private double r, pi = 3.14;
//     public void Nhap()
//     {
//         Console.WriteLine("---HINH TRON---");
//         Console.Write("Nhap ban kinh hinh tron: ");
//         r = Convert.ToDouble(Console.ReadLine());
//     }
//     public override void Chuvi()
//     {
//         Console.WriteLine("Chu vi hinh tron = "+(2*pi*r));
//     }
//     public override void Dientich()
//     {
//         Console.WriteLine("Dien tich hinh tron = "+(pi*r*r));
//     }
// }
// class Hinhtamgiac: Hinhhoc
// {
//     private double a,b,c,P,S;
//     public void Nhap()
//     {
//         Console.WriteLine("---HINH TAM GIAC---");
        // Console.Write("Nhap a: ");
        // a=Convert.ToDouble(Console.ReadLine());
        // Console.Write("Nhap b: ");
        // b=Convert.ToDouble(Console.ReadLine());
        // Console.Write("Nhap c: ");
        // c=Convert.ToDouble(Console.ReadLine());
//     }
//     public override void Chuvi()
//     {
//         if (a+b>c & b+c>a & a+c>b)
//         {
//             Console.WriteLine("Chu vi hinh tam giac = "+(a+b+c));
//         }
//         else
//         {
//             Console.WriteLine("Thong tin khong hop le !!!");
//         }
//     }
//     public override void Dientich()
//     {
//         P=(a+b+c)/2;
//         S=Math.Sqrt(P*(P-a)*(P-b)*(P-c)); 
//         if (a+b>c & b+c>a & a+c>b)
//         {  
//             Console.WriteLine("Dien tich hinh tam giac = "+S);
//         }
//         else
//         {
//             Console.WriteLine("Thong tin khong hop le !!!");
//         }
//     }
// }
// class Hinhvuong: Hinhhoc
// {
//     private double canh;
//     public void Nhap()
//     {
//         Console.WriteLine("---HINH VUONG---");
//         Console.Write("Nhap canh cua hinh vuong: ");
//         canh=Convert.ToDouble(Console.ReadLine());
//     }
//     public override void Chuvi()
//     {
//         Console.WriteLine("Chu vi hinh vuong = "+(canh*4));
//     }
//     public override void Dientich()
//     {
//         Console.WriteLine("Dien tich hinh vuong = "+(canh*canh));
//     }
// }
// class Program
// {
//     static void Main (string[] args)
//     {
//         Hinhchunhat hcn = new Hinhchunhat();
//         hcn.Nhap();
//         hcn.Chuvi();
//         hcn.Dientich();
//         Hinhtron ht = new Hinhtron();
//         ht.Nhap();
//         ht.Chuvi();
//         ht.Dientich();
//         Hinhtamgiac htg = new Hinhtamgiac();
//         htg.Nhap();
//         htg.Chuvi();
//         htg.Dientich();
//         Hinhvuong hv = new Hinhvuong();
//         hv.Nhap();
//         hv.Chuvi();
//         hv.Dientich();
//     }
// }


//BÀI 2
// interface dieukhien
// {
//     void ON();
//     void OFF();
// }
// class Tivi: dieukhien
// {
//     public  void ON()
//     {
//         Console.WriteLine("TiVi đang mo");
//     }
//     public void OFF()
//     {
//         Console.WriteLine("TiVi đang tat");
//     }
// }
// class Quat: dieukhien
// {
//     public void ON()
//     {
//         Console.WriteLine("Quat đang mo");
//     }
//     public void OFF()
//     {
//         Console.WriteLine("Quat đang tat");
//     }
// }
// class Dieuhoa: dieukhien
// {
//     public void ON()
//     {
//         Console.WriteLine("Dieu hoa đang mo");
//     }
//     public void OFF()
//     {
//         Console.WriteLine("Dieu hoa đang tat");
//     }
// }
// class program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine(@"
//         ----KIEM TRA----
//         1. Dang mo
//         2. Dang tat
//         ");
//         Tivi tv = new Tivi();
//         Console.Write("Kiem Tra Tivi: ");
//         int n =int.Parse(Console.ReadLine());
//         if (n==1)
//         {
//             tv.ON();
//         }
//         else if (n==2)
//         {
//             tv.OFF();
//         }

//         Dieuhoa dh = new Dieuhoa();
//         Console.Write("Kiem Tra Dieu Hoa: ");
//         int a =int.Parse(Console.ReadLine());
//         if (a==1)
//         {
//             dh.ON();
//         }
//         else if(a==2)
//         {
//             dh.OFF();
//         }

//         Quat quat = new Quat();
//         Console.Write("Kiem tra Quat: ");
//         int q =int.Parse(Console.ReadLine());
//         if (q==1)
//         {
//             quat.ON();
//         }
//         else if(q==2)
//         {
//             quat.OFF();
//         }
//     }
// }

//BAI 3

// abstract class Edition
// {
//     public string title, author, year, publisher;
//     public string journal;
//     public string link,abstracts;
//     public virtual void CompareTo()
//     {
//         Console.Write("Ten Tac gia: ");
//         author = Console.ReadLine();
//     }
//     public void Xuat()
//     {
//         Console.Write("Tac gia {0}",author);
//     }
// }
// class Book:Edition
// {
//     public override void CompareTo()
//     {
//         base.CompareTo();
//         Console.Write("Ten sach: ");
//         title = Console.ReadLine();
//         Console.Write("Nam Xuat Ban: ");
//         year = Console.ReadLine();
//         Console.Write("Nha xuat ban: ");
//         publisher = Console.ReadLine();
//     }
//     public new void Xuat()
//     {
//         base.Xuat();
//         Console.WriteLine(", viet cuon sach {0}, xuat ban nam {1}, duoc nha xuat ban {2} phat hanh"
//         ,title,year,publisher);
//     }
// }
// class Article:Edition
// {
//     public override void CompareTo()
//     {
//         base.CompareTo();
//         Console.Write("Ten tieu de bai bao: ");
//         title = Console.ReadLine();
//         Console.Write("Tap chi: ");
//         journal = Console.ReadLine();
//         Console.Write("Nam Xuat Ban: ");
//         year = Console.ReadLine();
//     }
//     public new void Xuat()
//     {
//         base.Xuat();
//         Console.WriteLine(", tieu de bai bao {0}, cua tap chi {1}, duoc xuat ban nam {2}"
//         ,title,journal,year);
//     }
// }
// class OnlineResoure:Edition
// {
//     public override void CompareTo()
//     {
//         base.CompareTo();
//         Console.Write("Ten tieu de: ");
//         title = Console.ReadLine();
//         Console.Write("Lien ket: ");
//         link = Console.ReadLine();
//         Console.Write("Tom tat: ");
//         abstracts = Console.ReadLine();
//     }
//     public new void Xuat()
//     {
//         base.Xuat();
//         Console.WriteLine(", tieu de bai viet {0}, link dang nhap: {1}, tom tat bai viet {2}"
//         ,title,link,abstracts);
//     }
// }
// class  program
// {
//     static void Main(string[] args)
//     {

//             Book B = new Book();
//             Console.WriteLine("----BOOK----");
//             B.CompareTo();
//             B.Xuat();
//             Console.WriteLine("--------");
//             Article Ar = new Article();
//             Console.WriteLine("----Article----");
//             Ar.CompareTo();
//             Ar.Xuat();
//             Console.WriteLine("--------");    
//             OnlineResoure On = new OnlineResoure();
//             Console.WriteLine("----OnlineResoure----");
//             On.CompareTo();
//             On.Xuat();
//             Console.WriteLine("--------");                  
//     }
// } 

//BÀI 4

class Quanly
{
    private string name,cmnd;
    private double date;
    public double sum=0,gia,S=0;
    public string phong;
    public string Ten
    {
        get{return name;}
        set{name = value;}
    }
    public string CMND
    {
        get {return cmnd;}
        set {cmnd = value;}
    }
    public double Date
    {
        get {return date;}
        set {date = value;}
    }
    public virtual void Nhap()
    {
        Console.Write("Ten khach hang: ");
        Ten = Console.ReadLine();
        Console.Write("So CMND: ");
        CMND = Console.ReadLine();
        Console.Write("Ngay o: ");
        Date = double.Parse(Console.ReadLine());
    }
    public virtual void Xuat()
    {
        Console.WriteLine("Khach hang {0}, CMND {1}, O {2} ngay, Gia {3} do 1 ngay",Ten,CMND,Date,gia);
    }
}
class Standard:Quanly
{
    public override void Nhap()
    {
        base.Nhap();
        if (Date>5) {gia = 400;}
        else if (Date <= 5) {gia = 500;}
        sum=gia*Date;
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine("Tong so tien can thanh toan la: {0} do",sum);
    }

}
class VIP:Quanly
{
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Chon phong: ");
        phong = Console.ReadLine();
        if(phong=="Luxury")
        {
            if (Date<=5) {gia = 1100;}
            else if (Date >= 6) {gia = 1000;}
            sum=gia*Date;
        }
        else if(phong=="President")
        {
            if (Date<=5) {gia = 1300;}
            else if (Date >= 6) {gia = 1000;}
            sum=gia*Date;
        }
    }
    public override void Xuat()
    {
        if (phong=="Luxury" || phong=="President")
        {
            base.Xuat();
            Console.WriteLine("Tong so tien can thanh toan la: {0} do",sum);
        }
        else if(phong!="Luxury" || phong!="President")
        {
            Console.WriteLine("Khong ton tai phong dang nhap, phong VIP chi co 2 loai phong (Luxury and President).");
        }
    }
}
class program
{
    static void Main(string[] args)
    {
        Quanly QL = new Quanly();
        Standard S = new Standard();
        VIP V = new VIP();
        for(;true;)
        {
            Console.WriteLine(@"
            ---Nhap MENU--- 
            1. Standard
            2. Vip");
            int n = int.Parse(Console.ReadLine());
            if (n==1)
            {
                Console.WriteLine("----STANDARD----");
                S.Nhap();
                S.Xuat();
            }
            if (n==2)
            {
                Console.WriteLine("----VIP----");
                V.Nhap();
                V.Xuat();
            }
        }
    }
}
