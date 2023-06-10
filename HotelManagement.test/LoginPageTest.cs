using Hotel_Managment_System;
using Hotel_Managment_System.Controls;
using Hotel_Managment_System.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagement.test
{
    [TestClass]
    public class LoginPageTest
    {
        [TestMethod]
        public void TestLogin()
        {
            var page = new SignIn();
           var user= page.UserLogin("gemy","123");
            Assert.IsNotNull(user);


            

        }
    }
}
