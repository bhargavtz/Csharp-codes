
## answer list

1. **Full Form of ADO.NET**: ActiveX Data Objects for .NET.
2. **ADO.NET**: ADO.NET is a data access technology provided by Microsoft as part of the .NET Framework. It allows developers to interact with data sources such as databases or XML files using a set of classes and components.
3. **Namespace for Database Connection**: The `System.Data` namespace is used for database connections in ADO.NET.
4. **Establishing a Connection to a Database**: You can establish a connection to a database in ADO.NET by creating an instance of the `SqlConnection` class and passing the connection string as a parameter to its constructor. Then, you open the connection using the `Open()` method.
5. **Use of DataSource Property**: The `DataSource` property is used to specify the data source for a data-bound control, such as a DataGridView or ListBox.
6. **Types of Connection Classes in .NET Framework**: There are two types of connection classes provided in .NET Framework:
   - `SqlConnection`: Used to establish a connection with a SQL Server database.
   - `OleDbConnection`: Used to establish a connection with any OLE DB data source, such as Access or Excel.
7. **Two Important Objects of ADO.NET**:
   - `Connection`: Represents a connection to a data source.
   - `Command`: Represents a command to execute against a data source.
8. **Use of DataAdapter**: The `DataAdapter` is used to fetch data from a data source and populate a `DataSet` or update a data source with changes made to the `DataSet`.
9. **Properties of DataAdapter**:
   - `SelectCommand`: Specifies the SQL command used to fetch data from the data source.
   - `InsertCommand`: Specifies the SQL command used to insert new records into the data source.
   - `UpdateCommand`: Specifies the SQL command used to update existing records in the data source.
   - `DeleteCommand`: Specifies the SQL command used to delete records from the data source.
10. **Creating a DataSet**: You can create a `DataSet` by instantiating the `DataSet` class using its constructor.
11. **DataReader Functionality**: The `DataReader` provides a forward-only, read-only, and connected view of the data retrieved from a data source. It is used to efficiently read large volumes of data quickly and with minimal overhead.
12. **Use of ExecuteScalar() Method**: The `ExecuteScalar()` method is used to execute a SQL query that returns a single value, such as an aggregate function like COUNT, SUM, or MAX, and returns the result as an object.
13. **Property to Hide Column Headers in DataGridView**: The `ColumnHeadersVisible` property will be set as `False` to hide the column headers in a DataGridView object.
14. **Effect of ReadOnly Property in DataGridView**: If the value of the `ReadOnly` property of the DataGridView is set to `True`, the user will not be able to edit the cells in the DataGridView.
15. **Property to Bind a DataGridView Control**: The `DataSource` property is used to bind a DataGridView control to a data source, such as a DataTable or a BindingSource.
16. **Significance of BindingSource Property**: The `BindingSource` property provides a layer of abstraction between a data source and data-bound controls. It allows for more flexible data manipulation and interaction between the data source and the control.
17. **Usage of ReadOnly Property**: The `ReadOnly` property is used to specify whether a DataGridView control allows users to edit its cells. Setting it to `True` makes the control read-only, preventing users from making changes to the data displayed in the control.
18. **Architecture Followed by Datasets**: Datasets follow the Disconnected Architecture.
19. **Role of DataSet Object in ADO.NET**: The `DataSet` object in ADO.NET acts as an in-memory cache of data retrieved from a data source. It can hold multiple DataTable objects, representing tables of data, along with relationships between the tables.
20. **Full Form of RDLC**: Report Definition Language Client-side.

---
