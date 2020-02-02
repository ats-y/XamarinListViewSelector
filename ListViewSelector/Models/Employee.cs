using System;
using System.ComponentModel;
using System.Diagnostics;
using Prism.Mvvm;
using Reactive.Bindings;
using Xamarin.Forms;

namespace ListViewSelector.Models
{
    /// <summary>
    /// 社員クラス
    /// </summary>
    public class Employee : BindableBase, IEmployeeRow
    {

        /// <summary>
        /// 漢字名
        /// </summary>
        public ReactiveProperty<string> KanjiName { get; set; }

        /// <summary>
        /// 入社日
        /// </summary>
        public ReactiveProperty<DateTime> Entering { get; set; }

        public Employee()
        {
        }

        private string _Text;
        public string Text
        {
            get { return _Text; }
            set
            {
                SetProperty(ref _Text, value);
            }
        }

        private string _ExpandedContent;
        public string ExpandedContent
        {
            get { return _ExpandedContent; }
            set
            {
                SetProperty(ref _ExpandedContent, value);
            }
        }

        private bool _IsExpanded;
        public bool IsExpanded
        {
            get { return _IsExpanded; }
            set
            {
                SetProperty(ref _IsExpanded, value);
            }
        }

        private Command<Employee> _ToggleItemCommand;
        public Command<Employee> ToggleItemCommand
        {
            get
            {
                return _ToggleItemCommand = _ToggleItemCommand
                             ?? new Command<Employee>((item) => {
                                 item.IsExpanded ^= true;
                                 Debug.WriteLine($"ToggleItemCommand -> {item.IsExpanded}");
                             //Whatever task you want the view model to do here, for example fetching the number of likes, views of a videos, the detailed review of a book...
                         });
            }
        }
    }
}
