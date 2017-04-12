using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace K19.Models
{
    public class K19Context:DbContext
    {
        public DbSet<Editora> Editoras { get; set; }

        public DbSet<Livro> Livros { get; set; }
    }
}
