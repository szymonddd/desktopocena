using System.Collections.Generic;

namespace AlienUniverseDatabase.Models;

public class Film
{
    public string TytulOryginalny { get; set; }
    public string TytulPolski { get; set; }
    public int RokPremiery { get; set; }
    public string Rezyser { get; set; }
    public string Scenariusz { get; set; }
    public string Gatunek { get; set; }
    public string CzasTrwania { get; set; }
    public double Ocena { get; set; }
    public string Statek { get; set; }
    public string OpisFabuly { get; set; }
    public string Ciekawostka { get; set; }
    public List<Postac> Postacie { get; set; } = new List<Postac>();
}