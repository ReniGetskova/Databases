##1.What database models do you know?##
**Relational Model**

In the relational model, all data must be stored in relations (tables witch consists of rows and columns).
Major characteristic of the relational model is the usage of keys. These are specially designated columns within a table, used to order data or relate data to other relations. One of the most important keys is the primary key, which is used to uniquely identify each row of table. To make querying for data easier, most relational databases go further and physically order the data by the primary key. Foreign keys relate data in one table to the primary key of another table.

**Object-oriented Model**

An object-oriented database is a database that subscribes to a model with information represented by objects. As the name implies, the main feature of object-oriented databases is allowing the definition of objects, which are different from normal database objects. Objects, in an object-oriented database, reference the ability to develop a product, then define and name it. The object can then be referenced, or called later, as a unit without having to go into its complexities. This is very similar to objects used in object-oriented programming.

**Network Model**

In the network model, entities are organised in a graph,in which some entities can be accessed through several path

**Hierarchical Model**

A hierarchical database is a design that uses a one-to-many relationship for data elements. Hierarchical database models use a tree structure that links a number of disparate elements to one "owner," or "parent," primary record. The idea behind hierarchical database models is useful for a certain type of data storage, but it is not extremely versatile. Its limitations mean that it is confined to some very specific uses. For example, where each individual person in a company may report to a given department, the department can be used as a parent record and the individual employees will represent secondary records, each of which links back to that one parent record in a hierarchical structure. Hierarchical models make the most sense where the primary focus of information gathering is on a concrete hierarchy such as a list of business departments, assets or people that will all be associated with specific higher-level primary data 

##2.Which are the main functions performed by a Relational Database Management System (RDBMS)?##

**RDBMS**

A relational database management system (RDBMS) is a program that lets you create, update, and administer a relational database. Most commercial RDBMS's use the Structured Query Language (SQL) to access the database.
The leading RDBMS products are Oracle, IBM's DB2 and Microsoft's SQL Server. 

##3.Define what is "table" in database terms.##

**Table in relational database**

In a relational database, a table (sometimes called a file) organizes the information about a single topic into rows and columns. For example, a database for a business would typically contain a table for customer information, which would store customers' account numbers, addresses, phone numbers, and so on as a series of columns. Each single piece of data (such as the account number) is a field in the table. A column consists of all the entries in a single field, such as the telephone numbers of all the customers. Fields, in turn, are organized as records, which are complete sets of information (such as the set of information about a particular customer), each of which comprises a row. The process of normalization determines how data will be most effectively organized into tables.

##4.Explain the difference between a primary and a foreign key.##
**Primary key**

Primary key is used to uniquely identify each row of table. To make querying for data easier, most relational databases go further and physically order the data by the primary key. 

**Foreign key**

Foreign keys relate data in one table to the primary key of another table. 

##5.Explain the different kinds of relationships between tables in relational databases.##

-	 one-to-many relationship, each row in the related to table can be related to many rows in the relating table. This effectively save storage as the related record does not need to be stored multiple times in the relating table. For example, all the customers belonging to a business is stored in a customer table while all the customer invoices are stored in an invoice table. Each customer can have many invoices but each invoice can only be generated for a single customer.
-	many-to-many relationship, one or more rows in a table can be related to 0, 1 or many rows in another table. A mapping table is required in order to implement such a relationship. For example, all the customers belonging to a bank is stored in a customer table while all the bank's products are stored in a product table. Each customer can have many products and each product can be assigned to many customers.
- one-to-one relationship, each row in one database table is linked to one and only one other row in another table. It would be apparent that one-to-one relationships are not very useful since the database designer might as well simply merge both tables into a single table.

##6.When is a certain database schema normalized?##

Normalization is the process of efficiently organizing data in a database. There are two goals of the normalization process:

1. There is no redundancy of data (all data is stored in only one place),

2. Data dependencies are logical (all related data items are stored together)

##7.What are database integrity constraints and when are they used?##

Integrity constraints are used to ensure accuracy and consistency of data in a relational database.

- Primary key is the term used to identify one or more columns in a table that make a row of data unique. Although the primary key typically consists of one column in a table, more than one column can comprise the primary key. 
- A unique column constraint in a table is similar to a primary key in that the value in that column for every row of data in the table must have a unique value. Although a primary key constraint is placed on one column, you can place a unique constraint on another column even though it is not actually for use as the primary key.
- A foreign key is a column in a child table that references a primary key in the parent table. A foreign key constraint is the main mechanism used to enforce referential integrity between tables in a relational database. A column defined as a foreign key is used to reference a column defined as a primary key in another table.
- NOT NULL constraint disallows the entrance of NULL values into a column; in other words, data is required in a NOT NULL column for each row of data in the table.
- Check constraints can be utilized to check the validity of data entered into particular table columns. The check constraint is a way of providing another protective layer for the data.

