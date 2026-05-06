
--------------------------------------------------------------
------------------Create POKEMON database---------------------
--------------------------------------------------------------

IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'POKEMON')
	CREATE DATABASE POKEMON