IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [AspNetRoles] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AspNetUsers] (
    [Id] nvarchar(450) NOT NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [Email] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AspNetRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserLogins] (
    [LoginProvider] nvarchar(450) NOT NULL,
    [ProviderKey] nvarchar(450) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(450) NOT NULL,
    [Name] nvarchar(450) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
GO

CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
GO

CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
GO

CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'00000000000000_CreateIdentitySchema', N'8.0.6');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [AspNetUsers] ADD [DisplayName] nvarchar(max) NOT NULL DEFAULT N'';
GO

ALTER TABLE [AspNetUsers] ADD [UAPIUserId] nvarchar(max) NOT NULL DEFAULT N'';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240626203242_initial', N'8.0.6');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'UAPIUserId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [AspNetUsers] ALTER COLUMN [UAPIUserId] nvarchar(max) NULL;
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'DisplayName');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [AspNetUsers] ALTER COLUMN [DisplayName] nvarchar(max) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240626205651_NullablColumns', N'8.0.6');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'09c54e22-6016-4824-bd0c-2f96610aa75e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUserRoles]
WHERE [RoleId] = N'f97f5b62-007a-4e85-b2f8-13365d6e45c8' AND [UserId] = N'e207c07e-32d2-45b8-a0a2-ef2ca333f2c2';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetRoles]
WHERE [Id] = N'f97f5b62-007a-4e85-b2f8-13365d6e45c8';
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] ON;
INSERT INTO [AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName])
VALUES (N'39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a', NULL, N'Manager', N'MANAGER'),
(N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', NULL, N'Underwriter', N'UNDERWRITER');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'ConcurrencyStamp', N'Name', N'NormalizedName') AND [object_id] = OBJECT_ID(N'[AspNetRoles]'))
    SET IDENTITY_INSERT [AspNetRoles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'DisplayName', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UAPIUserId', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
    SET IDENTITY_INSERT [AspNetUsers] ON;
INSERT INTO [AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [DisplayName], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UAPIUserId], [UserName])
VALUES (N'1f8c93bb-92a0-4e61-a4e6-7b28d61f0d71', 0, N'38dc1495-a935-4851-b25f-9fd9ccd7a991', N'Angela Hardy', N'astovallhardy@i3verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'ASTOVALLHARDY@I3VERTICALS.COM', N'astovallhardy@i3verticals.com', N'AQAAAAIAAYagAAAAEL3AFSYsXtl3nZIJgGFb/4flIfJoNGpf1OWamYVl4esOse1SwgfMQC/THG+YJPqltw==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'62420940457e21a2ca768c79', N'astovallhardy@i3verticals.com'),
(N'2a9f4b60-3c8e-41c7-9a7b-52341bfa1b62', 0, N'3cf6a825-5b75-444f-97e0-8955f0d19df9', N'Benji Lamfers', N'benji.lamfers@i3verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'BENJI.LAMFERS@I3VERTICALS.com', N'benji.lamfers@i3verticals.com', N'AQAAAAIAAYagAAAAENHrtA/RgtCxmpxWXh/W6b1q317o8DpVvwA1B8ypN4G1XT6l+Ci36yLuUWR3T6tFfQ==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'5d4a2dfdcd49961c2cd5729f', N'benji.lamfers@i3verticals.com'),
(N'4e9b671d-865e-4c6a-b283-1c5d214c5939', 0, N'e74d2923-24e0-4bcb-9452-b5183dde164f', N'Daniel Fonseca', N'dfonseca@i3verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'DFONSECA@I3VERTICALS.COM', N'dfonseca@i3verticals.com', N'AQAAAAIAAYagAAAAEAg/v58IJrMFMvG5f/shhlxlNAKwrgmLgt/CdDWEV1OLe4L6W11eEuyIrSSgIVeoPg==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'58574246aa45842a200103db', N'dfonseca@i3verticals.com'),
(N'58a3f7d6-2a7e-45f6-a5f4-6a8b93c8d9c7', 0, N'066c39ca-45e7-426e-bff2-bed250ec4b5f', N'Alyssa Smith', N'asmith@i3verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'ASMITH@I3VERTICALS.COM', N'asmith@i3verticals.com', N'AQAAAAIAAYagAAAAEO3jw10OWznYRRpJbw7O1c2yTT1ikL4pzDRQmmbafdAeDeW72BBpok9y1DQxNNaI8w==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'61d470129b42b0f4965aad74', N'asmith@i3verticals.com'),
(N'73e52b93-3ec5-47a6-85a1-4eb6dc3e6e34', 0, N'339085ea-1517-406e-87a9-c6a12c924cfd', N'Justin Esber', N'justin.esber@payschools.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'JUSTIN.ESBER@PAYSCHOOLS.COM', N'justin.esber@payschools.com', N'AQAAAAIAAYagAAAAEIfSpUMmAHHyB+AHIKDx8qTV6ytWFkFHm1ChH8LQvTTXQRgkHOxFDwcpiUuaPsMpgg==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'585742f4aa45842a200193b2', N'justin.esber@payschools.com'),
(N'87ad364d-53c9-4698-b0a1-c01f91c6f4b0', 0, N'a2a3c6d7-28ca-47e8-b1d5-9fe0fdad0a8d', N'Lisa Reedy', N'lreedy@gmail.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'LREEDY@GMAIL.COM', N'lreedy@gmail.com', N'AQAAAAIAAYagAAAAEI5Jmsmftu3uvM31gmo5x+tMwZ5IjSNrnbmhFZmc0pShKaDAgJfMI9Oia2WI868toA==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'58574197aa45842a20007798', N'lreedy@gmail.com'),
(N'9b6e1d64-0b93-4ba1-81a9-32d36e2d6e49', 0, N'bd6ac6bc-61bd-49fd-b755-33c58774ee93', N'Tee Locke', N'tee.locke@neo.rr.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'TEE.LOCKE@NEO.RR.COM', N'tee.locke@neo.rr.com', N'AQAAAAIAAYagAAAAEBFT4C9VjwRCYIBHT6n0dc7VLvY48ulxLbJLqySmaKFP6SBCUauQfhxFXv8dzyoC6A==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'597b2d274b9cfc2e6c819088', N'tee.locke@neo.rr.com'),
(N'b0145c62-e346-4ea8-ace2-6d82f84c9e2c', 0, N'eddcac0f-2b24-4d98-9905-cc05500e9b0d', N'Christian Zarnke', N'czarnke@i3verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'CZARNKE@I3VERTICALS.COM', N'czarnke@i3verticals.com', N'AQAAAAIAAYagAAAAEN3i823WfoRE5mVLNjDxbJWyS/Ux+/NRt1mSQI2HrZZ3w5DCJK3WEmTSzORAQ07dSA==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'620bd70caf64c4562d58b84c', N'czarnke@i3verticals.com'),
(N'c83b57ef-024b-48d9-939d-5b8d8e0b7d23', 0, N'a90a65fc-83f6-4642-80bf-a8b28d743a62', N'Sys Admin', N'Sysadmin@i3Verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'SYSADMIN@I3VERTICALS.COM', N'Sysadmin@i3Verticals.com', N'AQAAAAIAAYagAAAAEI0WEYYYoeravx81WPikJURjRysM+5TADBH/6LgvaG/T02gVgWjS6O1w2hwOaCwUgA==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'63a249ee424c29d968059d8d', N'Sysadmin@i3Verticals.com'),
(N'df9f1ac6-616b-44b0-a1de-85a56c7d4a58', 0, N'65376c28-ac6e-48b3-8a32-d45168c0b96d', N'Vadeene Sisk', N'vsisk@i3verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'VSISK@I3VERTICALS.COM', N'vsisk@i3verticals.com', N'AQAAAAIAAYagAAAAECuePUD/XgqY67/v5JtckDUsRSqqytjeFBMvYMoyvG6vEItyXS2c/Q3QqzFju8yfPw==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'636c2737b81806331e91f99e', N'vsisk@i3verticals.com'),
(N'e207c07e-32d2-45b8-a0a2-ef2ca333f2c2', 0, N'bb3fff00-4ec9-46d1-a1f6-c7aca01c4a2d', N'Sonya Ridinger', N'sridinger@i3verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'SRIDINGER@I3VERTICALS.COM', N'sridinger@i3verticals.com', N'AQAAAAIAAYagAAAAEPqFmsiim3X3IzM0xQ+vbY+kwssVjCXTm/wfGb7GK4ulnOoWK/WNfQPfQLSxJ+es4g==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'61d470129b42b0f4965aad74', N'sridinger@i3verticals.com'),
(N'f6e134e9-402b-4782-bca6-7e1f9a5d6c1f', 0, N'6d3d6f74-e217-488a-92eb-9e54c0bc9b11', N'Colleen Rumsey', N'crumsey@i3verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'CRUMSEY@I3VERTICALS.COM', N'crumsey@i3verticals.com', N'AQAAAAIAAYagAAAAEARqHlztABVNG0kGxUb/rHImmq1k3V1M/HlSvQ+ZSRm/Ncv9oguX5a+q5/BNQ06ARw==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'63b6ec7733247bfd8698d629', N'crumsey@i3verticals.com');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'DisplayName', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UAPIUserId', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
    SET IDENTITY_INSERT [AspNetUsers] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240628141019_SeedUserRoleDataToDataBase', N'8.0.6');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[AspNetUserRoles]'))
    SET IDENTITY_INSERT [AspNetUserRoles] ON;
