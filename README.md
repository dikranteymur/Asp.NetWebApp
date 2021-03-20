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