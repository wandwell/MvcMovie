using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieSearchViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public SelectList? Years{ get; set; }
    public int?MovieYear{ get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
}