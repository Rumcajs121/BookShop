namespace BookShop.Web.Services
{
    public class EventService
    {
        public event Action OnCartUpdated;

        public void NotifyCartUpdated()
        {
            OnCartUpdated?.Invoke();
        }
    }
}
