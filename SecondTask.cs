using System;
using System.Text;
internal class Emolod2
{
    static Dictionary<string, string> dict = new Dictionary<string, string>();
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nWhat you want to do? \n 1 - Add to the dictionary \n 2 - Remove from a dictionary \n 3 - Show dictionary");
            int operation = Convert.ToInt32(Console.ReadLine());
            Crud(operation);
        }
    }
    static void Crud(int indexOfOp)
    {
        switch (indexOfOp)
        {
            case 1:
                Console.WriteLine("Type name of the contact");
                string name = Console.ReadLine();
                Console.WriteLine("Type number of the contact");
                string number = Console.ReadLine();
                if (name != null && number != null) dict.Add(name, number);
                else Console.WriteLine("You didn't typed anything");
                Console.WriteLine("Successfully added to the dictionary");
                break;
            case 2:
                if(dict.Count > 0)
                {
                    Console.WriteLine("Which contact you wish to remove? Here is avaible contacts");
                    for (int i = 0; i < dict.Count; i++)
                    {
                        Console.Write((i + 1) + " - ");
                        Console.WriteLine(dict.ElementAt(i));
                    }
                    int index = Convert.ToInt32(Console.ReadLine());
                    dict.Remove(dict.ElementAt(index-1).Key);
                    Console.WriteLine("Successfully removed from a dictionary");
                }
                else Console.WriteLine("There is no contacts in your dictionary");
                break;
            case 3:
                if (dict.Count > 0)
                {
                    for (int i = 0; i < dict.Count; i++)
                    {
                        Console.WriteLine(dict.ElementAt(i));
                    }
                    Console.WriteLine("Here is yours dictionary");
                }
                else Console.WriteLine("There is no contacts in your dictionary");          
                break;
            default:
                Console.WriteLine("Incorrect index of operation");
                break;
        }
    }
}




