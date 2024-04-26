using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using System.Security.AccessControl;
using System.Collections.ObjectModel;
using System.IO;
using GameStore.Dtos;
// using GameStore.EndPoints;
// using GameStore.Service;
using GameStore.data;
using System.Collections.Generic;
var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddDbContext<DataContext>();
// dotnet add package Microsoft.EntityFrameworkCore.SqlServer
// using Microsoft.EntityFrameworkCore;
// builder.Services.AddSqlServer<GameStoreContext>(builder.Configuration.GetConnectionString("Server=.\\SQLEXPRESS;Database=GameStore;Trusted_Connection=true;TrustServerCertificate=true"));
                                                                                            

var app = builder.Build();
app.MigrateDb();
// app.MapGamesEndpoints();

// const string GetGame= "GetGame";


// app.MapGet("games", () => games);

// app.MapGet("game/{id}", (int id) => games.Find(game => game.Id == id)).WithName(GetGame);

// app.MapPost("game", (CreateGameDto newgame) => 
// {
//     GameDtos game = new (
//         games.Count =+ 1,
//         newgame.Name,
//         newgame.Genre,
//         newgame.Price,
//         newgame.ReleaseDate

//     );

//     games.Add(game);

//     return Results.CreatedAtRoute(GetGame, new {id = game.Id}, game);
// });


app.Run();
