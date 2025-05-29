public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private int _zip;
    private string _country;

    public Address(string street, string city, string state, int zip, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
        _country = country;
    }

    public string GetWholeAddress()
    {
        if (IsInUSA() == true)
        {
            return $"{_street}\n{_city}, {_state} {_zip}\n{_country}";
        }
        else
        {
            return $"{_street}\n{_city}, {_state}\n{_country}";
        }
    }
    public bool IsInUSA()
    {
        if (_country.ToLower() == "united states" || _country.ToLower() == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}