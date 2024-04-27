using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using System.Security.AccessControl;
using System.Collections.ObjectModel;
using System.IO;
using GameStore.Dtos;
using GameStore.EndPoints;

using GameStore.data;
using System.Collections.Generic;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataContext>();
// dotnet add package Microsoft.EntityFrameworkCore.SqlServer
// using Microsoft.EntityFrameworkCore;
// builder.Services.AddSqlServer<GameStoreContext>(builder.Configuration.GetConnectionString("Server=.\\SQLEXPRESS;Database=GameStore;Trusted_Connection=true;TrustServerCertificate=true"));
                                                                                            

var app = builder.Build();
await app.MigrateDbAsync();
app.MapGamesEndpoints();

app.Run();
