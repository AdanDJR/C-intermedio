using Practica_DL;

class Program
{
    static void Main(string[] args)
    {
        
        CustomerRepository repo = new CustomerRepository();
        
        CustomerService service = new CustomerService(repo);

       
        string resultado = service.GetCustomerDetails(1);
        Console.WriteLine(resultado);
    }
}