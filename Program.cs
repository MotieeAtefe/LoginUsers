using LoginUsers.Models;

var builder = WebApplication.CreateBuilder(args);

// افزودن خدمات به DI container
builder.Services.AddControllersWithViews();

var app = builder.Build();

// پیکربندی Middleware
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Person}/{action=Create}/{id?}");

app.Run();