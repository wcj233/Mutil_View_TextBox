using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TextboxApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static MainPage current;

        public MainPage()
        {
            this.InitializeComponent();
            current = this;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            int iMainViewId = ApplicationView.GetForCurrentView().Id;
            ((App)App.Current).MyMainViewId = iMainViewId;
            int iSecondViewId = 0;

            CoreApplicationView secondView = CoreApplication.CreateNewView();
            await secondView.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, async () =>
            {
                try
                {
                    Window.Current.Content = new SecondPage();
                    iSecondViewId = ApplicationView.GetForCurrentView().Id;
                    Window.Current.Activate();
                   
                }
                catch (Exception)
                {

                }
            });

            await ApplicationViewSwitcher.SwitchAsync(iSecondViewId, iMainViewId, ApplicationViewSwitchingOptions.Default);
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string a = "";
        }

        private void MyTB_GettingFocus(UIElement sender, GettingFocusEventArgs args)
        {
            Debug.WriteLine("1233333");
        }
    }
    
}
