using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace healthspanmd.mobileapp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VideoLibraryPage : ContentPage
	{
		public VideoLibraryPage()
		{
			InitializeComponent();

			var videoIds = new List<string>
			{
                "YplG2BiDc0M", //https://www.youtube.com/watch?v=YplG2BiDc0M
                "Kcj8Ms_3JbU", //https://www.youtube.com/watch?v=Kcj8Ms_3JbU
                "wsKYHxxZS9w", //https://www.youtube.com/watch?v=wsKYHxxZS9w
                "eNaRIe4-yVM", //https://www.youtube.com/watch?v=eNaRIe4-yVM
                "yB_xdD4sGls", //https://www.youtube.com/watch?v=yB_xdD4sGls
                "C0cVVE_5vzM" //https://www.youtube.com/watch?v=C0cVVE_5vzM
            };

            VideoList.ItemsSource = videoIds;
        }

        private void OnVideoSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is string videoId)
            {
                string embedHtml = $@"
                <html>
                    <body>
                        <iframe width='100%' height='100%' src='https://www.youtube.com/embed/{videoId}?rel=0&amp;controls=0&amp;showinfo=0' frameborder='0' allowfullscreen></iframe>
                    </body>
                </html>";

                YouTubeWebView.Source = new HtmlWebViewSource { Html = embedHtml };
            }
        }
    }
}