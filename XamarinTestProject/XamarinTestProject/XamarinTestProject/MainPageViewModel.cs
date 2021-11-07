using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace XamarinTestProject
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        int count;
        public int Count
        {
            get => count;
            set
            {
                count = value;

                var args = new PropertyChangedEventArgs(nameof(Count));

                PropertyChanged?.Invoke(this, args);
            }
        }
        Command AddCommand { get; }
        Command ResetCommand { get; }
        Command DeleteCommand { get; }
    }
}
