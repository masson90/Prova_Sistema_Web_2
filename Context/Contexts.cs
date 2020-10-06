using Prova_Sistema_Web_Ex6.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Prova_Sistema_Web_Ex6.Context
{
    public class Contexts : DbContext
    {

        public DbSet<Aluno> Alunos { get; set; }


    }
}