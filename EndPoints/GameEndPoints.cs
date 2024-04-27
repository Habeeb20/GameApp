using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;
using System.Security.AccessControl;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using System.Reflection.Metadata;
using GameStore.Mapping;
using GameStore.Dtos;
using GameStore.Entity;
using GameStore.data;
namespace GameStore.EndPoints
{
    public static class GameEndPoints
    {

        const  string GetGameEndpointName = "GetGame";
        public static RouteGroupBuilder MapGamesEndpoints(this WebApplication app)
        {
            var games=app.MapGroup("games").WithParameterValidation(); 

            games.MapGet("/", async(DataContext dbContext) => 
            await dbContext.Gaming.ToListAsync());
 
            games.MapGet("/{id}", async(int id, DataContext dbContext) =>
            {
                Gaming? game = await dbContext.Gaming.FindAsync(id);

                return game is null ? Results.NotFound() : Results.Ok(game); 


            }).WithName(GetGameEndpointName); 

            
            games.MapPost("/", async (CreateGameDto newGame, DataContext dbContext ) => 
            {
                Gaming game = newGame.ToEntity();
                // game.Genre = dbContext.Genre.Find(newGame.GenreId);
              

                dbContext.Gaming.Add(game);
                await dbContext.SaveChangesAsync();

                return Results.CreatedAtRoute(
                    GetGameEndpointName
                

                );


  

            });

            games.MapPut("/{id}", async (int id, UpdateGameDto updatedGame, DataContext dbContext ) => {
                var existingGame = await dbContext.Gaming.FindAsync(id);
                if(existingGame is null)
                {   
                    return Results.NotFound();
                }
                dbContext.Entry(existingGame).CurrentValues.SetValues(updatedGame.ToEntity(id));

                await dbContext.SaveChangesAsync();

                return Results.NoContent();

            });
            games.MapDelete("/{id}", async (int id, DataContext dbContext) => 
            {
               await  dbContext.Gaming.Where(game => game.Id == id).ExecuteDeleteAsync();
                return Results.NoContent();

            });
           return games;
        }
         
        

    }
}