using ShiftScheduler;
namespace Main.app
{
    // **מגבלות של המערכת**
    // אינה תומכת ביותר מסניף אחד לבית עסק
    // אין התייחסות למיקום בארץ, גיל, ומגדר
    // לא תומכת ביותר ממקום עבודה אחד לעובד


    // **מגבלות נוספות**
    // אין טיפול בקריסות כתוצאה מהזנת נתונים שגויים
    // אין אימות נתונים והסתמכות על הזנת נתונים הגיונית של המפעיל
    // אין התייחסות למיקום בארץ, גיל, ומגדר


    internal class Program
    {
        static User LogIn(User[] paramUsers)
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            
            for (int i = 0; paramUsers[i] != null && i < User.GetCounterUser(); i++)
            {
                if (paramUsers[i].GetEmail() == email && paramUsers[i].GetPassword() == password)
                {
                    User currentUserArrow = paramUsers[i];
                    return currentUserArrow;
                }
            }
            Console.WriteLine("Email or password is not correct");
            return null;
        }


        static User SignUp(User[] paramUsers)
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Write("Confirm password: ");
            string confirmPassword = Console.ReadLine();
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            if (password == confirmPassword)
            {
                return paramUsers[User.GetCounterUser()] = new User(email, password, firstName, lastName);                
            }
            return null;
        }
       

        static void Main(string[] args)
        {
            Day[] days = new Day[7];
            days[0] = new Day("Sunday");
            days[1] = new Day("Monday");
            days[2] = new Day("Tuesday");
            days[3] = new Day("Wednesday");
            days[4] = new Day("Thursday");
            days[5] = new Day("Friday");
            days[6] = new Day("Saturday");

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }


            Request[] requestsTypes = new Request[3];
            requestsTypes[0] = new Request("Morning", new TimeSpan(6, 0, 0), new TimeSpan(12, 0, 0));
            requestsTypes[1] = new Request("Evning", new TimeSpan(14, 0, 0), new TimeSpan(20, 0, 0));
            requestsTypes[2] = new Request("Night", new TimeSpan(20, 0, 0), new TimeSpan(6, 0, 0));

            //for (int i = 0; i < requestsTypes.Length; i++)
            //{
            //    Console.WriteLine(requestsTypes[i]);
            //}


            WorkplaceType[] workplaceTypes = new WorkplaceType[6];
            workplaceTypes[0] = new WorkplaceType("Else");
            workplaceTypes[1] = new WorkplaceType("Restaurant / Bar");
            workplaceTypes[2] = new WorkplaceType("Gas station");
            workplaceTypes[3] = new WorkplaceType("Security services");
            workplaceTypes[4] = new WorkplaceType("Cleaning services");
            workplaceTypes[5] = new WorkplaceType("Store / SuperMarket / etc");

            workplaceTypes[0].AddWorkerType(new WorkerType("Shift manager"));
            workplaceTypes[0].AddWorkerType(new WorkerType("Department manager"));
            workplaceTypes[0].AddWorkerType(new WorkerType("Work manager"));
            workplaceTypes[0].AddWorkerType(new WorkerType("Senior manager"));
            workplaceTypes[0].AddWorkerType(new WorkerType("Else"));


            workplaceTypes[1].AddWorkerType(new WorkerType("Waiter"));
            workplaceTypes[1].AddWorkerType(new WorkerType("Host"));
            workplaceTypes[1].AddWorkerType(new WorkerType("Chef"));
            workplaceTypes[1].AddWorkerType(new WorkerType("Cook"));
            workplaceTypes[1].AddWorkerType(new WorkerType("Barman"));


            for (int i = 0; i < workplaceTypes.Length; i++)
            {
                Console.WriteLine(workplaceTypes[i]);
            }


            User[] users = new User[250];
            users[0] = new User("Gal@gmail.com", "!A123456", "Gal", "Zilberman");
            users[1] = new User("omer@gmail.com", "!A123456", "Omer", "Cohen");
            users[2] = new User("keren@gmail.com", "!A123456", "Keren", "Levi");
            users[3] = new User("amit@gmail.com", "!A123456", "Amit", "Marintz");
            users[4] = new User("eli@gmail.com", "!A123456", "Eli", "Anevi");
            users[5] = new User("nir@gmail.com", "!A123456", "Nir", "Haim");
            users[6] = new User("habuba@gmail.com", "!A123456", "Habuba", "Vered");
            //Console.WriteLine(User.GetCounterUser());


            User currentUserArrow;// = LogIn(users);
                                  //Console.WriteLine(currentUserArrow);


            //currentUserArrow = LogIn(users);
            //for (int i = 0; i < users.Length; i++)
            //{
            //    if (users[i] != null)
            //    {
            //        Console.WriteLine(users[i]);
            //    }
            //}
            //currentUserArrow.DeleteThisUser(users);
            //for (int i = 0; i < users.Length; i++)
            //{
            //    if (users[i] != null)
            //    {
            //        Console.WriteLine(users[i]);
            //    }
            //}




            //currentUserArrow = SignUp(users);
            //for (int i = 0; i < users.Length; i++)
            //{
            //    if (users[i] != null)
            //    {
            //        Console.WriteLine(users[i]);
            //    }
            //}
            //currentUserArrow.DeleteThisUser(users);
            //for (int i = 0; i < users.Length; i++)
            //{
            //    if (users[i] != null)
            //    {
            //        Console.WriteLine(users[i]);
            //    }
            //}



            //Console.WriteLine(workplaceTypes[1]);


            //TimeSpan t1 = new TimeSpan(10, 20, 0); TimeSpan t2 = new TimeSpan(11, 20, 0);
            //Console.WriteLine(t1 > t2);

            //User user1 = new User("galzilberman56@walla.com", "!A123456", "Gal", "Zilberman");
            ////Console.WriteLine(user1);



        }
    }
}