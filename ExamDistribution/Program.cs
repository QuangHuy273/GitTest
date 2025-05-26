using ExamDistribution.Components;
using ExamDistribution.Data;
using ExamDistribution.Services.Interfaces;
using ExamDistribution.Services;
using Microsoft.EntityFrameworkCore;
using ExamDistribution.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// services
builder.Services.AddScoped<IStaffService, StaffService>();
builder.Services.AddScoped<IFacilityService, FacilityService>();
builder.Services.AddScoped<IStaffMajorFacilityService, StaffMajorFacilityService>();
builder.Services.AddScoped<IMajorFacilityService, MajorFacilityService>();
builder.Services.AddScoped<IDepartmentFacilityService, DepartmentFacilityService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IMajorService, MajorService>();



// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
