using MatrixClass;

Matrix matrixA = InitializeMatrix();
Matrix matrixB = InitializeMatrix();
Matrix matrixC = InitializeMatrix();

matrixA.FillMatrix();
matrixB.FillMatrix();
matrixC.FillMatrix();

PrintAverageValue(matrixA, 3);
PrintAverageValue(matrixB, 3);
PrintAverageValue(matrixC, 3);

Matrix matrixD = (matrixA * matrixB) * matrixC;
if (matrixD.GetA() == 0 && matrixD.GetB() == 0)
    Console.WriteLine("Impossible to multiply matrixs");
else
{
    Console.WriteLine($"A*B*C={matrixD.PrintMatrix()}");
}

int n = GetInt("enter number for compare with average value matrix A");
if(matrixA.GetAverage(0, 0, 0) > n && matrixC.IsTrue())
{
    int minAvr = matrixA.GetAverage(2) < matrixB.GetAverage(2) ? DoubleToInt(matrixA.GetAverage(2)) : DoubleToInt(matrixB.GetAverage(2));
    for (int i = 0; i<matrixC.GetA(); i++)
    {
        for(int j = 0; j< matrixC.GetB(); j++)
        {
            matrixC.ChangeElement(i, j, minAvr * matrixC.GetElement(i,j));
        }
    }    
}
Console.WriteLine(matrixC.PrintMatrix());
Console.ReadLine();

static string? GetString(string description)
{
    string? rtrnStrng;
    Console.WriteLine(description);
    rtrnStrng = Console.ReadLine();
    return rtrnStrng;
}

static int GetInt(string description)
{
    Console.WriteLine(description);
    int retValue = Convert.ToInt32(Console.ReadLine());
    return retValue;
}

static int DoubleToInt(double value)
{
    return (int)Math.Floor(value);
}

static void PrintAverageValue(Matrix m, int n)
{
    Console.WriteLine($"Average value negative elements of {m.GetName()}, that repeat 3 times and more = {m.GetAverage(n)}");
}

static Matrix InitializeMatrix()
{
    return new(GetInt("Enter rows number"), GetInt("Enter columns number"), GetString("Enter matrix name"));
}