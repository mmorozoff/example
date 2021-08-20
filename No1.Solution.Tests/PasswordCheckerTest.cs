using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerTest
    {
        [Test]
        public void RepositoryTests_CorrectParameters()
        {
            PasswordCheckerService service = new PasswordCheckerService(new PasswordChecker(), new ListRepository());
            service.VerifyPassword("123asd132");
            service.VerifyPassword("123");
            service.VerifyPassword("159asd156");
            Assert.AreEqual(2, service.Show().Length);
        }
    }
}
