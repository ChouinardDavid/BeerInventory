
INSERT INTO [dbo].Regions (Nom)
	VALUES	('Montréal'),
			('Québec'),
		    ('Chambly'),
			('Sagenay'),
			('Gaspésie')
			
INSERT INTO [dbo].Microbrasseries (Nom, Region_Id)
	VALUES ('La souche', 2),
		   ('Unibroue', 3),
		   ('Le castor', 4)

INSERT INTO [dbo].Volumes (Quantite)
	VALUES ('374 ml'),
		   ('500 ml'),
		   ('600 ml')

INSERT INTO [dbo].Houblons (Nom)
	VALUES ('Cascade'),
		   ('Centennial'),
		   ('Golding'),
		   ('Saaz')

INSERT INTO [dbo].TypeBieres (Nom, Description)
	VALUES ('IPA', 'Très amere'),
		   ('Blonde', 'douce'),
		   ('Brune', 'Plus foncée')

INSERT INTO [dbo].Bieres (Nom, Appreciation, Microbrasserie_Id, Type_Id, Volume_Id)
	VALUES ('La maudite', 'Plutôt forte, mais bonne', 2, 3, 3)