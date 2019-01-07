using FormsVideoLibrary;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Video.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CustomPositionBarPage : ContentPage
	{
		public CustomPositionBarPage ()
		{
			InitializeComponent ();
		}

        void OnPlayPauseButtonClicked(object sender, EventArgs args)
        {
            if (videoPlayer.Status == VideoStatus.Playing)
            {
                videoPlayer.Pause();
            }
            else if (videoPlayer.Status == VideoStatus.Paused)
            {
                videoPlayer.Play();
            }
        }

        void OnStopButtonClicked(object sender, EventArgs args)
        {
            videoPlayer.Stop();
        }
    }
}