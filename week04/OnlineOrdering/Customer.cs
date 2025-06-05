using System;
using System.Collections.Generic;

public class Customer {
    private string _name;
    private Address _address;

    public Customer (string name, Address address) {
        _name = name;
        _address = address;
    }

    public bool IsCustomerLivingInUSA () {
        if (_address.IsCountryUSA() == true) {
            return true;
        }
        else
        {
            return false;
        };
    }

    public string GetCustomerName () {
        return _name;
    }

    public string GetCustomerAddress () {
        return _address.DisplayAddress();
    }
};