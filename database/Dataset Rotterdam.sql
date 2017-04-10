--
-- PostgreSQL database dump
--

-- Dumped from database version 9.6.1
-- Dumped by pg_dump version 9.6.1

-- Started on 2017-04-10 15:48:57

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET row_security = off;

DROP DATABASE "Dataset Rotterdam";
--
-- TOC entry 2137 (class 1262 OID 86495)
-- Name: Dataset Rotterdam; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE "Dataset Rotterdam" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_United States.1252' LC_CTYPE = 'English_United States.1252';


ALTER DATABASE "Dataset Rotterdam" OWNER TO postgres;

\connect -reuse-previous=on "dbname='Dataset Rotterdam'"

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 1 (class 3079 OID 12387)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 2139 (class 0 OID 0)
-- Dependencies: 1
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 186 (class 1259 OID 94741)
-- Name: parking; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE parking (
    "NAME" character varying(80) NOT NULL,
    "CODE" character varying(5),
    "TYPE" character varying(20),
    "AANTAL_PLEKKEN" character varying(20),
    "ADRES" character varying(80) NOT NULL,
    "PLAATS" character varying(20) NOT NULL,
    "GEBIED" character varying(50)
);


ALTER TABLE parking OWNER TO postgres;

--
-- TOC entry 185 (class 1259 OID 94653)
-- Name: psa; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE psa (
    plaats character varying(20) NOT NULL,
    gebied character varying(20) NOT NULL,
    adres character varying(100) NOT NULL
);


ALTER TABLE psa OWNER TO postgres;

--
-- TOC entry 187 (class 1259 OID 94757)
-- Name: toeristische_attracties; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE toeristische_attracties (
    toeristische_attractie character varying(80) NOT NULL,
    onderwerp character varying(50) NOT NULL,
    bedekt character varying(3),
    reserveren_verplicht character varying(3),
    adres character varying(80) NOT NULL,
    postcode character varying(7) NOT NULL,
    gebied character varying(20),
    plaats character varying(30),
    tijden character varying(30)
);


ALTER TABLE toeristische_attracties OWNER TO postgres;

--
-- TOC entry 2131 (class 0 OID 94741)
-- Dependencies: 186
-- Data for Name: parking; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('Parkeergarage Erasmusbrug', 'P1', 'Parkeergarage', '327', 'Gedempte Zalmhaven', 'Rotterdam', 'Centrum');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('Parkeergarage Schouwburgplein', 'P4', 'Parkeergarage', '730', 'Schouwburgplein 22', 'Rotterdam', 'Centrum');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('Parkeergarage Erasmus MC', 'P15', 'Parkeergarage', ' ', 'Westzeedijk 361', 'Rotterdam', 'Centrum');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('Parkeergarage Museumpark', 'P19', 'Parkeergarage', '1162', 'Museumpark 32', 'Rotterdam', 'Centrum');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('P + R Beverwaard', 'P37', 'P + R', '508', 'Edo Bergsmaweg 1', 'Rotterdam', 'Beverwaard');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('Parkeergarage Weena', 'P8', 'Parkeergarage', '480', 'Karel Doormanstraat 10', 'Rotterdam', 'Centrum');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('Parkeergarage Plaza/Casino', 'P14', 'Parkeergarage', ' ', 'Kruisstraat 13', 'Rotterdam', 'Centrum');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('Parkeergarage Kruiskade', 'P9', 'Parkeergarage', '275', 'Kruiskade 21', 'Rotterdam', 'Centrum');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('Parkeergarage Westblaak', 'P10', 'Parkeergarage', '780', 'Hartmansstraat 35', 'Rotterdam', 'Centrum');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('Parkeergarage Lijnbaan', 'P7', 'Parkeergarage', '540', 'Crispijnstraat 6', 'Rotterdam', 'Centrum');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('Parkeergarage Bijenkorf', 'P13', 'Parkeergarage', '460', 'Aert van Nesstraat 16', 'Rotterdam', 'Centrum');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('Parkeergarage Beursplein', 'P16', 'Parkeergarage', '435', 'Bulgersteyn 5', 'Rotterdam', 'Centrum');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('Parkeergarage WTC-V&D', 'P12', 'Parkeergarage', ' ', 'Leeuwenstraat 2', 'Rotterdam', 'Centrum');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('Parkeergarage Oude Haven', 'P5', 'Parkeergarage', '229', 'Burgemeester van Walsumweg 718', 'Rotterdam', 'Centrum');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('P + R Kralingse Zoom', 'P42', 'P + R', '1700', 'Kralingse Zoom 50', 'Rotterdam', 'Kralingen-Oost');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('Parkeergarage Boompjes', 'P18', 'Parkeergarage', '623', 'Terwenakker 18', 'Rotterdam', 'Centrum');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('Parkeergarage World Port Center', 'P17', 'Parkeergarage', '505', 'Wilhelminakade 981', 'Rotterdam', 'Feijenoord');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('Parkeergarage Zuidplein', 'P31', 'Parkeergarage', '1400', 'Twentestraat 10', 'Rotterdam', 'Zuidplein');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('Parkeergarage Ahoy', 'P33', 'Parkeerterrein', '439', 'Montessoriweg 9', 'Rotterdam', 'Zuidplein');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('P + R Slinge benedendek', 'P30', 'P + R', '849', 'Slinge 763', 'Rotterdam', 'Pendrecht');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('P + R Alexander', 'P36', 'P + R', '473', 'Prins Alexanderlaan 35', 'Rotterdam', 'Prins Alexander');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('Parkeergarage Kiphof', 'P2', 'Parkeergarage', '339', 'Kipstraat 177', 'Rotterdam', 'Centrum');
INSERT INTO parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") VALUES ('P + R Noorderhelling', 'P43', 'P + R', '322', 'Stadionweg 1', 'Rotterdam', 'Sportdorp');


