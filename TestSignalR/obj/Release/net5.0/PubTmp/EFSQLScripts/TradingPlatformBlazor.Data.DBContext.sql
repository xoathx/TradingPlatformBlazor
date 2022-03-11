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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211023011730_Messages')
BEGIN
    CREATE TABLE [Messages] (
        [id] int NOT NULL IDENTITY,
        [body_message] nvarchar(max) NULL,
        [date_message] datetime2 NOT NULL,
        [from_user_id] int NOT NULL,
        [to_user_id] int NOT NULL,
        CONSTRAINT [PK_Messages] PRIMARY KEY ([id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211023011730_Messages')
BEGIN
    CREATE INDEX [IX_Messages_from_user_id] ON [Messages] ([from_user_id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211023011730_Messages')
BEGIN
    CREATE INDEX [IX_Messages_to_user_id] ON [Messages] ([to_user_id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211023011730_Messages')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211023011730_Messages', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211025002100_AddModelOffer')
BEGIN
    CREATE TABLE [Offers] (
        [id] int NOT NULL IDENTITY,
        [lot_id] int NOT NULL,
        [vendor_id] int NOT NULL,
        [customer_id] int NOT NULL,
        [is_openned] bit NOT NULL,
        [date_openning] datetime2 NOT NULL,
        [date_closing] datetime2 NOT NULL,
        CONSTRAINT [PK_Offers] PRIMARY KEY ([id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211025002100_AddModelOffer')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211025002100_AddModelOffer', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211025030133_UpdateOfferModel')
BEGIN
    ALTER TABLE [Offers] ADD [identifier_name] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211025030133_UpdateOfferModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211025030133_UpdateOfferModel', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211025053458_AddBalanceToUser')
BEGIN
    ALTER TABLE [Users] ADD [Balance] decimal(18,4) NOT NULL DEFAULT 0.0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211025053458_AddBalanceToUser')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211025053458_AddBalanceToUser', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211025054900_BalanceFromDecToDouble')
BEGIN
    EXEC sp_rename N'[Users].[Balance]', N'balance', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211025054900_BalanceFromDecToDouble')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Users]') AND [c].[name] = N'balance');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Users] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Users] ALTER COLUMN [balance] float NOT NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211025054900_BalanceFromDecToDouble')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211025054900_BalanceFromDecToDouble', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211025064153_UpdateOffer')
BEGIN
    ALTER TABLE [Offers] ADD [category_id] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211025064153_UpdateOffer')
BEGIN
    ALTER TABLE [Offers] ADD [state_offer] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211025064153_UpdateOffer')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211025064153_UpdateOffer', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211025211326_AddedLotInfoToOffer')
BEGIN
    ALTER TABLE [Offers] ADD [is_manyback] bit NOT NULL DEFAULT CAST(0 AS bit);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211025211326_AddedLotInfoToOffer')
BEGIN
    ALTER TABLE [Offers] ADD [lots_desc] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211025211326_AddedLotInfoToOffer')
BEGIN
    ALTER TABLE [Offers] ADD [lots_name] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211025211326_AddedLotInfoToOffer')
BEGIN
    ALTER TABLE [Offers] ADD [lots_price] float NOT NULL DEFAULT 0.0E0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211025211326_AddedLotInfoToOffer')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211025211326_AddedLotInfoToOffer', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211026195258_AddComments')
BEGIN
    CREATE TABLE [Comments] (
        [id] int NOT NULL IDENTITY,
        [from_user_id] int NOT NULL,
        [to_user_id] int NOT NULL,
        [offer_id] int NOT NULL,
        [body_comment] nvarchar(max) NULL,
        [value_rating] tinyint NOT NULL,
        CONSTRAINT [PK_Comments] PRIMARY KEY ([id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211026195258_AddComments')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211026195258_AddComments', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211026205755_AddToOfferFieldIsCommented')
BEGIN
    ALTER TABLE [Offers] ADD [is_commented] bit NOT NULL DEFAULT CAST(0 AS bit);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211026205755_AddToOfferFieldIsCommented')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211026205755_AddToOfferFieldIsCommented', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211026215420_AddDateToComment')
BEGIN
    ALTER TABLE [Comments] ADD [date_comment] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211026215420_AddDateToComment')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211026215420_AddDateToComment', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211031122739_AddedModelShopChangeUser')
BEGIN
    ALTER TABLE [Users] ADD [level_user] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211031122739_AddedModelShopChangeUser')
BEGIN
    CREATE TABLE [Shops] (
        [id] int NOT NULL IDENTITY,
        [name_shop] nvarchar(max) NULL,
        [shop_avatar] nvarchar(max) NULL,
        CONSTRAINT [PK_Shops] PRIMARY KEY ([id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211031122739_AddedModelShopChangeUser')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211031122739_AddedModelShopChangeUser', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211031124539_ShopFieldOfUser')
BEGIN
    ALTER TABLE [Users] ADD [id_shop] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211031124539_ShopFieldOfUser')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211031124539_ShopFieldOfUser', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211101102011_AddFieldCreatedIdToShop')
BEGIN
    ALTER TABLE [Shops] ADD [id_created] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211101102011_AddFieldCreatedIdToShop')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211101102011_AddFieldCreatedIdToShop', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211101103322_AddFieldDescToShop')
BEGIN
    ALTER TABLE [Shops] ADD [desc_shop] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211101103322_AddFieldDescToShop')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211101103322_AddFieldDescToShop', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211101153540_AddFieldShortNameShopToShop')
BEGIN
    ALTER TABLE [Shops] ADD [short_name_shop] nvarchar(max) NOT NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211101153540_AddFieldShortNameShopToShop')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211101153540_AddFieldShortNameShopToShop', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211102072753_AddFieldShopIdToLotUpdateLot')
BEGIN
    ALTER TABLE [Lots] DROP CONSTRAINT [FK_Lots_Categories_categoryId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211102072753_AddFieldShopIdToLotUpdateLot')
BEGIN
    ALTER TABLE [Lots] DROP CONSTRAINT [FK_Lots_Users_vendorId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211102072753_AddFieldShopIdToLotUpdateLot')
BEGIN
    DROP INDEX [IX_Lots_categoryId] ON [Lots];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211102072753_AddFieldShopIdToLotUpdateLot')
BEGIN
    DROP INDEX [IX_Lots_vendorId] ON [Lots];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211102072753_AddFieldShopIdToLotUpdateLot')
BEGIN
    ALTER TABLE [Lots] ADD [shop_vendor] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211102072753_AddFieldShopIdToLotUpdateLot')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211102072753_AddFieldShopIdToLotUpdateLot', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211108141422_RemoveShopIdFromLot')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Lots]') AND [c].[name] = N'shop_vendor');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Lots] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Lots] DROP COLUMN [shop_vendor];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211108141422_RemoveShopIdFromLot')
BEGIN
    EXEC sp_rename N'[Lots].[vendorId]', N'vendor_id', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211108141422_RemoveShopIdFromLot')
BEGIN
    EXEC sp_rename N'[Lots].[categoryId]', N'category_id', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211108141422_RemoveShopIdFromLot')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211108141422_RemoveShopIdFromLot', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211108142832_AddEntityShopLot')
BEGIN
    CREATE TABLE [ShopLots] (
        [id] int NOT NULL IDENTITY,
        [nameLot] nvarchar(max) NULL,
        [descLot] nvarchar(max) NULL,
        [price] float NOT NULL,
        [category_id] int NOT NULL,
        [shop_Id] int NOT NULL,
        CONSTRAINT [PK_ShopLots] PRIMARY KEY ([id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211108142832_AddEntityShopLot')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211108142832_AddEntityShopLot', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211108173247_AddFieldShopVendorIdToOffer')
BEGIN
    ALTER TABLE [Offers] ADD [shop_vendor_id] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211108173247_AddFieldShopVendorIdToOffer')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211108173247_AddFieldShopVendorIdToOffer', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211109152151_AddFieldShopLotIdToOffer')
BEGIN
    ALTER TABLE [Offers] ADD [shop_lot_id] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211109152151_AddFieldShopLotIdToOffer')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211109152151_AddFieldShopLotIdToOffer', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211116111248_AddEntityMessageShop')
BEGIN
    CREATE TABLE [MessageShops] (
        [id] int NOT NULL IDENTITY,
        [BodyMessage] nvarchar(max) NULL,
        [date_message] datetime2 NOT NULL,
        [is_shop_message] bit NOT NULL,
        [user_id] int NOT NULL,
        [shop_id] int NOT NULL,
        [shop_member_id] int NOT NULL,
        CONSTRAINT [PK_MessageShops] PRIMARY KEY ([id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211116111248_AddEntityMessageShop')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211116111248_AddEntityMessageShop', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220210145029_AddFiledToEntityEmailUpdateUserRoleBanned')
BEGIN
    ALTER TABLE [Users] ADD [email] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220210145029_AddFiledToEntityEmailUpdateUserRoleBanned')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220210145029_AddFiledToEntityEmailUpdateUserRoleBanned', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220213175949_DeleteLoginAtEntityUser')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Users]') AND [c].[name] = N'login');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Users] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Users] DROP COLUMN [login];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220213175949_DeleteLoginAtEntityUser')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220213175949_DeleteLoginAtEntityUser', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220213184833_AddedNewFieldAccessToken')
BEGIN
    CREATE TABLE [AccessTokens] (
        [Id] int NOT NULL IDENTITY,
        [Token] nvarchar(max) NULL,
        [Nick] nvarchar(max) NULL,
        [Passcrypt] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        CONSTRAINT [PK_AccessTokens] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220213184833_AddedNewFieldAccessToken')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220213184833_AddedNewFieldAccessToken', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220213190708_UpdateEntityAccessToken')
BEGIN
    EXEC sp_rename N'[AccessTokens].[Token]', N'token', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220213190708_UpdateEntityAccessToken')
BEGIN
    EXEC sp_rename N'[AccessTokens].[Passcrypt]', N'passcrypt', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220213190708_UpdateEntityAccessToken')
BEGIN
    EXEC sp_rename N'[AccessTokens].[Nick]', N'nick', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220213190708_UpdateEntityAccessToken')
BEGIN
    EXEC sp_rename N'[AccessTokens].[Email]', N'email', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220213190708_UpdateEntityAccessToken')
BEGIN
    EXEC sp_rename N'[AccessTokens].[Id]', N'id', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220213190708_UpdateEntityAccessToken')
BEGIN
    ALTER TABLE [AccessTokens] ADD [isActivated] bit NOT NULL DEFAULT CAST(0 AS bit);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220213190708_UpdateEntityAccessToken')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220213190708_UpdateEntityAccessToken', N'5.0.11');
END;
GO

COMMIT;
GO

