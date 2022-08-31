using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Studentsque.Interface;
using Studentsque.Models;
using Xamarin.Forms;

namespace Studentsque.ViewModels
{
	public class StudentDetailsPageViewModel : INotifyPropertyChanged
    {
		public StudentDetailsPageViewModel()
		{
		}
        private Student _student;
        public Student Student
        {
            get { return _student; }
            set { _student = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

