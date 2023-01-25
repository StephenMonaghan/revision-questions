namespace revision_question_1
    //Stephen Monaghan
    //25/1/2023
    //work sheet part 1 
{
    internal class Program
    {
        static void Main(string[] args)
        {


           // PrintIntegers();
          //  PrintIntegersWhile();

           // PrintIntegersDo();

            PrintDescendingFor();
            PrintExcludingFor();
        }

        static void PrintIntegers()
        {
            for (int i = 40; i <= 60; i++) /// this prints the numbers from 4o to 60 decending
            {
                Console.WriteLine(i);
            }
        }



        static void PrintIntegersWhile()// usig a while loop to preform a print function numbers 40 to 60
        {
            int x = 40;
            while (x <= 60)
            {
                Console.WriteLine(x);
                x++;
            }

        }

        static void PrintIntegersDo()
        {
            int x = 40;
            do
            {
                Console.WriteLine(x);
            }
            while (x <= 60);


        }




        static void PrintDescendingFor()
        {
            for (int i = 60; i >= 40; i--) /// this prints the numbers from 4o to 60 decending
            {
                Console.WriteLine(i);
            }

        }
        static void PrintExcludingFor()
        {
            for (int i = 40; i <= 60; i++) /// this prints the numbers from 4o to 60 decending
            {
                if ()
            }
        }


        


     }
}