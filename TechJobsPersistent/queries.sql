--Part 1
--Id int AI PK 
--Name longtext 
--EmployerId int

--Part 2
--SELECT Name 
--FROM employers 
--WHERE Location = "St. Louis City";

--Part 3
--SELECT name, description
--FROM skills
--inner join jobskills ON skills.id = jobskills.SkillId WHERE jobskills.JobId IS NOT NULL
--ORDER BY skills.name ASC;