namespace BigOAlgo
{

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Algorithm.GetNumber(10);
            Algorithm.GetNumber(15);
            
            var newList = new List<int>
            {
              1,
              3,
              58,
              75,
              100,
              150,
              200
            };
            Algorithm.DetermineItems(newList);
        }
    } 
}

