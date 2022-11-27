class Program 
{
    static string Generate(float per, string fill, string empty, int len)
    {
        float until = (per / 100) * len;

        string newProgressBar = "[";
        for (int i = 0; i < len; i++)
        {
            newProgressBar += ((i < until ? fill : empty));
        }

        newProgressBar += "]";
        return newProgressBar;
    }


    static void Main(string[] args)
    {
        try
        {
            if (args.Length != 4)
            {
                Console.WriteLine("<percent> <fill> <empty> <len>");
                return;
            }

            Console.WriteLine(Generate(int.Parse(args[0]) , args[1], args[2], int.Parse(args[3])));
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
    }
}


