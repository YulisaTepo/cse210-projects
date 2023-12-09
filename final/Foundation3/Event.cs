    public class Event
    {
        private string _eventTitle;
        private string _description;
        private string _date;
        private Address _address;
        private string _time;
        public Event(string title, string description, string date, string time, Address address)
        {
            _eventTitle = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;

        }
        public virtual string GetStandardDetails()
        {
            return $"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetAddress()}";
        }
        public virtual string GetFullDetails()
        {
            return $"{GetStandardDetails()} \nEvent: {this.GetType().Name} ";
        }
        public virtual string GetShortDescription()
        {
            return $"Event: {this.GetType().Name}\nTitle: {_eventTitle}\nDate: {_date}";
        }
    }