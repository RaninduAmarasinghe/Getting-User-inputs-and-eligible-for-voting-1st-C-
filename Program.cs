namespace User_is_eligible_for_vote;
class Program
{
    static void Main(string[] args)
    {
        String name;
        int age;
        Console.WriteLine("Enter ur name");
        name=Console.ReadLine();

        Console.WriteLine("Enter ur age");
        age = int.Parse(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine(name + "ur eligible for voting");
        }
        else
        {
            Console.WriteLine(name + "ur not eligible for voting");
        }
        Console.ReadKey();
    }
}

