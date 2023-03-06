using ItemsControlPractice.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsControlPractice.ViewModels
{
    internal class MainViewModel
    {
        public ObservableCollection<MyData> MyDatas { get; private set; }

        public MainViewModel()
        {
            MyDatas = new ObservableCollection<MyData>
            {
                new MyData(){ Name = "test", Age = 20, Address = "東京" },
                new MyData(){ Name = "test", Age = 20, Address = "東京" },
                new MyData(){ Name = "test", Age = 20, Address = "東京" },
                new MyData(){ Name = "test", Age = 20, Address = "東京" },
            };
        }
    }
}
