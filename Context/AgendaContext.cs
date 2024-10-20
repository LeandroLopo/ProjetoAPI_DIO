using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeuProjeto.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeuProjeto.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        public DbSet<Contato> Contatos { get; set; }
    }
}