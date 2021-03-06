# ViewYazmak
Asp.Net ile MVC uygulaması yapmak

## Projeyi calistirmak ve gozlemak
```cs
dotnet run
dotnet watch run
```

## Action katmanindan veri aktarmak
```cs
// Action Katmani
var isim = "Ahmet";
ViewBag.isim = isim;
// .isim yerine istenilen bir parametre kullanilabilir.

// View Katmani
// cs kodlarini .cshtml dosyasinda kullanmak icin @ isareti kullanililr.
@ViewBag.isim 
```

## Razor Goruntu Motoru
- View dosyalarinin uzantisi **.cshtml**
- CSharp kodlarini kullanmak icin kullanacagimiz cs kodunun onune **@** isareti koymaliyiz.
- @ isareti koymazsak butun yazilanlar html kodu olarak kabul edilir.

```cs
// Controllers/UrunIslemleriController.cs
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
        ViewBag.x = urunler;
        return View();
    }
```

```cs
// Views/UrunIslemleri/Index.cshtml
@foreach (var item in ViewBag.x)
{
    <p>item</p>     // Ekrana urunler.Length kadar 'item' yazar
    <p>@item</p>    // Ekrana urunler listesinde bulunan string'ler yazilir
}
```
> **Not:**
- CSharp kodu calisacaksa onune mutlaka **@** isareti konmali.

#### Razor Ifadeleri
- @Deneme -> Ortuk Razor ifadesi
- @(deneme - deneme2) -> Acik Razor ifadesi
- @{...} -> Razor kod bloklari

## ViewBag Yerine Model Kullanmak
- Model dosyasinda  -> `return View(model_ismi)` 
- View dosyasinda   -> `@model <model tipi>` Kullanirken: `Model`

```cs
// Controllers/UrunIslemleriController.cs
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
        //return View();
        return View(urunler);
    }
```

```cs
// Views/UrunIslemleri/Index.cshtml
@model List<string>  // Gelen model tipi

@foreach (var item in Model)
{
    <p>item</p>     // Ekrana urunler.Length kadar 'item' yazar
    <p>@item</p>    // Ekrana urunler listesinde bulunan string'ler yazilir
}
```