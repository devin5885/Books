INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'Admin', N'Admin')
GO
SET IDENTITY_INSERT [dbo].[Hobbies] ON 

GO
INSERT [dbo].[Hobbies] ([Id], [Name], [IsActive]) VALUES (1, N'Test', 1)
GO
INSERT [dbo].[Hobbies] ([Id], [Name], [IsActive]) VALUES (2, N'Test Hobby', 1)
GO
SET IDENTITY_INSERT [dbo].[Hobbies] OFF
GO
SET IDENTITY_INSERT [dbo].[Items] ON 

GO
INSERT [dbo].[Items] ([Id], [Name], [Description], [ItemNumber], [Picture], [Cost], [CheckedOut], [DueBack], [DateAcquired], [IsAvailable]) VALUES (3, N'Test1', N'Test24', N'Test3', N'/ItemImages/8f46d4c4-7268-40ec-93e9-9cc099369d09_Id.jpg', 2, NULL, NULL, CAST(N'2016-06-07 00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [Description], [ItemNumber], [Picture], [Cost], [CheckedOut], [DueBack], [DateAcquired], [IsAvailable]) VALUES (7, N'Test2', N'Test Description', N'Test', N'/ItemImages/987be421-ef6f-4e3e-a8e8-9bdb10708db1_Id.jpg', 3, NULL, NULL, CAST(N'2016-06-08 00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [Description], [ItemNumber], [Picture], [Cost], [CheckedOut], [DueBack], [DateAcquired], [IsAvailable]) VALUES (9, N'Test3', N'Test Description 3 4', N'Test', NULL, 5, NULL, NULL, CAST(N'2016-06-14 00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[Items] ([Id], [Name], [Description], [ItemNumber], [Picture], [Cost], [CheckedOut], [DueBack], [DateAcquired], [IsAvailable]) VALUES (10, N'ssdsvzxfgdgf', N'wrewqeerqwr', N'werweqer', N'/ItemImages/0dcaf178-2073-457e-a675-2786ee9f9e87_Id.jpg', 2.3, NULL, NULL, CAST(N'2016-10-13 00:00:00.000' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[Items] OFF
GO
SET IDENTITY_INSERT [dbo].[Notifications] ON 

GO
INSERT [dbo].[Notifications] ([Id], [Title], [Details], [IsAdminOnly], [DisplayStartDate], [DisplayEndDate], [CreateDate]) VALUES (2, N'Initial Title', N'These are the details.', 1, CAST(N'2010-10-02 18:00:00.000' AS DateTime), CAST(N'2020-10-02 20:00:00.000' AS DateTime), CAST(N'2016-10-02 18:55:00.000' AS DateTime))
GO
INSERT [dbo].[Notifications] ([Id], [Title], [Details], [IsAdminOnly], [DisplayStartDate], [DisplayEndDate], [CreateDate]) VALUES (3, N'Title2', N'Details 2', 0, CAST(N'2010-10-01 00:00:00.000' AS DateTime), CAST(N'2020-10-01 00:00:00.000' AS DateTime), CAST(N'2016-10-09 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Notifications] ([Id], [Title], [Details], [IsAdminOnly], [DisplayStartDate], [DisplayEndDate], [CreateDate]) VALUES (4, N'Title2', N'Title 2 Details', 1, CAST(N'2010-10-01 00:00:00.000' AS DateTime), CAST(N'2020-10-01 00:00:00.000' AS DateTime), CAST(N'2016-10-10 00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Notifications] OFF
GO
