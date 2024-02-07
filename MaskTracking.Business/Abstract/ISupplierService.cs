using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaskTracking.Entities.Concrete;

namespace MaskTracking.Business.Abstract;
public interface ISupplierService
{
    void GiveMask(Person person);
}
