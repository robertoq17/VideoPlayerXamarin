using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Video.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoYoutube : ContentPage
    {
        public VideoYoutube()
        {
            InitializeComponent();
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<html><body>  
<div style=' position: relative; padding-bottom: 56.25%; padding-top: 25px;'> 
<iframe style='position: absolute; top: 0; left: 0; width: 100%; height: 100%;'  src='https://www.youtube.com/embed/1w7OgIMMRc4' frameborder='0' allowfullscreen></iframe>
</div> 
</body>
</html>";
            webView.Source = htmlSource;
        }

        async void OnBackButtonClicked(object sender, EventArgs e)
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }
            else
            {
                await Navigation.PopAsync();
            }
        }

        void OnForwardButtonClicked(object sender, EventArgs e)
        {
            if (webView.CanGoForward)
            {
                webView.GoForward();
            }
        }

        void BackButton(object sender, EventArgs e)
        {
            App.Current.MainPage = new VideoPlayerPage();
        }
    }
}