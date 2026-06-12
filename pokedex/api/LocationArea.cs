namespace Pokedex.Api;
public record LocationAreaPage(
    int count,
    string? next,
    string? previous,
    List<LocationAreaRef> Results);
public record LocationAreaRef(string Name, string Url);