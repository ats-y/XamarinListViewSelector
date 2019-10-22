using System;
using ListViewSelector.Models;
using Xamarin.Forms;

namespace ListViewSelector.Selector
{
    /// <summary>
    /// 社員リスト用セレクター
    /// 「大分類」「小分類」「社員」
    /// </summary>
    public class EmployeeListSelector : DataTemplateSelector
    {
        public DataTemplate CategoryTemplate { get; set; }
        public DataTemplate SubCategoryTemplate { get; set; }
        public DataTemplate EmployeeTemplate { get; set; }

        public EmployeeListSelector()
        {
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            DataTemplate result;
            if (item.GetType() == typeof(EmployeeCategory))
            {
                result = CategoryTemplate;
            }
            else if (item.GetType() == typeof(EmployeeSubCategory))
            {
                result = SubCategoryTemplate;
            }
            else if (item.GetType() == typeof(Employee))
            {
                result = EmployeeTemplate;
            }
            else
            {
                result = null;
            }
            return result;
        }
    }
}
