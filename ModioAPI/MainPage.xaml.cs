using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ModioAPI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void loadEl_Click(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("https://api.mod.io/v1/games/629/mods/1770572?api_key=b2b55f3ae40cfaf8174521bc0c105265");

            using (var httpClient = new HttpClient())
            {
                string json = await httpClient.GetStringAsync(uri);
                var deserialized = JsonConvert.DeserializeObject<Mod>(json);

                var profilePhoto = deserialized.Submit.Profile.Photo100;
                BitmapImage profileImage = new BitmapImage();
                profileImage.UriSource = new Uri(profilePhoto);
                profileImageEl.Source = profileImage;

                var profileUser = deserialized.Submit.Username;
                profileUserEl.Text = profileUser;

                var profileUrl = deserialized.Submit.ProfileUrl;
                var profileUrlUri = new Uri(profileUrl, UriKind.Absolute);
                profileUrlEl.NavigateUri = profileUrlUri;
            }
        }
    }
}
