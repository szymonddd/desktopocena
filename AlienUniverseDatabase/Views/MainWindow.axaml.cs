using System;
using System.Reactive;
using System.Reactive.Disposables;
using AlienUniverseDatabase.ViewModels;
using Avalonia.Controls;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AlienUniverseDatabase.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
        
        this.WhenActivated((CompositeDisposable disposables) =>
        {
            ViewModel!.ShowSummaryWindow.RegisterHandler(async interaction =>
            {
                var win = new SummaryWindow()
                {
                    DataContext = new SummaryWindowViewModel(interaction.Input)
                };
                
                
                await win.ShowDialog(this);
                interaction.SetOutput(Unit.Default);
            }).DisposeWith(disposables);
        });
    }
}