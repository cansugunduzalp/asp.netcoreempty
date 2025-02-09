var builder = WebApplication.CreateBuilder(args);

// MVC servislerinin eklenmesi
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Statik dosyalarýn kullanýlmasýný saðlayacak konfigürasyon
app.UseStaticFiles(); // wwwroot klasöründeki statik dosyalarýn kullanýlmasýný saðlar.

// Routing yapýlandýrmasý
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Varsayýlan route: HomeController, Index action.

app.Run();


// builder.Build() metodu:
// WebApplication nesnesi oluþturulup, uygulamanýn çalýþtýrýlabilir hale gelmesini saðlar.

// app.Run() metodu:
// Web uygulamasýný baþlatýr ve gelen istekleri iþlemeye baþlar.

// MVC ile ilgili kavramlar:
// Controller: Kullanýcýdan gelen istekleri iþleyen sýnýflar (HomeController).
// Action: Controller'da bulunan metodlar, istekleri iþleyip uygun View'ý döndürür.
// Model: Controller ile View arasýnda veri taþýyan yapýlar.
// View: Kullanýcýya gösterilen HTML içerikleri, Razor View dosyalarý kullanýlarak oluþturulur.
// Razor: C# kodu ile HTML'in birleþimini saðlayan view þablon dili.
// RazorView: Razor dili ile yazýlmýþ HTML içeriði (örneðin, Index.cshtml).
// wwwroot: Statik dosyalarýn (CSS, JavaScript, resimler) bulunduðu klasör, kullanýcýya doðrudan sunulabilir.
