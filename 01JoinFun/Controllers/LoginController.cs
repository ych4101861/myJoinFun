using System.Configuration;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace _01JoinFun.Controllers
{
    public class LoginController : Controller
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["JoinFunConnectionString"].ConnectionString);

        // GET: Login
        //登入
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Account, string Password)
        {
            string sql = "select * from tStudent where Account=@Account  and Password=@Password";

            SqlCommand cmd = new SqlCommand(sql, Conn);
            cmd.Parameters.AddWithValue("@Account", Account);
            cmd.Parameters.AddWithValue("@Password", Password);
            SqlDataReader rd;

            Conn.Open();
            rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                Session["Account"] = rd["Account"].ToString();
                Session["Password"] = rd["Password"].ToString();

                Conn.Close();
                return RedirectToAction("Home");
            }


            Conn.Close();
            ViewBag.LoginErr = "帳號或密碼有誤!!";
            return View();

        }
        //成功登入首頁跳轉頁面
        public ActionResult Home()
        {
            return View();
        }

        //成功登入首頁跳轉頁面
        public ActionResult Register()
        {
            return View();
        }

        //登出
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }

    }
}