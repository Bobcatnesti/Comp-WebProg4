namespace LabExer2_Pacho {
    public class Program {
        public static void Main(string[] args) {
            do
            {
                Console.Write("x = ");
                string str = Console.ReadLine();
                if (str == "exit")
                {
                    Console.WriteLine("Program has stopped");
                    break;
                }
                else
                {
                    int x = Convert.ToInt32(str);
                    Console.Write("y = ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    int sum = x + y;
                    Console.WriteLine("Result: {0}", sum);
                }
            }
            while (true);
        }
    }
}