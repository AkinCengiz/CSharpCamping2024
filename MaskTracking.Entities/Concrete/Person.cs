using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaskTracking.Entities.Abstract;

namespace MaskTracking.Entities.Concrete;
public class Person : IEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public long NationalIdentity { get; set; }
    public int DateOfBirthYear { get; set; }
}
