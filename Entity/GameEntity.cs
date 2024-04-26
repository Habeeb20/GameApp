using System;
namespace GameStore.Entity
{
  public class Gaming
  {
    public int Id { get; set; } = 0;
    public string Name { get; set; }
    public int GenreId { get; set; }

    public Genre? Genre { get; set; }

    public decimal Price { get; set; }
    // public DateOnly ReleaseDate { get; set; }
  }
    
}