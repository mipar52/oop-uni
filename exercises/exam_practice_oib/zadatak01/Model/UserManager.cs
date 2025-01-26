using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using zadatak01.Delegates;
using zadatak01.Factory;

namespace zadatak01.Model
{
    internal class UserManager
    {
        private IRepo repo;
        private IDictionary<string, User> users;

        public event ErrorDelegate OnError;
        public event LoadDelegate OnLoad;

        public IDictionary<string, User> Users
        {
            get
            {
                if (users == null) { LoadUsers(); }
                return new Dictionary<string, User>(users);
            }
        }

        private void LoadUsers()
        {
          try
            {
                IList<User> peeps = repo.GetUsers();
                PrepareDict( peeps );

            } catch(Exception e) 
            {
                OnError?.Invoke(this, new ErrorArgs
                {
                    Exception = e
                });
            }
        }

        private void PrepareDict(IList<User> peeps)
        {
            users = new Dictionary<string, User>();

            foreach(var person in peeps)
            {
                try
                {
                    if (person.HasValidOib())
                    {
                        // users[person.Oib] = person;
                        users.Add(person.Oib, person);
                        OnLoad?.Invoke(this, new LoadedEventArgs
                        {
                            User = person,
                            BrokenUserInfo = LoadMissing(person)
                        });
                    }
                    else
                    {
                        throw new InvalidOibException($"OIB NE VALJA ZA OSOBU: {person.ToString()}");
                    }
                }
                catch (InvalidOibException e) 
                {
                    OnError?.Invoke(this, new ErrorArgs
                    {
                        Exception = e
                    });
                }

            }
        }

        private IList<string> LoadMissing(User person)
        {
            IList<string> list = new List<string>();
            if(string.IsNullOrEmpty(person.Name)) {
                list.Add(nameof(User.Name));
            }
            if (string.IsNullOrEmpty(person.LastName))
            {
                list.Add(nameof(User.LastName));
            }
            if (string.IsNullOrEmpty(person.BrojTelefona))
            {
                list.Add(nameof(User.BrojTelefona));
            }
            if (string.IsNullOrEmpty(person.Email))
            {
                list.Add(nameof(User.Email));
            }
            return list;
        }

        public UserManager()
        {
            repo = RepoFactory.GetRepository();
        }

    }
}
