using Laboratorium_3___App.Controllers;
using Laboratorium_3___App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab9___Test
{
    public class ContactControllerTest
    {
        private ContactController _controller;
        private IContactService _service;

        public ContactControllerTest()
        {
            _service = new MemoryContactService();
            _service.Add(new Contact() { Id=1 });
            _service.Add(new Contact() { Id = 2 });
            _controller = new ContactController(_service);
        }

        [Fact]
        public void IndexTest()
        {
            var result = _controller.Index();
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            var model = view.Model as List<Contact>;
            Assert.Equal(2, model.Count)
;       }

        [InlineData(1)]
        [InlineData(2)]
        [Fact]
        public void DetailsTestForExisitingContatcs()
        {
            var result = _controller.Index();
            Assert.IsType<ViewResult>(result);
            var view = result as ViewResult;
            var model = view.Model as Contact;
            Assert.Equal(1, model.Id)
;
        }

        [Fact]
        public void DetailsTestForNonExisitingContatcs()
        {
            var result = _controller.Details(3);
            Assert.IsType<NotFoundResult>(result);
        }
    }
}