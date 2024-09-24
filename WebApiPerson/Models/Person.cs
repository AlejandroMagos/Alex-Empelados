namespace WebApiPerson.Models
{
    public class Person
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string A_P { get; set; }
        public required string A_M { get; set; }
        public required int Edad { get; set; }
        public required char Sexo { get; set; }
    }
}
