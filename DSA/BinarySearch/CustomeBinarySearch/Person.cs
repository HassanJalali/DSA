namespace BinarySearch.CustomeBinarySearch
{
    public class Person : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(object? obj)
        {
            Person person = obj as Person;
            return this.Age - person.Age;
        }
    }
}
