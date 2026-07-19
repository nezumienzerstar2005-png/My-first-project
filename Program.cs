do {
    double x = 0;
    double y = 0;
    double answer = 0;

    Console.WriteLine("------------------------------");
    Console.WriteLine("Ya wanna know whats 9 plus 10?");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Type 9: ");
    x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Type 10: ");
    y = Convert.ToDouble(Console.ReadLine());
    

    Console.WriteLine("Whats 9 plus 10?");
    Console.WriteLine("\t+ : Add");
    Console.WriteLine("\t- : Subtract");
    Console.WriteLine("\t* : Multiply");
    Console.WriteLine("\t/ : Divide");
    Console.WriteLine("Type + for the funny: ");

    switch (Console.ReadLine())
    {
        case "+":
            if (x == 9 && y == 10)
            {
                Console.WriteLine("21 :troll:");
            }
            else if (answer == 67)
            {
                Console.WriteLine("SIX SEVEN!!1!!1!");
            }
            else
            {
                answer = x + y;
                Console.WriteLine(answer);
            }
            break;
        case "-":
            if (answer == 67)
            {
                Console.WriteLine("SIX SEVEN!!1!!1!");
            }
            else
            {
                answer = x - y;
                Console.WriteLine("You stupid: " + answer);
            }
            break;
        case "*":
            if (answer == 67)
            {
                Console.WriteLine("SIX SEVEN!!1!!1!");
            }
            else
            {
                answer = x * y;
                Console.WriteLine("You stupid: " + answer);
            }
            break;
        case "/":
            if (answer == 67)
            {
                Console.WriteLine("SIX SEVEN!!1!!1!");
            }
            else
            {
                answer = x / y;
                Console.WriteLine("You stupid: " + answer);
            }
            break;
        default:
            Console.WriteLine("You stupid, im not answering that cuh");
            break;
    }
    Console.WriteLine("Still wanna know whats 9 plus 10? (Y/N): ");
} while (Console.ReadLine().ToUpper() == "Y");

Console.WriteLine("U still stupid btw,bye cuh");
Console.ReadKey();