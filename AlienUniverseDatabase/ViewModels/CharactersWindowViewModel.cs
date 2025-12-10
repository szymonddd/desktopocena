using System.Collections.ObjectModel;
using AlienUniverseDatabase.Models;

namespace AlienUniverseDatabase.ViewModels;

public class CharactersWindowViewModel : ViewModelBase
{
    public ObservableCollection<Postac> Postacie { get; } = new()
    {
        new Postac
        {
            ImieNazwisko = "Ellen Louise Ripley",
            FilmNazwa = "Alien (1979), Aliens (1986), Alien³ (1992), Alien: Resurrection (1997)",
            Rola = "Oficer porządkowy / specjalistka ds. bezpieczeństwa",
            Aktor = "Sigourney Weaver",
            Rasa = "Człowiek",
            RokUrodzenia = 2092
        },
        new Postac
        {
            ImieNazwisko = "Arthur Koblenz Dallas",
            FilmNazwa = "Alien (1979)",
            Rola = "Kapitan USCSS Nostromo",
            Aktor = "Tom Skerritt",
            Rasa = "Człowiek",
            RokUrodzenia = 2071
        },
        new Postac
        {
            ImieNazwisko = "Ash",
            FilmNazwa = "Alien (1979)",
            Rola = "Oficer naukowy",
            Aktor = "Ian Holm",
            Rasa = "Android (Hyperdyne Systems 120-A/2)",
            RokUrodzenia = null
        },
        new Postac
        {
            ImieNazwisko = "Bishop",
            FilmNazwa = "Aliens (1986), Alien³ (1992)",
            Rola = "Oficer naukowy, android kolonialnych marines",
            Aktor = "Lance Henriksen",
            Rasa = "Android (Hyperdyne 341-B)",
            RokUrodzenia = null
        },
        new Postac
        {
            ImieNazwisko = "Jenette Vasquez",
            FilmNazwa = "Aliens (1986)",
            Rola = "Strzelec kolonialnych marines",
            Aktor = "Jenette Goldstein",
            Rasa = "Człowiek",
            RokUrodzenia = 2124
        },
        new Postac
        {
            ImieNazwisko = "Rebecca \"Newt\" Jorden",
            FilmNazwa = "Aliens (1986)",
            Rola = "Jedyna ocalała z kolonii Hadley’s Hope",
            Aktor = "Carrie Henn",
            Rasa = "Człowiek",
            RokUrodzenia = 2172
        },
        new Postac
        {
            ImieNazwisko = "The Queen Alien",
            FilmNazwa = "Aliens (1986), Alien: Resurrection (1997)",
            Rola = "Królowa ksenomorfów",
            Aktor = "Efekty praktyczne / animatronics",
            Rasa = "Ksenomorf",
            RokUrodzenia = null
        },
        new Postac
        {
            ImieNazwisko = "Annalee Call",
            FilmNazwa = "Alien: Resurrection (1997)",
            Rola = "Członkini załogi statku Betty",
            Aktor = "Winona Ryder",
            Rasa = "Android (Auton)",
            RokUrodzenia = 2381
        },
        new Postac
        {
            ImieNazwisko = "Ripley 8",
            FilmNazwa = "Alien: Resurrection (1997)",
            Rola = "Klon Ellen Ripley",
            Aktor = "Sigourney Weaver",
            Rasa = "Hybryda (człowiek / Obcy)",
            RokUrodzenia = 2381
        },
        new Postac
        {
            ImieNazwisko = "The Engineer",
            FilmNazwa = "Prometheus (2012)",
            Rola = "Starożytny stwórca ludzi",
            Aktor = "Ian Whyte",
            Rasa = "Inżynier",
            RokUrodzenia = null
        },
        new Postac
        {
            ImieNazwisko = "Neomorph",
            FilmNazwa = "Alien: Covenant (2017)",
            Rola = "Forma mutacyjna stworzona przez Davida",
            Aktor = "CGI",
            Rasa = "Obcy (mutant)",
            RokUrodzenia = null
        },
        new Postac
        {
            ImieNazwisko = "Daniels Branson",
            FilmNazwa = "Alien: Covenant (2017)",
            Rola = "Oficer kolonizacyjny",
            Aktor = "Katherine Waterston",
            Rasa = "Człowiek",
            RokUrodzenia = 2100
        }
    };
}