using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xamarin.Forms;

using App1.Models;
using App1.Views;

namespace App1.ViewModels
{
    public class HistoryViewModel : BaseViewModel
    {
        public ObservableCollection<Data> SavedData { get; set; }
        public HistoryViewModel()
        {
            Title = "History";
            SavedData = new ObservableCollection<Data>();
            
            //Placeholder data
            SavedData.Add(new Data() { Name = "Steve", Measurement = "21", Distance = "1" });
            SavedData.Add(new Data() { Name = "John", Measurement = "37", Distance = "2" });
            SavedData.Add(new Data() { Name = "Tom", Measurement = "42", Distance = "3" });
            SavedData.Add(new Data() { Name = "Lucas", Measurement = "29", Distance = "4" });
            SavedData.Add(new Data() { Name = "Tariq", Measurement = "39", Distance = "5" });
            SavedData.Add(new Data() { Name = "Jane", Measurement = "30", Distance = "6" });
            SavedData.Add(new Data() { Name = "Steve", Measurement = "21", Distance = "1" });
            SavedData.Add(new Data() { Name = "John", Measurement = "37", Distance = "2" });
            SavedData.Add(new Data() { Name = "Tom", Measurement = "42", Distance = "3" });
            SavedData.Add(new Data() { Name = "Lucas", Measurement = "29", Distance = "4" });
            SavedData.Add(new Data() { Name = "Tariq", Measurement = "39", Distance = "5" });
            SavedData.Add(new Data() { Name = "Jane", Measurement = "30", Distance = "6" });
            SavedData.Add(new Data() { Name = "Steve", Measurement = "21", Distance = "1" });
            SavedData.Add(new Data() { Name = "John", Measurement = "37", Distance = "2" });
            SavedData.Add(new Data() { Name = "Tom", Measurement = "42", Distance = "3" });
            SavedData.Add(new Data() { Name = "Lucas", Measurement = "29", Distance = "4" });
            SavedData.Add(new Data() { Name = "Tariq", Measurement = "39", Distance = "5" });
            SavedData.Add(new Data() { Name = "Jane", Measurement = "30", Distance = "6" });
        }
    }
}
