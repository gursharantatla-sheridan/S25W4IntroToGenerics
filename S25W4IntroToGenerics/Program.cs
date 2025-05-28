namespace S25W4IntroToGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;

            object obj = num;   // boxing, assigning from value-type -> ref type

            num = (int)obj;     // unboxing, ref type -> value type, type-casting



            //if (AreEqual(5, "hello"))
            if (AreEqual<int>(5, 5))
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");
        }

        // non-generic / normal mathod
        static bool AreEqual(object value1, object value2)
        {
            return value1.Equals(value2);
        }

        // generic method
        static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
