public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
    public bool LivesInUSA()
    {
        string countryStrip = _country.ToLower().Replace(".", "");
        if (countryStrip == "usa" || countryStrip == "us" || countryStrip == "united states" || countryStrip == "united states of america")
        {
            return true;

        }
        else
        {
            return false;
        }
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city} {_stateOrProvince}, {_country}";
    }
}