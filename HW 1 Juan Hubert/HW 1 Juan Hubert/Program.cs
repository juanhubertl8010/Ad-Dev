using System;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;

public class carclass
{
    private string make;
    private string model;
    private int year;
    private double price;
    private string type;
    private string costumername;

    public string costumerrr
    {
        get { return costumername; }
        set { costumername = value; }
    }

    public string makee
    {
        get { return make; }
        set { make = value; }
    }
    public string modell
    {
        get { return model; }
        set { model = value; }
    }
    public int yearr
    {
        get { return year; }
        set { year = value; }
    }
    public double pricee
    {
        get { return price; }
                set
        {
            price = value;
        }
    }
    public string typee
    {
        get { return type; }
                set
        {
            type = value;
        }
    }
}
public class gasoline : carclass
{
    private int gastanksize;
    public int kapasitasgas
    {
        get { return gastanksize; }
        set { gastanksize = value; }
    }
}   
public class electric : carclass
{
        private int baterycapacity;
        public int kapasitasbaterai
        {
            get { return baterycapacity; }
            set { baterycapacity = value; }
        }
}
public class hybrid : carclass
{
    private int gastanksize;
    public int kapasitasgas
    {
        get { return gastanksize; }
        set { gastanksize = value; }
    }
    private int baterycapacity;
    public int kapasitasbaterai
    {
        get { return baterycapacity; }
        set { baterycapacity = value; }
    }
}
public class makesales:carclass
{
    private string costumername;
    private double pricepaid;

    public string costumernamee
    {
        get { return costumername; }
        set { costumername = value; }
    }
    public double pricepaidd
    {
        get { return pricepaid; }
        set { pricepaid = value; }


    }
}
    public class dealershipclass
    {
        private string namadealer;
        private string lokasi;
    public string namadealerr
    {
        get { return namadealer; }
        set { namadealer = value; }
    }
    public string lokasii
    {
        get { return lokasi; }
        set { lokasi = value; }
    }
        List<carclass> listclass = new List<carclass>();
    List<carclass> listkejual = new List<carclass>();
 List<carclass>namacostumerlist = new List<carclass>();
    public void Addgasolinecar()
        {
        gasoline gasolinee = new gasoline();
        Console.Write("Add Make: ");
        gasolinee.makee = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Add Model: ");
        gasolinee.modell = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Add Year: ");
        gasolinee.yearr = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Add Price: ");
        gasolinee.pricee = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Add Gas Capacity: ");
        gasolinee.kapasitasgas = Convert.ToInt32(Console.ReadLine());
        gasolinee.typee = "gasoline";
        listclass.Add(gasolinee);
        }
        public void Addelectriccar()
    {
        electric electricc = new electric();
        Console.Write("Add Make: ");
        electricc.makee = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Add Model: ");
       electricc.modell = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Add Year: ");
        electricc.yearr = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Add Price: ");
        electricc.pricee = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Add Baterai Capacity");
        electricc.kapasitasbaterai = Convert.ToInt32(Console.ReadLine());
        electricc.typee = "electric";
        listclass.Add(electricc);
    }
    public void Addhybridcar()
    {
        hybrid hybridd = new hybrid();
        Console.Write("Add Make: ");
        hybridd.makee = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Add Model: ");
        hybridd.modell = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Add Year: ");
        hybridd.yearr = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Add Price: ");
        hybridd.pricee = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Add Baterai Capacity");
        hybridd.kapasitasbaterai = Convert.ToInt32(Console.ReadLine());
        Console.Write("Add Gas Capacity: ");
        hybridd.kapasitasgas = Convert.ToInt32(Console.ReadLine());
        hybridd.typee = "hybrid";
        listclass.Add(hybridd);
    }
        public void RemoveCar(string makecar,string modellll)
        {
          foreach (var n in listclass.ToList()) 
            {
                if(n.makee== makecar && n.modell == modellll)
            {
                listclass.Remove(n);
            }
                else
            {
                Console.Write("Make: ");
                Console.WriteLine(n.makee);
                Console.Write("Model: ");
                Console.WriteLine(n.modell);
                Console.Write("Price: ");
                Console.WriteLine(n.pricee);
                Console.Write("Year: ");
                Console.WriteLine(n.yearr);
                Console.Write("Type: ");
                Console.WriteLine(n.typee);
            }

        }
        }
        public void ShowCar()
        {
           foreach( var n in listclass)
        {
            Console.Write("Make: ");
            Console.WriteLine(n.makee);
            Console.Write("Model: ");
            Console.WriteLine(n.modell);
            Console.Write("Price: ");
            Console.WriteLine(n.pricee);
            Console.Write("Year: ");
            Console.WriteLine(n.yearr);
            Console.Write("Type: ");
            Console.WriteLine(n.typee);
            Console.WriteLine();
        }
        }
    public void makesaless()
    {
        
        Console.WriteLine("Masukkan nama Costumer");
        makesales makesaleeeee = new makesales();
        makesaleeeee.costumerrr = Console.ReadLine();
        Console.WriteLine("masukkan nama pembuat mobil");
        makesaleeeee.makee = Console.ReadLine();
        Console.WriteLine("Masukkan model mobil");
        makesaleeeee.modell = Console.ReadLine();
        Console.WriteLine("Masukkan price paid");
        makesaleeeee.pricepaidd = Convert.ToDouble(Console.ReadLine());

        foreach (var n in listclass.ToList())
        {
            if(n.makee == makesaleeeee.makee && n.modell == makesaleeeee.modell)
            {
                n.costumerrr = makesaleeeee.costumerrr;
                listkejual.Add(n);
                listclass.Remove(n);
            }
        }
    }
    public void showsales()
    {
        foreach (var n in listkejual)
        {
            Console.Write("Costumer: ");
            Console.WriteLine(n.costumerrr);
            Console.Write("Make: ");
            Console.WriteLine(n.makee);
            Console.Write("Model: ");
            Console.WriteLine(n.modell);
            Console.Write("Price: ");
            Console.WriteLine(n.pricee);
            Console.Write("Year: ");
            Console.WriteLine(n.yearr);
            Console.Write("Type: ");
            Console.WriteLine(n.typee);
            Console.WriteLine();
        }

    }
   
    }
