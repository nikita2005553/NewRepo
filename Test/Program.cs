int[,] GenerateMat(int n)
{
    int[,] matr = new int[n, n];
    Random r = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = r.Next(8);
        }
    }
    return matr;
}

void WriterMatr(int[,] matr, string file)
{
    int n = matr.Length;
    using (StreamWriter writer = new StreamWriter(file))
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                writer.Write("{0} ", matr[i, j]);
            writer.WriteLine();
        }
        writer.Close();
    }
}

int[,] ReaderMatr(string file, int n)
{
    using StreamReader reader = new StreamReader(file);
    int[,] matr = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        string[] s = reader.ReadLine().Split(" ");
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = int.Parse(s[j]);
        }


    }
    reader.Close();
    return matr;
}

void PrintMatr(int[,] matr)
{
    int n = matr.GetLength(0);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write($"{matr[i, j],4}");
        Console.WriteLine();
        Console.WriteLine();
    }
}

bool PrimeNumber(int x)
{
    for (int i = 2; i < (int)Math.Sqrt(x) + 1; i++)
    {
        if (x % i == 0)
        {
            return false;
        }
    }
    return true;
}
List<int> GerPrimeArr()
{
    List<int> primeNumbers = new List<int>();
    for (int i = 2; i < 1000000; i++)
    {
        if (PrimeNumber(i))
        {
            primeNumbers.Add(i);
        }
    }
    return primeNumbers;
}
List<int> prime = GerPrimeArr();


int[,] GenerateMatrIsPrime(List<int> prime, int n)
{
    int[,] matr = new int[n, n];
    Random r = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = prime[r.Next(prime.Count)];
        }
    }
    return matr;
}

int[,] GetIndexMaxAndMin(int[,] matr)
{
    int index_max_i = 0, index_max_j = 0, index_min_i = 0, index_min_j = 0;
    int max = 0, min = int.MaxValue;
    int n = matr.GetLength(0);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                index_min_i = i;
                index_min_j = j;
            }
            if (matr[i, j] > max)
            {
                max = matr[i, j];
                index_max_i = i;
                index_max_j = j;
            }
        }
    }
    int[,] res = { { max, index_max_i, index_max_j }, { min, index_min_i, index_min_j } };
    return res;
}

void ChangeString(int[,] matr)
{
    int n = matr.GetLength(0);
    int[,] position = GetIndexMaxAndMin(matr);
    int index_max_string = position[0, 1];
    int index_min_string = position[1, 1];
    for (int i = index_max_string; i < index_max_string + 1; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int t = matr[i, j];
            matr[i, j] = matr[index_min_string, j];
            matr[index_min_string, j] = t;
        }
    }
}


int SymetricRow(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        bool sym = true;
        int sum = 0;
        for (int i = 0; i < matr.GetLength(0) / 2; i++)
        {
            sum += matr[i, j] + matr[matr.GetLength(0) - 1 - i, j];
            if (matr[i, j] != matr[matr.GetLength(0) - 1 - i, j])
            {
                sym = false;
            }
        }
        if (sym)
        {
            return sum;
        }
    }
    return -1;
}
