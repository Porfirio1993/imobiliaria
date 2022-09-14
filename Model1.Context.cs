namespace imobiliaria
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class imobiliariaEntities1 : DbContext
    {
      

        public imobiliariaEntities1()
            : base("name=imobiliariaEntities")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();

        }
        public virtual DbSet<imoveis> imoveis { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
    }
}

/*public partial class Entities : DbContext
{
    static Entities()
    {
        Database.SetInitializer((IDatabaseInitializer<Entities>)null);
    }*/