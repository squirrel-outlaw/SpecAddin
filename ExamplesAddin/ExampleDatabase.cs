using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using Aveva.Pdms.Database;
using Aveva.Pdms.Utilities.Messaging;
using Aveva.PDMS.Database.Filters;
using Aveva.Pdms.Geometry;

namespace Aveva.Pdms.Examples
{
    public class ExampleDatabase
    {
        // db example
        public static void Run()
        {
            //Iterate thru all design db's in mdb
            Db[] dbs = MDB.CurrentMDB.GetDBArray(DbType.Design);
            foreach (Db db in dbs)
            {
                Console.WriteLine(db.Name);
            }
        }
    }
}