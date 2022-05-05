using EnglishWords.Data;
using EnglishWords.Repositories;
using EnglishWords.Services;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();

//DBŠÖ˜A
builder.Services.AddDbContext<EnglishWordsDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//RepositoryŠÖ˜A
builder.Services.AddScoped<IEnglishWordRepository, EnglishWordRepository>();
builder.Services.AddScoped<IRecordRepository, RecordRepository>();
builder.Services.AddScoped<ITranslationRepository, TranslationRepository>();

//ServiceŠÖ˜A            
builder.Services.AddScoped<IEnglishWordService, EnglishWordService>();
builder.Services.AddScoped<IRecordService, RecordService>();
builder.Services.AddScoped<ITranslationService, TranslationService>();


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