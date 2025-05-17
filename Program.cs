namespace ConsNum
{
    class program
    {
        static void Main(string[] argS)
        {
            Console.WriteLine("Enter a series of numbers split by a hyphen '-': ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("That was not a valid input.");
                return;
            }

            var inputSplit = input.Split('-');

            int[] numbers = new int[inputSplit.Length];
            for (int i = 0; i < inputSplit.Length; i++)
            {
                numbers[i] = Convert.ToInt32(inputSplit[i]);
            }

            bool isAscending = numbers[1] > numbers[0];
            bool isConsecutive = true;

            for (int i = 1; i < inputSplit.Length; i++)
            {
                if (isAscending)
                {
                    if (numbers[i] != numbers[i - 1] + 1)
                    {
                        isConsecutive = false;
                        break;
                    }
                }
                else
                {
                    if (numbers[i] != numbers[i - 1] - 1)
                    {
                        isConsecutive = false;
                        break;
                    }
                }

            }

            Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");
        }
    }
}