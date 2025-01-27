using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exam_preTest.Delegate;
using exam_preTest.Factory;

namespace exam_preTest.Model
{
    internal class UserManager
    {
        private IRepo repo;
        public IDictionary<string, User> Users
        {
            get
            {
                if(users == null)
                {
                    LoadUsers();
                }
                return users;
            }
        }

        private IDictionary<string, User> users;

        public OnLoadedDelegate onLoaded;
        public OnExceptionDelegate onException;

        public UserManager()
        {
            repo = UserFactory.GetRepository();
        }

        private void LoadUsers()
        {
            try
            {
                ISet<User> users = repo.GetUsers();
                PrepareDict(users);
            }
            catch (Exception ex)
            {
                // add delegate
                onException?.Invoke(this, new ExceptionEvent
                {
                    Exception = ex
                });
            }
        }

        private void PrepareDict(ISet<User> usersList)
        {
            users = new Dictionary<string, User>();
                foreach (User user in usersList)
                {
                try
                {
                    if (user.IsOibValid)
                    {
                        users.Add(user.Oib, user);
                        onLoaded?.Invoke(this, new LoadEvent
                        {
                            User = user,
                            BrokenUsers = AddBrokenUsers(user)
                        });
                    }
                    else
                    {
                        throw new InvalidOibException($"Neispavan oib za osobu: {user.ToString()}");
                    }
                }
                catch (InvalidOibException ex) 
                {
                    onException?.Invoke(this, new ExceptionEvent
                    {
                        Exception = ex
                    });
                }

                }
        }

        private (string, IList<string>) AddBrokenUsers(User user)
        {
            (string, IList<string>) BrokenUsers;
            BrokenUsers.Item1 = string.Empty;
            BrokenUsers.Item2 = new List<string>();

            if (string.IsNullOrEmpty(user.FirstName))
            {
                BrokenUsers.Item1 = user.Oib;
                BrokenUsers.Item2.Add(nameof(User.FirstName));
            }
            if (string.IsNullOrEmpty(user.LastName))
            {
                BrokenUsers.Item1 = user.Oib;
                BrokenUsers.Item2.Add(nameof(User.LastName));
            }
            if (string.IsNullOrEmpty(user.Telephone))
            {
                BrokenUsers.Item1 = user.Oib;
                BrokenUsers.Item2.Add(nameof(User.Telephone));
            }
            if (string.IsNullOrEmpty(user.Email))
            {
                BrokenUsers.Item1 = user.Oib;
                BrokenUsers.Item2.Add(nameof(User.Telephone));
            }
            return BrokenUsers;
        }
    }
}
