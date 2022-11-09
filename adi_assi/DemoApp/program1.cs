using Rentlib;
using System.Reflection;
delegate double Rent(int day,int nopersons);
class Program
{
    
    static void Main(string[] args)
    {
        int day = int.Parse(args[0]);
        int nopersons = int.Parse(args[1]);
        Type t = Type.GetType(args[2]);
        MethodInfo scheme = t.GetMethod(args[3]);
        object policy = Activator.CreateInstance(t);
        Rent rent = scheme.CreateDelegate<Rent>(policy);
        LuxuryTax md = scheme.GetCustomAttribute<LuxuryTax>();
        
        int m = md?.Limit ?? 10;
        double dailyRent = rent(day,nopersons);
        double total = (dailyRent+(dailyRent*m)/100);
        Console.WriteLine("Total tour expanse is {0}",total);
    }


}