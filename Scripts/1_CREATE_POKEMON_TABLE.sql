USE POKEMON

--------------------------------------------------------------
-------------------Create POKEMON table-----------------------
--------------------------------------------------------------

IF NOT EXISTS(SELECT * FROM SYS.TABLES WHERE name = 'pokemon')
	
	CREATE TABLE Pokemon (
		[id] INT NOT NULL,
		[name] VARCHAR(20),
		[base_experience] INTEGER,
		[height] INTEGER,
		[is_default] BIT,
		[order] BIT,
		[weight] INTEGER
	)
	

	IF NOT EXISTS(SELECT * FROM sys.key_constraints WHERE NAME = 'PK_Pokemon')

		ALTER TABLE Pokemon ADD CONSTRAINT PK_Pokemon PRIMARY KEY (id)
