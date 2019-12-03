using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TextboxApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SecondPage : Page
    {
        public SecondPage()
        {
            this.InitializeComponent();
            
        }

        

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var aa = Window.Current.Content;
            try
            {
                
                await ApplicationViewSwitcher.SwitchAsync(((App)App.Current).MyMainViewId);//, ApplicationView.GetForCurrentView().Id, ApplicationViewSwitchingOptions.ConsolidateViews);
                
            }
            catch (Exception)
            {
            }
        }
    }
}
