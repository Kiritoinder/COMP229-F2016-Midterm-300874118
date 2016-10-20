namespace COMP229_F2016_MidTerm_300874118.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TodoConnection : DbContext
    {
        public TodoConnection()
            : base("name=TodoConnection")
        {
        }

        public virtual DbSet<ToDo> ToDo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>()
                .Property(e => e.ToDoDescription)
                .IsUnicode(false);

            modelBuilder.Entity<ToDo>()
                .Property(e => e.Compleated)
                .IsFixedLength();
        }
    }
}
