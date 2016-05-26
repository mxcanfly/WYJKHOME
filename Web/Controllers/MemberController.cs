using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class MemberController : Controller
    {
        private ADOModel1 db = new ADOModel1();
        // GET: Member
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public String doLogin(String UserName,String Password,String checkCode)
        {
            UserName=UserName.Replace("'", "''");
            Password = Password.Replace("'", "''");

            DbRawSqlQuery<Members> res = db.Database.SqlQuery<Members>("select * from Members where (MemberName='" + UserName + "' or MemberPhone = '" + UserName + "') and Password='" + Password + "' ");

            foreach (var item in res)
            {
                this.Response.Redirect("/Index/Index");
            }

            return "登陆失败";

        }
    }
}