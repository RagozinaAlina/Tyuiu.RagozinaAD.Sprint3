using Tyuiu.RagozinaAD.Sprint3.Task3.V12.Lib;
namespace Tyuiu.RagozinaAD.Sprint3.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();

            string str = "bkkrk ckkkcs ksr";
            char chr = 'k';

            int res = ds.GetMaxCharCount(str, chr);

            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
