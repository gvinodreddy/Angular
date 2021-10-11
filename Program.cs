using System;

namespace Ass2
{
    class Program
    {

        static void Main(string[] args)
        {

            try
            {

                //Case 1:  

                //SubMain(0);

                //Case 2:  

                SubMain(1);



            }
            
            catch (ArgumentException a)
            {

                Console.WriteLine("ArgumentException");

                Console.ReadLine();

            }
            
            catch (DivideByZeroException d)
            {

                Console.WriteLine("DivideByZeroException ");

                Console.ReadLine();

            }
            catch (Exception e)
            {

                Console.WriteLine("Exception");

                Console.ReadLine();

            }




        }

        public static void SubMain(int i)
        {
           
            if (i <= 0)

                throw new ArgumentException("i is less than zero");



            try
            {

                int c = i / 0;

            }
            catch (DivideByZeroException d)
            {
                //todo: need to learn exception handlning types of exceptions in dotnet
                throw new Exception();
                //throw;
                //throw d;

            }



        }

    }



}