INSERT INTO [AspNetUserRoles] ([RoleId], [UserId])
VALUES (N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'1f8c93bb-92a0-4e61-a4e6-7b28d61f0d71'),
(N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'2a9f4b60-3c8e-41c7-9a7b-52341bfa1b62'),
(N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'4e9b671d-865e-4c6a-b283-1c5d214c5939'),
(N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'58a3f7d6-2a7e-45f6-a5f4-6a8b93c8d9c7'),
(N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'73e52b93-3ec5-47a6-85a1-4eb6dc3e6e34'),
(N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'87ad364d-53c9-4698-b0a1-c01f91c6f4b0'),
(N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'9b6e1d64-0b93-4ba1-81a9-32d36e2d6e49'),
(N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'b0145c62-e346-4ea8-ace2-6d82f84c9e2c'),
(N'39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a', N'c83b57ef-024b-48d9-939d-5b8d8e0b7d23'),
(N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'df9f1ac6-616b-44b0-a1de-85a56c7d4a58'),
(N'39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a', N'e207c07e-32d2-45b8-a0a2-ef2ca333f2c2'),
(N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'f6e134e9-402b-4782-bca6-7e1f9a5d6c1f');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[AspNetUserRoles]'))
    SET IDENTITY_INSERT [AspNetUserRoles] OFF;
GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'75ec5316-72b5-42b1-8ed4-40cfa1f62d13', [PasswordHash] = N'AQAAAAIAAYagAAAAEHXOp00+DT+jAp9pf8ld85H79I0579UqVJzxWauLChjglHGPfRxrQwhZl+6yr1jlcg=='
WHERE [Id] = N'1f8c93bb-92a0-4e61-a4e6-7b28d61f0d71';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'5936ee9a-d40a-43dd-9ccb-722683281a63', [PasswordHash] = N'AQAAAAIAAYagAAAAEMERHSZOACss5mMylKDmswRlnkimi7Hs9/1VAgp4jhRgHf/zp7Xx/OlUUTNW8dsx+w=='
WHERE [Id] = N'2a9f4b60-3c8e-41c7-9a7b-52341bfa1b62';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'8da2a52f-ce4c-4280-8ad0-da56f32237b6', [PasswordHash] = N'AQAAAAIAAYagAAAAELpGIwAMDkt/SoSYgBaPpol37pN8l2RcOBHZ3YyRVZC7DEB5FKHnBnO8tOZRIsLB9g=='
WHERE [Id] = N'4e9b671d-865e-4c6a-b283-1c5d214c5939';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'32af9380-fd08-4a51-90a6-0edc6c91f53c', [PasswordHash] = N'AQAAAAIAAYagAAAAEOacXvKdv/3YsXf0xkSganbdrM0E7RFuVGgHDwRlrMbzGYeAqmmcc03lQXjwMtlCpQ=='
WHERE [Id] = N'58a3f7d6-2a7e-45f6-a5f4-6a8b93c8d9c7';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'd5cb3d14-d748-4e31-b3cc-d95a0f60d75e', [PasswordHash] = N'AQAAAAIAAYagAAAAEATny0J9En9YNWqhdd6luMZrIrvJQOjWgR88v+ie7FkV9sahhyw86JpSI1rNYbw0Lw=='
WHERE [Id] = N'73e52b93-3ec5-47a6-85a1-4eb6dc3e6e34';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'4f86388b-60af-4700-97fd-03066e5dc50b', [PasswordHash] = N'AQAAAAIAAYagAAAAEKmB6eJZAFHPi6o94mVXha3guLfR5Jf8fn8G0CmMDAeJ+7W0M2LgcqW/QJbSbsDZMw=='
WHERE [Id] = N'87ad364d-53c9-4698-b0a1-c01f91c6f4b0';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'0ef4ed2f-4b0a-4e27-817c-9079088c9e34', [PasswordHash] = N'AQAAAAIAAYagAAAAEN7cP3Hd1n0X6LvazKcDDw8KyFrWDz41BvMPiiulAMb/2JeVd8MID8gSdDuUZpWutQ=='
WHERE [Id] = N'9b6e1d64-0b93-4ba1-81a9-32d36e2d6e49';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'69933d0a-9a52-41ce-9ab3-76245d8eabaa', [PasswordHash] = N'AQAAAAIAAYagAAAAEJTUQERdOB7O5aHM6wNEB14+JwJl6xnWgGaV9XSCSMFQclYy7OMgNg1wlcq4SR5pjw=='
WHERE [Id] = N'b0145c62-e346-4ea8-ace2-6d82f84c9e2c';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'ff6774a9-34c0-4ce9-92e6-5f2889a0abde', [PasswordHash] = N'AQAAAAIAAYagAAAAENGXfT80YGPx3nC4Hlpi+BmwHr3htgFefQBlpfSg26egc354Mrp1dCOcrZ4Y5Z/XCw=='
WHERE [Id] = N'c83b57ef-024b-48d9-939d-5b8d8e0b7d23';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'cfe486ad-59a3-4563-b80c-ca4e9027642b', [PasswordHash] = N'AQAAAAIAAYagAAAAEO8FSJw+AlEfvaPE1zycaaEfT9cWuVVzXRP7gg6uFp8g8OfdfojkquJeHbJUwFCVhg=='
WHERE [Id] = N'df9f1ac6-616b-44b0-a1de-85a56c7d4a58';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'2fd75cc1-40b8-4773-ae49-fe84c5b658f9', [PasswordHash] = N'AQAAAAIAAYagAAAAEH7M6tIrj1U/WlMU7pk/DqKbSQYgc4ZBZTSf+BCWr6jvnO0msDnouivasL/wprG1Cw=='
WHERE [Id] = N'e207c07e-32d2-45b8-a0a2-ef2ca333f2c2';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'19e69c5a-8cd4-466e-8fd0-3b696c5f07e8', [PasswordHash] = N'AQAAAAIAAYagAAAAEDCsZdDD9oVchfyuQmTaJXW9SRwqb39rJgLwdqf0cOpw3u7XNTWpe3BCiMNVrvGbXw=='
WHERE [Id] = N'f6e134e9-402b-4782-bca6-7e1f9a5d6c1f';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240628141537_MappingSysAdminUserRole', N'8.0.6');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [AspNetUserRoles]
WHERE [RoleId] = N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f' AND [UserId] = N'1f8c93bb-92a0-4e61-a4e6-7b28d61f0d71';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUserRoles]
WHERE [RoleId] = N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f' AND [UserId] = N'2a9f4b60-3c8e-41c7-9a7b-52341bfa1b62';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUserRoles]
WHERE [RoleId] = N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f' AND [UserId] = N'4e9b671d-865e-4c6a-b283-1c5d214c5939';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUserRoles]
WHERE [RoleId] = N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f' AND [UserId] = N'58a3f7d6-2a7e-45f6-a5f4-6a8b93c8d9c7';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUserRoles]
WHERE [RoleId] = N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f' AND [UserId] = N'73e52b93-3ec5-47a6-85a1-4eb6dc3e6e34';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUserRoles]
WHERE [RoleId] = N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f' AND [UserId] = N'87ad364d-53c9-4698-b0a1-c01f91c6f4b0';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUserRoles]
WHERE [RoleId] = N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f' AND [UserId] = N'9b6e1d64-0b93-4ba1-81a9-32d36e2d6e49';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUserRoles]
WHERE [RoleId] = N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f' AND [UserId] = N'b0145c62-e346-4ea8-ace2-6d82f84c9e2c';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUserRoles]
WHERE [RoleId] = N'39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a' AND [UserId] = N'c83b57ef-024b-48d9-939d-5b8d8e0b7d23';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUserRoles]
WHERE [RoleId] = N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f' AND [UserId] = N'df9f1ac6-616b-44b0-a1de-85a56c7d4a58';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUserRoles]
WHERE [RoleId] = N'39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a' AND [UserId] = N'e207c07e-32d2-45b8-a0a2-ef2ca333f2c2';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUserRoles]
WHERE [RoleId] = N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f' AND [UserId] = N'f6e134e9-402b-4782-bca6-7e1f9a5d6c1f';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'1f8c93bb-92a0-4e61-a4e6-7b28d61f0d71';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'2a9f4b60-3c8e-41c7-9a7b-52341bfa1b62';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'4e9b671d-865e-4c6a-b283-1c5d214c5939';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'58a3f7d6-2a7e-45f6-a5f4-6a8b93c8d9c7';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'73e52b93-3ec5-47a6-85a1-4eb6dc3e6e34';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'87ad364d-53c9-4698-b0a1-c01f91c6f4b0';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'9b6e1d64-0b93-4ba1-81a9-32d36e2d6e49';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'b0145c62-e346-4ea8-ace2-6d82f84c9e2c';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'c83b57ef-024b-48d9-939d-5b8d8e0b7d23';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'df9f1ac6-616b-44b0-a1de-85a56c7d4a58';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'e207c07e-32d2-45b8-a0a2-ef2ca333f2c2';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'f6e134e9-402b-4782-bca6-7e1f9a5d6c1f';
SELECT @@ROWCOUNT;

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'UAPIUserId');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [AspNetUsers] DROP COLUMN [UAPIUserId];
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'DisplayName', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
    SET IDENTITY_INSERT [AspNetUsers] ON;
