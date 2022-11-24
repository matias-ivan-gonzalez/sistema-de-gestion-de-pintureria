using Microsoft.Extensions.DependencyInjection;
using Pintureria.Aplicacion;
using Pintureria.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddTransient<AgregarClienteUseCase>();
builder.Services.AddTransient<ListarClientesUseCase>();
builder.Services.AddTransient<EliminarClienteUseCase>();
builder.Services.AddTransient<ModificarClienteUseCase>();
<<<<<<< HEAD
=======
builder.Services.AddTransient<BuscarClienteUseCase>();
>>>>>>> d7d627278d5d4a2257329ffe80c478f5b35f272c

builder.Services.AddTransient<AgregarProductoUseCase>();
builder.Services.AddTransient<ListarProductosUseCase>();
builder.Services.AddTransient<EliminarProductoUseCase>();
builder.Services.AddTransient<ModificarProductoUseCase>();
builder.Services.AddTransient<BuscarProductoUseCase>();


builder.Services.AddTransient<AgregarVentaUseCase>();
builder.Services.AddTransient<ListarVentasUseCase>();
builder.Services.AddTransient<BuscarVentaUseCase>();


builder.Services.AddScoped<IRepositorio<Cliente>, RepositorioSqlite<Cliente>>();
builder.Services.AddScoped<IRepositorio<Producto>, RepositorioSqlite<Producto>>();
builder.Services.AddScoped<IRepositorio<Venta>, RepositorioSqlite<Venta>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
