using HotelBooking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class SpecialOffer {
    public SpecialOffer(City city, Hotel hotel) {
        City = city;
        Hotel = hotel;
    }
    public City City { get; set; }
    public Hotel Hotel { get; set; }
}
