﻿using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public interface IServiceAreaComunal
    {
        IEnumerable<AreaComunal> GetAll();
        AreaComunal GetAreaComunalById(int id);


    }
}