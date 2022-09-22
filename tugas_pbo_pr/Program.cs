using System.Runtime;
using System.Runtime.CompilerServices;

namespace TugasPBOPR1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ban ban1 = new Ban("Ban Michelin");
            Ban ban2 = new Ban("Ban Bridgestone");
            Mobil Mobil2 = new Avanza("Toyota", "Avanza", ban2);
            Mobil2.NyalakanMesin();
            Mobil2.MatikanMesin();
            ((Avanza)Mobil2).NyalakanLampu();
            Console.WriteLine(Mobil2.ban.merk);
            Console.WriteLine();
            Mobil Mobil1 = new Agya("Toyota", "Agya", ban1);
            Mobil1.NyalakanMesin();
            Mobil1.MatikanMesin();
            Console.WriteLine(Mobil1.ban.merk);
            Console.WriteLine();
            Mobil Civic1 = new Civic("Honda", "Civic", ban1);
            Civic1.NyalakanMesin();
            Civic1.MatikanMesin();
            ((Civic)Civic1).VtecKickedln();
            Console.WriteLine();
        }
    }
}

class Ban
{
    public string merk;
    public Ban(string merk)
    {
        this.merk = merk;
    }
}

class Michelin : Ban
{
    public Michelin(string merk) : base(merk)
    {
        merk = "Michelin";
    }
}

class Bridgestone : Ban
{
    public Bridgestone(string merk) : base(merk)
    {
        merk = "Bridgestone";
    }
}
class Mobil
{
    public string Merk;
    public string Tipe;
    public Ban ban;

    public Mobil(string merk, string tipe, Ban ban)
    {
        this.Merk = merk;
        this.Tipe = tipe;
        this.ban = ban;
    }

    public void NyalakanMesin()
    {
        Console.WriteLine($"Mesin mobil {this.Merk} bertipe {this.Tipe} menyala");
    }

    public void MatikanMesin()
    {
        Console.WriteLine($"Mesin mobil {this.Merk} bertipe {this.Tipe} mati");
    }
}

class Avanza : Toyota
{
    public Avanza(string merk, string tipe, Ban ban) : base("Toyota", tipe, ban)
    {
    }

    public void NyalakanLampu()
    {
        Console.WriteLine($"Lampu mobil {this.Merk} bertipe {this.Tipe} menyala");
    }
}

class Agya : Toyota
{
    public Agya(string merk, string tipe, Ban ban) : base(merk, "Agya", ban)
    {
    }

}

class Innova : Mobil
{
    public Innova(string merk, string tipe, Ban ban) : base(merk, "Innova", ban)
    {
    }

}

class Toyota : Mobil
{
    public Toyota(string merk, string tipe, Ban ban) : base("Toyota", tipe, ban)
    {
    }

}

class Ayla : Mobil
{
    public Ayla(string merk, string tipe, Ban ban) : base(merk, "Ayla", ban)
    {
    }

}

class Xenia : Mobil
{
    public Xenia(string merk, string tipe, Ban ban) : base(merk, "Xenia", ban)
    {
    }

}

class Daihatsu : Mobil
{
    public Daihatsu(string merk, string tipe, Ban ban) : base("Daihatsu", tipe, ban)
    {
    }

}

class Brio : Mobil
{
    public Brio(string merk, string tipe, Ban ban) : base(merk, "Brio", ban)
    {
    }

}

class Civic : Mobil
{
    public Civic(string merk, string tipe, Ban ban) : base(merk, "Civic", ban)
    {
    }

    public void VtecKickedln()
    {
        Console.WriteLine($"Ngeeeng Wooosh!!!");
    }

}
class Honda : Mobil
{
    public Honda(string merk, string tipe, Ban ban) : base("Honda", tipe, ban)
    {
    }

}