# CSharp-Financial-Tracker

## Server/Database/Connection String:

Modify connection strings on all pages to your personal connection string for your server! It should be displayed on the properties tab when you click on your server in the server explorer:

## Table

**Here is the code for each table Expense, Income and User tables! This has already been implemented into our Azure DB! Feel free to replicate this for you own use!**

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


