using System;
using Reactive.Bindings;

namespace ListViewSelector.Models
{
    /// <summary>
    /// 大分類
    /// </summary>
    public class EmployeeCategory : IEmployeeRow
    {
        public string CategoryName { get; set; }

        public EmployeeCategory()
        {
        }

        public string RowTitle => CategoryName;
    }
}
