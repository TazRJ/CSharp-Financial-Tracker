# CSharp-Financial-Tracker

## Server/Database/Connection String:

**1. Install Sql Server Express**
**2. Open SQL Server Management Studio and connect default sql server**
<img width="957" alt="image" src="https://github.com/TazRJ/CSharp-Financial-Tracker/assets/99307581/27c27eea-7a68-48c5-a5b7-da7ebe1ca9a5">

**Connect to the server from VSStudio: Open Server Explorer, and click on add data connection. Select Microsoft SQL Server**
<img width="957" alt="image" src="https://github.com/TazRJ/CSharp-Financial-Tracker/assets/99307581/5801ce2a-6335-4d2c-bb6a-750dd2277045">

Modify connection strings on all pages to your personal connection string for your server! It should be displayed on the properties tab when you click on your server in the server explorer:

<img width="166" alt="image" src="https://github.com/TazRJ/CSharp-Financial-Tracker/assets/99307581/1bdfe497-d464-4569-a60d-e14c2b851ad5">

<img width="246" alt="image" src="https://github.com/TazRJ/CSharp-Financial-Tracker/assets/99307581/8cf21050-a7ec-41cd-9d01-338d71c3ee5d">


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


