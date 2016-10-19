namespace COMP229_F2016_MidTerm_300874118.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TodoContext : DbContext
    {
        public TodoContext()
            : base("name=TodoConnection")
        {
        }

        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<ToDo> ToDoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>()
                .Property(e => e.ToDoDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.Compleated)
                .IsFixedLength();

            modelBuilder.Entity<ToDo>()
                .Property(e => e.ToDoDescription)
                .IsUnicode(false);

            modelBuilder.Entity<ToDo>()
                .Property(e => e.Compleated)
                .IsFixedLength();
        }
    }
}
