using BinarySearch.CustomeBinarySearch;

Console.WriteLine("-------------- Built-in Binary Search --------------");
var list = Enumerable.Range(0, 128).ToArray();
var index = Array.BinarySearch(list, 4);
Console.WriteLine(string.Format("Here is the index {0}", index));

Console.WriteLine("-------------- Custome Binary Search --------------");
static int BinarySearch(Person[] people, Person person)
{
    int left = 0;
    int right = people.Length - 1;

    while (left <= right)
    {
        var middle = (left + right) / 2;
        var comparison = people[middle].CompareTo(person);

        if (comparison == 0)
        {
            return middle;
        }

        else if (comparison < 0)
        {
            left = middle + 1;
        }

        else
        {
            left = middle - 1;
        }

    }

    return -1;
}

Person[] people =
{
    new Person{Name="Ali" ,Age=32},
    new Person{Name="Hassan" ,Age=16},
    new Person{Name="Miald" ,Age=12}
};

var hassanIndex = BinarySearch(people, new Person { Name = "Hassan", Age = 16 });
Console.WriteLine(string.Format("Hassan Is On Index {0}", hassanIndex));
