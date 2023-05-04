using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftScheduler
{
    internal class User
    {   
        protected string email;
        protected string password;
        protected string firstName;
        protected string lastName;
        protected bool isVerifiedEmail;
        
        static int counterUser = 0;

        public User(string paramEmail, string paramPassword, string paramFirstName, string paramLastName, bool paramIsVerifiedEmail = true)
        {
            SetEmail(paramEmail);
            SetPassword(paramPassword);
            SetFirstName(paramFirstName);
            SetLastName(paramLastName);
            SetIsVerifiedEmail(paramIsVerifiedEmail);
            counterUser++;
        }


        public User(User paramUser) : this(paramUser.email, paramUser.password, paramUser.firstName, paramUser.lastName, paramUser.isVerifiedEmail) { }


        public string GetEmail() { return email; }

        public string GetPassword() { return password; }

        public bool GetIsVerifiedEmail() { return isVerifiedEmail; }

        public string GetFirstName() { return firstName; }
        
        public string GetLastName() { return lastName; }

         public static int GetCounterUser() { return counterUser; }


        public void SetEmail(string paramEmail) { this.email = paramEmail; }

        public void SetPassword(string paramPassword) { this.password = paramPassword; }

        public void SetIsVerifiedEmail(bool paramIsVerifiedEmail) { isVerifiedEmail = paramIsVerifiedEmail; }

        public void SetFirstName(string paramFirstName) { firstName = paramFirstName; }

        public void SetLastName(string paramLastName) { lastName = paramLastName; }


        public void UpdateDetails()
        {
            Console.WriteLine("Your current details are: ");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Password: {password}");
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine();
            Console.WriteLine("What would you like to update?\n1. Email\n2. Password\n3. First name\n4. Last name");
            int choiceToUpdate = int.Parse(Console.ReadLine());
            switch (choiceToUpdate)
            {
                case 1:
                    Console.Write("New email: ");
                    string newEmail = Console.ReadLine();
                    SetEmail(newEmail);
                    break;
                case 2:
                    Console.Write("New password: ");
                    string newPassword = Console.ReadLine();
                    SetPassword(newPassword);
                    break;
                case 3:
                    Console.Write("new First name: ");
                    string newFirstName = Console.ReadLine();
                    SetFirstName(newFirstName);
                    break;
                case 4:
                    Console.Write("New password: ");
                    string newLastName = Console.ReadLine();
                    SetLastName(newLastName);
                    break;
            }
        }

        
        public void DeleteThisUser(User[] paramUsers)
        {
            for (int i = 0; paramUsers[i] != null && i < counterUser; i++)
            {
                if (paramUsers[i] == this)
                {
                    paramUsers[i] = paramUsers[counterUser - 1];
                    paramUsers[counterUser - 1] = null;
                    counterUser--;
                }
            }
        }


        public override string ToString()
        {
            string st = $"Email: {email} | Password: ********** | Name: {firstName} {lastName}";
            return st;
        }
    }
}
