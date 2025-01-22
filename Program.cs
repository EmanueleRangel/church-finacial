using ChurchFinanceSystem.Data;
using ChurchFinanceSystem.Repositories;
using ChurchFinanceSystem.Services;
using Microsoft.EntityFrameworkCore;
using ApplicationDbContext = ChurchFinanceSystem.Data.ApplicationDbContext;

var builder = WebApplication.CreateBuilder(args);

// Configuração do DbContext com a string de conexão no appsettings.json
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Injeção de dependências para os repositórios e serviços
builder.Services.AddScoped<IInvoiceCategoryRepository, InvoiceCategoryRepository>();
builder.Services.AddScoped<IInvoiceCategoryService, InvoiceCategoryService>();

// Outras configurações de serviço e middlewares
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuração do Swagger e outros middlewares
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
