int[] cisla = {1,4,3,2,1};

Console.WriteLine($"Delka pole: {Delka(cisla)}");
Console.WriteLine($"Minimum: {Minimum(cisla)}");
Console.WriteLine($"Maximum: {Maximum(cisla)}");
Console.WriteLine($"Součet prvků: {Sum(cisla)}");
Console.WriteLine($"Součin prvků: {Product(cisla)}");
Console.WriteLine($"Aritmetický průměr: {Arithmetic(cisla)}");
Console.WriteLine($"Geometrický průměr: {Geometric(cisla)}");
Console.WriteLine($"Median: {Median(cisla)}");

static int Delka(int[] cisla)
{
    int delka = 0;

    foreach (int i in cisla)
    {
        delka++;
    }

    return delka;
}

static int Minimum(int[] cisla)
{
    int min = 0;

    foreach (int i in cisla)
    {
        if(min >= i)
        {
            min = i;
        }
    }

    return min;
}

static int Maximum(int[] cisla)
{
    int max = 0;

    foreach (int i in cisla)
    {
        if (max <= i)
        {
            max = i;
        }
    }

    return max;
}

static int Sum(int[] cisla)
{
    int sum = cisla[0];
    foreach(int i in cisla)
    {
        sum += i;
    }


    return sum;
}

static int Product(int[] cisla)
{
    int pro = cisla[0];
    foreach (int i in cisla)
    {
        pro *= i;
    }


    return pro;
}

static double Arithmetic(int[] cisla)
{
    return Sum(cisla)/cisla.Length;
}

static double Geometric(int[] cisla)
{
    return Math.Sqrt(Math.Abs(Product(cisla)));
}

static float Median(int[] cisla)
{
    int half = cisla.Length / 2;
    if (cisla.Length % 2 == 0)
    {
        
        return (cisla[half] + cisla[half++])/2f;
    }
    else
    {
        return cisla[half];
    }
    
}
