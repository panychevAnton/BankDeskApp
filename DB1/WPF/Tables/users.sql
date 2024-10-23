CREATE TABLE [WPF].[users] (
    [id]              INT          NOT NULL,
    [username]        VARCHAR (20) NULL,
    [salt]            VARCHAR (20) NULL,
    [hashed_password] VARCHAR (20) NULL,
    CONSTRAINT [users_pk] PRIMARY KEY CLUSTERED ([id] ASC)
);

