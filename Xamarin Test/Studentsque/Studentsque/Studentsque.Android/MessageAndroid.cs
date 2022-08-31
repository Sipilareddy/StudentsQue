using System;
using Android.App;
using Android.Widget;
using Studentsque.Droid;
using Studentsque.Interface;

[assembly: Xamarin.Forms.Dependency(typeof(MessageAndroid))]
namespace Studentsque.Droid
{
    public class MessageAndroid : IToastMessage
    {
        public void LongAlert(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }

        public void ShortAlert(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
        }
    }
}

