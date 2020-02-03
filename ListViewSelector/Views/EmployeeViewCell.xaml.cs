using System;
using System.Collections.Generic;
using System.Diagnostics;
using ListViewSelector.Models;
using Xamarin.Forms;

namespace ListViewSelector.Views
{
    public partial class EmployeeViewCell : ViewCell
    {
        public EmployeeViewCell()
        {
            InitializeComponent();
        }

        /// <summary>
        /// セルタップイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnEmployeeTapped(object sender, EventArgs e)
        {
            // 詳細エリアの表示・非表示を切り替える
            Debug.WriteLine("OnEmployeeTapped");

            Employee vm = BindingContext as Employee;
            if( vm != null)
            {
                //bool a = vm.IsExpanded.Value;
                //vm.IsExpanded.Value = a ? false : true;
            }
        }
    }
}
