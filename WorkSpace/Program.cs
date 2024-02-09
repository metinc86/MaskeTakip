using Business.Concrete;
using Etities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        Citizen citizen1 = new Citizen();

        citizen1.FirstName = "Metin";
        citizen1.LastName = "Canımoğlu";
        citizen1.DateOfBirth = 1986;
        citizen1.NationalIdentity = 12345678901; 

        PttManager pttManager = new PttManager(new CitizenManager());
        pttManager.GiveMask(citizen1);

        Console.ReadLine();
    }
}
