using Authentication.Core.DTOs;
using Authentication.Core.Entities;
using Authentication.Infrastructure.Configuration;
using Authentication.Infrastructure.Implementations;
using Fluent.Infrastructure.FluentModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Authentication.Test
{
    [TestClass]
    public class UnitTest_Login
    {
        private UserDTO user;
        private LoginRepository loginRepository;
        private readonly DataContext _context;
        public UnitTest_Login()
        {
            



        }
        [TestMethod]
        public void Login_ShouldBeTrue()
        {
            user.email = "test";
            user.password = "123456";

      

            Response response=loginRepository.Check(user);
            Assert.IsTrue((bool)response.content);
        }
        public void Login_ShouldBeFalse()
        {
            user.email = "test";
            user.password = "123456 ";
            Response response = loginRepository.Check(user);
            Assert.IsFalse((bool)response.content);
        }
        public void Login_ShouldBeFalseAndShowMessageRangeEmail()
        {
            user.email = "t";
            user.password = "123456";
            Response response = loginRepository.Check(user);
            Assert.IsFalse((bool)response.content);
        }
        public void Login_ShouldBeFalseAndShowMessageRangePassword()
        {
            user.email = "test";
            user.password = "";
            Response response = loginRepository.Check(user);
            Assert.IsFalse((bool)response.content);
        }
        public void Login_ShouldBeFalseAndShowMessageEmailRequired()
        {
            user.email = "";
            user.password = "123456";
            Response response = loginRepository.Check(user);
            Assert.IsFalse((bool)response.content);
        }
        public void Login_ShouldBeFalseAndShowMessagePasswordRequired()
        {
            user.email = "test";
            user.password = "";
            Response response = loginRepository.Check(user);
            Assert.IsFalse((bool)response.content);
        }
        public void Login_ShouldBeFalseAndShowMessageBothRequired()
        {
            user.email = "";
            user.password = "";
            Response response = loginRepository.Check(user);
            Assert.IsFalse((bool)response.content);
        }
        public void Login_ShouldBeFalseAndShowMessageEmailInvalid()
        {
            user.email = "t";
            user.password = "123456";
            Response response = loginRepository.Check(user);
            Assert.IsFalse((bool)response.content);
        }
    }
}
