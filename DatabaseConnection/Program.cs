using System;
namespace DatabaseConnection
{
    class program
    {
        public static void Main(String[] args)
        {
            // table creation
            //CreateTable obj = new CreateTable();
            //obj.TableCreate();


            //  insert operation
            //InsertOperation obj = new InsertOperation();
            //obj.insert();

            //display Query
            DisplayOperation obj = new DisplayOperation();
            obj.display();

            //Update Operation

            //UpdateOperation obj = new UpdateOperation();
            //obj.update();
            //Delete opertaion

            //DeleteById obj = new DeleteById();
            //obj.Delete();

            //Display By id
            //DisplayById obj = new DisplayById();
            //obj.ShowDetailsById();


            Console.ReadKey();
        }
    }
}