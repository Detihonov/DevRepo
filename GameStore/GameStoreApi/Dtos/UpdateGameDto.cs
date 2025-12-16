using System.ComponentModel.DataAnnotations;

namespace GameStoreApi.Dtos;

public record class UpdateGameDto(
    int GenreId,
    [Required] [StringLength(50)]string Name, 
    [Range(1,100)]decimal Price,
    DateOnly ReleaseDate
);