public class program
{
    public static void Menu()
    {
        Console.WriteLine("1. Add Car");
        Console.WriteLine("2. Remove Car");
        Console.WriteLine("3. Show Car List");
        Console.WriteLine("4. Make Sales");
        Console.WriteLine("5. Print Sales");
        Console.WriteLine("6. Exit");
        Console.WriteLine("pilih menuu: ");
    }
    public static void Menu1()
    {
        Console.WriteLine("1. Gasoline Car");
        Console.WriteLine("2. Electric Car");
        Console.WriteLine("3. Hybrid Car");
        Console.WriteLine("pilih nomor : ");
    }
    public static void Main()
    {
        int selesaimenu1 = 0;
        int selesaimenu2 = 0;
        int selesaimenu3 = 0;
        int selesaimenu4 = 0;
        int selesaimenu5 = 0; 
        int berhentitotal = 0;
        dealershipclass dealer = new dealershipclass();
        Console.Write("Add Dealer Name : ");
        dealer.namadealerr = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Add Dealer Location : ");
        dealer.lokasii = Console.ReadLine();
        Console.WriteLine("///////////////////////////");
        while (berhentitotal != 1)
        {
            selesaimenu1 = 0;
            selesaimenu3 = 0;
            selesaimenu2 = 0;
            selesaimenu4 = 0;
            selesaimenu5 = 0;
            Menu();
            int menuu = Convert.ToInt32(Console.ReadLine());
            if (menuu == 1)
            {
                while (selesaimenu1 != 1)
                {
                    Menu1();
                    int menuu1 = Convert.ToInt32(Console.ReadLine());
                    if (menuu1 == 1)
                    {
                        dealer.Addgasolinecar();
                        selesaimenu1 = 1;
                    }
                    if (menuu1 == 2)
                    {
                        dealer.Addelectriccar();
                        selesaimenu1 = 1;
                    }
                    if (menuu1 == 3)
                    {
                        dealer.Addhybridcar();
                        selesaimenu1 = 1;
                    }
                }
            }
                if(menuu==3)
                {
                    while (selesaimenu3 != 1)
                    {
                        dealer.ShowCar();
                        selesaimenu3 = 1;
                    }
                }
                if(menuu ==2)
            {
                while (selesaimenu2!=1)
                {
                    Console.WriteLine("Masukkan Nama Pembuat: ");
                    string namemake = Console.ReadLine();
                    Console.WriteLine("Masukkan Model:");
                    string modellll = Console.ReadLine();
                    dealer.RemoveCar(namemake,modellll);
                    selesaimenu2 = 1;
                }
                
            }
                if(menuu==4)
            {
                while (selesaimenu4!=1)
                {
                    dealer.makesaless();
                    selesaimenu4 = 1;

                }
            }
                if(menuu==5)
            {
                while(selesaimenu5!=1)
                {
                    dealer.showsales();
                    selesaimenu5 = 1;
                }
            }
                if(menuu==6) 
            {
                berhentitotal = 1;
            }
            
        }
        
        
    }
}
