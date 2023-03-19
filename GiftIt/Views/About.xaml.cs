﻿namespace GiftIt.Views;

public partial class About : ContentPage
{
	public About()
	{
		InitializeComponent();
	}

    private async void  LearnMore_Clicked(System.Object sender, System.EventArgs e)
    {
        if (BindingContext is Models.About about)
        {
            // Navigate to the specified URL in the system browser.
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
    }
}
