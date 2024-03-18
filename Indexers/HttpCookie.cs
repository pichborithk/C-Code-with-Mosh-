namespace Indexers
{
    public class HttpCookie
    {
        // private Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        // private Dictionary<string, string> _dictionary = new();
        private readonly Dictionary<string, string> _dictionary = [];

        public string GetItem(string key)
        {
            return _dictionary[key];
        }

        public void SetItem(string key, string value)
        {
            _dictionary[key] = value;
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
