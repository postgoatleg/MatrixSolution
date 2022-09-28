using MatrixClass;

Matrix matrixA = new(GetInt("Enter rows number"), GetInt("Enter columns number"), GetString("Enter matrix name"));
Matrix matrixB = new(GetInt("Enter rows number"), GetInt("Enter columns number"), GetString("Enter matrix name"));
Matrix matrixC = new(GetInt("Enter rows number"), GetInt("Enter columns number"), GetString("Enter matrix name"));

matrixA.FillMatrix();
matrixB.FillMatrix();
matrixC.FillMatrix();

Console.WriteLine($"Average value negative elements of {matrixA.GetName()}, that repeat 3 times and more = {matrixA.GetAverage(3)}");
Console.WriteLine($"Average value negative elements of {matrixA.GetName()}, that repeat 3 times and more = {matrixB.GetAverage(3)}");
Console.WriteLine($"Average value negative elements of {matrixB.GetName()}, that repeat 3 times and more = {matrixC.GetAverage(3)}");

Matrix matrixD = (matrixA * matrixB) * matrixC;
Console.WriteLine($"A*B*C={matrixD.PrintMatrix()}");
int n = GetInt("enter number of repeats for negative elements of Matrix A");
if(matrixA.GetAverage() > n && matrixC.IsTrue())
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