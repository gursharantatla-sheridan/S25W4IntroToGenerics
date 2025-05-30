namespace StackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            //int num = stack[1];

            Console.WriteLine("Total items: " + stack.Count);

            foreach (var i in stack)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");



            int num = stack.Pop();
            Console.WriteLine("num after Pop operation: " + num);

            Console.WriteLine("\n\nTotal items: " + stack.Count);

            foreach (var i in stack)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");


            num = stack.Peek();
            Console.WriteLine("num after Peek operation: " + num);

            Console.WriteLine("\n\nTotal items: " + stack.Count);

            foreach (var i in stack)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");
        }
    }
}
