using Pokedex.Api;
public class PokedexState
{
    public PokeApiClient Api { get; } = new();
    public string? NextLocationsUrl { get; set; }
    public string? PreviousLocationsUrl { get; set; }
}