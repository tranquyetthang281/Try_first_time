using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubSoftware.Model
{
    class DataProvider
    {
        private static DataProvider _ins;
        public static DataProvider Ins { get { if (_ins == null) _ins = new DataProvider(); return _ins; } set { _ins = value; } }

        public ClubSofwareDatabaseEntities DB { get; set; }

        void foo()
        {
            var newUser = new User();
            newUser.DisplayName = "Thang";
            newUser.UserName = "Thayboingugat";
            newUser.Password = "28012001";
            newUser.IdRole = 1;
            Model.DataProvider.Ins.DB.Users.Add(newUser);
            Model.DataProvider.Ins.DB.SaveChanges();

            var theUser = (from p in Model.DataProvider.Ins.DB.Users where p.DisplayName == "Thang" select p).Single();
            theUser.Descriptions = "Đẹp trai voãi";
            Model.DataProvider.Ins.DB.Users.Remove(theUser);
            Model.DataProvider.Ins.DB.SaveChanges();
        }
    }
}
