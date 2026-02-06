namespace ArraySortNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kasutame Array ja Sort-i");
            string[] animals = { "cat", "alligator", "fox", "donkey", "bear", "elephant", "goat" };
            //tuleb kasutada foreachi ja näidate kõiki loomi
            //paneb tähestikulisse järjekorda
            //Array.Sort(animals);
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine("----------------------");

            //järjesta kolm esimest sõna tähestlikuses järjestuses
            //vaadake Sort meetodit ja mitu overload sel on
            Array.Sort(animals, 0, 3);
            Console.WriteLine("esimest 3");
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("----------------------");
            int[] numbers = { 1, 2, 3, 4, 3, 55, 23, 2 };
            //tuleb välistada kordused
            //mida teha, et numbrid ei korduks
            var uniquenumbers = numbers.Distinct().ToArray();
            foreach (int number in uniquenumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
