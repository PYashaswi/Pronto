using System.Linq;
using ProntoApp;

namespace DataOp
{
    public class DataOpertations
    {
        public bool login(login user)
        {
            using (var cntx = new Model())
            {
                if (cntx.tblUsers.Any(c => c.tblUserID == user.userID && c.Password == user.password))
                {
                    return true;
                }
                return false;
            }
        }
        public void depot(login user)
        {
            using (var cntx = new Model())
            {
                var list = cntx.tblManifests.GroupBy(c => user.userID).ToList();
                //print list;
                /*foreach()
                {
                    Console.WriteLine();
                }*/
                //return cntx.tblManifests.GroupBy(c => user.userID).ToList();
            }
        }

    }
}
