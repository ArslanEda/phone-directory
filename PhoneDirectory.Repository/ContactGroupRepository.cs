using PhoneDirectory.Entity; 

namespace PhoneDirectory.Repository
{
    public class ContactGroupRepository : IContactGroupRepository
    {
        private readonly PhoneDirectoryDbContext _context;

        public ContactGroupRepository(PhoneDirectoryDbContext context)
        {
            _context = context;
        }

        public ContactGroup AddGroup(ContactGroup group)
        {
            _context.Groups.Add(group);
            _context.SaveChanges();
            return group;
        }

        public bool DeleteGroup(int id)
        {
            var group = _context.Groups.Find(id);
            if (group == null)
            {
                return false;
            }
            _context.Groups.Remove(group);
            _context.SaveChanges();
            return true;
        }

        public List<ContactGroup> GetGroups()
        {
            return _context.Groups.ToList();
        }

        public ContactGroup? GetGroupId(int id) 
        {
            return _context.Groups.Find(id);
        }
    }
}