--
-- PostgreSQL database dump
--

-- Dumped from database version 9.6.1
-- Dumped by pg_dump version 9.6.1

-- Started on 2017-04-10 15:18:10

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
-- TOC entry 2130 (class 0 OID 94653)
-- Dependencies: 185
-- Data for Name: psa; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY psa (plaats, gebied, adres) FROM stdin;
Rotterdam	Feijenoord	Lindendaal 1
Rotterdam	Feijenoord	Kortewelle 20
Rotterdam	Feijenoord	Oostendamstraat 41
Rotterdam	Feijenoord	Narcissenstraat 335
Rotterdam	Feijenoord	Wodenstraat 1121
Rotterdam	Feijenoord	Staalstraat 91
Rotterdam	Feijenoord	Putselaan 241
Rotterdam	Feijenoord	Paul Krugerstraat 113
Rotterdam	Feijenoord	Staalstraat 1
Rotterdam	Feijenoord	Tolhuisstraat 2
Rotterdam	Feijenoord	Wilhelminakade 967
Rotterdam	Feijenoord	Hillelaan 30
Rotterdam	Feijenoord	Hillekopplein 82
Rotterdam	Feijenoord	Laan op Zuid 780
Rotterdam	Feijenoord	WG Witteveenplein 102
Rotterdam	Feijenoord	J.B. Bakemakade 72
Rotterdam	Feijenoord	Oranjeboomstraat 169
Rotterdam	Feijenoord	Lodewijk Pincoffsweg 223
Rotterdam	Feijenoord	Lodewijk Pincoffsweg 329
Rotterdam	Feijenoord	Laan op Zuid 203
Rotterdam	Feijenoord	Nijverheidsstraat 184
Rotterdam	Feijenoord	Stieltjesstraat 16
Rotterdam	Feijenoord	Louis Pregerkade 10
Rotterdam	Feijenoord	Prins Hendrikkade 154
Rotterdam	Feijenoord	Prins Hendrikkade 148
Rotterdam	Feijenoord	Maaskade 152
Rotterdam	Feijenoord	Sleephellingstraat 50
Rotterdam	Feijenoord	Prins Hendrikkade 88
Rotterdam	Feijenoord	Maaskade 89
Rotterdam	Feijenoord	Van der Takstraat 34
Rotterdam	Feijenoord	Prins Hendrikkade 43
Rotterdam	Feijenoord	Prins Hendrikkade 10
Rotterdam	Feijenoord	De Ruyterstraat 1
Rotterdam	Charlois	Bas Jurgeriusstraat 31
Rotterdam	Charlois	Wolphaertbocht 372
Rotterdam	Charlois	Katendrechtse Lagedijk 10
Rotterdam	Charlois	Sluisjesdijk 151
Rotterdam	Charlois	Sint-Janshaven 476
Rotterdam	Charlois	Grondherendijk 17
Rotterdam	Charlois	Boergoensestraat 80
Rotterdam	Charlois	Portlandstraat 46
Rotterdam	Charlois	Lepelaarsingel 75
Rotterdam	Charlois	Wulpstraat 5
Rotterdam	Charlois	Boergoensevliet 110
Rotterdam	Charlois	Mezenstraat 59
Rotterdam	Charlois	Boergoensevliet 180
Rotterdam	Charlois	Schulpplein 36
Rotterdam	Charlois	Nijmegenstraat 27
Rotterdam	Charlois	Poelenburg 10
Rotterdam	Charlois	Ludenhorst 4446
Rotterdam	Charlois	Binkhorst 48
Rotterdam	Charlois	Langenhorst 241
Rotterdam	Charlois	Slinge 303
Rotterdam	Charlois	Slinge 162
Rotterdam	Centrum	Westerkade 31
Rotterdam	Centrum	Zeemansstraat 13
Rotterdam	Centrum	Kievitslaan 31
Rotterdam	Centrum	Parklaan 18
Rotterdam	Centrum	Parklaan 16
Rotterdam	Centrum	Veerhaven 2
Rotterdam	Centrum	Westplein 9
Rotterdam	Centrum	Maasstraat 6
Rotterdam	Centrum	Vasteland 12
Rotterdam	Centrum	Vasteland 60
Rotterdam	Centrum	Scheepstimmermanslaan 14
Rotterdam	Centrum	Van Vollenhovenstraat 14
Rotterdam	Centrum	Koningin Emmaplein 15
Rotterdam	Centrum	Parkhaven 9
Rotterdam	Centrum	Coolhaven 211
Rotterdam	Centrum	Rochussenstraat 230
Rotterdam	Centrum	Breitnerstraat 41
Rotterdam	Centrum	Mathenesserlaan 207
Rotterdam	Centrum	s-Gravendijkwal 66
Rotterdam	Centrum	Breitnerstraat 69
Rotterdam	Centrum	Gouvernestraat 250
Rotterdam	Centrum	Eendrachtsweg 38
Rotterdam	Centrum	Kortenaerstraat 14
Rotterdam	Centrum	William Boothlaan 18
Rotterdam	Centrum	Schilderstraat 57
Rotterdam	Centrum	Schiedamsevesthof 30
Rotterdam	Centrum	Schiedamsevesthof 21
Rotterdam	Centrum	2e- westblaakhof 8
Rotterdam	Centrum	Karel Doormanhof 2
Rotterdam	Centrum	Mauritsweg 37
Rotterdam	Centrum	Westersingel 41
Rotterdam	Centrum	Westersingel 6
Rotterdam	Centrum	Josephstraat 60
Rotterdam	Centrum	Henegouwerlaan 76
Rotterdam	Centrum	Delfsestraat 29
Rotterdam	Centrum	Scheepmakershaven 60
Rotterdam	Centrum	Glashaven 7
Rotterdam	Centrum	Oosterkade 119
Rotterdam	Centrum	Haringvliet 90
Rotterdam	Centrum	Haringvliet 25
Rotterdam	Centrum	Hoogstraat 3
Rotterdam	Centrum	Goudsewagenstraat 2
Rotterdam	Centrum	Groenendaal 225
Rotterdam	Centrum	Rijstuin 9
Rotterdam	Centrum	Mariniershof 10
Rotterdam	Centrum	Goudsesingel 262
Rotterdam	Centrum	Pannekoekstraat 66
Rotterdam	Centrum	Botersloot 141
Rotterdam	Centrum	Binnenrotte 15
Rotterdam	Centrum	Delfsevaart 24
Rotterdam	Centrum	Westewagenstraat 21
Rotterdam	Centrum	Grotekerkplein 10
Rotterdam	Centrum	Zijl 7
Rotterdam	Centrum	Steiger 12
Rotterdam	Centrum	Keizerstraat 108
\.


