//Detta tillåter FormData-klassen att komma åt StoreContext-instansen som skickas in som en
//    parameter och använda den för att interagera med det underliggande datalagret.
using ExamensArbeteMVC.Models;
using ExamensArbeteMVC.DBcontext;


namespace ExamensArbeteMVC.RepositoryData
{
    public class FormData : IFormData
    {
        private readonly StoreContext _context = null;
        public FormData(StoreContext context)
        {
            _context = context;
        }
        public async Task<int> ContactForm(ContactFormModel model)
        {
            var newContact = new Form()
            {
                Name = model.Name,
                AfterName = model.AfterName,
                Adress = model.Adress,
                Email = model.Email,
                Message = model.Message
                //SendAt = model.UtcNow

            };
            await _context.Contacts.AddAsync(newContact);

            await _context.SaveChangesAsync();
            return newContact.Id;

        }

    }
}