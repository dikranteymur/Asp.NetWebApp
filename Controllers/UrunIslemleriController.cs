using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ViewYazmak.Controllers
{
    public class UrunIslemleriController : Controller
    {
        List<string> urunler = new List<string>  // sanal veritabani
        {
            "kalem",
            "silgi",
            "defter",
            "kitap",
            "kalemtras",
            "cikolata"
        };

        // IDE'ye mvc yaparsak mvc ile alakali snippet'ler gelir
        public IActionResult Index()  // listeleme islemleri Index ile yapilir (CRUD ---> R)
        {
            // ViewBag dinamik oldugu icin x yerine istedigimiz bir isim verebiliriz.
            // ViewBag.x = urunler;
            // return View();

            // Model kullanmak
            return View(urunler);
        }

    }
}