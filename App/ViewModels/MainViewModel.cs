using System;
using System.Threading;

namespace App.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private string fText;
    private Timer fTimer;

    public MainViewModel()
    {
        fText = "Welcome to Avalonia!";
        fTimer = new Timer(this.Tick, null, TimeSpan.Zero, TimeSpan.FromMilliseconds(10));
    }

    public string Greeting
    {
        get => fText;
        private set
        {
            fText = value;
            OnPropertyChanged(nameof(Greeting));
        }
    }

    private void Tick(object? state)
    {
        Greeting = DateTime.Now.ToString("HH:mm:ss.f");
    }
}