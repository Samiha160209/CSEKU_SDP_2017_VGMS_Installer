-- Script Date: 10/20/17 11:18 PM  - ErikEJ.SqlCeScripting version 3.5.2.72
CREATE TABLE [UserInfo] (
  [Id] int IDENTITY (21,1) NOT NULL
, [FullName] nvarchar(256) NOT NULL
, [UserName] nvarchar(256) NOT NULL
, [Password] nvarchar(256) NOT NULL
, [Email] nvarchar(256) NOT NULL
, [Mobile] nvarchar(256) DEFAULT 880 NOT NULL
, [Dob] datetime DEFAULT (getdate()) NOT NULL
, [GenderEnumId] int DEFAULT 0 NOT NULL
, [TypeEnumId] int DEFAULT 0 NOT NULL
);
GO
CREATE TABLE [Product] (
  [Id] int IDENTITY (18,1) NOT NULL
, [Title] nvarchar(256) NOT NULL
, [DurationInMin] float NOT NULL
, [VideoTypeId] int NOT NULL
, [Actors] ntext NOT NULL
, [Directors] ntext NOT NULL
, [Producers] ntext NOT NULL
, [ReleaseDate] datetime NOT NULL
, [ImagePath] ntext NULL
, [StatusEnumId] int DEFAULT 0 NULL
, [TotalItem] int DEFAULT 0 NOT NULL
, [TotalSold] int DEFAULT 0 NOT NULL
, [BuyPrice] real DEFAULT 50.00 NOT NULL
, [SellingPrice] real DEFAULT 0.00 NOT NULL
, [TotalRented] int DEFAULT 10 NOT NULL
, [CreateById] int DEFAULT 15 NOT NULL
, [CreateDate] datetime DEFAULT (getdate()) NOT NULL
);
GO
CREATE TABLE [Invoice] (
  [Id] int IDENTITY (22,1) NOT NULL
, [TotalItem] int NOT NULL
, [TotalSellingPrice] real NOT NULL
, [CreateById] int NOT NULL
, [CreateDate] datetime NOT NULL
, [UpdateById] int NOT NULL
, [UpdateDate] datetime NOT NULL
, [InRent] bit DEFAULT 0 NOT NULL
);
GO
CREATE TABLE [Sold] (
  [Id] int IDENTITY (26,1) NOT NULL
, [ProductId] int NOT NULL
, [InvoiceId] int NOT NULL
, [Quantity] int NOT NULL
, [UnitSellingPrice] real NOT NULL
, [TotalPrice] real NOT NULL
, [SaleDate] datetime DEFAULT (getdate()) NOT NULL
);
GO
CREATE TABLE [Customer] (
  [Id] int IDENTITY (4,1) NOT NULL
, [Name] nvarchar(256) NOT NULL
, [Address] ntext NULL
, [MobileNumber] int NOT NULL
, [GenderEnumId] int NOT NULL
, [Diposite] float NOT NULL
, [CreateById] int NOT NULL
, [CreateDate] datetime NOT NULL
, [UpdateById] int NOT NULL
, [UpdateDate] datetime NOT NULL
);
GO
CREATE TABLE [Rented] (
  [Id] int IDENTITY (6,1) NOT NULL
, [CustomerId] int NOT NULL
, [ProductId] int NOT NULL
, [InvoiceId] int NOT NULL
, [RentDate] datetime NOT NULL
, [ReturnDate] datetime NOT NULL
, [RentAmount] float NOT NULL
, [IsReturned] bit NOT NULL
, [Quantity] int NOT NULL
);
GO
SET IDENTITY_INSERT [UserInfo] ON;
GO
INSERT INTO [UserInfo] ([Id],[FullName],[UserName],[Password],[Email],[Mobile],[Dob],[GenderEnumId],[TypeEnumId]) VALUES (
15,N'Samiha Ahmed',N'SamihaSaint',N'sami1234',N'samihasaint@gmail.com',N'01735973674',{ts '1998-05-13 10:54:55.000'},1,0);
GO
INSERT INTO [UserInfo] ([Id],[FullName],[UserName],[Password],[Email],[Mobile],[Dob],[GenderEnumId],[TypeEnumId]) VALUES (
16,N'Fatimatuj Jhora',N'Mesu13',N'160213',N'fatimamesu16@gmail.com',N'01625668814',{ts '1998-05-02 11:05:25.000'},1,0);
GO
INSERT INTO [UserInfo] ([Id],[FullName],[UserName],[Password],[Email],[Mobile],[Dob],[GenderEnumId],[TypeEnumId]) VALUES (
19,N'samiha ',N'samiha',N'sami',N'samiha@gmail.com',N'01735973674',{ts '1998-05-13 10:08:06.000'},1,1);
GO
INSERT INTO [UserInfo] ([Id],[FullName],[UserName],[Password],[Email],[Mobile],[Dob],[GenderEnumId],[TypeEnumId]) VALUES (
20,N'naeema',N'naeema',N'binthe',N'naeema@gmail.com',N'01234569',{ts '2015-04-14 10:09:19.000'},1,2);
GO
SET IDENTITY_INSERT [UserInfo] OFF;
GO
SET IDENTITY_INSERT [Product] ON;
GO
INSERT INTO [Product] ([Id],[Title],[DurationInMin],[VideoTypeId],[Actors],[Directors],[Producers],[ReleaseDate],[ImagePath],[StatusEnumId],[TotalItem],[TotalSold],[BuyPrice],[SellingPrice],[TotalRented],[CreateById],[CreateDate]) VALUES (
1,N'Iron Man',120,0,N'Robert Downeyjr',N'Jhon Favrean',N'Maek Fergw',{ts '2008-05-02 12:41:30.493'},N'\ProductImage\34.jpg',0,30,13,50,60,2,15,{ts '2017-10-17 00:11:05.580'});
GO
INSERT INTO [Product] ([Id],[Title],[DurationInMin],[VideoTypeId],[Actors],[Directors],[Producers],[ReleaseDate],[ImagePath],[StatusEnumId],[TotalItem],[TotalSold],[BuyPrice],[SellingPrice],[TotalRented],[CreateById],[CreateDate]) VALUES (
2,N'The Avengers',110,0,N'Chris Evans',N'Joss Whedon',N'Zak Penn',{ts '2012-05-04 12:41:30.493'},N'\ProductImage\2.jpg',0,6,6,50,60,0,15,{ts '2017-10-17 00:11:05.580'});
GO
INSERT INTO [Product] ([Id],[Title],[DurationInMin],[VideoTypeId],[Actors],[Directors],[Producers],[ReleaseDate],[ImagePath],[StatusEnumId],[TotalItem],[TotalSold],[BuyPrice],[SellingPrice],[TotalRented],[CreateById],[CreateDate]) VALUES (
3,N'Captain America',125,0,N'Chris Evans',N'Joe Johnston',N'Jack Kirby',{ts '2011-07-22 12:41:30.493'},N'\ProductImage\36.jpg',0,8,8,50,60,0,15,{ts '2017-10-17 00:11:05.580'});
GO
INSERT INTO [Product] ([Id],[Title],[DurationInMin],[VideoTypeId],[Actors],[Directors],[Producers],[ReleaseDate],[ImagePath],[StatusEnumId],[TotalItem],[TotalSold],[BuyPrice],[SellingPrice],[TotalRented],[CreateById],[CreateDate]) VALUES (
4,N'Thor',100,0,N'Chris Hemsworth',N'Kenneth Branagh',N'Ashley Miller',{ts '2011-05-06 12:41:30.493'},N'\ProductImage\37.jpg',0,8,8,50,60,0,15,{ts '2017-10-17 00:11:05.580'});
GO
INSERT INTO [Product] ([Id],[Title],[DurationInMin],[VideoTypeId],[Actors],[Directors],[Producers],[ReleaseDate],[ImagePath],[StatusEnumId],[TotalItem],[TotalSold],[BuyPrice],[SellingPrice],[TotalRented],[CreateById],[CreateDate]) VALUES (
5,N'Big Hero 6',110,0,N'Ryan Potter',N'Dan Hall',N'Jordon Roberts',{ts '2014-11-04 12:41:30.000'},N'\ProductImage\5.jpg',0,30,6,50,60,2,15,{ts '2017-10-17 00:11:05.580'});
GO
INSERT INTO [Product] ([Id],[Title],[DurationInMin],[VideoTypeId],[Actors],[Directors],[Producers],[ReleaseDate],[ImagePath],[StatusEnumId],[TotalItem],[TotalSold],[BuyPrice],[SellingPrice],[TotalRented],[CreateById],[CreateDate]) VALUES (
6,N'Kung Fu Panda',110,0,N'Jack Black',N'Marke Osborne',N'Ethen Rief',{ts '2008-06-06 12:41:30.493'},N'\ProductImage\6.jpg',0,30,10,50,60,0,15,{ts '2017-10-17 00:11:05.580'});
GO
INSERT INTO [Product] ([Id],[Title],[DurationInMin],[VideoTypeId],[Actors],[Directors],[Producers],[ReleaseDate],[ImagePath],[StatusEnumId],[TotalItem],[TotalSold],[BuyPrice],[SellingPrice],[TotalRented],[CreateById],[CreateDate]) VALUES (
7,N'Kung Fu Panda 2',100,0,N'Jack Black',N'Jenifer Yu',N'Goln Berger',{ts '2011-05-26 12:41:30.493'},N'\ProductImage\7.jpg',0,30,2,50,60,0,15,{ts '2017-10-17 00:11:05.580'});
GO
INSERT INTO [Product] ([Id],[Title],[DurationInMin],[VideoTypeId],[Actors],[Directors],[Producers],[ReleaseDate],[ImagePath],[StatusEnumId],[TotalItem],[TotalSold],[BuyPrice],[SellingPrice],[TotalRented],[CreateById],[CreateDate]) VALUES (
8,N'Moana',95,0,N'Dwayne Jonson',N'Dan Hall',N'Jored Bush',{ts '2016-11-23 12:41:30.493'},N'\ProductImage\8.jpg',0,30,1,50,60,0,15,{ts '2017-10-17 00:11:05.580'});
GO
INSERT INTO [Product] ([Id],[Title],[DurationInMin],[VideoTypeId],[Actors],[Directors],[Producers],[ReleaseDate],[ImagePath],[StatusEnumId],[TotalItem],[TotalSold],[BuyPrice],[SellingPrice],[TotalRented],[CreateById],[CreateDate]) VALUES (
9,N'Kung Fu Panda 3',100,0,N'Jack Black',N'Jennifer Yuh Nelson',N'Golnn Berger',{ts '2016-01-23 12:41:30.493'},N'\ProductImage\9.jpg',0,30,2,50,60,0,15,{ts '2017-10-17 00:11:05.580'});
GO
INSERT INTO [Product] ([Id],[Title],[DurationInMin],[VideoTypeId],[Actors],[Directors],[Producers],[ReleaseDate],[ImagePath],[StatusEnumId],[TotalItem],[TotalSold],[BuyPrice],[SellingPrice],[TotalRented],[CreateById],[CreateDate]) VALUES (
10,N'Iron Man 2',125,0,N'Robert Downey Jr.',N'Jon Faveau',N'Stan Lee',{ts '2010-05-07 12:41:30.493'},N'\ProductImage\10.jpg',0,30,1,50,60,0,15,{ts '2017-10-17 00:11:05.580'});
GO
INSERT INTO [Product] ([Id],[Title],[DurationInMin],[VideoTypeId],[Actors],[Directors],[Producers],[ReleaseDate],[ImagePath],[StatusEnumId],[TotalItem],[TotalSold],[BuyPrice],[SellingPrice],[TotalRented],[CreateById],[CreateDate]) VALUES (
11,N'Iron Man 3',130,0,N'Robert Downey Jr.',N'Shane Black',N'Shane Black',{ts '2012-05-03 12:41:30.493'},N'\ProductImage\11.jpg',0,2,2,50,60,0,15,{ts '2017-10-17 00:11:05.580'});
GO
INSERT INTO [Product] ([Id],[Title],[DurationInMin],[VideoTypeId],[Actors],[Directors],[Producers],[ReleaseDate],[ImagePath],[StatusEnumId],[TotalItem],[TotalSold],[BuyPrice],[SellingPrice],[TotalRented],[CreateById],[CreateDate]) VALUES (
12,N'The Avengers : Age Of Ultron',130,0,N'Chris Hemswath',N'Joss Whedon',N'Stan Lee',{ts '2015-05-01 12:41:30.493'},N'\ProductImage\12.jpg',0,30,0,50,60,0,15,{ts '2017-10-17 00:11:05.580'});
GO
INSERT INTO [Product] ([Id],[Title],[DurationInMin],[VideoTypeId],[Actors],[Directors],[Producers],[ReleaseDate],[ImagePath],[StatusEnumId],[TotalItem],[TotalSold],[BuyPrice],[SellingPrice],[TotalRented],[CreateById],[CreateDate]) VALUES (
13,N'Captain America : The Winter Soilder',130,0,N'Chirs Evans ',N'Anthony Russo',N'Jack Kirby',{ts '2014-07-22 12:41:30.493'},N'\ProductImage\13.jpg',0,30,0,50,60,0,15,{ts '2017-10-17 00:11:05.580'});
GO
INSERT INTO [Product] ([Id],[Title],[DurationInMin],[VideoTypeId],[Actors],[Directors],[Producers],[ReleaseDate],[ImagePath],[StatusEnumId],[TotalItem],[TotalSold],[BuyPrice],[SellingPrice],[TotalRented],[CreateById],[CreateDate]) VALUES (
14,N'Captain America : Civil War ',130,0,N'Chris Evans  ',N'Joe Russo',N'Joe Simon ',{ts '2016-05-06 12:41:30.493'},N'\ProductImage\14.jpg',NULL,10,0,100,110,0,15,{ts '2017-10-17 00:11:05.580'});
GO
INSERT INTO [Product] ([Id],[Title],[DurationInMin],[VideoTypeId],[Actors],[Directors],[Producers],[ReleaseDate],[ImagePath],[StatusEnumId],[TotalItem],[TotalSold],[BuyPrice],[SellingPrice],[TotalRented],[CreateById],[CreateDate]) VALUES (
17,N'Bugs life',120,0,N'james',N'micle',N'david',{ts '2017-03-13 12:41:30.493'},N'\ProductImage\17.jpg',NULL,0,0,50,70,0,15,{ts '2017-10-17 00:11:05.580'});
GO
SET IDENTITY_INSERT [Product] OFF;
GO
SET IDENTITY_INSERT [Invoice] ON;
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
1,3,180,0,{ts '2017-04-09 21:29:03.173'},0,{ts '2017-04-09 21:29:03.173'},0);
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
2,3,120,0,{ts '2017-04-02 21:37:32.863'},0,{ts '2017-04-09 21:37:32.863'},0);
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
3,7,360,0,{ts '2017-04-07 21:41:55.537'},0,{ts '2017-04-09 21:42:17.183'},0);
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
4,2,60,0,{ts '2017-04-09 21:47:14.460'},0,{ts '2017-04-09 21:47:14.460'},0);
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
5,4,180,0,{ts '2017-04-10 12:37:32.540'},0,{ts '2017-04-10 12:37:32.540'},0);
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
6,2,120,0,{ts '2017-04-10 21:59:25.227'},0,{ts '2017-04-10 21:59:25.227'},0);
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
7,6,360,0,{ts '2017-04-11 01:08:17.230'},0,{ts '2017-04-11 01:08:17.230'},0);
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
8,3,180,0,{ts '2017-04-11 11:26:50.820'},0,{ts '2017-04-11 11:26:50.820'},0);
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
9,5,300,0,{ts '2017-04-11 11:52:00.560'},0,{ts '2017-04-11 11:52:00.560'},0);
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
10,4,240,0,{ts '2017-04-13 01:12:19.857'},0,{ts '2017-04-13 01:12:19.857'},0);
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
11,3,180,0,{ts '2017-04-13 01:18:24.750'},0,{ts '2017-04-13 01:18:25.687'},0);
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
12,2,120,0,{ts '2017-04-13 09:33:39.537'},0,{ts '2017-04-13 09:33:39.537'},0);
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
13,3,180,0,{ts '2017-08-13 14:50:46.533'},0,{ts '2017-08-13 14:50:46.533'},0);
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
14,1,60,0,{ts '2017-08-27 10:58:15.550'},0,{ts '2017-08-27 10:58:15.550'},0);
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
15,7,420,15,{ts '2017-09-11 21:12:45.603'},15,{ts '2017-09-11 21:12:45.603'},0);
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
16,3,180,20,{ts '2017-09-12 11:22:35.900'},20,{ts '2017-09-12 11:22:35.900'},0);
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
17,2,120,0,{ts '2017-10-17 01:29:59.303'},0,{ts '2017-10-17 01:29:59.303'},0);
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
20,3,60,0,{ts '2017-10-17 01:49:52.467'},0,{ts '2017-10-17 01:49:52.467'},1);
GO
INSERT INTO [Invoice] ([Id],[TotalItem],[TotalSellingPrice],[CreateById],[CreateDate],[UpdateById],[UpdateDate],[InRent]) VALUES (
21,1,20,0,{ts '2017-10-18 21:25:12.670'},0,{ts '2017-10-18 21:25:12.673'},1);
GO
SET IDENTITY_INSERT [Invoice] OFF;
GO
SET IDENTITY_INSERT [Sold] ON;
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
1,3,1,3,60,180,{ts '2017-04-09 23:32:12.793'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
2,2,2,2,60,120,{ts '2017-04-09 23:32:12.793'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
3,4,3,3,60,180,{ts '2017-04-09 23:32:12.793'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
4,3,3,1,60,60,{ts '2017-04-09 23:32:12.793'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
5,5,3,2,60,120,{ts '2017-04-09 23:32:12.793'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
6,1,4,1,60,60,{ts '2017-04-09 23:32:12.793'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
7,4,5,3,60,180,{ts '2017-04-10 12:37:32.630'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
8,2,6,2,60,120,{ts '2017-04-10 21:59:25.327'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
9,11,7,2,60,120,{ts '2017-04-11 01:08:17.247'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
10,9,7,2,60,120,{ts '2017-04-11 01:08:17.247'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
11,1,7,2,60,120,{ts '2017-04-11 01:08:17.247'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
12,6,8,2,60,120,{ts '2017-04-11 11:26:50.867'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
13,8,8,1,60,60,{ts '2017-04-11 11:26:50.880'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
14,1,9,3,60,180,{ts '2017-04-11 11:52:00.577'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
15,2,9,2,60,120,{ts '2017-04-11 11:52:00.577'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
16,3,10,4,60,240,{ts '2017-04-13 01:12:19.920'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
17,5,11,3,60,180,{ts '2017-04-13 01:24:06.137'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
18,4,12,2,60,120,{ts '2017-04-13 09:33:39.567'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
19,7,13,2,60,120,{ts '2017-08-13 14:50:46.927'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
20,10,13,1,60,60,{ts '2017-08-13 14:50:46.940'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
21,5,14,1,60,60,{ts '2017-08-27 10:58:16.173'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
22,6,15,5,60,300,{ts '2017-09-11 21:12:46.027'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
23,1,15,2,60,120,{ts '2017-09-11 21:12:46.057'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
24,6,16,3,60,180,{ts '2017-09-12 11:22:35.977'});
GO
INSERT INTO [Sold] ([Id],[ProductId],[InvoiceId],[Quantity],[UnitSellingPrice],[TotalPrice],[SaleDate]) VALUES (
25,1,17,2,60,120,{ts '2017-10-17 01:29:59.670'});
GO
SET IDENTITY_INSERT [Sold] OFF;
GO
SET IDENTITY_INSERT [Customer] ON;
GO
INSERT INTO [Customer] ([Id],[Name],[Address],[MobileNumber],[GenderEnumId],[Diposite],[CreateById],[CreateDate],[UpdateById],[UpdateDate]) VALUES (
1,N'Kabir Ahmed',N'Farazipara,Khulna',195569401,0,300,1,{ts '2017-04-04 02:28:08.237'},1,{ts '2017-04-04 02:28:08.237'});
GO
INSERT INTO [Customer] ([Id],[Name],[Address],[MobileNumber],[GenderEnumId],[Diposite],[CreateById],[CreateDate],[UpdateById],[UpdateDate]) VALUES (
2,N'Moushan',N'Rupsa, Khulna',1772121415,1,250,1,{ts '2017-04-11 10:51:03.843'},1,{ts '2017-04-11 10:51:03.843'});
GO
SET IDENTITY_INSERT [Customer] OFF;
GO
SET IDENTITY_INSERT [Rented] ON;
GO
INSERT INTO [Rented] ([Id],[CustomerId],[ProductId],[InvoiceId],[RentDate],[ReturnDate],[RentAmount],[IsReturned],[Quantity]) VALUES (
3,1,1,20,{ts '2017-10-17 01:49:52.517'},{ts '2017-10-24 01:49:52.517'},20,0,1);
GO
INSERT INTO [Rented] ([Id],[CustomerId],[ProductId],[InvoiceId],[RentDate],[ReturnDate],[RentAmount],[IsReturned],[Quantity]) VALUES (
4,1,5,20,{ts '2017-10-17 01:49:52.530'},{ts '2017-10-24 01:49:52.530'},20,0,2);
GO
INSERT INTO [Rented] ([Id],[CustomerId],[ProductId],[InvoiceId],[RentDate],[ReturnDate],[RentAmount],[IsReturned],[Quantity]) VALUES (
5,1,1,21,{ts '2017-10-18 21:25:12.793'},{ts '2017-10-25 21:25:12.793'},20,0,1);
GO
SET IDENTITY_INSERT [Rented] OFF;
GO
ALTER TABLE [UserInfo] ADD CONSTRAINT [PK_UserInfo] PRIMARY KEY ([Id]);
GO
ALTER TABLE [Product] ADD CONSTRAINT [PK_VideoInfo] PRIMARY KEY ([Id]);
GO
ALTER TABLE [Invoice] ADD CONSTRAINT [PK_Tranjection] PRIMARY KEY ([Id]);
GO
ALTER TABLE [Sold] ADD CONSTRAINT [PK_Sold] PRIMARY KEY ([Id]);
GO
ALTER TABLE [Customer] ADD CONSTRAINT [PK_Customer] PRIMARY KEY ([Id]);
GO
ALTER TABLE [Rented] ADD CONSTRAINT [PK_Rented] PRIMARY KEY ([Id]);
GO
ALTER TABLE [UserInfo] ADD CONSTRAINT [UK_UserName] UNIQUE ([UserName]);
GO
ALTER TABLE [Sold] ADD CONSTRAINT [FK_Sold_Invoice] FOREIGN KEY ([InvoiceId]) REFERENCES [Invoice]([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
ALTER TABLE [Sold] ADD CONSTRAINT [FK_Sold_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product]([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
ALTER TABLE [Rented] ADD CONSTRAINT [FK_Rented_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [Customer]([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
ALTER TABLE [Rented] ADD CONSTRAINT [FK_Rented_Invoice] FOREIGN KEY ([InvoiceId]) REFERENCES [Invoice]([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
ALTER TABLE [Rented] ADD CONSTRAINT [FK_Rented_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product]([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

