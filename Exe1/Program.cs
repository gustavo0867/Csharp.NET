public static void CheckAge(int Age)
{
   if (Age < 18) throw new AccessViolationException("Pessoa menor de idade");

}


public static void Main(string[] args)
{
    try
    {
        InitialGreeting();
        int year = Convert.ToInt32(Console.ReadLine());
        var age = CalculateAgeByYear(year);
        Console.WriteLine("Idade: " + age);
        CheckAge(age);
    }
    catch(AccessViolationException err)
    {
        Console.WriteLine("Erro de permissão: " + err.Message);
    }
    catch(Exception err)
    {
        Console.WriteLine("Erro: " + err.Message);
    }
    finally 
    {
        Console.WriteLine("Fim do software");
    }
}