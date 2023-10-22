namespace Lab2.Models
{
    public class Person
    {
        public string name { get; set; }
        public DateTime date_of_birth { get; set; }

        public bool IsValid()
        {
            if(name != null && date_of_birth > DateTime.Today)
                return true;
            else
                return false;
        }

        public int Age()
        {
            int age = DateTime.Now.Year - date_of_birth.Year;
            return age;
        }
    }
}
