using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaskTracking.Business.Abstract;
using MaskTracking.Entities.Concrete;


namespace MaskTracking.Business.Concrete;
public class PersonManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {

    }

    public List<Person> GetList()
    {
        return null;
    }

    public bool CheckPerson(Person person)
    {
        return false;
    }

    public void ApplyForMask()
    {
        throw new NotImplementedException();
    }
}
