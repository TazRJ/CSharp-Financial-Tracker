# CSharp-Financial-Tracker

## Server/Database/Connection String:

**Server: sqldatabasefinance.database.windows.net**

**User Name:** test

**Password:** !abcd123

**Connection String:** Server=tcp:sqldatabasefinance.database.windows.net,1433;Initial Catalog=FinanceDB;Persist Security Info=False;User ID=test;Password=!abcd123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;**
**Database Name: FinanceDB

Modify connection strings on all pages to your personal connection string for your server! It should be displayed on the properties tab when you click on your server in the server explorer:

<img width="136" alt="image" src="https://github.com/TazRJ/CSharp-Financial-Tracker/assets/99307581/dd1e48c9-1ba5-4a64-aaf4-30c8df9529a4">

## Table

**Here is the code for each table Expense, Income and User tables! Add these to the Tables folder in your database!**

~~~
 CREATE TABLE [dbo].[ExpenseTbl] (
    [ExpId]     INT           IDENTITY (1, 1) NOT NULL,
    [ExpName]   VARCHAR (50)  NOT NULL,
    [ExpAmount] INT           NOT NULL,
    [ExpCat]    VARCHAR (50)  NOT NULL,
    [ExpDate]   DATE          NOT NULL,
    [ExpDesc]   VARCHAR (100) NOT NULL,
    [ExpUser]   VARCHAR (20)  NOT NULL,
    PRIMARY KEY CLUSTERED ([ExpId] ASC)
);
~~~
~~~
CREATE TABLE [dbo].[IncomeTbl] (
    [IncId]     INT           IDENTITY (1, 1) NOT NULL,
    [IncName]   VARCHAR (50)  NOT NULL,
    [IncAmount] INT           NOT NULL,
    [IncCat]    VARCHAR (50)  NOT NULL,
    [IncDate]   DATE          NOT NULL,
    [IncDesc]   VARCHAR (100) NOT NULL,
    [IncUser]   VARCHAR (20)  NOT NULL
);
~~~
~~~
CREATE TABLE [dbo].[UserTbl] (
    [UId]      INT          IDENTITY (1, 1) NOT NULL,
    [UName]    VARCHAR (50) NOT NULL,
    [UDob]     DATE         NOT NULL,
    [UPhone]   VARCHAR (50) NOT NULL,
    [UPass]    VARCHAR (50) NOT NULL,
    [UAddress] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([UId] ASC)
);
~~~


