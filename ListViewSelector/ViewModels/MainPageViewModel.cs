using System;
using System.Diagnostics;
using ListViewSelector.Models;
using Reactive.Bindings;

namespace ListViewSelector.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ReactiveCollection<IEmployeeRow> Employees { get; set; }

        public MainPageViewModel()
        {
            Debug.WriteLine("MainPageViewModel()");

            Employees = new ReactiveCollection<IEmployeeRow>
            {
                new EmployeeCategory
                {
                    CategoryName = new ReactiveProperty<string>("ソリューション事業部エンベデッドシステムソリューション部"),
                },
                new EmployeeSubCategory
                {
                    SubCategoryName = new ReactiveProperty<string>("Aチーム"),
                },
                new Employee
                {
                    KanjiName = new ReactiveProperty<string>("社員 太郎"),
                    Entering = new ReactiveProperty<DateTime>(new DateTime(1999,4,1)),
                },
                new Employee
                {
                    KanjiName = new ReactiveProperty<string>("社員 二郎"),
                    Entering = new ReactiveProperty<DateTime>(new DateTime(2000,4,1)),
                },
                new Employee
                {
                    KanjiName = new ReactiveProperty<string>("社員 三郎"),
                    Entering = new ReactiveProperty<DateTime>(new DateTime(2000,4,1)),
                },
                new EmployeeSubCategory
                {
                    SubCategoryName = new ReactiveProperty<string>("Bチーム"),
                },
                new Employee
                {
                    KanjiName = new ReactiveProperty<string>("社員 四郎"),
                    Entering = new ReactiveProperty<DateTime>(new DateTime(2000,4,1)),
                },
                new Employee
                {
                    KanjiName = new ReactiveProperty<string>("社員 五郎"),
                    Entering = new ReactiveProperty<DateTime>(new DateTime(2000,4,1)),
                },
                new EmployeeCategory
                {
                    CategoryName = new ReactiveProperty<string>("ソリューション事業部ソリューション部"),
                },
                new Employee
                {
                    KanjiName = new ReactiveProperty<string>("社員 六郎"),
                    Entering = new ReactiveProperty<DateTime>(new DateTime(2000,4,1)),
                },
                new Employee
                {
                    KanjiName = new ReactiveProperty<string>("社員 七郎"),
                    Entering = new ReactiveProperty<DateTime>(new DateTime(2000,4,1)),
                },
                new Employee
                {
                    KanjiName = new ReactiveProperty<string>("社員 八郎"),
                    Entering = new ReactiveProperty<DateTime>(new DateTime(2000,4,1)),
                },
                new Employee
                {
                    KanjiName = new ReactiveProperty<string>("社員 九郎"),
                    Entering = new ReactiveProperty<DateTime>(new DateTime(2000,4,1)),
                },
                new Employee
                {
                    KanjiName = new ReactiveProperty<string>("社員 十郎"),
                    Entering = new ReactiveProperty<DateTime>(new DateTime(2000,4,1)),
                },
            };
        }
    }
}
