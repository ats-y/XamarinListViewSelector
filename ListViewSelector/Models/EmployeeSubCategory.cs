using System;
using Reactive.Bindings;

namespace ListViewSelector.Models
{
    /// <summary>
    /// 小分類
    /// </summary>
    public class EmployeeSubCategory : IEmployeeRow
    {
        /// <summary>
        /// 分類名
        /// </summary>
        public ReactiveProperty<string> SubCategoryName { get; set; }

        public EmployeeSubCategory()
        {
        }


    }
}
