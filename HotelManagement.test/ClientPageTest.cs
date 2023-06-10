using Hotel_Managment_System;
using Hotel_Managment_System.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagement.test
{
    [TestClass]
    public class ClientPageTest
    {
        [TestMethod]
        public void TestAddClient()
        {


            var page = new UserControlClient();
            var client = new Client
            {
                Address = "kahsua",
                firstName = "asghgas",
                lastName = "ABhgsh",
                phone = "ABHSAGJHS",

            };

            page.AddClient(client);


            var context = new HotelManagementSystemEntities();
            var clients = context.Clients.ToList();
            Assert.IsTrue(clients.Any(a=>a.ClientID==client.ClientID));


            

        }
    }
}