--
-- TOC entry 2130 (class 0 OID 94653)
-- Dependencies: 185
-- Data for Name: psa; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Lindendaal 1');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Kortewelle 20');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Oostendamstraat 41');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Narcissenstraat 335');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Wodenstraat 1121');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Staalstraat 91');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Putselaan 241');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Paul Krugerstraat 113');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Staalstraat 1');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Tolhuisstraat 2');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Wilhelminakade 967');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Hillelaan 30');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Hillekopplein 82');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Laan op Zuid 780');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'WG Witteveenplein 102');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'J.B. Bakemakade 72');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Oranjeboomstraat 169');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Lodewijk Pincoffsweg 223');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Lodewijk Pincoffsweg 329');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Laan op Zuid 203');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Nijverheidsstraat 184');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Stieltjesstraat 16');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Louis Pregerkade 10');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Prins Hendrikkade 154');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Prins Hendrikkade 148');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Maaskade 152');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Sleephellingstraat 50');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Prins Hendrikkade 88');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Maaskade 89');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Van der Takstraat 34');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Prins Hendrikkade 43');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'Prins Hendrikkade 10');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Feijenoord', 'De Ruyterstraat 1');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Bas Jurgeriusstraat 31');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Wolphaertbocht 372');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Katendrechtse Lagedijk 10');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Sluisjesdijk 151');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Sint-Janshaven 476');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Grondherendijk 17');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Boergoensestraat 80');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Portlandstraat 46');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Lepelaarsingel 75');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Wulpstraat 5');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Boergoensevliet 110');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Mezenstraat 59');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Boergoensevliet 180');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Schulpplein 36');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Nijmegenstraat 27');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Poelenburg 10');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Ludenhorst 4446');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Binkhorst 48');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Langenhorst 241');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Slinge 303');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Charlois', 'Slinge 162');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Westerkade 31');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Zeemansstraat 13');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Kievitslaan 31');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Parklaan 18');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Parklaan 16');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Veerhaven 2');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Westplein 9');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Maasstraat 6');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Vasteland 12');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Vasteland 60');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Scheepstimmermanslaan 14');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Van Vollenhovenstraat 14');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Koningin Emmaplein 15');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Parkhaven 9');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Coolhaven 211');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Rochussenstraat 230');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Breitnerstraat 41');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Mathenesserlaan 207');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 's-Gravendijkwal 66');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Breitnerstraat 69');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Gouvernestraat 250');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Eendrachtsweg 38');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Kortenaerstraat 14');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'William Boothlaan 18');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Schilderstraat 57');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Schiedamsevesthof 30');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Schiedamsevesthof 21');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', '2e- westblaakhof 8');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Karel Doormanhof 2');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Mauritsweg 37');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Westersingel 41');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Westersingel 6');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Josephstraat 60');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Henegouwerlaan 76');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Delfsestraat 29');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Scheepmakershaven 60');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Glashaven 7');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Oosterkade 119');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Haringvliet 90');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Haringvliet 25');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Hoogstraat 3');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Goudsewagenstraat 2');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Groenendaal 225');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Rijstuin 9');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Mariniershof 10');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Goudsesingel 262');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Pannekoekstraat 66');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Botersloot 141');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Binnenrotte 15');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Delfsevaart 24');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Westewagenstraat 21');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Grotekerkplein 10');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Zijl 7');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Steiger 12');
INSERT INTO psa (plaats, gebied, adres) VALUES ('Rotterdam', 'Centrum', 'Keizerstraat 108');


