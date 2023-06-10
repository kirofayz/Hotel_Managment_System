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
    public class RoomPageTest
    {
        [TestMethod]
        public void TestAddRoom()
        {
            var page = new UserControlRooms();
            var room = new Room
            { RoomNo = 20, RoomPrice = 50, RoomFree = "Y", RoomType = "Single " };

            page.AddRoom(room);


            var context = new HotelManagementSystemEntities();
            var existedRoom = context.Rooms.Find(room.RoomID);
            Assert.IsNotNull(existedRoom);





        }
        [TestMethod]

        public void TestDeleteRoom()
        {
            var page = new UserControlRooms();
            var room1 = new Room
            { RoomNo = 20, RoomPrice = 50, RoomFree = "Y", RoomType = "Single " };

            page.DeleteRoom(room1);
            var context1 = new HotelManagementSystemEntities();
            var existedRoom1 = context1.Rooms.Find(room1.RoomID);
            Assert.IsNotNull(existedRoom1);

        }
    }
}
