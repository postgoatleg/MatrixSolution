using System.Runtime.InteropServices;

namespace MatrixClass;
public class Matrix
{
    int a, b;
    string? name = "";
    int[,] matrix;

    public Matrix(int a, int b, string? name, int[,]? matrixValues = null)
    {
        this.a = a;
        this.b = b;
        this.name = name;
        matrix = new int[a, b];
        matrix = matrixValues == null ? matrix : matrixValues;
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

    public int GetA()
    {
        return this.a;
    }

    public int GetElement(int i, int j)
    {
        return this.matrix[i, j];
    }

    public int GetB()
    {
        return this.b;
    }

    public bool IsTrue()
    {
        int i = 0, count = 0;
        while (i < this.a)
        {
            int j = 0;
            while (j < this.b)
            {
                if(this.matrix[i, j] == 0)
                {
                   count++;
                }
                j++;
            }
            i++;
        }
        if(this.a*this.b==count)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void FillMatrix()
    {
        for(int i = 0; i < this.a; i++)
        {
            for(int j =0; j < this.b; j++)
            {
                Console.Write($"Enter {this.name}[{i},{j}]: ");
                this.matrix[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        if (m1.a != m2.a || m1.b != m2.b)
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

    public int[,] GetMatrix()
    {
        return this.matrix;
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
    public string? GetName()
    {
        return this.name;
    }

    public double GetAverage(int n=0)
    {
        int[] copies = new int[this.a * this.b];
        int[] numbers = new int[this.a * this.b];
        int k = 0;
        double count = 0, sum = 0;
        for (int i = 0; i < this.a; i++)
        {
            for (int j = 0; j < this.b; j++)
            {
                if (this.matrix[i, j] < 0)
                {
                    int arrInd = Array.IndexOf(copies, this.matrix[i, j]);
                    if (arrInd == -1)
                    { 
                    copies[k] = this.matrix[i, j];
                    numbers[k]++;
                    k++;
                    }
                    else
                    {
                        numbers[arrInd]++;
                    }

                }
            }
        }

        for (int i = 0; i<copies.Length; i++)
        {
            if (numbers[i] >= n)
            {
                sum += copies[i] * numbers[i];
                count += numbers[i];
            }
        }
        count = count == 0 ? 1 : count;
        return sum / count;
    }
}


