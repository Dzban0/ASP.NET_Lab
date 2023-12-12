using Laboratorium_3___App.Controllers;
using Laboratorium_3___App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab9___Test
{
    public class ContactControllerTest
    {
        private ContactController _contact;
        private IContactService _service;

        public ContactControllerTest()
        {
            _service = new MemoryContactService(new CurrentDateTimeProvider());
            _service.Add(new Contact() { Id = 1 });
            _service.Add(new Contact() { Id = 2 });
            _contact = new ContactController(_service);
        }

        [Fact]
        public void IndexTest()
        {
            var result = _contact.Index();
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            var model = view.Model as List<Contact>;
            Assert.Equal(2, model.Count());
        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]

        public void DeatailsTest(int id)
        {
            var result = _contact.Details(id);
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            var model = view.Model as Contact;
            Assert.Equal(id, model.Id);
        }
        [Fact]
        public void DeatailstestForNonExistingContact()
        {
            var result = _contact.Details(3);
            Assert.IsType<NotFoundResult>(result);

        }
    }
}