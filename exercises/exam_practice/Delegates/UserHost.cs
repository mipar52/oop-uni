namespace Delegates
{
    public class UserHost
    {
        public event UserDelegate onUserArrived;

        public void UserHasArrived(User user)
        {
            onUserArrived?.Invoke(this, new UserEventArgs {User = user});
        }
    }
}