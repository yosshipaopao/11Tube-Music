using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.Storage;
using static Vanara.PInvoke.User32;

namespace ElevenTube_Music
{
    public sealed partial class MainWindow : Window
    {
        public void PauseMusic()
        {
            await WebView.ExecuteScriptAsync("document.querySelector('#movie_player').pauseVideo()");
        }
        public void PlayMusic()
        {
            await WebView.ExecuteScriptAsync("document.querySelector('#movie_player').playVideo()");
        }

        public async void PlayPauseMusic()
        {
            if (IsPaused) PlayMusic();
            else PauseMusic();
        }

        public async void PreviousMusic()
        {
            await WebView.ExecuteScriptAsync("document.querySelector('#movie_player').previousVideo()");
        }
        public async void NextMusic()
        {
            await WebView.ExecuteScriptAsync("document.querySelector('#movie_player').nextVideo()");
        }
        public async void SetPlayerSeek(int time)
        {
            await WebView.ExecuteScriptAsync(String.Format("document.querySelector('#movie_player').seekTo({0})", time));
        }

    }
}
