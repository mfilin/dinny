--
-- PostgreSQL database dump
--

-- Dumped from database version 9.2.1
-- Dumped by pg_dump version 9.2.0
-- Started on 2013-03-13 16:59:01

SET statement_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;

--
-- TOC entry 183 (class 3079 OID 11727)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 1993 (class 0 OID 0)
-- Dependencies: 183
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 168 (class 1259 OID 24875)
-- Name: ctl_Dish; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE "ctl_Dish" (
    id integer NOT NULL,
    name character varying(100) NOT NULL,
    sname character varying(30),
    recipe character varying(30),
    outdish integer,
    rf_idunit integer
);


ALTER TABLE public."ctl_Dish" OWNER TO postgres;

--
-- TOC entry 169 (class 1259 OID 24878)
-- Name: ctl_DishNmk; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE "ctl_DishNmk" (
    id bigint NOT NULL,
    rf_idnmk integer,
    brutto double precision,
    netto double precision,
    loss integer,
    rf_iddish integer
);


ALTER TABLE public."ctl_DishNmk" OWNER TO postgres;

--
-- TOC entry 170 (class 1259 OID 24881)
-- Name: ctl_Nmk; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE "ctl_Nmk" (
    id integer NOT NULL,
    name character varying(100) NOT NULL,
    parentid integer,
    parent boolean,
    rf_idunit integer
);


ALTER TABLE public."ctl_Nmk" OWNER TO postgres;

--
-- TOC entry 171 (class 1259 OID 24884)
-- Name: ctl_Person; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE "ctl_Person" (
    id integer NOT NULL,
    name character varying(100) NOT NULL,
    parentid integer,
    parent boolean,
    inn character varying(30),
    kpp character varying(30)
);


ALTER TABLE public."ctl_Person" OWNER TO postgres;

--
-- TOC entry 172 (class 1259 OID 24887)
-- Name: ctl_Unit; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE "ctl_Unit" (
    id integer NOT NULL,
    name character varying(100) NOT NULL,
    sname character varying(30),
    idokei character varying(3)
);


ALTER TABLE public."ctl_Unit" OWNER TO postgres;

--
-- TOC entry 173 (class 1259 OID 24890)
-- Name: ctl_dish_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE ctl_dish_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.ctl_dish_id_seq OWNER TO postgres;

--
-- TOC entry 1994 (class 0 OID 0)
-- Dependencies: 173
-- Name: ctl_dish_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('ctl_dish_id_seq', 12, true);


--
-- TOC entry 174 (class 1259 OID 24892)
-- Name: ctl_dishnmk_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE ctl_dishnmk_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.ctl_dishnmk_id_seq OWNER TO postgres;

--
-- TOC entry 1995 (class 0 OID 0)
-- Dependencies: 174
-- Name: ctl_dishnmk_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('ctl_dishnmk_id_seq', 16, true);


--
-- TOC entry 175 (class 1259 OID 24894)
-- Name: ctl_nmk_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE ctl_nmk_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.ctl_nmk_id_seq OWNER TO postgres;

--
-- TOC entry 1996 (class 0 OID 0)
-- Dependencies: 175
-- Name: ctl_nmk_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('ctl_nmk_id_seq', 31, true);


--
-- TOC entry 176 (class 1259 OID 24896)
-- Name: ctl_person_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE ctl_person_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.ctl_person_id_seq OWNER TO postgres;

--
-- TOC entry 1997 (class 0 OID 0)
-- Dependencies: 176
-- Name: ctl_person_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('ctl_person_id_seq', 2, true);


--
-- TOC entry 177 (class 1259 OID 24898)
-- Name: ctl_unit_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE ctl_unit_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.ctl_unit_id_seq OWNER TO postgres;

--
-- TOC entry 1998 (class 0 OID 0)
-- Dependencies: 177
-- Name: ctl_unit_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('ctl_unit_id_seq', 2, true);


--
-- TOC entry 178 (class 1259 OID 24900)
-- Name: doc_Recipe; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE "doc_Recipe" (
    id bigint NOT NULL,
    rf_idorg integer,
    rf_iddish integer,
    quantity integer,
    sumcost double precision,
    onecost double precision,
    price double precision,
    ppercent double precision,
    docnumber integer,
    docdate date
);


ALTER TABLE public."doc_Recipe" OWNER TO postgres;

--
-- TOC entry 179 (class 1259 OID 24903)
-- Name: doc_RecipeCost; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE "doc_RecipeCost" (
    id bigint NOT NULL,
    rf_idrecipe integer,
    rf_iddishnmk integer,
    cost double precision,
    summa double precision
);


