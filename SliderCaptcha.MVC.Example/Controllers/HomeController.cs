using SliderCaptcha.NET;
using System;
using System.Collections;
using System.Drawing;
using System.Web.Mvc;

namespace SliderCaptcha.MVC.Example.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GetCaptcha()
        {
            Captcha64Model model = Captcha.GenerateBase64();
            Session["sliderX"] = model.X;
            Hashtable ht = new Hashtable();
            ht.Add("background", model.Background);
            ht.Add("slider", model.Slide);
            return Json(ht);
        }

        


        [ValidateAntiForgeryToken]
        public ActionResult CheckCaptcha(int x = 0)
        {
            Hashtable hs = new Hashtable();
            string Mess = "";
            int Code = 0;
            if (Session["sliderX"] == null)
            {
                Mess = "请刷新验证码";
                Code = 500;
                goto block;
            }
            string sliderXStr = Session["sliderX"] as string;
            int sliderX = Convert.ToInt32(sliderXStr);
            int difX = sliderX - x;
            if (difX >= 0 - Config.blod && difX <= Config.blod)
            {
                Mess = "success";
                Code = 0;
            }
            else
            {
                Session["sliderX"] = null;
                Mess = "错误";
                Code = 500;
            }
        block:
            hs.Add("Mess", Mess);
            hs.Add("Code", Code);
            return Json(hs);
        }

    }
}