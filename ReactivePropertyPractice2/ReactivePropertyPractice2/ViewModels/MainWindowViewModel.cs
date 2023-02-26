using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactivePropertyPractice2.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        [Required(ErrorMessage = "名前は必須入力項目です")]
        public ReactiveProperty<string> Name { get; }

        public MainWindowViewModel()
        {
            //Name = new ReactiveProperty<string>(
            //    mode: ReactivePropertyMode.Default | ReactivePropertyMode.IgnoreInitialValidationError)
            //    .SetValidateNotifyError(x => string.IsNullOrEmpty(x) ? "空文字はNG！！！" : null);
            Name = new ReactiveProperty<string>()
                .SetValidateAttribute(() => Name);
        }
    }
}
