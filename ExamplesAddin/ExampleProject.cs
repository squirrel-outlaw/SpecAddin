using System;
using System.Collections.Generic;
using System.Text;

using Aveva.Pdms.Database;
using Aveva.Pdms.Utilities.Messaging;
using Aveva.PDMS.Database.Filters;
using Aveva.Pdms.Geometry;

namespace Aveva.Pdms.Examples
{
    public class ExampleProject
    {
        public static void Run()
        {
            //Project name
            string projName = Project.CurrentProject.Name;

            //User name
            string userName = Project.CurrentProject.UserName;

            //MDB name
            string MDBName = MDB.CurrentMDB.Name;
        }
    }
}