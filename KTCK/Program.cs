abstract class DICHVU
{
  public string tenkhach, diemnhan, diemden;
  public double khoangcach, dongia, giamgia;
  public virtual void nhap()
  {
    Console.Write("Ten khach: ");
    tenkhach = Console.ReadLine();
    Console.Write("Diem nhan: ");
    diemnhan = Console.ReadLine();
    Console.Write("Diem den: ");
    diemden = Console.ReadLine();
    Console.Write("Khoang cach: " );
    khoangcach = double.Parse(Console.ReadLine());
    Console.Write("Don gia: " );
    dongia = double.Parse(Console.ReadLine());
    Console.Write("Giam gia: ");
    giamgia= double.Parse(Console.ReadLine());
  }
  public virtual void phidichvu()
  {
      Console.WriteLine("Phi DV = ");
  }
}
 //tao lop xe may ke thua dich vu
class xemay : DICHVU
{
  double pdv;
  public override void nhap()
  {
    base.nhap();
  }
  public override void phidichvu()
  {
    base.phidichvu();
    pdv = khoangcach * dongia - giamgia;
    Console.WriteLine (pdv);
  }
}
//tao lop o to ke thua dich vu
class oto : DICHVU
{
  int loaixe;
  double hesoloaixe, pvd1;
  public override void nhap()
  {
    base.nhap();
    Console.Write("Loai xe: ");
    loaixe = int.Parse(Console.ReadLine());
    if (loaixe == 4)
    {
      hesoloaixe = 1;
    }
    else if (loaixe == 7)
    {
      hesoloaixe = 1.5;
    }
  }
  public override void phidichvu()
  {
    base.phidichvu();
    pvd1 = (khoangcach * dongia) * hesoloaixe - giamgia;
    Console.WriteLine(pvd1);
  }
}
class giaohang : DICHVU
{
  double giasp, pdv3;
  public override void nhap()
  {
    base.nhap();
    Console.Write("Gia SP: ");
    giasp = double.Parse(Console.ReadLine());
  }
  public override void phidichvu()
  {
    base.phidichvu();
    pdv3 = giasp + khoangcach * dongia - giamgia;
    Console.WriteLine(pdv3);
  }
}
class program
{
  static void Main(string[]args)
  {
    // xemay [] sxm = new xemay [100];
    // oto [] sot = new oto [100];
    // giaohang [] sgh = new giaohang [100];
    int n = 0;
    
    while (n!=3)
    {
      Console.WriteLine(@"
      ---- QUAN LY DICH VU ----
      1. Xe may
      2. O to
      3. Giao hang
      0. Ket thuc");
      n = int.Parse(Console.ReadLine());
      if (n==1)
      {
        xemay xm = new xemay();
        xm.nhap();
        xm.phidichvu();
      }
      else if (n==2)
      {
        oto o = new oto();
        o.nhap();
        o.phidichvu();
      }
      else if (n==3)
      {
        giaohang gh = new giaohang();
        gh.nhap();
        gh.phidichvu();
      }
      else if (n==0)
      {
      Console.WriteLine("KET THUC DICH VU!");
      } 
      break;
    }
  }
}