﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ContactValidtor : AbstractValidator<Contact>
    {
        public ContactValidtor()
        {

        }
    }
}
