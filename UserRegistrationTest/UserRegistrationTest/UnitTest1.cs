using NUnit.Framework;
using UserRegistration;

namespace UserRegistrationTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        Program prg = new Program();
        [Test]
        public void Test1()
        {
            var data1=prg.firstNameValidate("Sanju");
            Assert.AreEqual("Valid", data1);
        }

        [Test]
        public void Test2()
        {
            var data2 = prg.lastNameValidate("Bridge");
            Assert.AreEqual("Valid", data2);
        }

        [Test]
        public void Test3()
        {
            var data3 = prg.emailValidate("sanju@gmail.com");
             Assert.AreEqual("Valid", data3);
        }

        [Test]
        public void Test4()
        {
            var data4 = prg.emailValidate("sanju.jais12@gmail.com");
            Assert.AreEqual("Valid", data4);
        }

        [Test]
        public void Test5()
        {
            var data5 = prg.mobileNoValidate("91 9975653632");
            Assert.AreEqual("Valid", data5);
        }
        
        [Test]
        public void Test6()
        {
            var data6 = prg.mobileNoValidate("916675653632");
            Assert.AreEqual("Invalid", data6);
        }

        [Test]
        public void Test7()
        {
            var data7 = prg.mobileNoValidate("91 6675653632");
            Assert.AreEqual("Valid", data7);
        }

        [Test]
        public void Test8()
        {
            var data8 = prg.passwordValidate("Absjud12$");
            Assert.AreEqual("Valid", data8);
        }

        [Test]
        public void Test9()
        {
            var data9 = prg.passwordValidate("Sabjt12345#");
            Assert.AreEqual("Valid", data9);
        }

        [Test]
        public void Test10()
        {
            var data10 = prg.passwordValidate("bspK123@");
            Assert.AreEqual("Valid", data10);
        }

    }
}