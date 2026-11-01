using customer_registration_api_csharp.Dal.Dao;
using customer_registration_api_csharp.Model.Model;
using Microsoft.EntityFrameworkCore;

namespace customer_registration_api_csharp.Dal
{
    public class CustomerDal
    {
        private readonly SqlServerContext _context;

        public CustomerDal(SqlServerContext context)
        {
            this._context = context;
        }

        public Customer GetOneCustome(Int64 id) {
            try
            {
                return _context.Customer.FirstOrDefault(i => i.id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Customer> GetListCustomer(string name, string rg, string cpf)
        {
            try
            {
                return _context.Customer.Where(i => i.name.Contains(name) && i.rg.Contains(rg) && cpf.Contains(cpf)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public Customer CreateCustomer(Customer obj) {
            Customer insert = new Customer();

            insert.name = obj.name;
            insert.rg = obj.rg;
            insert.cpf = obj.cpf;
            insert.status =true;

            _context.Add(insert);
            _context.SaveChanges();
            return insert;
        }


        public Customer UpdateCustomer(Int64 id, Customer obj) { 
            Customer selected = _context.Customer.FirstOrDefault(i=> i.id == id);
            if (selected != null)
            {
                selected.name = obj.name;
                selected.rg = obj.rg;
                selected.cpf = obj.cpf;
                selected.status = obj.status;
                _context.SaveChanges();
            }
            return selected;
        }

        public Customer DeleteCustomer(Int64 id)
        {
            Customer delete = _context.Customer.FirstOrDefault(i => i.id == id);
            if (delete != null)
            {
                _context.Customer.Remove(delete);
                _context.SaveChanges();
            }
            return delete;
        }
    }
}
