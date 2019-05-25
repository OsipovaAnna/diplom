using ClassLibrary1.Models;
using ClassLibrary1.Repository;
using Dip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dip.Service
{
    public class AuthService
    {
        public void Register(RegisterModel model)
        {
            CompanyRepository<Employee> companyRepository = new CompanyRepository<Employee>();
            companyRepository.Create(new Employee()
            { Login = model.Login, Name = model.Name, Password = model.Password });
        }

        public bool Login(AuthModel model)
        {
            CompanyRepository<Employee> companyRepository = new CompanyRepository<Employee>();
            var list = companyRepository.GetAll();
            var temp = list.Where(x => x.Login == model.Login && x.Password == model.Password)
                .FirstOrDefault();
            if (temp != null)
            {
                return true;
            }
            return false;
        }
    }
}