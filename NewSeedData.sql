USE [RentCars.mdf]
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'0148617b-ef31-46aa-bac8-ff78f4799e1d', N'Customer', N'CUSTOMER', NULL)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'6688565a-c815-4ffd-9677-443011d99592', N'Admin', N'ADMIN', NULL)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'09532693-d7de-40cd-abeb-c22642932d66', N'Admin101@gmail.com', N'ADMIN101@GMAIL.COM', N'Admin101@gmail.com', N'ADMIN101@GMAIL.COM', 1, N'AQAAAAIAAYagAAAAEIs6Xd/S8UDO2uZ6ZCKxbDla19ozCRHPQz35Vf06MWQ0OwpYll7VEongJQRfRWJ7Xg==', N'2QFODS4RUTGUFOUBUZF245EWYUQWPBQ4', N'ba394a2c-1563-48f4-b8fa-5e9a843cae1b', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'298896ec-1483-4113-839e-0a7d7a732bd0', N'customer02@gmail.com', N'CUSTOMER02@GMAIL.COM', N'customer02@gmail.com', N'CUSTOMER02@GMAIL.COM', 1, N'AQAAAAIAAYagAAAAEDH3LXkAbhhgHGUJiFLAUo9+PtS2efiF8Zn3Q5zctkkyZJr5IOd3ksLnfoprBGnMAQ==', N'PRA5G7LCZCPC7RBMUIPWDUXUHH5IN2RW', N'9dc8ac0c-169a-40b8-af26-75c6212bb1d8', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'2d270b5e-fb3b-489f-992f-d268c11417c1', N'customer03@gmail.com', N'CUSTOMER03@GMAIL.COM', N'customer03@gmail.com', N'CUSTOMER03@GMAIL.COM', 1, N'AQAAAAIAAYagAAAAEKcmEIZhqoulH4ON9HYOj7jfxnetMcSDdPbnTDaCYTa9bdQJ5DUx9+DBF3yzMYVbfA==', N'DGQ2G3COL7KDFCVXGPEE2Z25MHMUH5SA', N'd877336f-1417-4ec7-8f20-e78d7bc013c7', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'b133bd0b-5424-4189-8edd-294c39d3a659', N'customer04@gmail.com', N'CUSTOMER04@GMAIL.COM', N'customer04@gmail.com', N'CUSTOMER04@GMAIL.COM', 1, N'AQAAAAIAAYagAAAAEKmzuc/oRXuYpAyVRWpsB/4bHcGlCIJryGuO7BAnuXCvm2iwVYV1Tj/Xv2t5w61/Vw==', N'QMP7CUPVNB2UTWZX67HFPSKG2HEBFWDK', N'32ce1ec5-74b1-46dc-a63c-8bd5578fbebb', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'efe49c7e-0269-40f8-92b7-fee8dcd812be', N'customer01@gmail.com', N'CUSTOMER01@GMAIL.COM', N'customer01@gmail.com', N'CUSTOMER01@GMAIL.COM', 1, N'AQAAAAIAAYagAAAAECYkuIM57Wz1MpvglYRPjF3NVuLbsjEWM+T4omqD1Sd7pi9q/JWHLjF+mKOa7CMViQ==', N'QZRFMD3QGYAVN57DOL2UCU37XQTR3S72', N'01a56aee-095c-46f3-926f-ffe8e655263f', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'298896ec-1483-4113-839e-0a7d7a732bd0', N'0148617b-ef31-46aa-bac8-ff78f4799e1d')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2d270b5e-fb3b-489f-992f-d268c11417c1', N'0148617b-ef31-46aa-bac8-ff78f4799e1d')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b133bd0b-5424-4189-8edd-294c39d3a659', N'0148617b-ef31-46aa-bac8-ff78f4799e1d')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'efe49c7e-0269-40f8-92b7-fee8dcd812be', N'0148617b-ef31-46aa-bac8-ff78f4799e1d')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'09532693-d7de-40cd-abeb-c22642932d66', N'6688565a-c815-4ffd-9677-443011d99592')
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerId], [Lname], [Fname], [License], [Email], [Phone]) VALUES (1, N'Tan', N'Amanda', N'DF86732', N'customer01@gmail.com', 98221121)
INSERT [dbo].[Customer] ([CustomerId], [Lname], [Fname], [License], [Email], [Phone]) VALUES (2, N'Fin', N'Lara', N'ER67542', N'customer02@gmail.com', 87541324)
INSERT [dbo].[Customer] ([CustomerId], [Lname], [Fname], [License], [Email], [Phone]) VALUES (3, N'Max', N'Jen', N'QT23217', N'customer03@gmail.com', 98343232)
INSERT [dbo].[Customer] ([CustomerId], [Lname], [Fname], [License], [Email], [Phone]) VALUES (4, N'Wills', N'Smith', N'PO21232', N'customer04@gmail.com', 42313231)
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([StaffId], [Lname], [Fname], [Phone], [Role]) VALUES (1, N'Fox', N'Jame', 89763456, N'Admin')
SET IDENTITY_INSERT [dbo].[Staff] OFF
GO
SET IDENTITY_INSERT [dbo].[Rental] ON 

INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (1, CAST(N'2025-06-13' AS Date), CAST(N'2025-06-13' AS Date), N'Confirmed', 0, 0, 0, 0, 1, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (2, CAST(N'2025-06-13' AS Date), CAST(N'2025-06-13' AS Date), N'Confirmed', 0, 0, 0, 0, 1, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (3, CAST(N'2025-06-13' AS Date), CAST(N'2025-06-13' AS Date), N'Confirmed', 0, 0, 0, 0, 2, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (4, CAST(N'2025-06-13' AS Date), CAST(N'2025-06-13' AS Date), N'Confirmed', 0, 0, 0, 0, 2, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (5, CAST(N'2025-06-13' AS Date), CAST(N'2025-06-13' AS Date), N'Confirmed', 0, 0, 0, 0, 2, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (6, CAST(N'2025-06-13' AS Date), CAST(N'2025-06-13' AS Date), N'Confirmed', 0, 0, 0, 0, 2, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (7, CAST(N'2025-06-13' AS Date), CAST(N'2025-06-13' AS Date), N'Confirmed', 0, 0, 0, 0, 2, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (8, CAST(N'2025-06-14' AS Date), CAST(N'2025-06-14' AS Date), N'Confirmed', 0, 0, 0, 0, 2, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (9, CAST(N'2025-06-14' AS Date), CAST(N'2025-06-14' AS Date), N'Confirmed', 0, 0, 0, 0, 2, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (10, CAST(N'2025-06-14' AS Date), CAST(N'2025-06-14' AS Date), N'Confirmed', 0, 0, 0, 0, 1, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (11, CAST(N'2025-06-14' AS Date), CAST(N'2025-06-14' AS Date), N'Confirmed', 0, 0, 0, 0, 2, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (12, CAST(N'2025-06-14' AS Date), CAST(N'2025-06-14' AS Date), N'Confirmed', 0, 0, 0, 0, 3, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (13, CAST(N'2025-06-13' AS Date), CAST(N'2025-06-13' AS Date), N'Confirmed', 0, 0, 0, 0, 3, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (14, CAST(N'2025-06-13' AS Date), CAST(N'2025-06-13' AS Date), N'Confirmed', 0, 0, 0, 0, 3, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (15, CAST(N'2025-06-13' AS Date), CAST(N'2025-06-16' AS Date), N'Confirmed', 0, 0, 0, 0, 3, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (16, CAST(N'2025-06-14' AS Date), CAST(N'2025-06-14' AS Date), N'Confirmed', 0, 0, 0, 0, 3, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (18, CAST(N'2025-06-13' AS Date), CAST(N'2025-06-13' AS Date), N'Confirmed', 0, 0, 0, 0, 3, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (19, CAST(N'2025-06-16' AS Date), CAST(N'2025-06-16' AS Date), N'Confirmed', 0, 0, 0, 0, 3, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (20, CAST(N'2025-06-16' AS Date), CAST(N'2025-06-16' AS Date), N'Confirmed', 0, 0, 0, 0, 2, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (21, CAST(N'2025-06-16' AS Date), CAST(N'2025-06-17' AS Date), N'Confirmed', 0, 0, 0, 0, 3, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (22, CAST(N'2025-06-16' AS Date), CAST(N'2025-06-17' AS Date), N'Confirmed', 0, 0, 0, 0, 3, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (23, CAST(N'2025-06-16' AS Date), CAST(N'2025-06-17' AS Date), N'Confirmed', 0, 0, 0, 0, 3, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (24, CAST(N'2025-06-16' AS Date), CAST(N'2025-06-17' AS Date), N'Confirmed', 0, 0, 0, 0, 3, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (25, CAST(N'2025-06-16' AS Date), CAST(N'2025-06-17' AS Date), N'Confirmed', 0, 0, 0, 0, 1, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (26, CAST(N'2025-06-16' AS Date), CAST(N'2025-06-16' AS Date), N'Confirmed', 0, 0, 0, 0, 1, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (27, CAST(N'2025-06-16' AS Date), CAST(N'2025-06-17' AS Date), N'Confirmed', 0, 0, 0, 0, 2, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (28, CAST(N'2025-06-16' AS Date), CAST(N'2025-06-16' AS Date), N'Confirmed', 0, 0, 0, 0, 3, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (29, CAST(N'2025-06-16' AS Date), CAST(N'2025-06-17' AS Date), N'Confirmed', 0, 0, 0, 0, 4, 1)
INSERT [dbo].[Rental] ([RentalId], [StartDate], [EndDate], [BookingStatus], [EstimatedRentalCost], [Latefee], [SecurityDeposit], [TotalAmount], [CustomerId], [StaffId]) VALUES (30, CAST(N'2025-06-16' AS Date), CAST(N'2025-06-16' AS Date), N'Confirmed', 0, 0, 0, 0, 4, 1)
SET IDENTITY_INSERT [dbo].[Rental] OFF
GO
SET IDENTITY_INSERT [dbo].[Vehicle] ON 

INSERT [dbo].[Vehicle] ([VehicleId], [Type], [Model], [Year], [Mileage], [LicensePlate], [Status], [DailyRate], [WeeklyRate], [MonthlyRate], [ImageUrl]) VALUES (1, N'SUV', N'Honda Vezel', 2022, 20, N'SBA1234A', N'Available', 95, 665, 2850, N'suvhondavezel.jpg')
INSERT [dbo].[Vehicle] ([VehicleId], [Type], [Model], [Year], [Mileage], [LicensePlate], [Status], [DailyRate], [WeeklyRate], [MonthlyRate], [ImageUrl]) VALUES (2, N'SUV', N'Hyundai Hybrid', 2018, 15, N'SBR6532R', N'Available', 85, 595, 2550, N'suvhyundaihybrid.jpg')
INSERT [dbo].[Vehicle] ([VehicleId], [Type], [Model], [Year], [Mileage], [LicensePlate], [Status], [DailyRate], [WeeklyRate], [MonthlyRate], [ImageUrl]) VALUES (3, N'SUV', N'Skoda Kodiaq', 2020, 20, N'SBC7657C', N'Available', 100, 700, 3000, N'suvskodakodiaq.jpg')
INSERT [dbo].[Vehicle] ([VehicleId], [Type], [Model], [Year], [Mileage], [LicensePlate], [Status], [DailyRate], [WeeklyRate], [MonthlyRate], [ImageUrl]) VALUES (4, N'SUV', N'Mitsubishi Outlander', 2022, 20, N'SBB9845B', N'Available', 95, 665, 2850, N'suvmitsubishioutlander.jpg')
INSERT [dbo].[Vehicle] ([VehicleId], [Type], [Model], [Year], [Mileage], [LicensePlate], [Status], [DailyRate], [WeeklyRate], [MonthlyRate], [ImageUrl]) VALUES (5, N'SUV', N'Hyundai Palisade', 2019, 18, N'SBE5432E', N'Available', 110, 770, 3300, N'suvhyundaipalisade.jpg')
INSERT [dbo].[Vehicle] ([VehicleId], [Type], [Model], [Year], [Mileage], [LicensePlate], [Status], [DailyRate], [WeeklyRate], [MonthlyRate], [ImageUrl]) VALUES (6, N'SUV', N'Toyota Fortuner', 2023, 22, N'SBQ2345Q', N'Available', 130, 910, 3900, N'suvtoyotafortuner.jpg')
INSERT [dbo].[Vehicle] ([VehicleId], [Type], [Model], [Year], [Mileage], [LicensePlate], [Status], [DailyRate], [WeeklyRate], [MonthlyRate], [ImageUrl]) VALUES (7, N'SUV', N'Jeep Wrangler', 2024, 22, N'SBT2903T', N'Available', 110, 770, 3300, N'suvjeepwrangler.jpg')
INSERT [dbo].[Vehicle] ([VehicleId], [Type], [Model], [Year], [Mileage], [LicensePlate], [Status], [DailyRate], [WeeklyRate], [MonthlyRate], [ImageUrl]) VALUES (8, N'SUV', N'Toyota Harrier', 2024, 15, N'SBX6745X', N'Available', 95, 665, 2850, N'suvtoyotaharrier.jpg')
INSERT [dbo].[Vehicle] ([VehicleId], [Type], [Model], [Year], [Mileage], [LicensePlate], [Status], [DailyRate], [WeeklyRate], [MonthlyRate], [ImageUrl]) VALUES (9, N'SUV', N'Kia Sonet', 2019, 15, N'SBP3821P', N'Available', 80, 560, 2400, N'suvkiasonet.jpg')
INSERT [dbo].[Vehicle] ([VehicleId], [Type], [Model], [Year], [Mileage], [LicensePlate], [Status], [DailyRate], [WeeklyRate], [MonthlyRate], [ImageUrl]) VALUES (10, N'SUV', N'Volkswagen Tiguan', 2020, 20, N'SBM3094M', N'Available', 90, 630, 2700, N'suvvolkswagentiguan.jpg')
INSERT [dbo].[Vehicle] ([VehicleId], [Type], [Model], [Year], [Mileage], [LicensePlate], [Status], [DailyRate], [WeeklyRate], [MonthlyRate], [ImageUrl]) VALUES (11, N'SUV', N'Mazda CX8', 2018, 18, N'SBG3276G', N'Available', 120, 840, 3600, N'suvmazdacx8.jpg')
INSERT [dbo].[Vehicle] ([VehicleId], [Type], [Model], [Year], [Mileage], [LicensePlate], [Status], [DailyRate], [WeeklyRate], [MonthlyRate], [ImageUrl]) VALUES (12, N'SUV', N'Volvo CX90', 2021, 23, N'SBI5833I', N'Available', 125, 875, 3750, N'suvvolvoxc90.jpg')
SET IDENTITY_INSERT [dbo].[Vehicle] OFF
GO
SET IDENTITY_INSERT [dbo].[RentalDetail] ON 

INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (1, 1, 85, 1, 2)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (2, 1, 100, 2, 3)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (3, 1, 120, 3, 11)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (4, 1, 85, 4, 2)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (5, 1, 85, 5, 2)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (6, 1, 95, 6, 1)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (7, 1, 95, 7, 1)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (8, 1, 95, 8, 4)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (9, 1, 95, 9, 1)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (10, 1, 90, 10, 10)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (11, 1, 80, 11, 9)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (12, 1, 130, 12, 6)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (13, 1, 130, 13, 6)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (14, 1, 95, 14, 8)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (15, 1, 110, 15, 5)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (16, 1, 95, 16, 4)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (18, 1, 90, 18, 10)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (19, 1, 95, 19, 1)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (20, 1, 95, 20, 4)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (21, 1, 90, 21, 10)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (22, 1, 90, 22, 10)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (23, 1, 80, 23, 9)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (24, 1, 85, 24, 2)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (25, 1, 120, 25, 11)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (26, 1, 95, 26, 4)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (27, 1, 80, 27, 9)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (28, 1, 110, 28, 7)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (29, 1, 125, 29, 12)
INSERT [dbo].[RentalDetail] ([RentalDetailId], [NumberOfDays], [DailyRate], [RentalId], [VehicleId]) VALUES (30, 1, 100, 30, 3)
SET IDENTITY_INSERT [dbo].[RentalDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Invoice] ON 

INSERT [dbo].[Invoice] ([InvoiceId], [Date], [TotalAmount], [PaymentStatus], [RentalId]) VALUES (1, CAST(N'2025-06-13' AS Date), 130, N'Paid', 3)
INSERT [dbo].[Invoice] ([InvoiceId], [Date], [TotalAmount], [PaymentStatus], [RentalId]) VALUES (2, CAST(N'2025-06-13' AS Date), 175, N'Paid', 3)
INSERT [dbo].[Invoice] ([InvoiceId], [Date], [TotalAmount], [PaymentStatus], [RentalId]) VALUES (3, CAST(N'2025-06-13' AS Date), 170, N'Paid', 3)
INSERT [dbo].[Invoice] ([InvoiceId], [Date], [TotalAmount], [PaymentStatus], [RentalId]) VALUES (4, CAST(N'2025-06-16' AS Date), 95, N'Paid', 3)
INSERT [dbo].[Invoice] ([InvoiceId], [Date], [TotalAmount], [PaymentStatus], [RentalId]) VALUES (5, CAST(N'2025-06-16' AS Date), 270, N'Paid', 2)
INSERT [dbo].[Invoice] ([InvoiceId], [Date], [TotalAmount], [PaymentStatus], [RentalId]) VALUES (6, CAST(N'2025-06-16' AS Date), 180, N'Paid', 3)
INSERT [dbo].[Invoice] ([InvoiceId], [Date], [TotalAmount], [PaymentStatus], [RentalId]) VALUES (7, CAST(N'2025-06-16' AS Date), 0, N'Paid', 3)
INSERT [dbo].[Invoice] ([InvoiceId], [Date], [TotalAmount], [PaymentStatus], [RentalId]) VALUES (8, CAST(N'2025-06-16' AS Date), 85, N'Paid', 3)
INSERT [dbo].[Invoice] ([InvoiceId], [Date], [TotalAmount], [PaymentStatus], [RentalId]) VALUES (9, CAST(N'2025-06-16' AS Date), 210, N'Paid', 1)
INSERT [dbo].[Invoice] ([InvoiceId], [Date], [TotalAmount], [PaymentStatus], [RentalId]) VALUES (10, CAST(N'2025-06-16' AS Date), 95, N'Paid', 1)
INSERT [dbo].[Invoice] ([InvoiceId], [Date], [TotalAmount], [PaymentStatus], [RentalId]) VALUES (11, CAST(N'2025-06-16' AS Date), 80, N'Paid', 2)
INSERT [dbo].[Invoice] ([InvoiceId], [Date], [TotalAmount], [PaymentStatus], [RentalId]) VALUES (12, CAST(N'2025-06-16' AS Date), 110, N'Paid', 3)
INSERT [dbo].[Invoice] ([InvoiceId], [Date], [TotalAmount], [PaymentStatus], [RentalId]) VALUES (13, CAST(N'2025-06-16' AS Date), 125, N'Paid', 4)
INSERT [dbo].[Invoice] ([InvoiceId], [Date], [TotalAmount], [PaymentStatus], [RentalId]) VALUES (14, CAST(N'2025-06-16' AS Date), 100, N'Paid', 4)
SET IDENTITY_INSERT [dbo].[Invoice] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'9.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250530032834_InitialCreate', N'9.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250530045900_AddedImageUrl', N'9.0.5')
GO
