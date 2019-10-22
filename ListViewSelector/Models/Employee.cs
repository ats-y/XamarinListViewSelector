using System;
namespace ListViewSelector.Models
{
    public class Employee : IEmployeeRow
    {
        public string KanjiName { get; set; }

        public string RowTitle => KanjiName;

        public Employee()
        {
        }
    }
}