ALTER TABLE public."doc_RecipeCost" OWNER TO postgres;

--
-- TOC entry 180 (class 1259 OID 24906)
-- Name: doc_recipe_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE doc_recipe_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.doc_recipe_id_seq OWNER TO postgres;

--
-- TOC entry 1999 (class 0 OID 0)
-- Dependencies: 180
-- Name: doc_recipe_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('doc_recipe_id_seq', 13, true);


--
-- TOC entry 181 (class 1259 OID 24908)
-- Name: doc_recipecost_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE doc_recipecost_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.doc_recipecost_id_seq OWNER TO postgres;

--
-- TOC entry 2000 (class 0 OID 0)
-- Dependencies: 181
-- Name: doc_recipecost_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('doc_recipecost_id_seq', 33, true);


--
-- TOC entry 182 (class 1259 OID 24974)
-- Name: view_rptOP1; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW "view_rptOP1" AS
    SELECT "ctl_Person".name AS person, "ctl_Dish".name AS dish, "doc_Recipe".id AS docnum, "doc_Recipe".quantity, "doc_Recipe".sumcost, "doc_Recipe".onecost, "doc_Recipe".price, ("doc_Recipe".price - "doc_Recipe".onecost) AS pprice, "doc_Recipe".ppercent, "ctl_Nmk".name AS nmk, "ctl_Nmk".id AS idnmk, a.sname AS nameunit, a.idokei, "doc_RecipeCost".cost, "ctl_DishNmk".brutto, "ctl_DishNmk".netto, "doc_RecipeCost".summa, "ctl_Dish".outdish, b.sname AS nameunitdish FROM ((((((("doc_RecipeCost" LEFT JOIN "doc_Recipe" ON (("doc_RecipeCost".rf_idrecipe = "doc_Recipe".id))) LEFT JOIN "ctl_Person" ON (("doc_Recipe".rf_idorg = "ctl_Person".id))) LEFT JOIN "ctl_DishNmk" ON (("doc_RecipeCost".rf_iddishnmk = "ctl_DishNmk".id))) LEFT JOIN "ctl_Dish" ON (("ctl_DishNmk".rf_iddish = "ctl_Dish".id))) LEFT JOIN "ctl_Nmk" ON (("ctl_DishNmk".rf_idnmk = "ctl_Nmk".id))) LEFT JOIN "ctl_Unit" a ON (("ctl_Nmk".rf_idunit = a.id))) LEFT JOIN "ctl_Unit" b ON (("ctl_Dish".rf_idunit = b.id)));


ALTER TABLE public."view_rptOP1" OWNER TO postgres;

--
-- TOC entry 1979 (class 0 OID 24875)
-- Dependencies: 168
-- Data for Name: ctl_Dish; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "ctl_Dish" (id, name, sname, recipe, outdish, rf_idunit) FROM stdin;
1	Берлинское пирожное	\N	487	500	1
\.


--
-- TOC entry 1980 (class 0 OID 24878)
-- Dependencies: 169
-- Data for Name: ctl_DishNmk; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "ctl_DishNmk" (id, rf_idnmk, brutto, netto, loss, rf_iddish) FROM stdin;
16	27	45	40	20	1
15	27	150	145	8	1
14	28	100	200	30	1
\.


--
-- TOC entry 1981 (class 0 OID 24881)
-- Dependencies: 170
-- Data for Name: ctl_Nmk; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "ctl_Nmk" (id, name, parentid, parent, rf_idunit) FROM stdin;
23	Специи	\N	\N	\N
27	Корица молотая	23	\N	1
28	Цедра	23	\N	1
\.


--
-- TOC entry 1982 (class 0 OID 24884)
-- Dependencies: 171
-- Data for Name: ctl_Person; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "ctl_Person" (id, name, parentid, parent, inn, kpp) FROM stdin;
1	Юридические лица	\N	\N	\N	\N
2	ОАО «Волгоград-Энерго»	1	\N	111111	22222
\.


--
-- TOC entry 1983 (class 0 OID 24887)
-- Dependencies: 172
-- Data for Name: ctl_Unit; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "ctl_Unit" (id, name, sname, idokei) FROM stdin;
1	Грамм	гр.	163
2	Килограмм	кг.	166
\.


--
-- TOC entry 1984 (class 0 OID 24900)
-- Dependencies: 178
-- Data for Name: doc_Recipe; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "doc_Recipe" (id, rf_idorg, rf_iddish, quantity, sumcost, onecost, price, ppercent, docnumber, docdate) FROM stdin;
13	2	1	30	221.25	7.375	8.8499999999999996	20	\N	\N
\.


