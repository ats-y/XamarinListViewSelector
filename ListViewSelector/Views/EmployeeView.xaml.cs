using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace ListViewSelector.Views
{
    public partial class EmployeeView : ViewCell
    {
        public EmployeeView()
        {
            InitializeComponent();
            DetailArea.IsVisible = false;
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
            DetailArea.IsVisible = !DetailArea.IsVisible;
            ForceUpdateSize();
        }
    }
}
