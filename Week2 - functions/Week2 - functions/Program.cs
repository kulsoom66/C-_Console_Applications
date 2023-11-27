namespace Week2___functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            PrintLine(10, "*", false);
        }
        //static function in behavior 


        //static DataType FunctionName(Arguments or Parameters){
        //
        //logic
        //return 
        //}

        // static void (NoType) FunctionName (){
        // 
        // }


        static void PrintLine(int n = 10, string pattern = "_", bool flag = true)
        {
            for (int i =0; i< n; i++)
            {
                if (flag)
                {
                    Console.WriteLine(pattern);

                }
                else
                {
                    Console.Write(pattern);
                }
            }
        }


        
    }
}