--
-- TOC entry 2132 (class 0 OID 94757)
-- Dependencies: 187
-- Data for Name: toeristische_attracties; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY toeristische_attracties (toeristische_attractie, onderwerp, bedekt, reserveren_verplicht, adres, postcode, gebied, plaats, tijden) FROM stdin;
Euromast	High Tea	Ja	Ja	Parkhaven 20	3016GM	Centrum	Rotterdam	10:00-16:00 
Euromast	Diner	Ja	Ja	Parkhaven 20	3016GM	Centrum	Rotterdam	16:00-23:00 
Euromast	Lunch	Ja	Ja	Parkhaven 20	3016GM	Centrum	Rotterdam	11:00-16:00 
Euromast	Brunch	Ja	Ja	Parkhaven 20	3016GM	Centrum	Rotterdam	10:00-12:00*
Euromast	Tokkelen	Nee	Ja	Parkhaven 20	3016GM	Centrum	Rotterdam	11:00-17:55*
Euromast	Abseilen	Nee	Ja	Parkhaven 20	3016GM	Centrum	Rotterdam	10:00-19:00*
Kubuswoningen	Architectuur	Ja	Nee	Overblaak 70	3011MH	Centrum	Rotterdam	11:00-17:00 
Kubuswoningen	Museum	Ja	Nee	Overblaak 70	3011MH	Centrum	Rotterdam	11:00-17:00 
Museum Boijmans Van Beuningen	Architectuur	Ja	Nee	Museumpark 18	3015CX	Centrum	Rotterdam	11:00-17:00*
Museum Boijmans Van Beuningen	Museum	Ja	Nee	Museumpark 18	3015CX	Centrum	Rotterdam	11:00-17:00*
Erasmusbrug	Architectuur	Nee	Nee	Erasmusbrug 1	3011BN	Centrum	Rotterdam	24/7 Open
Kunsthal Rotterdam	Architectuur	Ja	Nee	Westzeedijk 341	3015AA	Centrum	Rotterdam	10:00-17:00*
Kunsthal Rotterdam	Museum	Ja	Nee	Westzeedijk 341	3015AA	Centrum	Rotterdam	10:00-17:00*
Wereldmuseum Rotterdam	Museum	Ja	Nee	Willenskade 25	3016DM	Centrum	Rotterdam	10:30-17:30*
Grote of Sint-Laurenskerk	Architectuur	Ja	Nee	Grotekerkplein 27	3011GC	Centrum	Rotterdam	11.00-17.00 uur*
Grote of Sint-Laurenskerk	Concertgebouw	Ja	Nee	Grotekerkplein 27	3011GC	Centrum	Rotterdam	11.00-17.00 uur*
Grote of Sint-Laurenskerk	Kerkgebouw	Ja	Nee	Grotekerkplein 27	3011GC	Centrum	Rotterdam	11.00-17.00 uur*
Grote of Sint-Laurenskerk	Monument	Ja	Nee	Grotekerkplein 27	3011GC	Centrum	Rotterdam	11.00-17.00 uur*
Diergaarde Blijdorp	Dierentuin	Nee	Nee	Blijdorplaan 8	3041JG	Blijdorpse Polder	Rotterdam	09:00-18:00
Witte Huis	Architectuur	Nee	Nee	Geldersekade 1	3011WB	Centrum	Rotterdam	15:00-05:00*
Witte Huis	Cafe	Nee	Nee	Geldersekade 1	3011WB	Centrum	Rotterdam	15:00-05:00*
Witte Huis	Monument	Nee	Nee	Geldersekade 1	3011WB	Centrum	Rotterdam	15:00-05:00*
Maritiem Museum Rotterdam	Museum	Ja	Nee	Leuvehaven 1	3011EA	Centrum	Rotterdam	10:00 - 16:00
Nederlands Fotomuseum	Museum	Ja	Nee	Las Palmas, Wilhelminakade 332	3072AR	Feijenoord	Rotterdam	10:00-17:00*
Witte de With	Architectuur	Ja 	Nee	Witte de withstraat 50	3012BR	Centrum	Rotterdam	11:00-18:00*
Witte de With	Museum	Ja 	Nee	Witte de withstraat 50	3012BR	Centrum	Rotterdam	11:00-18:00*
Van Nellefabriek	Architectuur	Ja	Nee	Van Nelleweg 1	3044BC	Spaanse Polder	Rotterdam	12:00 - 14:00*
Oceanium	Dierentuin	Ja	Nee	Blijdorplaan 8	3041JG	Blijdorpse Polder	Rotterdam	09:00-18:00*
Chabot Museum	Architectuur	Ja	Nee	Museumpark 11	3015CB	Centrum	Rotterdam	11:00-16:30*
Chabot Museum	Museum	Ja	Nee	Museumpark 11	3015CB	Centrum	Rotterdam	11:00-16:30*
De Doelen	Concertgebouw	Ja	Ja	Schouwburgplein 50	3012CL	Centrum	Rotterdam	14:00 - 18:00*
Natuurhistorische Museum Rotterdam	Museum	Ja	Nee	Westzeedijk 345	3015AA	Centrum	Rotterdam	11:00-17:00*
De verwoeste stad	Monument	Nee	Nee	Plein 1940	3011EA	Centrum	Rotterdam	24/7 Open
Markthal	Architectuur	Ja	Nee	Dominee Jan Scharpstraat 298	3011GZ	Centrum	Rotterdam	10:00 - 20:00*
Markthal	Markt	Ja	Nee	Dominee Jan Scharpstraat 298	3011GZ	Centrum	Rotterdam	10:00 - 20:00*
Miniworld Rotterdam	Museum	Ja 	Nee	Weena 745	3013AL	Centrum	Rotterdam	12:00-17:00*
Plaswijckpark	Attractiepark	Nee	Nee	Ringdijk 18	3053KS	Schiebroek	Rotterdam	10:00-17:00
Plaswijckpark	Dierentuin	Nee	Nee	Ringdijk 19	3053KS	Schiebroek	Rotterdam	10:00-17:00
Plaswijckpark	Park	Nee	Nee	Ringdijk 20	3053KS	Schiebroek	Rotterdam	10:00-17:00
Het Park	Park	Nee	Nee	Westzeedijk/ GR, Parkkade	3016 CG	Centrum	Rotterdam	24/7 Open
Vroesenpark	Park	Nee	Nee	Stadhoudersweg 181	3039MC	Blijdorp	Rotterdam	24/7 Open
Oude Haven	Haven	Nee	Nee	Oude Haven	3011MG	Centrum	Rotterdam	24/7 Open
Roel Langerakpark	Park	Nee	Nee	Roel Langerakweg 25	3041JK	Blijdorpse Polder	Rotterdam	24/7 Open
Havenmuseum	Attractiepark	Nee	Nee	Leuvehaven 49	3011EA	Centrum	Rotterdam	24/7 Open
Museum Rotterdam	Museum	Ja	Nee	Rodezand 26	3011AN	Centrum	Rotterdam	10:00-17:00*
Veerhaven	Concertgebouw	Ja	Nee	Veerkade 15	3016DE	Centrum	Rotterdam	24/7 Open
Huis Sonneveld	Architectuur	Ja	Nee	Jongkindstraat 12	3015CG	Centrum	Rotterdam	11:00-17:00*
Rijnhaven	Bos	Nee	Nee	Rijnhaven 1	3072AJ	Feijenoord	Rotterdam	24/7 Open
Hop-on Hop-off Rotterdam B.V.	Stadstour	Nee	Ja	Van Vollenhovenstraat 15A	3016BE	Centrum	Rotterdam	10:00-17:00
Leuvehaven	Haven	Nee	Nee	Leuvehaven 1	3011 EA	Centrum	Rotterdam	24/7 Open
Mariniersmuseum	Museum	Ja	Nee	Wijnhaven 11	3011WH	Centrum	Rotterdam	10:00-17:00*
Stadsarchief Rotterdam	Museum	Ja	Nee	Hofdijk 651	3032CG	Agniesebuurt	Rotterdam	09:00-17:00*
Belasting & Douane Museum	Museum	Ja	Nee	Parklaan 14-16	3016BB	Centrum	Rotterdam	11:00-17:00*
Rivierahal	Tentoonstelling	Ja	Nee	Blijdorplaan 8	3041JG	Blijdorpse Polder	Rotterdam	09:00-18:00*
Dutch Pinball Museum	Museum	Ja	Nee	Paul Nijghkade 19-K	3072AN	Katendrecht	Rotterdam	12:00-18:00*
Garage Rotterdam	Tentoonstelling	Ja	Nee	Goudsewagenstraat 27	3011RH	Centrum	Rotterdam	12:30-17:30*
Schoonoord	Park	Nee	Nee	Kievitslaan 8	3016CG	Centrum	Rotterdam	08:30-16:30*
De Hef	Architectuur	Nee	Nee	De Hef	3071	Feijenoord	Rotterdam	24/7 Open
De Hef	Architectuur	Nee	Nee	De Hef	3072	Feijenoord	Rotterdam	24/7 Open
\.


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


-- Completed on 2017-04-10 15:18:11

--
-- PostgreSQL database dump complete
--

