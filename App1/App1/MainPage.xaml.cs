using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 を参照してください

namespace App1
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "こんにちは" + this.textBox.Text + "さん";

        }
        public void SaveState()
        {
            ApplicationData.Current.LocalSettings.Values["MainPage.InputText"] = this.textBox.Text;
            ApplicationData.Current.LocalSettings.Values["MainPage.OutputMessage"] = this.textBlock.Text;
        }

        public void LoadState()
        {
            var temp = default(object);
            if(ApplicationData.Current.LocalSettings.Values.TryGetValue("MainPage.InputText", out temp))
            {
                this.textBox.Text = (string)temp;
            }
            if (ApplicationData.Current.LocalSettings.Values.TryGetValue("MainPage.OutputMessage", out temp))
            {
                this.textBlock.Text = (string)temp;
            }
        }
    }
}
