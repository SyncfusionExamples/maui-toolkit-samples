namespace GettingStarted
{
    public class PersonViewModel
    {
        public List<PersonModel> Data { get; set; }
        public PersonViewModel()
        {
            Data = new List<PersonModel>()
            {
            new PersonModel { Name = "David", Height = 170 },
            new PersonModel { Name = "Michael", Height = 96 },
            new PersonModel { Name = "Steve", Height = 65 },
            new PersonModel { Name = "Joel", Height = 182 },
            new PersonModel { Name = "Bob", Height = 134 }
            };
        }
    }
}