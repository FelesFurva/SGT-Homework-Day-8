double x;
double y;
char action;

while (true)
{
    Console.WriteLine("Please enter x:");
    string user_x = Console.ReadLine();
    if (!Double.TryParse(user_x, out x))
        Console.WriteLine("Please enter a number\n");
    else
    {
        break;
    }
}
while (true)
{
    Console.WriteLine("Please enter y:");
    string user_y = Console.ReadLine();
    if (!Double.TryParse(user_y, out y))
        Console.WriteLine("Please enter a number\n");
    else
    {
        break;
    }
}

while (true)
{

    Console.WriteLine("Please choose what to do:\n + for sum\n - subtraction\n" +
    " / dividing\n * multiplication\n % remainder \n p print\n b bigger f the two numbers\n" +
    " s smaller of the two\n q exit");

    while (true)
    {

        string input = Console.ReadLine();
        string v = input.ToLower();
        if (!char.TryParse(v, out action))
            Console.WriteLine("Please enter a character");
        else
        {
            break;
        }
    }

    if (action == 'q')
    {
        break ;
    }

    switch (action)
    {
        case '+':
            Console.WriteLine($"{x} + {y} = {x + y}");
            break;
        case '-':
            Console.WriteLine($"{x} - {y} = {x - y} \n");
            break;
        case '/':
            Console.WriteLine($"{x} / {y} = {x / y} \n");
            break;
        case '*':
            Console.WriteLine($"{x} * {y} = {x * y}\n");
            break;
        case '%':
            Console.WriteLine($"{x} % {y} = {x % y}\n");
            break;
        case 'p':
            Console.WriteLine($"x is: {x} and y is: {y}\n");
            break;
        case 'b':
            Console.WriteLine($"The biggest number is {Math.Max(x, y)}\n");
            break;
        case 's':
            Console.WriteLine($"The smallest number is {Math.Min(x, y)}\n");
            break;
        default:
            Console.WriteLine("Well, I can't do that\n");
            break;
    }
}