namespace ConsNum
{
    class program
    {
        static void Main(string[] argS)
        {
            Console.WriteLine("Enter a series of numbers split by a hyphen '-': ");
            var input = Console.ReadLine();

            var inputSplit = input.Split('-');

        }
    }
}