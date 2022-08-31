using System;
using System.Collections.Generic;
using Studentsque.Models;
using Studentsque.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Studentsque.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StudentDetailsPage : ContentPage
	{	
		public StudentDetailsPage (Student student)
		{
			InitializeComponent ();
			this.BindingContext = new StudentDetailsPageViewModel();
			if (student != null)
				((StudentDetailsPageViewModel)BindingContext).Student = student;
		}

		
	}
}

