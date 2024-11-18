using System.Collections;

namespace minioppgave_arraylist_and_lists;

class Program
{
    static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add("Hello there!");
        arrayList.Add("General Kenobi!");
        arrayList.Add(1);
        arrayList.Add(true);
        arrayList.Add(string.Empty);

        foreach (var myObjects in arrayList)
        {
            Console.WriteLine(myObjects);
        }

        int num1 = 62;
        Console.WriteLine(num1);

        List<object> myList = new List<object>();
        myList.Add("Hello there!");
        myList.Add("General Kenobi!");
        myList.Add(23);
        myList.Add(false);
        myList.Add(string.Empty);

        foreach (var otherObjects in myList)
        {
            Console.WriteLine(otherObjects);
        }


    }
}