INSERT INTO [AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [DisplayName], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
VALUES (N'58574197aa45842a20007798', 0, N'f3621f3b-4828-4064-b3ae-647229de90c4', N'Lisa Reedy', N'lreedy@gmail.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'LREEDY@GMAIL.COM', N'lreedy@gmail.com', N'AQAAAAIAAYagAAAAEL9FmvySfip/77gSByaGZpGtkdGh3qYUzIx6vzo4dqjph/ET0Y1jJJJrvUQPMTfbCg==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'lreedy@gmail.com'),
(N'58574246aa45842a200103db', 0, N'8126d374-9942-4ac5-a628-2dbe4edb35ff', N'Daniel Fonseca', N'dfonseca@i3verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'DFONSECA@I3VERTICALS.COM', N'dfonseca@i3verticals.com', N'AQAAAAIAAYagAAAAEMBDoSgYgDV2ibykPWa0hI4m+LTVB42m//5K/8GWDDJtt8oCIY8adCKVHlkHGY1uew==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'dfonseca@i3verticals.com'),
(N'585742f4aa45842a200193b2', 0, N'c9ac3274-68ab-4f09-9997-5f93fa3b0bec', N'Justin Esber', N'justin.esber@payschools.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'JUSTIN.ESBER@PAYSCHOOLS.COM', N'justin.esber@payschools.com', N'AQAAAAIAAYagAAAAEIxBLgK9rmInQLH11C4xrygmOJVkjdXrz1kF6zsJt40BaXs3o2q9AOYjcC1XHlEwuQ==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'justin.esber@payschools.com'),
(N'59691d964b9cfc16a848e768', 0, N'f6907389-dd3d-489f-9a1c-1dd9fda3f6ca', N'David Sowiak', N'dsowiak@i3verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'DSOWIAK@I3VERTICALS.COM', N'DSOWIAK@I3VERTICALS.COM', N'AQAAAAIAAYagAAAAEFuMXfe17S2VKFydSYc1LR/IEs4bOvMLYXDPf5LNBDPzZucvYuSlO+OgTeCTUVpYUA==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'dsowiak@i3verticals.com'),
(N'597b2d274b9cfc2e6c819088', 0, N'a06ec454-01cf-4a91-9565-96c864be18ab', N'Tee Locke', N'tee.locke@neo.rr.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'TEE.LOCKE@NEO.RR.COM', N'tee.locke@neo.rr.com', N'AQAAAAIAAYagAAAAEBU1ftWq45XENEPU+hxZULphze1t35F8bY4fZJhs46Op4B1YpTfd75F4QIhfwzIDtw==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'tee.locke@neo.rr.com'),
(N'5d4a2dfdcd49961c2cd5729f', 0, N'bf03e21a-b15c-4fe9-a68a-30d85b875d20', N'Benji Lamfers', N'benji.lamfers@i3verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'BENJI.LAMFERS@I3VERTICALS.com', N'benji.lamfers@i3verticals.com', N'AQAAAAIAAYagAAAAEM8+wXDt/kHpY25hAPOBXSJtQQMeiUY1vSkV49rxCj5qAQnECl9QJcEcFdRC+Grarw==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'benji.lamfers@i3verticals.com'),
(N'61d470129b42b0f4965aad74', 0, N'880ec31a-137b-438c-8ab0-479452fcfb96', N'Alyssa Smith', N'asmith@i3verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'ASMITH@I3VERTICALS.COM', N'asmith@i3verticals.com', N'AQAAAAIAAYagAAAAEDoag9DwY5rAfgBsRPShcZkYyzCipXLq8Ytniibi8SYLomRzqgpji4xMSaWWeweRZg==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'asmith@i3verticals.com'),
(N'620bd70caf64c4562d58b84c', 0, N'f47aedc4-48a8-4a5a-838f-616104c5f9fe', N'Christian Zarnke', N'czarnke@i3verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'CZARNKE@I3VERTICALS.COM', N'czarnke@i3verticals.com', N'AQAAAAIAAYagAAAAEDNoIE4zpZ2dhLLmGZaIfS6JK86hNbcIgED1zctg3BmBONEcyIwgguLaz3bUAR0LcA==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'czarnke@i3verticals.com'),
(N'62420940457e21a2ca768c79', 0, N'05a7a116-e654-4f6f-ae96-e8300a01984e', N'Angela Hardy', N'astovallhardy@i3verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'ASTOVALLHARDY@I3VERTICALS.COM', N'astovallhardy@i3verticals.com', N'AQAAAAIAAYagAAAAEIqup9KnjIVP3/a2V85Kbzqq0xGyFNxsaH3kC6dDyiaEDHYzVF4PR9LyqhZj+Y5GDQ==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'astovallhardy@i3verticals.com'),
(N'636c2737b81806331e91f99e', 0, N'341b66dc-0e65-4088-a6ec-1ad15cb24563', N'Vadeene Sisk', N'vsisk@i3verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'VSISK@I3VERTICALS.COM', N'vsisk@i3verticals.com', N'AQAAAAIAAYagAAAAEDpQI89YMkUYKw3oiYChWUyuT+W2mUntVMdDgAmU3OOE12CEoruXqjZT5wu113r0uw==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'vsisk@i3verticals.com'),
(N'63740329467a12cd1cf74e41', 0, N'd762746f-c28f-4d7b-b392-b21e1ac8c466', N'Sonya Ridinger', N'sridinger@i3verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'SRIDINGER@I3VERTICALS.COM', N'sridinger@i3verticals.com', N'AQAAAAIAAYagAAAAEJ8aVCjTb2YQ8WrO7Z9RIyRmEevv9OtdvQvlnTfa7l3qNCNUnKXFtREQ68yPNnsctg==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'sridinger@i3verticals.com'),
(N'63a249ee424c29d968059d8d', 0, N'4e158007-8d6c-401c-ac68-8119ace3bacc', N'Sys Admin', N'Sysadmin@i3Verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'SYSADMIN@I3VERTICALS.COM', N'Sysadmin@i3Verticals.com', N'AQAAAAIAAYagAAAAEOZmD29p6PFnpzGwB3vIlS9Q6YRXg8tf13RBJeB77sWfqu0FwGgtNbKhDz/N8nnx7w==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'Sysadmin@i3Verticals.com'),
(N'63b6ec7733247bfd8698d629', 0, N'578b5c2c-aa4b-466a-82e9-89d12aa361a9', N'Colleen Rumsey', N'crumsey@i3verticals.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'CRUMSEY@I3VERTICALS.COM', N'crumsey@i3verticals.com', N'AQAAAAIAAYagAAAAEBsmaeCgaPyxgmzz+YmQ1ubJ3RyJHURix8dXM2iJaqV64vf84Q1f2AeVBCCqkdRrJA==', NULL, CAST(0 AS bit), N'', CAST(0 AS bit), N'crumsey@i3verticals.com');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'ConcurrencyStamp', N'DisplayName', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
    SET IDENTITY_INSERT [AspNetUsers] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[AspNetUserRoles]'))
    SET IDENTITY_INSERT [AspNetUserRoles] ON;
INSERT INTO [AspNetUserRoles] ([RoleId], [UserId])
VALUES (N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'58574197aa45842a20007798'),
(N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'58574246aa45842a200103db'),
(N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'585742f4aa45842a200193b2'),
(N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'59691d964b9cfc16a848e768'),
(N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'597b2d274b9cfc2e6c819088'),
(N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'5d4a2dfdcd49961c2cd5729f'),
(N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'61d470129b42b0f4965aad74'),
(N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'620bd70caf64c4562d58b84c'),
(N'7cd35e1b-5f72-470b-9e1a-8f6d4b3e5a3f', N'62420940457e21a2ca768c79'),
(N'39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a', N'636c2737b81806331e91f99e'),
(N'39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a', N'63740329467a12cd1cf74e41'),
(N'39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a', N'63a249ee424c29d968059d8d'),
(N'39f6d8e5-9a2b-4c3f-a7e6-8b1d2c5e3f7a', N'63b6ec7733247bfd8698d629');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[AspNetUserRoles]'))
    SET IDENTITY_INSERT [AspNetUserRoles] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240628191021_RolesUpdate', N'8.0.6');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'a615025a-f54a-42e0-bdd8-60c21790cc64', [PasswordHash] = N'AQAAAAIAAYagAAAAEJjdcImdvuVJ/t0MsitoyQebmfVWSNDHegQabJYclEJkAaBXK69njuNRqO5O05ClIw=='
WHERE [Id] = N'58574197aa45842a20007798';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'46e235c8-f3d5-4a7c-8405-3abb3fd451e5', [PasswordHash] = N'AQAAAAIAAYagAAAAEKaP2ajb8CFiFEADPKzZkpGj8LzplTA3eWwd9+j6ALV1ZhLKR1V+DhJfme0nXFZPww=='
WHERE [Id] = N'58574246aa45842a200103db';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'bc8ebe47-0287-4cdb-8676-b28ffedb9ddc', [PasswordHash] = N'AQAAAAIAAYagAAAAEOI82vuTjNRSZUBtZxSpk4a39EnSeTHzO7Idaj7lmYUTuCwAQyQcXMyNbwxr2od27w=='
WHERE [Id] = N'585742f4aa45842a200193b2';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'dfcc4e04-2ef2-4b3d-b8a2-8e07d92d36c4', [PasswordHash] = N'AQAAAAIAAYagAAAAEHGfmZ4Hc3xJ36lo/ChAJxVrUWvgSzAABYT5aiuvth9FBsStay2DJMvG/jdBE7XM/A=='
WHERE [Id] = N'59691d964b9cfc16a848e768';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'b519994f-b64c-4819-892f-1633b7b6e2ff', [PasswordHash] = N'AQAAAAIAAYagAAAAELlbj8nuzPSjBwM3nOJk+zmSuN112Z1jogvqFdw7ziQNEKpEemXPsyy6M1BHW4Pu8w=='
WHERE [Id] = N'597b2d274b9cfc2e6c819088';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'd106f094-cf37-4743-9feb-6c45c485f585', [PasswordHash] = N'AQAAAAIAAYagAAAAEKeDXIqquZsLPHBwG9+atF7w92h9rosLdCNBlBeuxllTqP8CGm/twdM43+NI6vl30Q=='
WHERE [Id] = N'5d4a2dfdcd49961c2cd5729f';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'85d6d280-7e0f-46c5-a169-876a805be704', [PasswordHash] = N'AQAAAAIAAYagAAAAEKPA7KxjP+dfwy7bybLpq0ttJEkhF/Ik7KlgnDGXntX1mODUXuEsP9ApNktcMQuutA=='
WHERE [Id] = N'61d470129b42b0f4965aad74';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'8b0fa48d-bf45-4d6a-a8f9-754087004e77', [PasswordHash] = N'AQAAAAIAAYagAAAAEGfO6lH79Rll3vejGifqp8dfvxpJUwJ/O2gb9nRSFS05xKr+/0JbVJnWTrtOPDUz5w=='
WHERE [Id] = N'620bd70caf64c4562d58b84c';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'c177df7b-a431-42d8-b0b9-fd5f04de80d5', [PasswordHash] = N'AQAAAAIAAYagAAAAELu4z7K8yuOl3qUuPZeZ+58SaSsgSa/f7QfkvuaDfOT3ykLFUNCDDO8olSqm/EseVQ=='
WHERE [Id] = N'62420940457e21a2ca768c79';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'4282cd48-64e5-4ce3-aed7-513f8d3d232d', [PasswordHash] = N'AQAAAAIAAYagAAAAECz/zol+0ruH7L5KRgNzzuhzfLUYGTy87sXR3jrQEfPyy27odsh0jg5dQpMXGKH5Hg=='
WHERE [Id] = N'636c2737b81806331e91f99e';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'8769605d-119f-428b-8ea7-19a923bb410e', [PasswordHash] = N'AQAAAAIAAYagAAAAEDR89mg9PWuT91oKzjSIntSnSry0ezGkQVs6TZaPSqzGJqFBaNjn/SCdwtI1OJuvvQ=='
WHERE [Id] = N'63740329467a12cd1cf74e41';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'7b6d8a8d-f577-48ee-952a-91725dd6caa4', [PasswordHash] = N'AQAAAAIAAYagAAAAEA4ePxsH+MaW0tinkFf1IWWsCj4oWCYKZYjss+RBTduxO0vduZOGHa3DP7c9GZYpOg=='
WHERE [Id] = N'63a249ee424c29d968059d8d';
SELECT @@ROWCOUNT;

GO

UPDATE [AspNetUsers] SET [ConcurrencyStamp] = N'384768ec-0b91-43ed-9218-5bf6b25a6d1a', [PasswordHash] = N'AQAAAAIAAYagAAAAENatiTdbPutiixYOY84/XFZffUScODGHjKl02v6S4+c65d2qMs+alWvWeOLF0a3DAA=='
WHERE [Id] = N'63b6ec7733247bfd8698d629';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250924200634_Underwriting-UI', N'8.0.6');
GO

COMMIT;
GO

