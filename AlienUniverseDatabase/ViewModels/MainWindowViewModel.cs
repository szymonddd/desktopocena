using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;
using AlienUniverseDatabase.Models;
using ReactiveUI;

namespace AlienUniverseDatabase.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
     public ObservableCollection<Film> Films { get; } = new()
    {
        new Film
        {
            TytulOryginalny = "Alien",
            TytulPolski = "Obcy – ósmy pasażer Nostromo",
            RokPremiery = 1979,
            Rezyser = "Ridley Scott",
            Gatunek = "Sci-Fi / Horror",
            CzasTrwania = 117,
            Ocena = 8.5,
            Postacie = new List<string> { "Ellen Ripley", "Dallas", "Ash", "Lambert", "Kane" },
            Statek = "USCSS Nostromo",
            OpisFabuly = "Załoga statku handlowego Nostromo odbiera sygnał z nieznanej planety. " +
                        "Po lądowaniu odkrywają obcą formę życia, która zaczyna eliminować członków załogi jeden po drugim.",
            Ciekawostka =
                "Scena z „wyskakującym potworem” z klatki piersiowej aktora była niespodzianką dla obsady – ich reakcje są autentyczne."
        },

        new Film
        {
            TytulOryginalny = "Aliens",
            TytulPolski = "Obcy – decydujące starcie",
            RokPremiery = 1986,
            Rezyser = "James Cameron",
            Gatunek = "Sci-Fi / Akcja / Horror",
            CzasTrwania = 137,
            Ocena = 8.4,
            Postacie = new List<string> { "Ellen Ripley", "Hicks", "Newt", "Bishop", "Vasquez" },
            Statek = "USS Sulaco",
            OpisFabuly =
                "Ripley, jedyna ocalała z wcześniejszego ataku obcego, wraca z oddziałem kolonialnych marines " +
                "na księżyc LV-426, by zbadać utratę kontaktu z kolonią. Wkrótce stają oko w oko z armią obcych.",
            Ciekawostka =
                "James Cameron napisał scenariusz podczas lotu do Londynu – tytuł w liczbie mnogiej symbolizuje, że tym razem potworów będzie więcej."
        },

        new Film
        {
            TytulOryginalny = "Alien³",
            TytulPolski = "Obcy³",
            RokPremiery = 1992,
            Rezyser = "David Fincher",
            Gatunek = "Sci-Fi / Horror",
            CzasTrwania = 114,
            Ocena = 6.5,
            Postacie = new List<string> { "Ellen Ripley", "Dillon", "Clemens", "Morse", "Andrews" },
            Statek = "E.E.V. z USS Sulaco",
            OpisFabuly = "Po katastrofie statku Sulaco Ripley trafia na więzienną planetę Fiorina 161, " +
                         "gdzie wkrótce pojawia się obcy. Pozbawiona broni i wsparcia, musi walczyć o życie " +
                         "wśród skazańców i odkrywa, że nosi w sobie embrion królowej obcych.",
            Ciekawostka =
                "David Fincher zadebiutował tym filmem jako reżyser, jednak miał ograniczoną kontrolę twórczą – produkcja była pełna konfliktów."
        },

        new Film
        {
            TytulOryginalny = "Alien: Resurrection",
            TytulPolski = "Obcy: Przebudzenie",
            RokPremiery = 1997,
            Rezyser = "Jean-Pierre Jeunet",
            Gatunek = "Sci-Fi / Horror",
            CzasTrwania = 109,
            Ocena = 6.2,
            Postacie = new List<string> { "Ellen Ripley (klon)", "Call", "Johner", "Christie", "Dr. Gediman" },
            Statek = "USM Auriga",
            OpisFabuly =
                "Dwieście lat po śmierci Ripley naukowcy klonują ją, by wydobyć królową obcych z jej ciała. " +
                "Klonowana Ripley zyskuje niezwykłe zdolności i wraz z grupą kosmicznych najemników " +
                "musi zapobiec katastrofie, gdy obcy wydostają się na wolność.",
            Ciekawostka =
                "Postać androidki Call gra Winona Ryder, a film miał być początkiem nowej trylogii, która jednak nigdy nie powstała."
        },

        new Film
        {
            TytulOryginalny = "Prometheus",
            TytulPolski = "Prometeusz",
            RokPremiery = 2012,
            Rezyser = "Ridley Scott",
            Gatunek = "Sci-Fi / Thriller",
            CzasTrwania = 124,
            Ocena = 7.0,
            Postacie = new List<string> { "Elizabeth Shaw", "David", "Charlie Holloway", "Meredith Vickers" },
            Statek = "USCSS Prometheus",
            OpisFabuly = "Ekspedycja naukowa wyrusza na odległą planetę, by odkryć pochodzenie ludzkości. " +
                         "Załoga Prometeusza odkrywa ruiny cywilizacji Inżynierów oraz coś, co nigdy nie powinno zostać obudzone.",
            Ciekawostka =
                "Ridley Scott planował, aby film był zarówno prequelem „Obcego”, jak i samodzielną opowieścią o powstaniu życia i człowieka."
        },

        new Film
        {
            TytulOryginalny = "Alien: Covenant",
            TytulPolski = "Obcy: Przymierze",
            RokPremiery = 2017,
            Rezyser = "Ridley Scott",
            Gatunek = "Sci-Fi / Horror",
            CzasTrwania = 122,
            Ocena = 6.4,
            Postacie = new List<string> { "Daniels", "David", "Walter", "Oram", "Tennessee" },
            Statek = "USCSS Covenant",
            OpisFabuly = "Załoga statku kolonizacyjnego Covenant odkrywa nieznaną planetę, idealną do osiedlenia. " +
                         "Na miejscu natrafiają na Davida – syntetyka ocalałego z Prometeusza – oraz nowe formy obcych stworzeń.",
            Ciekawostka =
                "Film pierwotnie miał nosić tytuł „Paradise Lost”; Scott planował jeszcze jedną część łączącą fabułę z oryginalnym „Obcym”."
        }
    };
     
    public ReactiveCommand<Film?, Unit> RemoveFilmCommand { get; }
    public ReactiveCommand<Unit, Unit> AddItemCommand { get; }
    
    public ReactiveCommand<Unit, Unit> SummaryButton { get; }


    [Reactive]
    public Film? SelectedItem { get; set; }
    
    [Reactive]
    public string NewFilm { get; set; } = string.Empty;

    [Reactive] 
    public Film NewFilmEntry { get; set; } = new Film();
    
    public Interaction<Film, Unit> ShowSummaryWindow { get; } 
    
    [Reactive] 
    public string Name { get; set; } = "";

    public MainWindowViewModel()
    {
        AddItemCommand = ReactiveCommand.Create(() =>
        {
            Films.Add(NewFilmEntry);
            NewFilmEntry = new Film();
        });
    
        RemoveFilmCommand = ReactiveCommand.Create<Film?>(Film =>
        {
            if (Film == null || !Films.Contains(Film)) return;
            Films.Remove(Film);
        });
    
        ShowSummaryWindow = new Interaction<Film, Unit>();
        
        SummaryButton = ReactiveCommand.CreateFromTask(async () =>
        {
            await ShowSummaryWindow.Handle(SelectedItem!);
        });
    }
}