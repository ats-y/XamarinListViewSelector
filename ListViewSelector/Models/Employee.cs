using System;
using Reactive.Bindings;

namespace ListViewSelector.Models
{
    /// <summary>
    /// 社員クラス
    /// </summary>
    public class Employee : IEmployeeRow
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
    }
}
