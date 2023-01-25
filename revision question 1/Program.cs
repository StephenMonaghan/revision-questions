namespace revision_question_1
    //Stephen Monaghan
    //25/1/2023
    //work sheet part 1 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            PrintIntegers();
            PrintIntegersWhile();
        }

        static void PrintIntegers()
        {
            for (int i = 40; i <= 60; i++) /// this prints the numbers from 4o to 60 decending
            {
                Console.WriteLine(i);
            }
        }    



        static void PrintIntegersWhile()
        {
            int x = 40;
            while(x<=60)
            {
                Console.WriteLine(x);
                x++;
            }

        }





    }
}