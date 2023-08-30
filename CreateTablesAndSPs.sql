SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LMS].[GoogleBooks](
	[BookId] [int] IDENTITY(10001,1) NOT NULL,
	[Title] [nvarchar](255) NULL,
	[Subtitle] [nvarchar](255) NULL,
	[AuthorOne] [int] NULL,
	[AuthorTwo] [int] NULL,
	[AuthorThree] [int] NULL,
	[AuthorFour] [int] NULL,
	[AuthorFive] [int] NULL,
	[Publisher] [int] NULL,
	[PublishedDate] [datetime] NULL,
	[Descripction] [nvarchar](max) NULL,
	[BookPageCount] [int] NULL,
	[SmallThumbnail] [nvarchar](1000) NULL,
	[Thumbnail] [nvarchar](1000) NULL,
	[Language] [nvarchar](25) NULL,
	[DownloadLink] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LMS].[GoogleBooksAuthors](
	[AuthorId] [int] IDENTITY(10001,1) NOT NULL,
	[Name] [nvarchar](255) NULL
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LMS].[GoogleBooksPublishers](
	[PublisherId] [int] IDENTITY(10001,1) NOT NULL,
	[Name] [nvarchar](255) NULL
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER   PROCEDURE [LMS].[spGoogleBook_Add]
    @Title nvarchar(255) = NULL,
	@Subtitle nvarchar(255) = NULL,
	@AuthorOne int = NULL,
	@AuthorTwo int = NULL,
	@AuthorThree int = NULL,
	@AuthorFour int = NULL,
	@AuthorFive int = NULL,
	@Publisher int = NULL,
	@PublishedDate datetime = NULL,
	@Descripction nvarchar(max) = NULL,
	@BookPageCount int = NULL,
	@SmallThumbnail nvarchar(1000) = NULL,
	@Thumbnail nvarchar(1000) = NULL,
	@Language nvarchar(25) = NULL,
	@DownloadLink nvarchar(max) = NULL
AS
BEGIN
    INSERT INTO LMS.GoogleBooks(
        Title,
        Subtitle,
        AuthorOne,
        AuthorTwo,
        AuthorThree,
        AuthorFour,
        AuthorFive,
        Publisher,
        PublishedDate,
        Descripction,
        BookPageCount,
        SmallThumbnail,
        Thumbnail,
        Language,
        DownloadLink 
    ) VALUES (
        @Title,
        @Subtitle,
        @AuthorOne,
        @AuthorTwo,
        @AuthorThree,
        @AuthorFour,
        @AuthorFive,
        @Publisher,
        @PublishedDate,
        @Descripction,
        @BookPageCount,
        @SmallThumbnail,
        @Thumbnail,
        @Language,
        @DownloadLink

    )
END
GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [LMS].[spGoogleBooksAuthors_Add]
    @Name nvarchar(255) = NULL
AS
BEGIN
    INSERT INTO LMS.GoogleBooksAuthors(
        [Name]
    ) VALUES (
        @Name

    )
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [LMS].[spGoogleBooksPublishers_Add]
    @Name nvarchar(255) = NULL
AS
BEGIN
    INSERT INTO LMS.GoogleBooksPublishers(
        [Name]
    ) VALUES (
        @Name

    )
END
GO
