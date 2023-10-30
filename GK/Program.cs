
class Toy
{
    public string [,] dochoi=new string[50,5];
    public void nhap()
    {
        int i=0,j=0;
        string[]input=File.ReadAllLines(@"toy.txt");
        foreach(string s in input)
        {
            j=0;
            string[] m=s.Split(";");
            foreach(string n in m)
            {
                if (j==5)
                {
                    break;
                }
            dochoi[i,j]=Convert.ToString(n);
            j++;
            }
        i++;
        }
    }
     public void them()
    {
        int i;
        for(i=0;i<50;i++)
        {
            if (dochoi[i,0]==null)
            {
                Console.Write("Ma SP: ");
                dochoi[i,0]=Console.ReadLine();
                Console.Write("TenSP: ");
                dochoi[i,1]=Console.ReadLine();
                Console.Write("Do tuoi: ");
                dochoi[i,2]=Console.ReadLine();
                Console.Write("Phan loai: ");
                dochoi[i,3]=Console.ReadLine();
                Console.Write("Gia ban: ");
                dochoi[i,4]=Console.ReadLine();
                break;
            }
        }
    }
    public void timvaxuat()
    {
        int i,j;
        Console.Write("Nhap phan loai do choi can tim: ");
        string a=Console.ReadLine();
        for (i=0;i<50;i++)
        {
            if (dochoi[i,3]==a)
            {
                Console.WriteLine("MaSP "+ dochoi[i,0]+" TenSP "+dochoi[i,1]+" Do tuoi "+dochoi[i,2]+" Phan loai "+dochoi[i,3]+" Gia ban "+dochoi[i,4]);
            }
        }
    }
}
class program
{
    static void Main(string[]args)
    {
        Toy dc=new Toy();
        dc.nhap();
        while (true)
        {
            Console.WriteLine(@"
            --------MENU--------
            1. Them moi danh sach
            2. Sap xep do choi theo gia
            3. Tim va xuat danh sach do choi
            0. EXIT
            -------------------");
            Console.Write("Nhap tuy chon: ");
            int k=Convert.ToInt32(Console.ReadLine());
            if (k==1)
            {
                dc.them();
            }
            else if (k==3)
            {
                dc.timvaxuat();
            }
            else if ((k!=3)&(k!=1)&(k!=0))
            {
                Console.WriteLine("Khong co tuy chon tren");
                Console.WriteLine("Vui long nhap lai!!!");
            }
            else if (k==0)
            {
                Console.WriteLine("EXIT. NO SEE YOU AGAIN!!!");
                break;
            }
        }
    }
}
