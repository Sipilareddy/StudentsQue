using System;
using System.Collections.Generic;
using Studentsque.ViewModels;
using Xamarin.Forms;

namespace Studentsque.Views
{	
	public partial class LoginPage : ContentPage
	{	
		public LoginPage ()
		{
			InitializeComponent ();
			BindingContext = new LoginPageViewModel(Navigation);
		}

  
    }
}

