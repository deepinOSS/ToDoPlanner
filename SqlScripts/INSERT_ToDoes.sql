USE [ToDoPlanner]
GO

/*
9871E50F-5240-46EB-9508-4D290D8244BB
404E6509-9C7E-4FA6-A81A-CD14BC69265A
DAF15A38-FB69-4C11-9670-CDE63B5806A8
*/

INSERT INTO [dbo].[ToDoes]
           ([Id]
           ,[Title]
           ,[Description]
           ,[CreatedOn]
           ,[CreatedBy_Id])
     VALUES
           (NEWID()
           ,'Create ToDo application'
           ,'for learning ASP.NET MVC and apply the concepts'
           ,'2014-08-31'
           ,'9871E50F-5240-46EB-9508-4D290D8244BB')
GO


INSERT INTO [dbo].[ToDoes]
           ([Id]
           ,[Title]
           ,[Description]
           ,[CreatedOn]
           ,[CreatedBy_Id])
     VALUES
           (NEWID()
           ,'implement oAuth'
           ,'for learning security concepts in ASP.NET MVC and apply the concepts'
           ,'2013-10-02'
           ,'404E6509-9C7E-4FA6-A81A-CD14BC69265A')
GO

INSERT INTO [dbo].[ToDoes]
           ([Id]
           ,[Title]
           ,[Description]
           ,[CreatedOn]
           ,[CreatedBy_Id])
     VALUES
           (NEWID()
           ,'Read ASP.NET MVC'
           ,'Preparing for the ToDo planner'
           ,'2014-07-01'
           ,'DAF15A38-FB69-4C11-9670-CDE63B5806A8')
GO

INSERT INTO [dbo].[ToDoes]
           ([Id]
           ,[Title]
           ,[Description]
           ,[CreatedOn]
           ,[CreatedBy_Id])
     VALUES
           (NEWID()
           ,'Create a Mobile app'
           ,'for integrating with mobile concepts'
           ,'2014-10-12'
           ,'9871E50F-5240-46EB-9508-4D290D8244BB')
GO

