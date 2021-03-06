﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Days
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		async void OnButtonClicked(object sender, EventArgs args)
		{
			if (int.TryParse(editor.Text, out int difference))
			{
				var endDate = DateTime.Now.AddDays(difference).ToString("dddd, MMMM dd yyyy");
				await DisplayAlert("End", endDate, "Ok");
			}
		}
	}
}
