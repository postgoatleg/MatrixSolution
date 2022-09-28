namespace MatrixClass;
public class Matrix
{
    int a, b;
    string? name = "";
    int[,] matrix;

    public Matrix(int a, int b, string? name)
    {
        this.a = a;
        this.b = b;
        this.name = name;
        matrix = new int[a, b];
    }
    /// <summary>
    /// i - num of culumn, j - num of row, num - new value
    /// </summary>
    /// <param name="i"></param>
    /// <param name="j"></param>
    /// <param name="num"></param>
    public void ChangeElement(int i, int j, int num)
    {
        this.matrix[i,j] = num;
    }

    public bool IsTrue()
    {
        int i = 0;
        while (i < this.a)
        {
            int j = 0;
            while (j < this.b)
            {
                if(this.matrix[i, j] != 0)
                {
                    return true;
                }
            }
            i++;
        }
        return false;
    }

    public void FillMatrix()
    {
        for(int i = 0; i < this.a; i++)
        {
            for(int j =0; j < this.b; j++)
            {
                Console.Write($"Enter a[{i},{j}]: ");
                this.matrix[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        if (m1.a != m2.a && m1.b != m2.b)
        {
            return new Matrix(0, 0, "null");
        }
        else
        {
            Matrix m3 = new(m1.a, m2.b, m1.name + m2.name);
            for (int i = 0; i<m1.a; i++)
            {
                for(int j = 0; j<m1.b; j++)
                {
                    int ii=0, jj=0, elementValue=0; 
                    while(ii<m1.a && jj < m1.b)
                    {

                        elementValue += m1.matrix[i, jj] * m2.matrix[ii, j];
                        ii++;
                        jj++;
                    }
                    m3.matrix[i, j] = elementValue;
                }
            }
            return m3;
        }
    }

    public string PrintMatrix()
    {
        string resultString = $"Matrix {this.name}:\n";
        for (int i = 0; i < this.a; i++)
        {
            for (int j = 0; j < this.b; j++)
            {
                resultString += Convert.ToString(this.matrix[i, j]) + ", ";

            }
            resultString += "\n";
        }
        return resultString;
    }

    public double getAverage()
    {
        int[] copies = new int[this.a * this.b];
        int[] numbers = new int[this.a * this.b];
        double count = 0, sum = 0;
        for(int i = 0; i < this.a; i++)
        {
            for(int j = 0; j < this.b; j++)
            {
                if(this.matrix[i, j] < 0)
                {
                    Console.WriteLine("el", this.matrix[i,j], "ind",Array.IndexOf(copies, this.matrix[i, j]));
                    int arrayIndex = Array.IndexOf(copies, this.matrix[i, j]);
                    Console.WriteLine("arr ind:", arrayIndex);
                    if ( arrayIndex == -1)
                    { 
                        copies.Append(this.matrix[i, j]);
                        numbers[copies.Length - 1] = 1;
                    }
                    else
                    {
                        numbers[arrayIndex]++;
                    }
                }
            }
        }
        foreach(int i in copies)
        {
            sum += i;
            count++;
        }
        sum /= count;
        return sum;
    }
}


