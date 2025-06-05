using System;
using System.Collections.Generic;

public class Order {
    private Customer _customer;
    private List<Product> _products = new List<Product> ();

    public Order (Customer aCustomer, List<Product> aListOfProducts) {
        _customer = aCustomer;
        _products = aListOfProducts;
    }

    public string ShowPackingLabel () {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetProductId()} {product.GetProductName()}: ${product.GetTotalCost():F2}\n";
        }
        return label.Trim();
    }

    public string ShowShippingLabel () {
        return $"Customer Name: {_customer.GetCustomerName().ToUpper()} \nCustomer Address:\n{_customer.GetCustomerAddress()}";
    }

    public double OrderTotalPriceIs () {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }

        if (_customer.IsCustomerLivingInUSA() == true){
            return total + 5;
        }
        else {
            return total + 35;
        }
    }  
}