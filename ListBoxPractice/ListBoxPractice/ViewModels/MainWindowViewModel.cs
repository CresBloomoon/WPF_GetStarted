using ListBoxPractice.Models;
using Livet;
using Livet.Commands;
using Livet.EventListeners;
using Livet.Messaging;
using Livet.Messaging.IO;
using Livet.Messaging.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ListBoxPractice.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        public ObservableCollection<CardItem> ItemsSource { get; set; } = new ObservableCollection<CardItem>();
    }
}
