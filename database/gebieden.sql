-- Alle gebieden
SELECT DISTINCT "GEBIED" FROM "parking"
UNION 
SELECT DISTINCT "gebied" FROM "psa"
UNION
SELECT DISTINCT "gebied" FROM "toeristische_attracties"

-- 2 tabels met data samen:

SELECT "psa"."adres", psa."gebied" AS "PSAG" 
FROM parking AS p
LEFT JOIN "psa" ON p."GEBIED" = "psa"."gebied"

INTERSECT

SELECT "psa"."adres", psa."gebied" AS "PSAG" 
FROM parking AS p
RIGHT JOIN "psa" ON p."GEBIED" = "psa"."gebied"