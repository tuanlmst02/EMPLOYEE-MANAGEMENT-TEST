using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using EmployeeManagementTest.Controllers;

namespace EmployeeManagementUnitTest
{
    [TestClass]
    public class ControllerTest
    {
        /// <summary>
        /// TestMethod Index
        /// </summary>
        [TestMethod]
        public void Index()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }

        /// <summary>
        /// TestMethod Register
        /// </summary>
        [TestMethod]
        public void Register()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Register() as ViewResult;

            Assert.IsNotNull(result);
        }

        /// <summary>
        /// TestMethod Login
        /// </summary>
        [TestMethod]
        public void Login()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Login() as ViewResult;

            Assert.IsNotNull(result);
        }

        /// <summary>
        /// TestMethod News
        /// </summary>
        [TestMethod]
        public void News()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.News() as ViewResult;

            Assert.IsNotNull(result);
        }

        /// <summary>
        /// TestMethod Logout
        /// </summary>
        [TestMethod]
        public void Logout()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Logout() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
