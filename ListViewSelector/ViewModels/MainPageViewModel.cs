using System;
using ListViewSelector.Models;
using Reactive.Bindings;

namespace ListViewSelector.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ReactiveCollection<IEmployeeRow> Employees { get; set; }

        public MainPageViewModel()
        {
            Employees = new ReactiveCollection<IEmployeeRow>
            {
                new EmployeeCategory
                {
                    CategoryName = "大分類①"
                },
                new EmployeeSubCategory
                {
                    SubCategoryName = "小分類①"
                },
                new Employee
                {
                    KanjiName = "社員①"
                },
            };
        }
    }
}
