using MatrixClass;
namespace MatrixTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMultiply()
    {
        int[,] ma = new int[,] { { 1, 2 }, { 3, 4 } };
        int[,] mb = new int[,] { { 5, 6 }, { 7, 8 } };
        Matrix a = new(2, 2, "a", ma);
        Matrix b = new(2, 2, "b", mb);
        Matrix c = a * b;
        //int count = 0;
        int[,] ans = new int[,] { { 19, 22 }, { 43, 50 } };
        for(int i = 0; i<c.GetA();i++)
        {
            for(int j = 0; j<c.GetB(); j++)
            {
                Assert.AreEqual(ans[i, j], c.GetElement(i, j));
                //if(ans[i,j] == c.GetElement(i,j))
                //{
                //    count++;
                //}
            }
        }
        //bool boolAns = count == c.GetA() * c.GetB() ? true : false;
        //Assert.AreEqual(true, boolAns);
    }

    [TestMethod]
    public void TestAverageMethod()
    {
        Matrix a = new(2, 2, "a");
        a.ChangeElement(0, 0, -5);
        a.ChangeElement(0, 1, -10);
        a.ChangeElement(1, 0, -5);
        a.ChangeElement(1, 1, 4);

        Assert.AreEqual((double)-20/3, a.GetAverage());
    }

    [TestMethod]
    public void TestIsTrueMethod()
    {
        Matrix a = new(2, 2, "a");
        a.ChangeElement(0, 0, 0);
        a.ChangeElement(0, 1, 0);
        a.ChangeElement(1, 0, 0);
        a.ChangeElement(1, 1, 0);

        Assert.AreEqual(false, a.IsTrue());
    }

    [TestMethod]
    public void TestChangeElement()
    {
        Matrix a = new(2, 2, "a");
        a.ChangeElement(0, 0, 95);

        Assert.AreEqual(95, a.GetElement(0,0));
    }
}
