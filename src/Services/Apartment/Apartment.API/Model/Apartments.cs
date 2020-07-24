﻿namespace Apartment.API.Model
{
    public class Apartments
    {
        public int Id { get; set; }
        public bool Parking { get; set; }        
        public int Reception { get; set; }
        public int Kitchens { get; set; }
        public int Bathrooms { get; set; }
        public int Area { get; set; }
        public string View { get; set; }
        public int Floor { get; set; }
        public int Flat { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Adresse { get; set; }
        public decimal Price { get; set; }
        public bool Installment { get; set; }
        public int OwnerId { get; set; }
        public int BedroomId { get; set; }
        public Bedrooms Bedroom { get; set; }
        public int CountryId { get; set; }
        public Countries Country { get; set; }
        public int FurnitureId { get; set; }
        public Furnishings Furniture { get; set; }
        public int PeriodId { get; set; }
        public Periods Period { get; set; }
        public int PurposeId { get; set; }
        public Purpose Purpose { get; set; }
    }
}