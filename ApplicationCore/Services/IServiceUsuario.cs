﻿using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public interface IServiceUsuario
    {
        Usuario GetUsuarioById(int Cedula);
        void SaveOrUpdate(Usuario usuario);
        void Delete(int cedula);
        Usuario GetUsuario(string email, string password);
        IEnumerable<Usuario> GetAll();

    }
}
