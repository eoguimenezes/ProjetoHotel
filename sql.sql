

USE [master]
GO
CREATE DATABASE hotel


USE hotel
GO
CREATE TABLE dbo.Hotel(
	HotelId int IDENTITY(1,1) NOT NULL,
	HotelNome nvarchar(100) NOT NULL,
	HotelCnpj int NOT NULL,
	HotelEndereco nvarchar(100) NOT NULL,
	HotelDescricao nvarchar(100) NOT NULL,
 CONSTRAINT [PK_Hotel] PRIMARY KEY CLUSTERED 
(
	[HotelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, 
  ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


USE hotel
GO
ALter TABLE dbo.Quarto(
	QuartoId int IDENTITY(1,1) NOT NULL,
	HotelId int NOT NULL,
	QuartoNome nvarchar(100) NOT NULL,
	QuartoOcupante int NOT NULL,
	QuartoAdulto int NOT NULL,
	QuartoCrianca int NOT NULL,
	Preco nvarchar(250) NULL,
	Imagem nvarchar(250) NULL
CONSTRAINT [PK_Quarto] PRIMARY KEY CLUSTERED 
(
	[QuartoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, 
ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] 
