//using Data;
//using Data.Entities;
//using Laboratorium_3___App.Mappers;


//namespace Laboratorium_3___App.Models
//{
//    public class MemoryContactService : IContactService
//    {
//        //private readonly IDateTimeProvider _timeProvider;
//        //private Dictionary<int, Contact> _items = new Dictionary<int, Contact>();
//        //public int Add(Contact item)
//        //{
//        //    item.Created = _timeProvider.GetDateTime();
//        //    int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
//        //    item.Id = id + 1;
//        //    _items.Add(item.Id, item);
//        //    return item.Id;
//        //}


//        //public void Delete(int id)
//        //{
//        //    _items.Remove(id);
//        //}

//        //public List<Contact> FindAll()
//        //{
//        //    return _items.Values.ToList();
//        //}

//        //public Contact? FindById(int id)
//        //{
//        //    return _items[id];
//        //}

//        //public void Update(Contact item)
//        //{
//        //    _items[item.Id] = item;
//        //}

//        //public MemoryContactService(IDateTimeProvider timeProvider)
//        //{
//        //    _timeProvider = timeProvider;
//        //}
//        private AppDbContext _context;

//        public MemoryContactService(AppDbContext context)
//        {
//            _context = context;
//        }

//        public int Add(Contact contact)
//        {
//            var e = _context.Contacts.Add(ContactMapper.ToEntity(contact));
//            _context.SaveChanges();
//            return e.Entity.Id;
//        }

//        public void Delete(int id)
//        {
//            ContactEntity? find = _context.Contacts.Find(id);
//            if (find != null)
//            {
//                _context.Contacts.Remove(find);
//            }
//        }

//        public List<Contact> FindAll()
//        {
//            return _context.Contacts.Select(e => ContactMapper.FromEntity(e)).ToList(); ;
//        }

//        public List<OrganizationEntity> FindAllOrganizations()
//        {
//            throw new NotImplementedException();
//        }

//        public Contact? FindById(int id)
//        {
//            return ContactMapper.FromEntity(_context.Contacts.Find(id));
//        }

//        public void Update(Contact contact)
//        {
//            _context.Contacts.Update(ContactMapper.ToEntity(contact));
//        }
//    }
//}
