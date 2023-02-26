using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace ReactivePropertyPractice1.ViewModels
{
    public class ViewModel
    {
        public ReactiveProperty<string> InputValue { get; }
        public ReactiveProperty<string?> OutputValue { get; }

        public ViewModel()
        {
            InputValue = new ReactiveProperty<string>();
            OutputValue = InputValue.ToReactiveProperty();
        }
    }
}
