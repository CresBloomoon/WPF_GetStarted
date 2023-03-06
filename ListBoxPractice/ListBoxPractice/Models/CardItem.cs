using Livet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace ListBoxPractice.Models
{
    public class CardItem : NotificationObject
    {
        public string Message { get; set; }
        public SolidColorBrush BarColor { get; set; }
    }
}
