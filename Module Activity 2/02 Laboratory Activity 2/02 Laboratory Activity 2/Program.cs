namespace O2_Laboratory_Activity_2 {

    public class Methods {
        public void enterContinue() {
            Console.Write("\nPress enter to continue . . . ");
            Console.ReadLine();
            Console.Clear();
        }
        public void clearAndWriteL(string str) {
            Console.Clear();
            Console.WriteLine(str);
        }
        public int getSum(int x, int y, int z)
        {
            return x + y + z;
        }
        public int getDifference(int x, int y, int z)
        {
            return x - y - z;
        }
        public int getProduct(int x, int y, int z)
        {
            return x * y * z;
        }
        public int getQuotient(int x, int y, int z)
        {
            if (y == 0 || z == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return x / y / z;
        }
        public int getRemainder(int x, int y, int z)
        {
            if (y == 0 || z == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return x % y % z;
        }
    }

    public class Program {
        public static void Main(string[] args) {
            Methods methods = new Methods();
            do {
                string str = "test";
                Console.Write("x = ");
                str = Console.ReadLine();

                if (str == "exit") {
                    methods.clearAndWriteL("Program has stopped");
                    break;
                }
                else {
                    if (!int.TryParse(str, out int x)) {
                        methods.clearAndWriteL("Input is not a valid integer. Please enter a valid integer or type 'exit' to quit.");
                        continue;
                    }
                    Console.Write("y = ");
                    str = Console.ReadLine();
                    if (!int.TryParse(str, out int y) {
                        methods.clearAndWriteL("Input is not a valid integer.");
                        continue;
                    }
                    Console.Write("z = ");
                    str = Console.ReadLine();
                    if (!int.TryParse(str, out int z)) {
                        methods.clearAndWriteL("Input is not a valid integer.");
                        continue;
                    }

                    Console.Write("Enter operation (+, -, *, /, %): ");
                    str = Console.ReadLine();

                    int result = 0;
                    bool validOperation = true;
                    switch (str) {
                        case "+":
                            result = methods.getSum(x, y, z);
                            break;
                        case "-":
                            result = methods.getDifference(x, y, z);
                            break;
                        case "*":
                            result = methods.getProduct(x, y, z);
                            break;
                        case "/":
                            if (y == 0 || z == 0) {
                                methods.clearAndWriteL("Cannot divide by zero.");
                                validOperation = false;
                            }
                            else {
                                result = methods.getQuotient(x, y, z);
                            }
                            break;
                        case "%":
                            if (y == 0 || z == 0) {
                                methods.clearAndWriteL("Cannot divide by zero.");
                                validOperation = false;
                            }
                            else {
                                result = methods.getRemainder(x, y, z);
                            }
                            break;
                        default:
                            methods.clearAndWriteL("Invalid operation. Please enter one of the following: +, -, *, /, %");
                            validOperation = false;
                            break;
                    }
                    if (validOperation) {
                        Console.WriteLine("Result: {0}", result);
                    }
                    methods.enterContinue();
                }
            }
            while (true);
        }
    }
}