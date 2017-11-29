using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions.Enums;
using Xamarin.Forms;

namespace VideoPlayerMediaManager
{
    public partial class MainPage : ContentPage
    {
        private const string VideoLink = "https://sec.ch9.ms/ch9/b721/db937a96-2fc1-4f27-85ce-a04ba510b721/K100.mp4";

        public MainPage()
        {
            InitializeComponent();
        }

        private async void ControlButton_OnClicked(object sender, EventArgs e)
        {
            switch (ControlButton.Text)
            {
                case "Play":
                    await CrossMediaManager.Current.Play(VideoLink, MediaFileType.Video);
                    ControlButton.Text = "Pause";
                    ControlButton.BackgroundColor = Color.Crimson;
                    VideoStatus.Text = "Playing...";
                    break;
                case "Pause":
                    await CrossMediaManager.Current.Pause();
                    ControlButton.Text = "Play";
                    ControlButton.BackgroundColor = Color.LimeGreen;
                    VideoStatus.Text = "Paused";
                    break;
            }
        }
    }
}
