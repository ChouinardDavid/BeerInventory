using EFObjects.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace BeerInventory
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            UnityConfig.RegisterComponents();  //Permet l'utilisation de Unity.MVC5
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Permet l'utilisation de EntityFramework et l'initialisatin de la bd selon 'DBInitializer.cs'
            IDatabaseInitializer<DBContext> init = new DBInitializer();
            Database.SetInitializer(init);
            init.InitializeDatabase(DBContext.GetInstance());
        }
    }
}
