USE [Norskapi];

GO
    MERGE [dbo].[Subjunctions] AS target USING (
        VALUES
            (
                N'f8b262f5-c9f0-440b-a887-010d026fc9c5',
                N'["dadadada", "ddddd"]',
                N'["dadada", "g86"]',
                N'["daadda", "g86"]',
                N'["assaas", "g86"]',
                N'["assasa", "g86"]',
                SYSDATETIME(),
				SYSDATETIME()
            )
    ) AS source (
        [Id],
        [Time],
        [Arsak],
        [Hensikt],
        [Betingelse],
        [Motsetning],
        [CreatedDateTime],
        [UpdatedDateTime]
    ) ON target.[Id] = source.[Id]
    WHEN MATCHED THEN
UPDATE
SET
    [Time] = source.[Time],
    [Arsak] = source.[Arsak],
    [Hensikt] = source.[Hensikt],
    [Betingelse] = source.[Betingelse],
    [Motsetning] = source.[Motsetning],
    [UpdatedDateTime] = source.[UpdatedDateTime]
    WHEN NOT MATCHED THEN
INSERT
    (
        [Id],
        [Time],
        [Arsak],
        [Hensikt],
        [Betingelse],
        [Motsetning],
        [CreatedDateTime],
        [UpdatedDateTime]
    )
VALUES
    (
        source.[Id],
        source.[Time],
        source.[Arsak],
        source.[Hensikt],
        source.[Betingelse],
        source.[Motsetning],
        source.[CreatedDateTime],
        source.[UpdatedDateTime]
    );

GO