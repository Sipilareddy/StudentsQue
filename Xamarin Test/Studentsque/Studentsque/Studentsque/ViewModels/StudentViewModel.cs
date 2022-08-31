using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Studentsque.Models;
using Studentsque.Services;
using Xamarin.Forms;

namespace Studentsque.ViewModels
{
	public class StudentViewModel :  INotifyPropertyChanged
    {
        StudentService studentService;
        public ICommand searchCommand => new Command<string>(LoadStudents);
        public ICommand sortCommand => new Command(SortStudents);
        public ICommand SelectedStudentCommand { get; set; }
        public string SelectedStudent { get; set; }
       
        public ObservableCollection<Student> _studentsList;
        public ObservableCollection<Student> StudentsList
        {
            get { return _studentsList; }
            set { _studentsList = value; OnPropertyChanged(); }
        }
        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; OnPropertyChanged(); }
        }
        public string StudentName { get; set; }
        
        public StudentViewModel()
        {
            studentService = new StudentService();
            LoadStudents(string.Empty);

        }
        private void LoadStudents(string query)
        {
               IsBusy = true;
                StudentsList =  studentService.GetStudentsAsync(query);
               IsBusy = false;
        }
        private void SortStudents(object obj)
        {

            StudentsList = new ObservableCollection<Student>(StudentsList.OrderBy(x => x.StudentName)
           .ToList());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}

