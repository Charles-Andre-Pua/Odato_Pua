using Speeches.MVVM.Models;
using Speeches.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Speeches.MVVM.ViewModels
{
    public class LoginVM
    {
        //Fields
        public User User { get; set; }

        //Get Users
        private List<User> Users { get; } = FakeDatabase.FakeDatabase.DB_Users;

        //Commands
        public ICommand LoginCommand { get; set; }


        //Constructors
        public LoginVM()
        {
            //Custom User
            FakeDatabase.FakeDatabase.DB_Users.Add(new User()
            {
                Username = "CharlesBIOT",
                Password = "123123"
            });

            //Login
            LoginCommand = new Command(() =>
            {
                //Get list to compare
                var lstuser = FakeDatabase.FakeDatabase.DB_Users;

                //Get User
                var user = lstuser.FirstOrDefault(x => x.Username == User.Username && x.Password == User.Password);
                if(user is not null)
                {
                    App.Current.MainPage = new Home();
                }
            });
        }



        
    }
}
