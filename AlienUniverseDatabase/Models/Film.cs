using System.Collections.Generic;

namespace AlienUniverseDatabase.Models;

public class Film
{
    public string TytulOryginalny { get; set; } = "";
    public string TytulPolski { get; set; } = "";
    public int? RokPremiery { get; set; } 
    public string Rezyser { get; set; } = "";
    public string Gatunek { get; set; } = "";
    public int? CzasTrwania { get; set; } 
    public double? Ocena { get; set; }
    public List<string> Postacie { get; set; } = new List<string>();
    public string Statek { get; set; } = "";
    public string OpisFabuly { get; set; } = "";
    public string Ciekawostka { get; set; } = "";
}