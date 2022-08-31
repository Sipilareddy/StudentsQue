using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Studentsque.Interface;
using Studentsque.Views;
using Xamarin.Forms;

namespace Studentsque.ViewModels
{
	public class LoginPageViewModel : INotifyPropertyChanged
	{
        public INavigation Navigation { get; set; }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private string password;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public ICommand SubmitCommand { protected set; get; }
        public LoginPageViewModel() { }
        public LoginPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            SubmitCommand = new Command(async () => await OnSubmit());
        }
        public async Task OnSubmit()
        {
            if (email != "User" || password != "Password")
            {
                DependencyService.Get<IToastMessage>().ShortAlert("Please check username and password");

            }
            else
            {
              await  Navigation.PushAsync(new StudentsPage());
            }
        }
    }
}

