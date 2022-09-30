namespace GlobalAssemblyTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var assembly1=  typeof(ClassLibrary1.Class1).Assembly;
            var assembly2 = typeof(ClassLibrary2.Class1).Assembly;
            var assembly3 = typeof(ClassLibrary3.Class1).Assembly;

         
            Assert.True(assembly1.FullName.Contains("2.0.2.1"));
            Assert.True(assembly2.FullName.Contains("2.0.2.1"));
            Assert.True(assembly3.FullName.Contains("2.0.2.1"));
            //Assert.Pass();
        }
    }
}