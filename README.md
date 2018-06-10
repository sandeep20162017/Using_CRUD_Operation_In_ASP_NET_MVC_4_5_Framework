# Using_CRUD_Operation_In_ASP_NET_MVC_4_5_Framework
Step 1: Open Visual Studio and click File=> New=> Project.

Step 2: Now, select ASP.NET Web Application .Here, our project name will be “BookManagement “.

Step 3: Here, select MVC Template and click OK button.

Step 4: Right click on App_Data and Select Add => New Item.

Step 5: SQL Server database name is “BookDatabase”.

Step 6: After creating a database, you will create a table for it.

Step 7: Now, click on Server Explorer at the left side of the Window, select BookDatabase.Mdf. Afterwards, right click Tables, Add New Table.

Step 8: I need to create some data field name and define its data type. After creating a data field name, you will click Update button. I have given the name of table “Mybook”.

CREATE TABLE [dbo].[MyBook]
(
	[Id] INT NOT NULL PRIMARY KEY,
        [BookName] NCHAR(50) NOT NULL,
	[AutherName] NCHAR(50) NOT NULL,
	[BookPrice] INT NOT NULL,
	[BookPublish] NCHAR(50) NOT NULL,
	[Comments] NCHAR(30) NOT NULL
)


Step 9: Click Update Database button.

Step 10: Create a model Class. Right click on the models folder and click Add. Click Class to add a class. 

Step 11: Again, select Class template and give it a name. I have given the name of Class “Mybook”. 

Click add button.

Thus, our model class has been created. There are six properties in the class. Here, I am using validation. I need to add “using System.ComponentModel.DataAnnotations;” namespace for the validation.

Step 12: Create a controller with the views, using Entity Framework. Add new Scaffold in the project.

Step 13: Now, choose MVC 5 Controller, using Entity framework.

Click Add button.

Step 14: Finally, the controller was created by automatic CRUD operations. It is very simple to perform CRUD operations.

Step 15: You can see, here the views are automatically created.

Step 16: Access application using http://localhost:4090/MyBooks



