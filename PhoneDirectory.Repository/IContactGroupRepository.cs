using PhoneDirectory.Entity; 

namespace PhoneDirectory.Repository
{
    public interface IContactGroupRepository
    {
        ContactGroup AddGroup(ContactGroup group);
        bool DeleteGroup(int id);
        List<ContactGroup> GetGroups();
        ContactGroup? GetGroupId(int id);
    }
}