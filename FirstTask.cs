using System;
using System.Text;
internal class Emolod2
{
    static List<string> list = new List<string>();
    static string engSymbols = "qwertyuiopasdfghjklzxcvbnm";
    static string engSymbolsUpper = "QWERTYUIOPASDFGHJKLZXCVBNM";
    static string symbols = "!@#$%^&*()_+-=[]';.,/<>?:";
    static string numbers = "1234567890";

    static void Main()
    {
        while(true)
        {     
            Console.WriteLine("\nWhat you want to do? \n 0 - Show your list \n 1 - Create new list/Add value to list \n 2 - Get value of index \n 3 - Update infomation of index \n 4 - Delete information in list");
            int operation = Convert.ToInt32(Console.ReadLine());
            Crud(operation);
        }               
    }

    static void Crud(int indexOfOp)
    {
        int index = -1;
        if(list.Count <= 0 && indexOfOp != 1)
        {
            indexOfOp = 1;
            Console.WriteLine("You don't have list yet, we need to do new");
        }
        switch(indexOfOp)
        {
            case 0:
                list.ForEach(value => Console.WriteLine(value));
                Console.WriteLine("Here is yours list");
                break;
            case 1:
                Console.WriteLine("Would u like to Add or Create new? add/create");
                string addOrCreate = Console.ReadLine();
                if (addOrCreate == "add")
                {
                    Console.WriteLine("Type what you want to add");
                    string valueToAdd = Console.ReadLine();
                    if (valueToAdd != null)
                    {
                        list.Add(valueToAdd);
                        Console.WriteLine("Successfully added value to list");
                    }                       
                    else Console.WriteLine("You need to type something to add");
                    break;
                }
                else if(addOrCreate == "create")
                {
                    list = new List<string>();
                    Random random = new Random();
                    Console.WriteLine("How many words do you need");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How min long they would be?");
                    int minLength = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How max long they would be?");
                    int maxlength = Convert.ToInt32(Console.ReadLine());
                    List<string> s = new List<string>();
                    s.Add(engSymbols);
                    Console.WriteLine("Would you like to add Spec symbols to your list? yes/no");
                    if (Console.ReadLine().ToString() == "yes") s.Add(symbols);
                    Console.WriteLine("Would you like to add Upper case symbols to your list? yes/no");
                    if (Console.ReadLine().ToString() == "yes") s.Add(engSymbolsUpper);
                    Console.WriteLine("Would you like to add numbers to your list? yes/no");
                    if (Console.ReadLine().ToString() == "yes") s.Add(numbers);

                    string[] strMassive = s.ToArray();
                    List<char> chars = new List<char>();
                    foreach (string str in strMassive)
                    {
                        foreach (char c in str)
                        {
                            chars.Add(c);
                        }
                    }
                    string newSymbols = new string(chars.ToArray());
                    for (int i = 0; i < quantity; i++)
                    {
                        char[] randomStr = new char[random.Next(minLength, maxlength)];
                        for (int j = 0; j < randomStr.Length; j++)
                        {
                            randomStr[j] = newSymbols[random.Next(0, newSymbols.Length)];
                        }
                        string str = new string(randomStr);
                        list.Add(str);
                    }
                    Console.WriteLine("Successfully created new list");
                }               
                break;
            case 2:
                Console.WriteLine("What index do you need? Here is all avaible indexes - " + list.Count);
                int showIndex = Convert.ToInt32(Console.ReadLine());
                if (showIndex > 0 && showIndex <= list.Count) Console.WriteLine("\n Here it is - " + list[showIndex - 1]);
                else Console.WriteLine("Incorrect index");      
                break;
            case 3:
                Console.WriteLine("Which index you want to replace? Here is all avaible indexes - " + list.Count);
                index = Convert.ToInt32(Console.ReadLine());
                if(index > 0 && index <= list.Count)
                {
                    Console.WriteLine("Type what you want to see in that index");
                    string replacedValue = Console.ReadLine();
                    if (replacedValue != null)
                    {
                        list.RemoveAt(index - 1);
                        list.Insert(index - 1, replacedValue);
                    }
                    else Console.WriteLine("Error - You didn't typed something");
                }
                else Console.WriteLine("Incorrect index");
                break;
            case 4:
                Console.WriteLine("Which index you want to delete? Here is all avaible indexes - " + list.Count);
                index = Convert.ToInt32(Console.ReadLine());
                list.RemoveAt(index-1);
                Console.WriteLine("Successfully removed value");
                break;
        }
    }

    
}



