START TRANSACTION;

ALTER TABLE students ALTER COLUMN adm_number 
DROP IDENTITY;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20211215064416_migration2', '5.0.0');

COMMIT;

