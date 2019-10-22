using System;
using Reactive.Bindings;

namespace ListViewSelector.Models
{
    /// <summary>
    /// 小分類
    /// </summary>
    public class EmployeeSubCategory : IEmployeeRow
    {
        public string SubCategoryName { get; set; }

        public EmployeeSubCategory()
        {
        }

        public string RowTitle => SubCategoryName;

    }
}
