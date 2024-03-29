using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projetoMVC.Models;

namespace projetoMVC.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos{ get; set; }

        public AgendaContext(DbSet<Contato> contatos)
        {
            Contatos = contatos;
        }
    }
}