--
-- TOC entry 1985 (class 0 OID 24903)
-- Dependencies: 179
-- Data for Name: doc_RecipeCost; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "doc_RecipeCost" (id, rf_idrecipe, rf_iddishnmk, cost, summa) FROM stdin;
31	13	16	20	40
32	13	15	10	181.25
33	13	14	0	0
\.


--
-- TOC entry 1960 (class 2606 OID 24916)
-- Name: ctl_DishNmk_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "ctl_DishNmk"
    ADD CONSTRAINT "ctl_DishNmk_pkey" PRIMARY KEY (id);


--
-- TOC entry 1958 (class 2606 OID 24918)
-- Name: ctl_Dish_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "ctl_Dish"
    ADD CONSTRAINT "ctl_Dish_pkey" PRIMARY KEY (id);


--
-- TOC entry 1962 (class 2606 OID 24920)
-- Name: ctl_Nmk_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "ctl_Nmk"
    ADD CONSTRAINT "ctl_Nmk_pkey" PRIMARY KEY (id);


--
-- TOC entry 1966 (class 2606 OID 24922)
-- Name: ctl_Unit_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "ctl_Unit"
    ADD CONSTRAINT "ctl_Unit_pkey" PRIMARY KEY (id);


--
-- TOC entry 1964 (class 2606 OID 24924)
-- Name: ctl_person_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "ctl_Person"
    ADD CONSTRAINT ctl_person_pkey PRIMARY KEY (id);


--
-- TOC entry 1970 (class 2606 OID 24926)
-- Name: doc_RecipeCost_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "doc_RecipeCost"
    ADD CONSTRAINT "doc_RecipeCost_pkey" PRIMARY KEY (id);


--
-- TOC entry 1968 (class 2606 OID 24928)
-- Name: doc_Recipe_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "doc_Recipe"
    ADD CONSTRAINT "doc_Recipe_pkey" PRIMARY KEY (id);


--
-- TOC entry 1977 (class 2606 OID 24929)
-- Name: fk_cost_dishnmk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "doc_RecipeCost"
    ADD CONSTRAINT fk_cost_dishnmk FOREIGN KEY (rf_iddishnmk) REFERENCES "ctl_DishNmk"(id) ON DELETE CASCADE;


--
-- TOC entry 1971 (class 2606 OID 24934)
-- Name: fk_ctl_Dish_Unit; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "ctl_Dish"
    ADD CONSTRAINT "fk_ctl_Dish_Unit" FOREIGN KEY (rf_idunit) REFERENCES "ctl_Unit"(id) ON DELETE CASCADE;


--
-- TOC entry 1972 (class 2606 OID 24939)
-- Name: fk_ctl_dishnmk_dish; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "ctl_DishNmk"
    ADD CONSTRAINT fk_ctl_dishnmk_dish FOREIGN KEY (rf_iddish) REFERENCES "ctl_Dish"(id) ON DELETE CASCADE;


--
-- TOC entry 1973 (class 2606 OID 24944)
-- Name: fk_ctl_dishnmk_nmk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "ctl_DishNmk"
    ADD CONSTRAINT fk_ctl_dishnmk_nmk FOREIGN KEY (rf_idnmk) REFERENCES "ctl_Nmk"(id) ON DELETE CASCADE;


--
-- TOC entry 1974 (class 2606 OID 24949)
-- Name: fk_ctl_nmk_parent; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "ctl_Nmk"
    ADD CONSTRAINT fk_ctl_nmk_parent FOREIGN KEY (parentid) REFERENCES "ctl_Nmk"(id);


--
-- TOC entry 1975 (class 2606 OID 24954)
-- Name: fk_ctl_nmk_unit; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "ctl_Nmk"
    ADD CONSTRAINT fk_ctl_nmk_unit FOREIGN KEY (rf_idunit) REFERENCES "ctl_Unit"(id) ON DELETE CASCADE;


--
-- TOC entry 1976 (class 2606 OID 24959)
-- Name: fk_ctl_person_parent; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "ctl_Person"
    ADD CONSTRAINT fk_ctl_person_parent FOREIGN KEY (parentid) REFERENCES "ctl_Person"(id);


--
-- TOC entry 1978 (class 2606 OID 24964)
-- Name: fk_recipe_recipecost; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "doc_RecipeCost"
    ADD CONSTRAINT fk_recipe_recipecost FOREIGN KEY (rf_idrecipe) REFERENCES "doc_Recipe"(id) ON DELETE CASCADE;


--
-- TOC entry 1992 (class 0 OID 0)
-- Dependencies: 6
-- Name: public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;


-- Completed on 2013-03-13 16:59:04

--
-- PostgreSQL database dump complete
--

