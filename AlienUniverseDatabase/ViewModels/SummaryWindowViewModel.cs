using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using AlienUniverseDatabase.Models;
using ReactiveUI;

namespace AlienUniverseDatabase.ViewModels;

public class SummaryWindowViewModel : ViewModelBase
{
    public Film FilmDetails { get; } 
    
    public string MainCharactersString => 
        string.Join(", ", FilmDetails.Postacie ?? new List<string>());
    
    public Interaction<List<string>, Unit> ShowCharactersWindow { get; } 
    public ReactiveCommand<Unit, Unit> CharactersButton { get; }
    
    
    
    
    
    public SummaryWindowViewModel(Film data)
    {
        FilmDetails = data;

        ShowCharactersWindow = new Interaction<List<string>, Unit>();

        CharactersButton = ReactiveCommand.CreateFromTask(async () =>
        {
            if (FilmDetails.Postacie != null)
            {
                await ShowCharactersWindow.Handle(FilmDetails.Postacie);
            }
        });
    }
}