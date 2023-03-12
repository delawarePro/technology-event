using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using dte.wall.Data;

namespace dte.wall;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddHttpClient("2023", c => c.BaseAddress = new Uri("https://sessionize.com/api/v2/qqwyyssz/"));
        builder.Services.AddSingleton<Edition2023Service>();
        builder.Services.Configure<ConferenceOptions>(builder.Configuration.GetSection("conference"));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseRouting();

        app.MapBlazorHub();
        app.MapFallbackToPage("/_Host");

        app.Run();
    }
}
