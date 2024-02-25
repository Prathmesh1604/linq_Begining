bool isAnyGreaterThan100(int[] numbers)
{
    foreach(var number in numbers)
    {
        if (number > 100)
        {
            return true;
        }
    }
    return false;
}

bool isAnyEven(int[] numbers)
{
    foreach (var number in numbers)
    {
        if (number % 2=0)
        {
            return true;
        }
    }
    return false;
}

var numbers = new[] { 1, 2, 5, 80, 900, 99, 200 };

Console.WriteLine("Is Any Greater Than 100"+isAnyGreaterThan100(numbers));
Console.WriteLine("Is Any Even Number" + isAnyEven(numbers));


Console.ReadLine();
