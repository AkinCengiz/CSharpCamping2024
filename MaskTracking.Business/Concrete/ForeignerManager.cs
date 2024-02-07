using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaskTracking.Business.Abstract;
using MaskTracking.Entities.Concrete;

namespace MaskTracking.Business.Concrete;
public class ForeignerManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {
        throw new NotImplementedException();
    }

    public List<Person> GetList()
    {
        throw new NotImplementedException();
    }

    public bool CheckPerson(Person person)
    {
        throw new NotImplementedException();
    }
}
