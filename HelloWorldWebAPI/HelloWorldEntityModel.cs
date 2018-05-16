namespace HelloWorldWebAPI
{
  using System.Data.Entity;

  public class HelloWorldEntityModel : DbContext
    {
        //Context For an EntityFramework Object to be used to write to the database in the futrue
        public HelloWorldEntityModel()
            : base("name=HelloWorldEntityModel")
        {
        }

        //Add EntityObjects and EntitySets to match to our Future DB.
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}