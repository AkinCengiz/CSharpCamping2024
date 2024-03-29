﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MaskTracking.Business.Abstract;
using MaskTracking.Entities.Concrete;

namespace MaskTracking.Business.Concrete;
public class PttManager : ISupplierService
{
    private IApplicantService _applicantService;

    public PttManager(IApplicantService applicantService)
    {
        _applicantService = applicantService;
    }
    public void GiveMask(Person person)
    {
        if (_applicantService.CheckPerson(person))
        {
            Console.WriteLine(person.FirstName + " için maske verildi...");
        }
    }
}
