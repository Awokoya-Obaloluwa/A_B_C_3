namespace A_B_C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(" Please enter a first number");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter a second number");   
                int B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter a third number");
                int C = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Correctness(A, B, C));
            }
            catch(FormatException )
            {
                Console.WriteLine("Please always input a number");
            }
            
        }

        public static bool Correctness(int A, int B, int C)
        {
            bool k = true;
            
                if (C == 0)
              {  if(A >= 14 && B >= 14)
                {
                    Console.WriteLine(k); 
                }

              }
                else if (C > 0)
                {  if(A > 2 * (C + 1) && B > 2 * (C + 1))
                {
                    Console.WriteLine(k); 
                }

                }
              else if(A < 0 || B < 0 || C < 0)
              {
                Console.WriteLine("Numbers below zero are not allowed");

              }
            return false; 
           
        }
       
    }
}