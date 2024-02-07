namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Examples();
            // ExerciseOne();
            // ExerciseTwo();
            // ExerciseThree();
            // ExerciseFour();
            // ExerciseFive();
            // ExerciseSix();
            // ExerciseSeven();
            // ExerciseEight();
            // ExerciseNine();
            // ExerciseTen();
            // ExerciseEleven();
            // ExerciseTwelve();
            ExerciseThirteen();
        }

        static void Examples()
        {
            // ## Default Hello, World ##
            Console.WriteLine("Hello, World!\n"); // Write to STDOUT with \n

            // ## User Input
            Console.Write("Type your name: "); // Write to STDOUT w/out \n
            string userName = Console.ReadLine(); // Read from STDIN
            userName = ToNameCase(userName);
            Console.Write("Type your age: ");
            int userAge = Int32.Parse(Console.ReadLine()); // Convert string (as read from STDIN) to 32-bit int. Helps to validate this is a number

            Console.WriteLine(
                "\nThe name you typed was {0}.\nYou are {1} year{2} old.\n",
                userName,
                userAge,
                (userAge == 1 ? "" : "s") // Returns "" if userAge is 1, else returns "s"
            ); // Write formatted string to STDOUT

            // ## Booleans
            bool rightName = false;
            rightName = (userName == "Jack"); // rightName is true if userName is "Jack"
            if (rightName)
            { // if true
                Console.WriteLine("Hi, Jack");
            }
            else
            {
                Console.WriteLine("I don't know who you are");
            }
        }

        // ## Functions
        static string ToNameCase(string name)
        {
            return string.Join(
                " ",
                name.ToLower().Split(" ").Select(
                    name => char.ToUpper(name[0]) + name.Substring(1) // First character uppercase
                )
            );
        }

        // ## Exercises
        static void ExerciseOne ()
        {
            Console.Write("Type your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine(
                "Hello: {0}",
                userName
            );
        }

        static void ExerciseTwo ()
        {
            int numberOne = 1;
            int numberTwo = 4;

            int sum = numberOne + numberTwo;

            Console.WriteLine(
                "{0} + {1} = {2}",
                numberOne,
                numberTwo,
                sum
            );
        }

        static void ExerciseThree ()
        {
            int numberOne = 5;
            int numberTwo = 2;

            int div = numberOne / numberTwo;

            Console.WriteLine(
                "{0} / {1} = {2}",
                numberOne,
                numberTwo,
                div
            );
        }

        static void ExerciseFour ()
        {
            int resultOne = -1 + 4 * 6;
            int resultTwo = (35 + 5) % 7;
            int resultThree = 14 + -4 * 6 / 11;
            int resultFour = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine(
                "{0}\n{1}\n{2}\n{3}",
                resultOne,
                resultTwo,
                resultThree,
                resultFour
            );
        }

        static void ExerciseFive ()
        {
            int numberOne, numberTwo;

            Console.Write("Input the First Number: ");
            numberOne = Int32.Parse(Console.ReadLine());

            Console.Write("Input the Second Number: ");
            numberTwo = Int32.Parse(Console.ReadLine());

            int numberThree = numberOne;
            numberOne = numberTwo;
            numberTwo = numberThree;

            Console.WriteLine(
                "After Swapping:\nFirst Number: {0}\nSecond Number: {1}",
                numberOne,
                numberTwo
            );
        }

        static void ExerciseSix ()
        {
            Console.Write("Input the first number to multiply: ");
            int numberOne = Int32.Parse(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            int numberTwo = Int32.Parse(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            int numberThree = Int32.Parse(Console.ReadLine());

            int mult = numberOne * numberTwo * numberThree;

            Console.WriteLine(
                "{0} x {1} x {2} = {3}",
                numberOne,
                numberTwo,
                numberThree,
                mult
            );
        }

        static void ExerciseSeven ()
        {
            Console.Write("Input the first number: ");
            int numberOne = Int32.Parse(Console.ReadLine());

            Console.Write("Input the second number: ");
            int numberTwo = Int32.Parse(Console.ReadLine());

            int sum = numberOne + numberTwo;
            int sub = numberOne - numberTwo;
            int mult = numberOne * numberTwo;
            int div = numberOne / numberTwo;
            int mod = numberOne % numberTwo;

            Console.WriteLine(
                "{0} + {1} = {2}\n{0} - {1} = {3}\n{0} x {1} = {4}\n{0} / {1} = {5}\n{0} mod {1} = {6}",
                numberOne,
                numberTwo,
                sum,
                sub,
                mult,
                div,
                mod
            );
        }

        static void ExerciseEight ()
        {
            Console.Write("Enter the number: ");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int mult = number * i;

                Console.WriteLine(
                    "{0} * {1} = {2}",
                    number,
                    i,
                    mult
                );
            }
        }

        static void ExerciseNine ()
        {
            Console.Write("Enter the First number: ");
            float numberOne = float.Parse(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            float numberTwo = float.Parse(Console.ReadLine());

            Console.Write("Enter the Third number: ");
            float numberThree = float.Parse(Console.ReadLine());

            Console.Write("Enter the Fourth number: ");
            float numberFour = float.Parse(Console.ReadLine());

            float avg = (numberOne + numberTwo + numberThree + numberFour) / 4f;

            Console.WriteLine(
                "The average of {0}, {1}, {2}, {3} is: {4}",
                numberOne,
                numberTwo,
                numberThree,
                numberFour,
                avg
            );
        }

        static void ExerciseTen ()
        {
            Console.Write("Enter first number - ");
            int numberOne = Int32.Parse(Console.ReadLine());

            Console.Write("Enter second number - ");
            int numberTwo = Int32.Parse(Console.ReadLine());

            Console.Write("Enter third number - ");
            int numberThree = Int32.Parse(Console.ReadLine());

            int resultOne = (numberOne + numberTwo) * numberThree;
            int resultTwo = numberOne * numberTwo + numberTwo * numberThree;

            Console.WriteLine(
                "Result of specified numbers {0}, {1} and {2}, (x+y)*z is {3} and x*y + y*z = {4}",
                numberOne,
                numberTwo,
                numberThree,
                resultOne,
                resultTwo
            );
        }

        static void ExerciseEleven ()
        {
            Console.Write("Enter your age - ");
            int userAge = Int32.Parse(Console.ReadLine());

            Console.WriteLine(
                "You look older than {0}.",
                userAge
            );
        }

        static void ExerciseTwelve ()
        {
            Console.Write("Enter a digit: ");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(
                        "{0} ",
                        number
                    );
                }
                Console.WriteLine();

                for (int j = 0; j < 4; j++)
                {
                    Console.Write(
                        "{0}",
                        number
                    );
                }
                Console.WriteLine();
            }
        }

        static void ExerciseThirteen ()
        {
            Console.Write("Enter a number: ");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                Console.Write(
                    "{0}",
                    number
                );
            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(
                    "{0} {0}",
                    number
                );
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write(
                    "{0}",
                    number
                );
            }
        }
    }
}