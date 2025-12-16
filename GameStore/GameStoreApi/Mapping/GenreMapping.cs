using GameStoreApi.Dtos;
using GameStoreApi.Entities;

namespace GameStoreApi.Mapping;

public static class GenreMapping
{
    public static GenreDto ToDto(this Genre genre) => new(genre.Id, genre.Name);
}
