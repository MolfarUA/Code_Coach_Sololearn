INSERT INTO Animals (name, type, country_id) 
VALUES ('Slim', 'Giraffe', 1);

SELECT animals.name, animals.type, countries.country FROM animals, countries
WHERE animals.country_id=countries.id order by animals.country_id desc
