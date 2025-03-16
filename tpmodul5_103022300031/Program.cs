public class Hallogeneric 
{
    public void SapaUser<T>(T user) 
    {
        Console.WriteLine("Hallo User " + user);
    }
}

public class program
{
    public static void Main() 
    {
        Hallogeneric sapa = new Hallogeneric();
        sapa.SapaUser("Thoriq");
    }
}