using System;
using Reactive.Bindings;

namespace ListViewSelector.Models
{
    /// <summary>
    /// 大分類
    /// </summary>
    public class EmployeeCategory : IEmployeeRow
    {
        /// <summary>
        /// 分類名
        /// </summary>
        public ReactiveProperty<string> CategoryName { get; set; }

        public EmployeeCategory()
        {
        }


    }
}
