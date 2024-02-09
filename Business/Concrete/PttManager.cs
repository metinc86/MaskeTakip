using Business.Abstract;
using Etities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService; 

        public PttManager(IApplicantService applicantService) 
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Citizen citizen)         
        { 
            if (_applicantService.CheckCitizen(citizen))
            {
                Console.WriteLine("Mask is given to " + citizen.FirstName);
            }
            else 
            {
                Console.WriteLine("Mask could not be given to " + citizen.FirstName);
            }        
        }
    }
}
