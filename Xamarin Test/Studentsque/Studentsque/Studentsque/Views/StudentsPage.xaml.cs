using System;
using Studentsque.Models;
using Studentsque.ViewModels;
using Xamarin.Forms;

namespace Studentsque.Views
{	
	public partial class StudentsPage : ContentPage
	{
		
		public StudentsPage ()
		{
			InitializeComponent ();
			this.BindingContext = new StudentViewModel();

		}

       private void CollectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
			var itemselected = e.CurrentSelection[0] as Student;
			Navigation.PushAsync(new StudentDetailsPage(itemselected));
		}
    }
}

