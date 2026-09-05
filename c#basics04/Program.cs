namespace c_basics04
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //ans.q1
            #region Create a one-dimensional array
            //double[] arr = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(arr[1]); 
            #endregion

            //ans.q2
            #region Create a 2x2 multidimensional array
            //int[,] shelfCopies =
            //{
            //    { 3, 5 },
            //    { 1, 4 }
            //};
            //Console.WriteLine(shelfCopies[1,0]); 
            #endregion

            //ans.q3
            //printWelcomeMessage();

            //ans.q4
            //PrintBookTitle("clean code");

            //ans.q5
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            //// Output: 400 because the AddBonusPages method is passing by value -value types.

            //ans.q6
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            // Output: 20.5 because the ApplyDiscount method is passing the array by reference - reference types.

            //ans.q7
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages);
            // Output: 450 because the AddBonusPagesByRef method is passing by reference - value types.

            //ans.q8
            //double[] prices = { 5.0, 7.5 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);
            


        }

        //public static void printWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //}

        //public static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine("Book title: " + title);
        //}

        //public static void AddBonusPages(int pages)
        //{
        //    pages += 50;
        //}

        //public static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] -= 5;
        //}

        //public static void AddBonusPagesByRef(ref int pages)
        //{
        //    pages += 50;
        //}

        //public static void ReplaceArray(ref double[] prices)
        //{
        //    prices = new double[] { 10.0, 12.5, 15.0 };
        //}
    }

}

