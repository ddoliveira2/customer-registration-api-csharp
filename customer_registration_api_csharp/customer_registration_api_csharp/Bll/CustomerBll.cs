using customer_registration_api_csharp.Dal;
using customer_registration_api_csharp.Dal.Dao;
using customer_registration_api_csharp.Model.Model;
using customer_registration_api_csharp.Model.Request;
using Microsoft.EntityFrameworkCore;

namespace customer_registration_api_csharp.Bll
{
    public class CustomerBll
    {

        private CustomerDal _dal;

        public CustomerBll(SqlServerContext context)
        {
            this._dal = new CustomerDal(context);
        }

        public Customer GetOneCustome(string id)
        {
            try
            {
                Int64 _id = 0;

                Int64.TryParse(id, out _id);

                if (_id > 0)
                {
                    return _dal.GetOneCustome(_id);
                }
                return new Customer();
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
                return _dal.GetListCustomer(name, rg, cpf);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Customer CreateCustomer(RequestCreateUpdateCustomer obj, out string msg)
        {
            try
            {
                msg = "Cliente cadastrado com sucesso!";

                if (string.IsNullOrEmpty(obj.name) || string.IsNullOrEmpty(obj.rg) || string.IsNullOrEmpty(obj.cpf))
                {
                    msg = "Verificar se todos parametros foram preenchidos!";
                    return new Customer();
                }

                Customer insert = new Customer
                {
                    name = obj.name,
                    rg = obj.rg,
                    cpf = obj.cpf
                };

                return _dal.CreateCustomer(insert);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Customer UpdateCustomer(string id, RequestCreateUpdateCustomer obj, out string msg)
        {
            try
            {
                msg = "Cliente Atualizado com sucesso!";

                Int64 _id = 0;

                Int64.TryParse(id, out _id);

                if (_id == 0)
                {

                    msg = "Id do cliente não foi informado!";
                    return new Customer();
                }

                if (string.IsNullOrEmpty(obj.name) || string.IsNullOrEmpty(obj.rg) || string.IsNullOrEmpty(obj.cpf))
                {
                    msg = "Verificar se todos parametros foram preenchidos!";
                    return new Customer();
                }
                Customer update = new Customer
                {
                    name = obj.name,
                    rg = obj.rg,
                    cpf = obj.cpf
                };
                return _dal.UpdateCustomer(_id, update);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Customer DeleteCustomer(string id, out string msg)
        {
            try
            {
                msg = "Cliente Deletado com sucesso!";

                Int64 _id = 0;

                Int64.TryParse(id, out _id);

                if (_id == 0)
                {

                    msg = "Id do cliente não foi informado!";
                    return new Customer();
                }


                return _dal.DeleteCustomer(_id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
