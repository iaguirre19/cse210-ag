namespace OnlineOrdering
{
    public class Address
    {
        private string _street;
        private string _city;
        private string _state;
        private string _country;
        private bool _isUsaAddress;

        public Address(string street, string city, string state, string country)
        {
            _street = street;
            _city = city;
            _state = state;
            _country = country;
        }

        public bool IsUsaAddress()
        {
            if(_country != "USA")
            {
                _isUsaAddress = false;
            }
            else
            {
                _isUsaAddress = true;
            }       
            return _isUsaAddress; 
        }

        public void GetFullAddress()
        {
            Console.WriteLine($"{ _street}");
            Console.WriteLine($"{ _city}, { _state}");
            Console.WriteLine($"{ _country}");
        }
    }


}