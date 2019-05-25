using ClassLibrary1.Models;
using ClassLibrary1.Repository;
using Dip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dip.Service
{
    public class WorkService
    {
        CompanyRepository<Task> _companyRepositoryTask;
        CompanyRepository<Job> _companyRepositoryJob;
        CompanyRepository<Customer> _companyRepositoryCustomer;
        public WorkService()
        {
            _companyRepositoryCustomer = new CompanyRepository<Customer>();
            _companyRepositoryTask = new CompanyRepository<Task>();
            _companyRepositoryJob = new CompanyRepository<Job>();
        }

        public List<Job> GetJobsByName(string Name)
        {
            var jobs = _companyRepositoryJob.GetAll().Where(x => x.EmployeeName == Name).ToList();
            return jobs;
        }

        public void AddJob(Job job)
        {
            _companyRepositoryJob.Create(job);
        }

        public void UpdateJobs(List<Job> jobs)
        {
            var list = _companyRepositoryJob.GetAll();
            Job item;
            foreach (var i in jobs)
            {
                item = list.Find(x => x.Id == i.Id);
                if (item != null)
                {
                    item.Status = i.Status;
                    _companyRepositoryJob.Update(item);
                }
            }
        }
    }
}