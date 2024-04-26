using System.Security.AccessControl;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using System.Reflection.Metadata;
using GameStore.Service;
using GameStore.Dtos;
using GameStore.Entity;
using GameStore.data;
namespace GameStore.EndPoints
// {
//     public static class GameEndPoints
//     {
//         public static RouteGroupBuilder MapGamesEndpoints(this WebApplication routes)
//         {
//             var games=routes.MapGroup("games").WithParameterValidation(); 

//             games.MapGet("/", (IGameService service) =>
//              {
//                 var game = service.GetAllGameStores();
//                 return game;
//              });

//             games.MapGet("/{id}", (IGameService service, int id) =>
//             {
//                 var game = service.GetGame(id);
//                 return game is null ? null: Results.Ok(game);
//              });
            
            games.MapPost("/", (CreateGameDto newGame, DataContext dbContext ) => 
            {
                Gaming game = new()
                {
                    Name = newGame.Name,
                    Genre = dbContext.Genres.Find(newGame.GenreId)
                    GenreId = newGame.GenreId,
                    Price = newGame.Price
                };

                dbContext.Gaming.Add(game);
                dbContext.SaveChangesAsync();


  

            });
            return games;
//         }
        

//     }
// }