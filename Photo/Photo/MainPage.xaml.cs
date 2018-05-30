using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Photo
{
	public partial class MainPage : ContentPage
	{
	    private static int counter = 1;
		public MainPage()
		{
			InitializeComponent();
		    imgs.Source = ImageSource.FromResource($"Photo.Images.{counter}.png");
		}

        private void left_Clicked(object sender, EventArgs e)
        {
            if (counter > 1)
            {
                counter--;
                imgs.Source = ImageSource.FromResource($"Photo.Images.{counter}.png");

            }
            else
            {
                counter = 10;
                imgs.Source = ImageSource.FromResource($"Photo.Images.{counter}.png");
            }
        }

        private void right_Clicked(object sender, EventArgs e)
        {
            if (counter < 10)
            {
                counter++;
                imgs.Source = ImageSource.FromResource($"Photo.Images.{counter}.png");

            }
            else
            {
                counter = 1;
                imgs.Source = ImageSource.FromResource($"Photo.Images.{counter}.png");
            }
        }
    }
}
