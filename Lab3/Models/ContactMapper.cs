using Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lab3.Models
{
    public class ContactMapper
    {
        public static Contact FromEntity(ContactEntity entity)
        {
            return new Contact()
            {
                Name = entity.Name,
                Email = entity.Email,
                Phone = entity.Phone,
                Birth = entity.Birth,
            };
        }
        public static ContactEntity ToEntity(Contact model)
        {
            return new ContactEntity
            {
                Name = model.Name,
                Email = model.Email,
                Phone = model.Phone,
                Birth = model.Birth,
            };
        }
    }
}
