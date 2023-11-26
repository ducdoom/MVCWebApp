using ManyaffClient.Responses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ManyaffClient.Tests
{
    [TestClass()]
    public class ManyaffClientTests
    {
        [TestMethod()]
        public async Task LoginTest()
        {
            User user = new()
            {
                Email = "pub1@gmail.com",
                Password = "123456"
            };

            ManyaffClient manyaffClient = new();
            LoginResponse loginResponse = await manyaffClient.GetLoginResponse(user);
            Assert.AreEqual(true, loginResponse.Success);
        }
    }
}