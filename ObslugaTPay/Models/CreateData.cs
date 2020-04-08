using ObslugaTPay.Models.Enums;
using System;

namespace ObslugaTPay.Models
{
    public class CreateData
    {
        public CreateData(double amount, string description, byte group, string name, AcceptTos acceptTos)
        {
            Amount = amount;
            Description = description;
            Group = group;
            Name = name;
            AcceptTos = acceptTos;
        }

        public double Amount { get; }
        public byte Group { get; }
        public string Description { get; }
        public string Name { get; }
        public AcceptTos AcceptTos { get; }
        public Online Online { get; set; }
        public string ResultUrl { get; set; }
        public string ResultEmail { get; set; }
        public string MerchantDescription { get; set; }
        public string CustomDescription { get; set; }
        public string ReturnUrl { get; set; }
        public string ReturnErrorUrl { get; set; }
        public string Language { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
