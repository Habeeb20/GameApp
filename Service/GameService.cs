// using System;
// using System.Security.AccessControl;
// using System.Net.Cache;
// using System.Reflection.Metadata;
// using GameStore.data;
// using System.Collections.Generic;
// using GameStore.Service;
// using GameStore.Entity;
// namespace GameStore.Service
// {
//     public class GameService : IGameService
//     {
//         //   private static List<Gaming> gaming = new List<Gaming> {
//         //         new Gaming{Id = 1, Name = "spiderMan", Genre = "peter", Price = 55.55M, ReleaseDate = DateTime.Now},
//         // };


        
//         private readonly GameStoreContext  _context;

//         public GameService(GameStoreContext context)
//         {
//             _context = context;
//         }

//         public async Task<List<Gaming>> GetAllGameStores()
//         {
//             var Game = await _context.Gaming.ToListAsync();
//             return Game;
//         }

//         public async Task<Gaming?> GetGame(int id)
//         {
//             var Game = await _context.Gaming.FindAsync(id);
//             if(Game is null)
//             {
//                 return null;
//             }
//             return Game;
//         }

//         public async Task<List<Gaming>> AddGame(Gaming game)
//         {
//             var Game = await _context.Gaming.AddAsync(game);
//             if(Game is null)
//             {
//                 return null;
//             }
//             return await _context.Gaming.ToListAsync();
//         }


//         public async Task<List<Gaming>> UpdateGame(int id, Gaming request)
//         {
//             var Game = await _context.Gaming.FindAsync( id);
//             if (Game is null)
//             {
//                 return null;
//             }

//             Game.Name = request.Name;
//             Game.Genre = request.Genre;
//             Game.Price = request.Price;
           

//             await _context.SaveChangesAsync();
//             return await _context.Gaming.ToListAsync(); 
//         }

//         public async Task<List<Gaming>> DeleteGame(int id)  
//         {
//             var Game = await _context.Gaming.FindAsync(id);
//             if(Game is null)
//             {
//                 return null;
//             }

//              _context.Gaming.Remove(Game);
//             await _context.SaveChangesAsync();
//             return  await _context.Gaming.ToListAsync(); 


//         }
//     }

  
// }    
