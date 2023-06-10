using Hotel_Managment_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.test
{
    class DbMock
    {

        public List<Client> clients = new List<Client>();
        public Exception ExceptionToThrow { get; set; }
        public void AddClient(Client client)
        {
            if (ExceptionToThrow != null)
                throw ExceptionToThrow;
            clients.Add(client);
        }



    }
}
