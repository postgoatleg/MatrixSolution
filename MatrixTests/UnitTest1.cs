using MatrixClass;
namespace MatrixTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMultiply()
    {
        Matrix a = new(2, 2, "a");
        Matrix b = new(2, 2, "b");
        a.ChangeElement(0, 0, 1);
        a.ChangeElement(0, 1, 2);
        a.ChangeElement(1, 0, 3);
        a.ChangeElement(1, 1, 4);
        b.ChangeElement(0, 0, 5);
        b.ChangeElement(0, 1, 6);
        b.ChangeElement(1, 0, 7);
        b.ChangeElement(1, 1, 8);
        Matrix c = a * b;
        Equals(c.PrintMatrix(), $"Matrix ab:\n19, 22,\n43, 50,\n");
    }

    [TestMethod]
    public void TestAverageMethod()
    {
        Matrix a = new(2, 2, "a");
        a.ChangeElement(0, 0, -5);
        a.ChangeElement(0, 1, -10);
        a.ChangeElement(1, 0, -5);
        a.ChangeElement(1, 1, 4);

        Equals(a.GetAverage(), -20/3);
    }

    [TestMethod]
    public void TestIsTrueMethod()
    {
        Matrix a = new(2, 2, "a");
        a.ChangeElement(0, 0, 0);
        a.ChangeElement(0, 1, 0);
        a.ChangeElement(1, 0, -5);
        a.ChangeElement(1, 1, 0);

        Equals(a.IsTrue(), true);
    }
}
