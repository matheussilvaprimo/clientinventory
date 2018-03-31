using System.Linq;
using entities = ClientInventory.Domain.Entities;
using models = ClientInventory.API.Models;

namespace ClientInventory.Business
{
    internal static class Mapper
    {
        internal static entities.Client MapClientToEntity(this models.Client m)
        {
            var e = new entities.Client
            {
                Addresses = m.Addresses.Select(x => x.MapAddressToEntity()).ToList(),
                Age = m.Age,
                Emails = m.Emails,
                Gender = m.Gender,
                Joined = m.Joined,
                LastName = m.LastName,
                Name = m.Name,
                Telephones = m.Telephones.Select(x => x.MapTelephoneToEntity()).ToList()
            };

            if (!string.IsNullOrWhiteSpace(m.ID))
            {
                e.ID = m.ID;
            }

            return e;
        }

        internal static models.Client MapClientToModel(this entities.Client e)
        {
            var m = new models.Client
            {
                Addresses = e.Addresses.Select(x => x.MapAddressToModel()).ToList(),
                Age = e.Age,
                Emails = e.Emails,
                Gender = e.Gender,
                ID = e.ID,
                Joined = e.Joined,
                LastName = e.LastName,
                Name = e.Name,
                Telephones = e.Telephones.Select(x => x.MapTelephoneToModel()).ToList()
            };

            return m;
        }

        internal static entities.Address MapAddressToEntity(this models.Address m)
        {
            var e = new entities.Address
            {
                City = m.City,
                Complement = m.Complement,
                Country = m.Country,
                State = m.State,
                Street = m.Street,
                Type = m.Type
            };

            if (!string.IsNullOrWhiteSpace(m.ID))
            {
                e.ID = m.ID;
            }

            return e;
        }

        internal static models.Address MapAddressToModel(this entities.Address m)
        {
            var e = new models.Address
            {
                City = m.City,
                Complement = m.Complement,
                Country = m.Country,
                ID = m.ID,
                State = m.State,
                Street = m.Street,
                Type = m.Type
            };

            return e;
        }

        internal static entities.Telephone MapTelephoneToEntity(this models.Telephone m)
        {
            var e = new entities.Telephone
            {
                Number = m.Number,
                Type = m.Type
            };

            if (!string.IsNullOrWhiteSpace(m.ID))
            {
                e.ID = m.ID;
            }
            return e;
        }

        internal static models.Telephone MapTelephoneToModel(this entities.Telephone m)
        {
            var e = new models.Telephone
            {
                ID = m.ID,
                Number = m.Number,
                Type = m.Type
            };
            return e;
        }
    }
}
