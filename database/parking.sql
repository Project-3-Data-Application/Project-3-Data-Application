--
-- PostgreSQL database dump
--

-- Dumped from database version 9.6.1
-- Dumped by pg_dump version 9.6.1

-- Started on 2017-04-10 15:09:37

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET row_security = off;

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
-- TOC entry 2123 (class 0 OID 94741)
-- Dependencies: 186
-- Data for Name: parking; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY parking ("NAME", "CODE", "TYPE", "AANTAL_PLEKKEN", "ADRES", "PLAATS", "GEBIED") FROM stdin;
Parkeergarage Erasmusbrug	P1	Parkeergarage	327	Gedempte Zalmhaven	Rotterdam	Centrum
Parkeergarage Schouwburgplein	P4	Parkeergarage	730	Schouwburgplein 22	Rotterdam	Centrum
Parkeergarage Erasmus MC	P15	Parkeergarage	 	Westzeedijk 361	Rotterdam	Centrum
Parkeergarage Museumpark	P19	Parkeergarage	1162	Museumpark 32	Rotterdam	Centrum
P + R Beverwaard	P37	P + R	508	Edo Bergsmaweg 1	Rotterdam	Beverwaard
Parkeergarage Weena	P8	Parkeergarage	480	Karel Doormanstraat 10	Rotterdam	Centrum
Parkeergarage Plaza/Casino	P14	Parkeergarage	 	Kruisstraat 13	Rotterdam	Centrum
Parkeergarage Kruiskade	P9	Parkeergarage	275	Kruiskade 21	Rotterdam	Centrum
Parkeergarage Westblaak	P10	Parkeergarage	780	Hartmansstraat 35	Rotterdam	Centrum
Parkeergarage Lijnbaan	P7	Parkeergarage	540	Crispijnstraat 6	Rotterdam	Centrum
Parkeergarage Bijenkorf	P13	Parkeergarage	460	Aert van Nesstraat 16	Rotterdam	Centrum
Parkeergarage Beursplein	P16	Parkeergarage	435	Bulgersteyn 5	Rotterdam	Centrum
Parkeergarage WTC-V&D	P12	Parkeergarage	 	Leeuwenstraat 2	Rotterdam	Centrum
Parkeergarage Oude Haven	P5	Parkeergarage	229	Burgemeester van Walsumweg 718	Rotterdam	Centrum
P + R Kralingse Zoom	P42	P + R	1700	Kralingse Zoom 50	Rotterdam	Kralingen-Oost
Parkeergarage Boompjes	P18	Parkeergarage	623	Terwenakker 18	Rotterdam	Centrum
Parkeergarage World Port Center	P17	Parkeergarage	505	Wilhelminakade 981	Rotterdam	Feijenoord
Parkeergarage Zuidplein	P31	Parkeergarage	1400	Twentestraat 10	Rotterdam	Zuidplein
Parkeergarage Ahoy	P33	Parkeerterrein	439	Montessoriweg 9	Rotterdam	Zuidplein
P + R Slinge benedendek	P30	P + R	849	Slinge 763	Rotterdam	Pendrecht
P + R Alexander	P36	P + R	473	Prins Alexanderlaan 35	Rotterdam	Prins Alexander
Parkeergarage Kiphof	P2	Parkeergarage	339	Kipstraat 177	Rotterdam	Centrum
P + R Noorderhelling	P43	P + R	322	Stadionweg 1	Rotterdam	Sportdorp
\.


--
-- TOC entry 2005 (class 2606 OID 94745)
-- Name: parking parking_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY parking
    ADD CONSTRAINT parking_pkey PRIMARY KEY ("NAME", "ADRES", "PLAATS");


-- Completed on 2017-04-10 15:09:37

--
-- PostgreSQL database dump complete
--

