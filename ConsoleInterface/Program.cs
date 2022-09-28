using MatrixClass;

Matrix drain = new(2, 2, GetString("Enter matrix name"));
Matrix drain1 = new(2, 2, GetString("Enter matrix name"));
drain.FillMatrix();
drain1.FillMatrix();
Console.WriteLine(drain.PrintMatrix());
Console.WriteLine(drain1.PrintMatrix());
Matrix drain3 = drain * drain1;
Console.WriteLine(drain3.PrintMatrix());


//drain.ChangeElement(GetInt("Enter column"), GetInt("Enter row"), GetInt("Enter new value"));
//Console.WriteLine(drain.PrintMatrix());

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