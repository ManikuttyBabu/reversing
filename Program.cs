namespace reversing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myStr, rev;
            myStr = "Manikuy";
            rev = "";
            Console.WriteLine("String is {0}", myStr);
            int len;
            len = myStr.Length - 1;
            while (len >= 0)
            {
                rev = rev + myStr[len];
                len--;
            }
            Console.WriteLine("Reversed String is {0}", rev);
            //Console.ReadLine();//comment
        }
    }
}

