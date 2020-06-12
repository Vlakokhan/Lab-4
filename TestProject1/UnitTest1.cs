using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Lab41.Student student =new Lab41.Student("Микола","Шевчук","IТ-14",2019,"вулиця.Личакiвська 78","465895693",23,"067 564 7854",78);
            string rating1 = "Mожна вчитися краще";
            string result = student.StudentRating(student.Rating);
            Assert.AreEqual(rating1,result);
        }
    }
}