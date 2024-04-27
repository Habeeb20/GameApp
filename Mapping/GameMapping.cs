using GameStore.Entity;
using GameStore.Dtos;
namespace GameStore.Mapping
{
    public static class GameMapping
    {
        public static Gaming ToEntity(this CreateGameDto game)
        {
            return new Gaming()
            {
                Name = game.Name,
                Genre = game.Genre,
                Price = game.Price,
                // ReleaseDate = game.ReleaseDate,

            };

        }

        public static Gaming ToEntity(this UpdateGameDto game, int id)
        {
            return new Gaming()
            {
                Id  = id,
                Name = game.Name,
                Genre = game.Genre,
                Price = game.Price,
                // ReleaseDate = game.ReleaseDate,

            };

        }
        // public static Gaming ToDto(this Gaming game)
        // {
        //     return new (
        //         game.Id,
        //         game.Name,
        //         game.Genre,
        //         game.Price
        //         // game.ReleaseDate
        // );
        // }
        
    }

    
}