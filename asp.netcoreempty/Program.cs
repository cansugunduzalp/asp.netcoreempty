var builder = WebApplication.CreateBuilder(args);

// MVC servislerinin eklenmesi
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Statik dosyalar�n kullan�lmas�n� sa�layacak konfig�rasyon
app.UseStaticFiles(); // wwwroot klas�r�ndeki statik dosyalar�n kullan�lmas�n� sa�lar.

// Routing yap�land�rmas�
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Varsay�lan route: HomeController, Index action.

app.Run();


// builder.Build() metodu:
// WebApplication nesnesi olu�turulup, uygulaman�n �al��t�r�labilir hale gelmesini sa�lar.

// app.Run() metodu:
// Web uygulamas�n� ba�lat�r ve gelen istekleri i�lemeye ba�lar.

// MVC ile ilgili kavramlar:
// Controller: Kullan�c�dan gelen istekleri i�leyen s�n�flar (HomeController).
// Action: Controller'da bulunan metodlar, istekleri i�leyip uygun View'� d�nd�r�r.
// Model: Controller ile View aras�nda veri ta��yan yap�lar.
// View: Kullan�c�ya g�sterilen HTML i�erikleri, Razor View dosyalar� kullan�larak olu�turulur.
// Razor: C# kodu ile HTML'in birle�imini sa�layan view �ablon dili.
// RazorView: Razor dili ile yaz�lm�� HTML i�eri�i (�rne�in, Index.cshtml).
// wwwroot: Statik dosyalar�n (CSS, JavaScript, resimler) bulundu�u klas�r, kullan�c�ya do�rudan sunulabilir.
