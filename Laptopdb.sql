USE [LaptopsOnline]
GO

/****** Object: Table [dbo].[Laptops] Script Date: 16-09-2022 16:42:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Laptops] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [ModelName]   NVARCHAR (MAX) NOT NULL,
    [Price]       NVARCHAR (MAX) NULL,
    [Image]       NVARCHAR (MAX) NULL,
    [Brand]       NVARCHAR (MAX) NULL,
    [RamSize]     NVARCHAR (MAX) NULL,
    [CPUModel]    NVARCHAR (MAX) NULL,
    [ScreenSize]  NVARCHAR (MAX) NULL,
    [Description] NVARCHAR (MAX) NULL
);

set identity_insert Laptops OFF;

select * from Laptops;

insert into Laptops
(Id,
ModelName,
Price,
Image,
Brand,
RamSize,
CPUModel,
ScreenSize,
Description)
values
(
'00',
'15s-fq2673TU',
'42,999',
'00.jpg',
'HP',
'8 GB',
'Core i3',
'39.6 Centimetres',
'HP 15s, 11th Gen Intel Core i3, 8GB RAM/512GB SSD 15.6-inch(39.6 cm) Micro-Edge Anti-Glare FHD Laptop/Alexa Built-in/Win 11/Intel UHD Graphics/Dual Speakers/ MS Office 2021/1.69 Kg, 15s-fq2673TU'
),
(
'01',
'AERO 5 KE4',
'1,67,990',
'01.jpg',
'GIGABYTE',
'16 GB',
'Core I7 12700H',
'15.6 Inches',
'GIGABYTE AERO 5 KE4 Laptop, 15.6" UHD OLED 60Hz, Intel Core i7-12700H 12th Gen, NVIDIA® RTX 3060 6GB Graphics, Gaming Laptop (16 GB / Windows 11 Home / Gen4 1TB SSD/ Office 365/Black)'
),
(
'02',
'ROG Zephyrus Duo 16 (2022)',
'3,91,990',
'02.jpg',
'ASUS',
'32 GB',
'Ryzen 9',
'16 Inches',
'ASUS ROG Zephyrus Duo 16 (2022), 16" (40.64 cm) QHD+ 16:10 165Hz/3ms, AMD Ryzen 9 6900HX, 16GB RTX 3080 Ti, Dual-Screen Gaming Laptop (32GB/2TB SSD/Win 11/with Office/Black/2.60 Kg), GX650RXZ-LO227WS'
),
(
'03',
'15s- fq5111TU',
'56,916',
'03.jpg',
'HP',
'8 GB',
'Core i5',
'15.6 Inches',
'HP 15s, 12th Gen Intel Core i5 8GB RAM/512GB SSD 15.6-inch(39.6 cm) FHD,Micro-Edge, Anti- Glare Display/Win 11/Intel Iris Xe Graphics/Dual Speakers/Alexa/Backlit KB/MSO/Fast Charge, 15s- fq5111TU'
),
(
'04',
'Mi Notebook Pro',
'59,990.',
'04.jpg',
'MI',
'16 GB',
'Core i5',
'35.56 Centimetres',
'Mi Notebook Pro Qhd+ IPS Anti Glare Display Intel Core I5-11300H 11Th Gen 14 Inches Thin & Light Laptop (16Gb/512Gb Ssd/Iris Xe Graphics/Windows 11 Home/Ms Office 21/Backlit Kb/Fp Sensor/1.4 Kg)'
),
(
'05',
'Swift 3',
'69,990',
'05.jpg',
'Acer',
'8 GB',
'Core i5',
'14 Inches',
'Acer Swift 3 SF314-512 Intel EVO Thin & Light Laptop (12th Gen Intel Core i5-1240P processor/8GB/512GB/Windows 11/MS Office/1.2kg/Backlit Keyboard/Fingerprint Reader/14" Full IPS Display)'
),
(
'06',
'17Z90P-G.AH85A2',
'94,999.',
'06.jpg',
'LG',
'16 GB',
'Intel Core i7-1165G7',
'17 Inches',
'LG Gram Intel Evo 11th Gen Core i7 17"(43cm)Ultra-Light Laptop (16 GB RAM, 512 GB SSD, New Windows 11 Home Preload, Iris Xe Graphics, USC -C x 2 (with Power), 1.35 kg, 17Z90P-G.AH85A2, Black)'
),
(
'07',
'15s- fq5112TU',
'62,989',
'07.jpg',
'HP',
'16 GB',
'Core i5',
'39.6 Centimetres',
'HP 15s, 12th Gen Intel Core i5 16GB RAM/512GB SSD 15.6-inch(39.6 cm) Micro-Edge Anti-Glare FHD Laptop/Win 11/Intel Iris Xe Graphics/Dual Speakers/Alexa/Backlit KB/MSO/Fast Charge, 15s- fq5112TU'
),
(
'08',
'VAIO SE14',
'49,990',
'08.jpg',
'VAIO',
'8GB',
'Core i5',
'14.1 Inches',
'VAIO SE14 NP14V3IN034P 14-inch/35.56 cm( Intel Core i5-1135G7 Intel Iris Xe Graphics 8GB/512GB SSD /Win 10 Home/Backlit KBD/FHD/Fingerprint Reader) MS Office 365, 1.39kg,with Carrying Bag, Dark Grey'
),
(
'09',
'IdeaPad 5',
'68,500',
'09.jpg',
'Lenovo',
'16 GB',
'Core i5',
'15.6 Inches',
'Lenovo IdeaPad Slim 5 Intel Core i5 11th Gen 15.6" (39.62cm) FHD IPS Thin & Light Laptop (16GB/512GB SSD/Windows 11/Office 2021/Backlit/FPR/3months Game Pass/Graphite Grey/1.66Kg), 82FG01H9IN'
),
(
'10',
'ThinkBook 15',
'80,950',
'10.jpg',
'Lenovo',
'16 GB',
'Core i7',
'15.6 Inches',
'Lenovo ThinkBook 15 Intel 11th Gen Core i7 15.6"(39.62 cm)FHD Thin and Light Laptop (16GB/512GB SSD/Windows 11 Home/MS Office H&S 2021/Iris® Xe Graphics/Backlit/Mineral Grey/1.7 Kg) 20VE00W4IH'
),
(
'11',
'Extensa',
'45,990',
'11.jpg',
'Acer',
'8 GB',
'Core i5',
'15.6 Inches',
'Acer Extensa 15 Lightweight Laptop 11th Gen Intel Core i5 Processor with 15.6" (39.6 cms) Full HDDisplay - (8 GB/512 GB SSD/Windows 11 Home/Intel Iris Xe Graphics /1.7Kg/Black) EX215-54'
)


set identity_insert Carousels ON;
select * from Carousels;

insert into Carousels(Id,Title,ImageURL,Description)
values
('0','Discount Laptops','car1.jpg','Get all the Laptops on high discounts!!!'),
('1','Brand New Laptops','car2.jpeg','All the brand new Laptops in one place. Enjoy the taste of brands'),
('2','Get Laptops on EMIs','car3.png','Now get latops on EMIs,monthly EMIs startig at just 799Rs/Month');



select * from Orders;

truncate table Orders;







