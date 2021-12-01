namespace exercise
{
    public static class Program
    {
        public static void Main()
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(14);
            numbers.Push(21);
            numbers.Push(32);
            numbers.Push(45);
            numbers.Push(51);
            numbers.Push(104);
            numbers.Push(151);
            numbers.Push(141);
            numbers.Push(159);
            numbers.Push(49);
            numbers.Push(1556);
            numbers.Count();
            bool Found = numbers.Contains(45);           


            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\nPopping {0}", numbers.Pop());
            Console.WriteLine("Contains {0}", Found);
            Console.WriteLine("Your all numbers are {0}", numbers.Count());
            Console.ReadLine();
            
        }
    }
}
