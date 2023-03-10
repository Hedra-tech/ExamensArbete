using ExamensArbeteMVC.DBcontext;
using ExamensArbeteMVC.RepositoryData;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<StoreContext>(options => options.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=Store;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
//builder.Services.AddDbContext<StoreContext>(option => option.UseSqlServer(("server = .; Database= Store ; Integrated security=True; TrustServerCertificate=True")));
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<StoreContext>();
builder.Services.AddControllersWithViews();


builder.Services.AddScoped< FormData>();
builder.Services.AddScoped<IAccountData, AccountData>();
builder.Services.AddScoped<ICourseData, CourseData>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error!!!!!");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
// add new middleware
app.UseHttpsRedirection();
app.UseStaticFiles();

using var scope = app.Services.CreateScope();
var dbContext = scope.ServiceProvider.GetRequiredService<StoreContext>();

//dbContext.Database.EnsureDeleted();
dbContext.Database.EnsureCreated();

app.UseRouting();


app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});
// I will use MapControllerRoute to add this endpoints controller like default route for home and index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
