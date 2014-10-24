using BlackBookExercise.Models;

namespace BlackBookExercise.DAL
{
    using System.Data.Entity;

    public class EntityContext : DbContext
    {
        // Your context has been configured to use a 'EntityContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BlackBookExercise.DAL.EntityContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EntityContext' 
        // connection string in the application configuration file.
        public EntityContext()
            : base("name=EntityContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public DbSet<Debitor> Debitors { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}