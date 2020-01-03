using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Aveva.Pdms.Database;
using ATT = Aveva.Pdms.Database.DbAttributeInstance;



namespace Aveva.Pdms.Spec
{
    class DBService
    {
      private MDB mDB;
       public DBService() {
            mDB = MDB.CurrentMDB;
        }

        public List<String> Query() {
            List<String> strList = new List<String>();
            Db[] dBList= mDB.GetDBArray();
            foreach (Db db in dBList) {
                strList.Add(db.Name);
            }
            return strList;
        }

    }
}