--
-- TOC entry 2132 (class 0 OID 94757)
-- Dependencies: 187
-- Data for Name: toeristische_attracties; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Euromast', 'High Tea', 'Ja', 'Ja', 'Parkhaven 20', '3016GM', 'Centrum', 'Rotterdam', '10:00-16:00 ');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Euromast', 'Diner', 'Ja', 'Ja', 'Parkhaven 20', '3016GM', 'Centrum', 'Rotterdam', '16:00-23:00 ');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Euromast', 'Lunch', 'Ja', 'Ja', 'Parkhaven 20', '3016GM', 'Centrum', 'Rotterdam', '11:00-16:00 ');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Euromast', 'Brunch', 'Ja', 'Ja', 'Parkhaven 20', '3016GM', 'Centrum', 'Rotterdam', '10:00-12:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Euromast', 'Tokkelen', 'Nee', 'Ja', 'Parkhaven 20', '3016GM', 'Centrum', 'Rotterdam', '11:00-17:55*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Euromast', 'Abseilen', 'Nee', 'Ja', 'Parkhaven 20', '3016GM', 'Centrum', 'Rotterdam', '10:00-19:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Kubuswoningen', 'Architectuur', 'Ja', 'Nee', 'Overblaak 70', '3011MH', 'Centrum', 'Rotterdam', '11:00-17:00 ');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Kubuswoningen', 'Museum', 'Ja', 'Nee', 'Overblaak 70', '3011MH', 'Centrum', 'Rotterdam', '11:00-17:00 ');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Museum Boijmans Van Beuningen', 'Architectuur', 'Ja', 'Nee', 'Museumpark 18', '3015CX', 'Centrum', 'Rotterdam', '11:00-17:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Museum Boijmans Van Beuningen', 'Museum', 'Ja', 'Nee', 'Museumpark 18', '3015CX', 'Centrum', 'Rotterdam', '11:00-17:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Erasmusbrug', 'Architectuur', 'Nee', 'Nee', 'Erasmusbrug 1', '3011BN', 'Centrum', 'Rotterdam', '24/7 Open');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Kunsthal Rotterdam', 'Architectuur', 'Ja', 'Nee', 'Westzeedijk 341', '3015AA', 'Centrum', 'Rotterdam', '10:00-17:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Kunsthal Rotterdam', 'Museum', 'Ja', 'Nee', 'Westzeedijk 341', '3015AA', 'Centrum', 'Rotterdam', '10:00-17:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Wereldmuseum Rotterdam', 'Museum', 'Ja', 'Nee', 'Willenskade 25', '3016DM', 'Centrum', 'Rotterdam', '10:30-17:30*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Grote of Sint-Laurenskerk', 'Architectuur', 'Ja', 'Nee', 'Grotekerkplein 27', '3011GC', 'Centrum', 'Rotterdam', '11.00-17.00 uur*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Grote of Sint-Laurenskerk', 'Concertgebouw', 'Ja', 'Nee', 'Grotekerkplein 27', '3011GC', 'Centrum', 'Rotterdam', '11.00-17.00 uur*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Grote of Sint-Laurenskerk', 'Kerkgebouw', 'Ja', 'Nee', 'Grotekerkplein 27', '3011GC', 'Centrum', 'Rotterdam', '11.00-17.00 uur*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Grote of Sint-Laurenskerk', 'Monument', 'Ja', 'Nee', 'Grotekerkplein 27', '3011GC', 'Centrum', 'Rotterdam', '11.00-17.00 uur*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Diergaarde Blijdorp', 'Dierentuin', 'Nee', 'Nee', 'Blijdorplaan 8', '3041JG', 'Blijdorpse Polder', 'Rotterdam', '09:00-18:00');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Witte Huis', 'Architectuur', 'Nee', 'Nee', 'Geldersekade 1', '3011WB', 'Centrum', 'Rotterdam', '15:00-05:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Witte Huis', 'Cafe', 'Nee', 'Nee', 'Geldersekade 1', '3011WB', 'Centrum', 'Rotterdam', '15:00-05:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Witte Huis', 'Monument', 'Nee', 'Nee', 'Geldersekade 1', '3011WB', 'Centrum', 'Rotterdam', '15:00-05:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Maritiem Museum Rotterdam', 'Museum', 'Ja', 'Nee', 'Leuvehaven 1', '3011EA', 'Centrum', 'Rotterdam', '10:00 - 16:00');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Nederlands Fotomuseum', 'Museum', 'Ja', 'Nee', 'Las Palmas, Wilhelminakade 332', '3072AR', 'Feijenoord', 'Rotterdam', '10:00-17:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Witte de With', 'Architectuur', 'Ja ', 'Nee', 'Witte de withstraat 50', '3012BR', 'Centrum', 'Rotterdam', '11:00-18:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Witte de With', 'Museum', 'Ja ', 'Nee', 'Witte de withstraat 50', '3012BR', 'Centrum', 'Rotterdam', '11:00-18:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Van Nellefabriek', 'Architectuur', 'Ja', 'Nee', 'Van Nelleweg 1', '3044BC', 'Spaanse Polder', 'Rotterdam', '12:00 - 14:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Oceanium', 'Dierentuin', 'Ja', 'Nee', 'Blijdorplaan 8', '3041JG', 'Blijdorpse Polder', 'Rotterdam', '09:00-18:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Chabot Museum', 'Architectuur', 'Ja', 'Nee', 'Museumpark 11', '3015CB', 'Centrum', 'Rotterdam', '11:00-16:30*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Chabot Museum', 'Museum', 'Ja', 'Nee', 'Museumpark 11', '3015CB', 'Centrum', 'Rotterdam', '11:00-16:30*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('De Doelen', 'Concertgebouw', 'Ja', 'Ja', 'Schouwburgplein 50', '3012CL', 'Centrum', 'Rotterdam', '14:00 - 18:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Natuurhistorische Museum Rotterdam', 'Museum', 'Ja', 'Nee', 'Westzeedijk 345', '3015AA', 'Centrum', 'Rotterdam', '11:00-17:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('De verwoeste stad', 'Monument', 'Nee', 'Nee', 'Plein 1940', '3011EA', 'Centrum', 'Rotterdam', '24/7 Open');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Markthal', 'Architectuur', 'Ja', 'Nee', 'Dominee Jan Scharpstraat 298', '3011GZ', 'Centrum', 'Rotterdam', '10:00 - 20:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Markthal', 'Markt', 'Ja', 'Nee', 'Dominee Jan Scharpstraat 298', '3011GZ', 'Centrum', 'Rotterdam', '10:00 - 20:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Miniworld Rotterdam', 'Museum', 'Ja ', 'Nee', 'Weena 745', '3013AL', 'Centrum', 'Rotterdam', '12:00-17:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Plaswijckpark', 'Attractiepark', 'Nee', 'Nee', 'Ringdijk 18', '3053KS', 'Schiebroek', 'Rotterdam', '10:00-17:00');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Plaswijckpark', 'Dierentuin', 'Nee', 'Nee', 'Ringdijk 19', '3053KS', 'Schiebroek', 'Rotterdam', '10:00-17:00');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Plaswijckpark', 'Park', 'Nee', 'Nee', 'Ringdijk 20', '3053KS', 'Schiebroek', 'Rotterdam', '10:00-17:00');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Het Park', 'Park', 'Nee', 'Nee', 'Westzeedijk/ GR, Parkkade', '3016 CG', 'Centrum', 'Rotterdam', '24/7 Open');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Vroesenpark', 'Park', 'Nee', 'Nee', 'Stadhoudersweg 181', '3039MC', 'Blijdorp', 'Rotterdam', '24/7 Open');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Oude Haven', 'Haven', 'Nee', 'Nee', 'Oude Haven', '3011MG', 'Centrum', 'Rotterdam', '24/7 Open');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Roel Langerakpark', 'Park', 'Nee', 'Nee', 'Roel Langerakweg 25', '3041JK', 'Blijdorpse Polder', 'Rotterdam', '24/7 Open');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Havenmuseum', 'Attractiepark', 'Nee', 'Nee', 'Leuvehaven 49', '3011EA', 'Centrum', 'Rotterdam', '24/7 Open');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Museum Rotterdam', 'Museum', 'Ja', 'Nee', 'Rodezand 26', '3011AN', 'Centrum', 'Rotterdam', '10:00-17:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Veerhaven', 'Concertgebouw', 'Ja', 'Nee', 'Veerkade 15', '3016DE', 'Centrum', 'Rotterdam', '24/7 Open');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Huis Sonneveld', 'Architectuur', 'Ja', 'Nee', 'Jongkindstraat 12', '3015CG', 'Centrum', 'Rotterdam', '11:00-17:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Rijnhaven', 'Bos', 'Nee', 'Nee', 'Rijnhaven 1', '3072AJ', 'Feijenoord', 'Rotterdam', '24/7 Open');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Hop-on Hop-off Rotterdam B.V.', 'Stadstour', 'Nee', 'Ja', 'Van Vollenhovenstraat 15A', '3016BE', 'Centrum', 'Rotterdam', '10:00-17:00');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Leuvehaven', 'Haven', 'Nee', 'Nee', 'Leuvehaven 1', '3011 EA', 'Centrum', 'Rotterdam', '24/7 Open');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Mariniersmuseum', 'Museum', 'Ja', 'Nee', 'Wijnhaven 11', '3011WH', 'Centrum', 'Rotterdam', '10:00-17:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Stadsarchief Rotterdam', 'Museum', 'Ja', 'Nee', 'Hofdijk 651', '3032CG', 'Agniesebuurt', 'Rotterdam', '09:00-17:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Belasting & Douane Museum', 'Museum', 'Ja', 'Nee', 'Parklaan 14-16', '3016BB', 'Centrum', 'Rotterdam', '11:00-17:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Rivierahal', 'Tentoonstelling', 'Ja', 'Nee', 'Blijdorplaan 8', '3041JG', 'Blijdorpse Polder', 'Rotterdam', '09:00-18:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Dutch Pinball Museum', 'Museum', 'Ja', 'Nee', 'Paul Nijghkade 19-K', '3072AN', 'Katendrecht', 'Rotterdam', '12:00-18:00*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Garage Rotterdam', 'Tentoonstelling', 'Ja', 'Nee', 'Goudsewagenstraat 27', '3011RH', 'Centrum', 'Rotterdam', '12:30-17:30*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('Schoonoord', 'Park', 'Nee', 'Nee', 'Kievitslaan 8', '3016CG', 'Centrum', 'Rotterdam', '08:30-16:30*');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('De Hef', 'Architectuur', 'Nee', 'Nee', 'De Hef', '3071', 'Feijenoord', 'Rotterdam', '24/7 Open');
INSERT INTO toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) VALUES ('De Hef', 'Architectuur', 'Nee', 'Nee', 'De Hef', '3072', 'Feijenoord', 'Rotterdam', '24/7 Open');


--
-- TOC entry 2010 (class 2606 OID 94745)
-- Name: parking parking_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY parking
    ADD CONSTRAINT parking_pkey PRIMARY KEY ("NAME", "ADRES", "PLAATS");


--
-- TOC entry 2008 (class 2606 OID 94657)
-- Name: psa psa_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY psa
    ADD CONSTRAINT psa_pkey PRIMARY KEY (plaats, gebied, adres);


--
-- TOC entry 2012 (class 2606 OID 94761)
-- Name: toeristische_attracties toeristische_attracties_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY toeristische_attracties
    ADD CONSTRAINT toeristische_attracties_pkey PRIMARY KEY (toeristische_attractie, onderwerp, adres, postcode);


-- Completed on 2017-04-10 15:48:58

--
-- PostgreSQL database dump complete
--

