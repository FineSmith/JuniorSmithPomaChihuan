var builder = WebApplication.CreateBuilder(args);

// Configurar URLs
builder.WebHost.UseUrls("http://localhost:8080");

var app = builder.Build();

app.MapGet("/", () =>
{
    return "API Sistema Academico funcionando";
});

app.MapGet("/api/copteles", () =>
{
    return Results.Ok(new[]
    {
        new
        {
            Id = 1,
            Nombre = "Mojito Cubano",
            Precio = 8.50m,
            Ingredientes = new List<string>
            {
                "Ron Blanco", "Menta", "Azúcar", "Lima", "Agua con gas"
            },
            Stock = 25
        },
        new
        {
            Id = 2,
            Nombre = "Margarita Clasica",
            Precio = 9.00m,
            Ingredientes = new List<string>
            {
                "Tequila", "Triple Sec", "Jugo de Lima", "Sal"
            },
            Stock = 18
        },
        new
        {
            Id = 3,
            Nombre = "Old Fashioned",
            Precio = 10.50m,
            Ingredientes = new List<string>
            {
                "Bourbon", "Amargo de Angostura", "Terrón de Azúcar", "Naranja"
            },
            Stock = 12
        },
        new
        {
            Id = 4,
            Nombre = "Piña Colada",
            Precio = 8.00m,
            Ingredientes = new List<string>
            {
                "Ron Blanco", "Crema de Coco", "Jugo de Piña"
            },
            Stock = 30
        },
        new
        {
            Id = 5,
            Nombre = "Gin Tonic Botanico",
            Precio = 9.50m,
            Ingredientes = new List<string>
            {
                "Ginebra", "Agua Tónica", "Enebro", "Rodaja de Pepino"
            },
            Stock = 20
        },
        new
        {
            Id = 6,
            Nombre = "Daiquiri de Fresa",
            Precio = 8.50m,
            Ingredientes = new List<string>
            {
                "Ron Blanco", "Fresas", "Jugo de Lima", "Jarabe de Azúcar"
            },
            Stock = 15
        },
        new
        {
            Id = 7,
            Nombre = "Espresso Martini",
            Precio = 11.00m,
            Ingredientes = new List<string>
            {
                "Vodka", "Licor de Café", "Café Espresso", "Jarabe de Azúcar"
            },
            Stock = 10
        },
        new
        {
            Id = 8,
            Nombre = "Aperol Spritz",
            Precio = 8.00m,
            Ingredientes = new List<string>
            {
                "Aperol", "Prosecco", "Agua con gas", "Rodaja de Naranja"
            },
            Stock = 22
        },
        new
        {
            Id = 9,
            Nombre = "Pisco Sour",
            Precio = 9.50m,
            Ingredientes = new List<string>
            {
                "Pisco", "Jugo de Limón", "Jarabe de Goma",
                "Clara de Huevo", "Amargo de Angostura"
            },
            Stock = 16
        },
        new
        {
            Id = 10,
            Nombre = "Negroni",
            Precio = 10.00m,
            Ingredientes = new List<string>
            {
                "Ginebra", "Campari", "Vermut Rojo"
            },
            Stock = 14
        }
    });
});

app.Run();