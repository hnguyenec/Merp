﻿using Merp.Domain;
using System;

namespace Merp.Registry.CommandStack.Commands
{
    public class ChangePersonShippingAddressCommand : MerpCommand
    {
        public Guid PersonId { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public DateTime EffectiveDate { get; set; }

        public ChangePersonShippingAddressCommand(Guid userId, Guid personId, string address, string postalCode, string city, string province, string country, DateTime effectiveDate)
            : base(userId)
        {
            PersonId = personId;
            Address = address ?? throw new ArgumentNullException(nameof(address));
            PostalCode = postalCode;
            City = city ?? throw new ArgumentNullException(nameof(city));
            Country = country;
            Province = province;
            EffectiveDate = effectiveDate;
        }
    }
}
