﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Business.Services
{
    public interface IConfigurationService
    {
public T Get<T>(string section);

    }
}
