using Microsoft.AspNetCore.Mvc;

namespace ViewYazmak.Controllers
{
    public class MerhabaController : Controller
    {
        public string Hosgeldiniz()
        {
            return "Merhaba <b>Ahmet</b>, uygulamamiza hosgeldiniz...";
        }

        // view veya json firlatabilmek isin IActionResult kullanilir.
        public IActionResult ViewliHosgeldiniz()
        {
            var isim = "Ahmet";

            // viewbag.isim ile veriyi gonderiyoruz. .isim ---> isim degiskeni
            ViewBag.isim = isim;

            // return view() olunca ViewliHosgeldiniz.cshtml dosyasini arar
            return View();
        }
    }
}