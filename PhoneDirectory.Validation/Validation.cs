using PhoneDirectory.Dto.Requests;
using PhoneDirectory.Dto.Shared;

namespace PhoneDirectory.Validation
{
    public class Validation
    {
        public static void Validate(string name, string surname, List<PhoneNumberDto>? phoneNumbers) 
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Geçerli bir isim giriniz.");
            }

            if (string.IsNullOrWhiteSpace(surname))
            {
                throw new ArgumentException("Geçerli bir soyisim giriniz.");
            }

            if (phoneNumbers == null || !phoneNumbers.Any())
            {
                throw new ArgumentException("En az bir telefon numarası girilmelidir.");
            }
   
            foreach (var phone in phoneNumbers)
            {
                if (phone == null || string.IsNullOrWhiteSpace(phone.PhoneNo))
                {
                    throw new ArgumentException("Geçerli bir telefon numarası giriniz.");
                }

                if (phone.PhoneNo.Length != 11 || !phone.PhoneNo.StartsWith("0"))
                {
                    throw new ArgumentException("Telefon numarası 0 ile başlamalı ve 11 haneli olmalıdır.");
                }

                var types = new[] { "Mobile", "Home", "Work", "School" };

                if (!string.IsNullOrWhiteSpace(phone.Type) && types.Contains(phone.Type))
                {
                    phone.Type = "Other";
                }
            }
        }

        public static void ValidateAddContact(AddContactRequest request)
        {
            Validate(request.Name, request.Surname, request.PhoneNumbers);
        }

        public static void ValidateUpdateContact(UpdateContactRequest request)
        {
            Validate(request.Name, request.Surname, request.PhoneNumbers);
        }

        public static void ValidateAddGroup(AddGroupRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
            {
                throw new ArgumentException("Geçerli bir grup ismi giriniz.");
            }
        }
    }
}