##8.Point out the pros and cons of using indexes in a database.##

**Advantages:** use an index for quick access to a database table specific information. The index is a structure of the database table the value of one or more columns to sort
As a general rule, only when the data in the index column Frequent queries, only need to create an index on the table. The index take up disk space and reduce to add, delete, and update the line speed. In most cases, the speed advantages of indexes for data retrieval greatly exceeds it.
 
**Disadvantages:** too index will affect the speed of update and insert, because it requires the same update each index file. For a frequently updated and inserted into the table, there is no need for a rarely used where the words indexed separately, small table, the cost of sorting will not be great, there is no need to create additional indexes. In some cases, the indexing words may not be fast, for example, the index is placed in a contiguous memory space, which will increase the burden of disk read, which is optimal, it should be through the actual use of the environment to be tested.

##9.What's the main purpose of the SQL language?##

**SQL**

Structured Query Language is a special-purpose programming language designed for managing data held in a relational database management system (RDBMS), or for stream processing in a relational data stream management system (RDSMS). Originally based upon relational algebra and tuple relational calculus, SQL consists of a data definition language, data manipulation language, and a data control language. The scope of SQL includes data insert, query, update and delete, schema creation and modification, and data access control. Although SQL is often described as, and to a great extent is, a declarative language, it also includes procedural elements.

##10.What are transactions used for?##
A transaction, in the context of a database, is a logical unit that is independently executed for data retrieval or updates. In relational databases, database transactions must be atomic, consistent, isolated and durable--summarized as the ACID acronym.

Transactions are completed by COMMIT or ROLLBACK SQL statements, which indicate a transaction’s beginning or end. The ACID acronym defines the properties of a database transaction, as follows:
Atomicity: A transaction must be fully complete, saved (committed) or completely undone (rolled back). A sale in a retail store database illustrates a scenario which explains atomicity, e.g., the sale consists of an inventory reduction and a record of incoming cash. Both either happen together or do not happen - it's all or nothing.
Consistency: The transaction must be fully compliant with the state of the database as it was prior to the transaction. In other words, the transaction cannot break the database’s constraints. For example, if a database table’s Phone Number column can only contain numerals, then consistency dictates that any transaction attempting to enter an alphabetical letter may not commit.
Isolation: Transaction data must not be available to other transactions until the original transaction is committed or rolled back.
Durability: Transaction data changes must be available, even in the event of database failure.

##11.What is a NoSQL database?##

NoSQL is a class of database management systems (DBMS) that do not follow all of the rules of a relational DBMS and cannot use traditional SQL to query data. NoSQL-based systems are typically used in very large databases, which are particularly prone to performance problems caused by the limitations of SQL and the relational model of databases. Many think of NoSQL as the modern database of choice that scales with Web requirements. 

##12.Explain the classical non-relational data models.##

A non-relational database is a database that does not incorporate the table/key model that relational database management systems (RDBMS) promote. These kinds of databases require data manipulation techniques and processes designed to provide solutions to big data problems that big companies face. The most popular emerging non-relational database is called NoSQL (Not Only SQL).

##13.Give few examples of NoSQL databases and their pros and cons.##

Implementations of NoSQL are Facebook's Cassandra database, Google's BigTable and Amazon's SimpleDB and Dynamo.

**NoSQL pros:**

- Mostly open source.
- Horizontal scalability. There’s no need for complex joins and data can be easily sharded and processed in parallel.
- Support for Map/Reduce. This is a simple paradigm that allows for scaling computation on cluster of computing nodes.
- No need to develop fine-grained data model – it saves development time.
- Easy to use.
- Very fast for adding new data and for simple operations/queries.
- No need to make significant changes in code when data structure is modified.
- Ability to store complex data types (for document based solutions) in a single item of storage.

**NoSQL cons:**

- Immaturity. Still lots of rough edges.
- Possible database administration issues. NoSQL often sacrifices features that are present in SQL solutions “by default” for the sake of performance. For example, one needs to check different data durability modes and journaling in order not to be caught by surprise after a cold restart of the system. Memory consumption is one more important chapter to read up on in the database manual because memory is usually heavily used.
- No indexing support (Some solutions like MongoDB have indexing but it’s not as powerful as in SQL solutions).
- No ACID (Some solutions have just atomicity support on single object level).
- Bad reporting performance.
- Complex consistency models (like eventual consistency). CAP theorem states that it’s not possible to achieve consistency, availability and partitioning tolerance at the same time. NoSQL vendors are trying to make their solutions as fast as possible and consistency is most typical trade-off.
- Absence of standardization. No standard APIs or query language. It means that migration to a solution from different vendor is more costly. Also there are no standard tools (e.g. for reporting)


