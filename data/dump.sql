--
-- PostgreSQL database dump
--

-- Dumped from database version 9.2.3
-- Dumped by pg_dump version 9.2.0
-- Started on 2013-05-16 10:44:01

SET statement_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;

--
-- TOC entry 191 (class 3079 OID 11727)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 2034 (class 0 OID 0)
-- Dependencies: 191
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 168 (class 1259 OID 16489)
-- Name: ctl_Dish; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE "ctl_Dish" (
    id integer NOT NULL,
    name character varying(100) NOT NULL,
    sname character varying(30),
    recipe character varying(30),
    outdish integer,
    rf_idunit integer,
    tprocess text
);


ALTER TABLE public."ctl_Dish" OWNER TO postgres;

--
-- TOC entry 169 (class 1259 OID 16495)
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
-- TOC entry 170 (class 1259 OID 16498)
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
-- TOC entry 171 (class 1259 OID 16501)
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
-- TOC entry 172 (class 1259 OID 16504)
-- Name: ctl_Setting; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE "ctl_Setting" (
    id integer NOT NULL,
    name character varying(30),
    value character varying(250)
);


ALTER TABLE public."ctl_Setting" OWNER TO postgres;

--
-- TOC entry 173 (class 1259 OID 16507)
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
-- TOC entry 174 (class 1259 OID 16510)
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
-- TOC entry 2035 (class 0 OID 0)
-- Dependencies: 174
-- Name: ctl_dish_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('ctl_dish_id_seq', 16, true);


--
-- TOC entry 175 (class 1259 OID 16512)
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
-- TOC entry 2036 (class 0 OID 0)
-- Dependencies: 175
-- Name: ctl_dishnmk_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('ctl_dishnmk_id_seq', 29, true);


--
-- TOC entry 176 (class 1259 OID 16514)
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
-- TOC entry 2037 (class 0 OID 0)
-- Dependencies: 176
-- Name: ctl_nmk_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('ctl_nmk_id_seq', 58, true);


--
-- TOC entry 177 (class 1259 OID 16516)
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
-- TOC entry 2038 (class 0 OID 0)
-- Dependencies: 177
-- Name: ctl_person_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('ctl_person_id_seq', 4, true);


--
-- TOC entry 178 (class 1259 OID 16518)
-- Name: ctl_setting_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE ctl_setting_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.ctl_setting_id_seq OWNER TO postgres;

--
-- TOC entry 2039 (class 0 OID 0)
-- Dependencies: 178
-- Name: ctl_setting_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('ctl_setting_id_seq', 3, true);


--
-- TOC entry 179 (class 1259 OID 16520)
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
-- TOC entry 2040 (class 0 OID 0)
-- Dependencies: 179
-- Name: ctl_unit_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('ctl_unit_id_seq', 4, true);


--
-- TOC entry 180 (class 1259 OID 16522)
-- Name: doc_Delivery; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE "doc_Delivery" (
    id integer NOT NULL,
    docnumber integer,
    docdate date,
    department character varying(30)
);


ALTER TABLE public."doc_Delivery" OWNER TO postgres;

--
-- TOC entry 181 (class 1259 OID 16525)
-- Name: doc_DeliveryCost; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE "doc_DeliveryCost" (
    id integer NOT NULL,
    rf_nmkid integer,
    rf_unitid integer,
    quantity double precision,
    price double precision,
    pricep double precision,
    rf_iddelivery integer
);


ALTER TABLE public."doc_DeliveryCost" OWNER TO postgres;

--
-- TOC entry 182 (class 1259 OID 16528)
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
-- TOC entry 183 (class 1259 OID 16531)
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
-- TOC entry 184 (class 1259 OID 16534)
-- Name: doc_delivery_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE doc_delivery_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.doc_delivery_id_seq OWNER TO postgres;

--
-- TOC entry 2041 (class 0 OID 0)
-- Dependencies: 184
-- Name: doc_delivery_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('doc_delivery_id_seq', 13, true);


--
-- TOC entry 185 (class 1259 OID 16536)
-- Name: doc_deliverycost_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE doc_deliverycost_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.doc_deliverycost_id_seq OWNER TO postgres;

--
-- TOC entry 2042 (class 0 OID 0)
-- Dependencies: 185
-- Name: doc_deliverycost_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('doc_deliverycost_id_seq', 21, true);


--
-- TOC entry 186 (class 1259 OID 16538)
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
-- TOC entry 2043 (class 0 OID 0)
-- Dependencies: 186
-- Name: doc_recipe_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('doc_recipe_id_seq', 16, true);


--
-- TOC entry 187 (class 1259 OID 16540)
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
-- TOC entry 2044 (class 0 OID 0)
-- Dependencies: 187
-- Name: doc_recipecost_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('doc_recipecost_id_seq', 40, true);


--
-- TOC entry 188 (class 1259 OID 16542)
-- Name: view_rptDelivery; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW "view_rptDelivery" AS
    SELECT a.id, a.docnumber, a.docdate, a.department, nmk.name AS nmkname, b.quantity, b.price, b.pricep, (b.quantity * b.price) AS sumprice, (b.quantity * b.pricep) AS sumpricep, (((100)::double precision * b.pricep) / b.price) AS percent FROM (("doc_Delivery" a JOIN "doc_DeliveryCost" b ON ((a.id = b.rf_iddelivery))) JOIN "ctl_Nmk" nmk ON ((nmk.id = b.rf_nmkid)));


ALTER TABLE public."view_rptDelivery" OWNER TO postgres;

--
-- TOC entry 189 (class 1259 OID 16547)
-- Name: view_rptOP1; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW "view_rptOP1" AS
    SELECT "ctl_Person".name AS person, "ctl_Dish".name AS dish, "doc_Recipe".id, "doc_Recipe".docnumber AS docnum, "doc_Recipe".docdate, "doc_Recipe".quantity, "doc_Recipe".sumcost, "doc_Recipe".onecost, "doc_Recipe".price, ("doc_Recipe".price - "doc_Recipe".onecost) AS pprice, "doc_Recipe".ppercent, "ctl_Nmk".name AS nmk, "ctl_Nmk".id AS idnmk, a.sname AS nameunit, a.idokei, "doc_RecipeCost".cost, "ctl_DishNmk".brutto, "ctl_DishNmk".netto, "doc_RecipeCost".summa, "ctl_Dish".outdish, b.sname AS nameunitdish FROM ((((((("doc_RecipeCost" LEFT JOIN "doc_Recipe" ON (("doc_RecipeCost".rf_idrecipe = "doc_Recipe".id))) LEFT JOIN "ctl_Person" ON (("doc_Recipe".rf_idorg = "ctl_Person".id))) LEFT JOIN "ctl_DishNmk" ON (("doc_RecipeCost".rf_iddishnmk = "ctl_DishNmk".id))) LEFT JOIN "ctl_Dish" ON (("ctl_DishNmk".rf_iddish = "ctl_Dish".id))) LEFT JOIN "ctl_Nmk" ON (("ctl_DishNmk".rf_idnmk = "ctl_Nmk".id))) LEFT JOIN "ctl_Unit" a ON (("ctl_Nmk".rf_idunit = a.id))) LEFT JOIN "ctl_Unit" b ON (("ctl_Dish".rf_idunit = b.id)));


ALTER TABLE public."view_rptOP1" OWNER TO postgres;

--
-- TOC entry 190 (class 1259 OID 16552)
-- Name: view_rptTCard; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW "view_rptTCard" AS
    SELECT "ctl_Dish".id AS docnum, "ctl_Dish".recipe, "ctl_Dish".name, "ctl_Dish".sname, "ctl_Dish".outdish, "ctl_Dish".tprocess, "ctl_Nmk".name AS nmkname, "ctl_DishNmk".brutto, "ctl_DishNmk".netto, "ctl_DishNmk".loss FROM (("ctl_Dish" JOIN "ctl_DishNmk" ON (("ctl_DishNmk".rf_iddish = "ctl_Dish".id))) JOIN "ctl_Nmk" ON (("ctl_DishNmk".rf_idnmk = "ctl_Nmk".id)));


ALTER TABLE public."view_rptTCard" OWNER TO postgres;

--
-- TOC entry 2017 (class 0 OID 16489)
-- Dependencies: 168
-- Data for Name: ctl_Dish; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "ctl_Dish" (id, name, sname, recipe, outdish, rf_idunit, tprocess) FROM stdin;
14	картофель отварной	картофель отварной	\N	168	4	\N
16	тест тест	\N	11	0	\N	4.1 Подготовка сырья к производству блюда (!!!) производится в соответствии со Сборником рецептур блюд и кулинарных изделий для предприятий общественного питания (1994г.)\n\n5. Оформление, подача, реализация и хранение\n\n5.1 Блюдо подают на закусочной тарелке.\n5.2 Температура подачи должна быть не менее 65 градусов по Цельсию\n5.3 Срок реализации данного блюда при хранении на мармите или горячей плите - не более 3 часов с момента      окончания технологического процесса .\n\n6. Показатели качества и безопасности\n6.1 Органолептические показатели блюда:\n\tВнешний вид -\n\tКонсистенция -\n\tЦвет -\n\tВкус и запах -\n     Физико-химические показатели:\n           Массовая доля сухих веществ, %(не менее) - \t\n           Массовая доля жира, %(не менее) -\t\n           Массовая доля жира, %(не менее) - \t\n6.3 Микробиологические показатели:\n\tКМАФАнМ, КОЕ/г, не более 1x10\n\tМасса продукта(г), в которой не допускаются:\n·\tБГКП:\n·\tE coli:\n·\tS aureus:\n·\tProteus:\n·\tПатогенные, в т.ч. сальмонеллы:\nПримечания:\n
\.


--
-- TOC entry 2018 (class 0 OID 16495)
-- Dependencies: 169
-- Data for Name: ctl_DishNmk; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "ctl_DishNmk" (id, rf_idnmk, brutto, netto, loss, rf_iddish) FROM stdin;
25	37	0.20000000000000001	0.14999999999999999	1	14
26	39	0.016	0.014999999999999999	1	14
27	40	0.0040000000000000001	0.0030000000000000001	1	14
29	39	111	111	21	16
\.


--
-- TOC entry 2019 (class 0 OID 16498)
-- Dependencies: 170
-- Data for Name: ctl_Nmk; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "ctl_Nmk" (id, name, parentid, parent, rf_idunit) FROM stdin;
23	Специи	\N	\N	\N
27	Корица молотая	23	\N	1
28	Цедра	23	\N	1
38	Компоненты	\N	\N	\N
39	Сливочное масло	38	\N	2
49	сигареты	\N	\N	\N
50	С/Винстон  супер слим	49	\N	\N
51	Парламент найт блю	49	\N	\N
52	Кент №8	49	\N	\N
53	Кент № 4	49	\N	\N
54	Кисс дрим	49	\N	\N
55	Кисс энерджи	49	\N	\N
56	Кисс клубника	49	\N	\N
57	кент тонкий черный 	49	\N	\N
58	Парламент аква блю	49	\N	\N
32	Овощи	\N	\N	2
33	Лук репчатый	32	t	2
35	Морковь	33	\N	2
36	Морковь	33	\N	2
37	Картофель	32	\N	2
40	Зелень	32	\N	2
42	Морковь	32	\N	2
46	чеснок	32	\N	2
47	свекла	32	\N	2
48	капуста	32	\N	2
\.


--
-- TOC entry 2020 (class 0 OID 16501)
-- Dependencies: 171
-- Data for Name: ctl_Person; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "ctl_Person" (id, name, parentid, parent, inn, kpp) FROM stdin;
3	ООО "Бизнес-Клуб"	\N	\N	3435095613	343501001
1	Организации	\N	\N	\N	\N
2	ОАО «Волгоград-Энерго»	1	\N	111111	22222
4	Физические лица	\N	\N	\N	\N
\.


--
-- TOC entry 2021 (class 0 OID 16504)
-- Dependencies: 172
-- Data for Name: ctl_Setting; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "ctl_Setting" (id, name, value) FROM stdin;
1	ORG_NAME	ООО Бизнес клуб
2	DIR_NAME	Директор
3	DIR_FIO	Иванов И.И.
4	INN	3435095613
5	SUB_ORG	Кафе Бизнес-Клуб
6	ORG_ADRES	г.Волжский, ул. Карбыщева, 76
\.


--
-- TOC entry 2022 (class 0 OID 16507)
-- Dependencies: 173
-- Data for Name: ctl_Unit; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "ctl_Unit" (id, name, sname, idokei) FROM stdin;
1	Грамм	гр.	163
2	Килограмм	кг.	166
4	грамм	гр	\N
\.


--
-- TOC entry 2023 (class 0 OID 16522)
-- Dependencies: 180
-- Data for Name: doc_Delivery; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "doc_Delivery" (id, docnumber, docdate, department) FROM stdin;
10	1	2013-04-24	КУХНЯ
11	2	2013-05-16	КУХНЯ
12	3	2013-05-16	БАР
\.


--
-- TOC entry 2024 (class 0 OID 16525)
-- Dependencies: 181
-- Data for Name: doc_DeliveryCost; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "doc_DeliveryCost" (id, rf_nmkid, rf_unitid, quantity, price, pricep, rf_iddelivery) FROM stdin;
8	39	2	10	200	300	10
9	37	2	25	35	0	11
10	33	2	10	32	0	11
11	42	2	10	26	0	11
12	46	2	1	90	0	11
13	47	2	10	25	0	11
14	48	2	10	20	0	11
15	50	\N	10	45	50	12
16	51	\N	10	78	83	12
17	52	\N	10	65	70	12
18	53	\N	10	65	70	12
19	54	\N	10	35	40	12
20	55	\N	10	35	40	12
\.


--
-- TOC entry 2025 (class 0 OID 16528)
-- Dependencies: 182
-- Data for Name: doc_Recipe; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "doc_Recipe" (id, rf_idorg, rf_iddish, quantity, sumcost, onecost, price, ppercent, docnumber, docdate) FROM stdin;
16	4	14	77	2.0129999999999999	0.0261428571428571	0	NaN	1	2013-04-12
\.


--
-- TOC entry 2026 (class 0 OID 16531)
-- Dependencies: 183
-- Data for Name: doc_RecipeCost; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY "doc_RecipeCost" (id, rf_idrecipe, rf_iddishnmk, cost, summa) FROM stdin;
38	16	25	12	1.8
39	16	26	12	0.17999999999999999
40	16	27	11	0.033000000000000002
\.


--
-- TOC entry 1989 (class 2606 OID 16557)
-- Name: ctl_DishNmk_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "ctl_DishNmk"
    ADD CONSTRAINT "ctl_DishNmk_pkey" PRIMARY KEY (id);


--
-- TOC entry 1987 (class 2606 OID 16559)
-- Name: ctl_Dish_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "ctl_Dish"
    ADD CONSTRAINT "ctl_Dish_pkey" PRIMARY KEY (id);


--
-- TOC entry 1991 (class 2606 OID 16561)
-- Name: ctl_Nmk_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "ctl_Nmk"
    ADD CONSTRAINT "ctl_Nmk_pkey" PRIMARY KEY (id);


--
-- TOC entry 1995 (class 2606 OID 16563)
-- Name: ctl_Setting_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "ctl_Setting"
    ADD CONSTRAINT "ctl_Setting_pkey" PRIMARY KEY (id);


--
-- TOC entry 1997 (class 2606 OID 16565)
-- Name: ctl_Unit_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "ctl_Unit"
    ADD CONSTRAINT "ctl_Unit_pkey" PRIMARY KEY (id);


--
-- TOC entry 1993 (class 2606 OID 16567)
-- Name: ctl_person_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "ctl_Person"
    ADD CONSTRAINT ctl_person_pkey PRIMARY KEY (id);


--
-- TOC entry 2001 (class 2606 OID 16569)
-- Name: doc_DeliveryCost_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "doc_DeliveryCost"
    ADD CONSTRAINT "doc_DeliveryCost_pkey" PRIMARY KEY (id);


--
-- TOC entry 1999 (class 2606 OID 16571)
-- Name: doc_Delivery_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "doc_Delivery"
    ADD CONSTRAINT "doc_Delivery_pkey" PRIMARY KEY (id);


--
-- TOC entry 2005 (class 2606 OID 16573)
-- Name: doc_RecipeCost_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "doc_RecipeCost"
    ADD CONSTRAINT "doc_RecipeCost_pkey" PRIMARY KEY (id);


--
-- TOC entry 2003 (class 2606 OID 16575)
-- Name: doc_Recipe_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY "doc_Recipe"
    ADD CONSTRAINT "doc_Recipe_pkey" PRIMARY KEY (id);


--
-- TOC entry 2015 (class 2606 OID 16576)
-- Name: fk_cost_dishnmk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "doc_RecipeCost"
    ADD CONSTRAINT fk_cost_dishnmk FOREIGN KEY (rf_iddishnmk) REFERENCES "ctl_DishNmk"(id) ON DELETE CASCADE;


--
-- TOC entry 2006 (class 2606 OID 16581)
-- Name: fk_ctl_Dish_Unit; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "ctl_Dish"
    ADD CONSTRAINT "fk_ctl_Dish_Unit" FOREIGN KEY (rf_idunit) REFERENCES "ctl_Unit"(id) ON DELETE CASCADE;


--
-- TOC entry 2007 (class 2606 OID 16586)
-- Name: fk_ctl_dishnmk_dish; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "ctl_DishNmk"
    ADD CONSTRAINT fk_ctl_dishnmk_dish FOREIGN KEY (rf_iddish) REFERENCES "ctl_Dish"(id) ON DELETE CASCADE;


--
-- TOC entry 2008 (class 2606 OID 16591)
-- Name: fk_ctl_dishnmk_nmk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "ctl_DishNmk"
    ADD CONSTRAINT fk_ctl_dishnmk_nmk FOREIGN KEY (rf_idnmk) REFERENCES "ctl_Nmk"(id) ON DELETE CASCADE;


--
-- TOC entry 2009 (class 2606 OID 16596)
-- Name: fk_ctl_nmk_parent; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "ctl_Nmk"
    ADD CONSTRAINT fk_ctl_nmk_parent FOREIGN KEY (parentid) REFERENCES "ctl_Nmk"(id);


--
-- TOC entry 2010 (class 2606 OID 16601)
-- Name: fk_ctl_nmk_unit; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "ctl_Nmk"
    ADD CONSTRAINT fk_ctl_nmk_unit FOREIGN KEY (rf_idunit) REFERENCES "ctl_Unit"(id) ON DELETE CASCADE;


--
-- TOC entry 2011 (class 2606 OID 16606)
-- Name: fk_ctl_person_parent; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "ctl_Person"
    ADD CONSTRAINT fk_ctl_person_parent FOREIGN KEY (parentid) REFERENCES "ctl_Person"(id);


--
-- TOC entry 2012 (class 2606 OID 16611)
-- Name: fk_deliverycost; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "doc_DeliveryCost"
    ADD CONSTRAINT fk_deliverycost FOREIGN KEY (rf_iddelivery) REFERENCES "doc_Delivery"(id) ON DELETE CASCADE;


--
-- TOC entry 2013 (class 2606 OID 16616)
-- Name: fk_nmk_delivery; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "doc_DeliveryCost"
    ADD CONSTRAINT fk_nmk_delivery FOREIGN KEY (rf_nmkid) REFERENCES "ctl_Nmk"(id) ON DELETE CASCADE;


--
-- TOC entry 2016 (class 2606 OID 16621)
-- Name: fk_recipe_recipecost; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "doc_RecipeCost"
    ADD CONSTRAINT fk_recipe_recipecost FOREIGN KEY (rf_idrecipe) REFERENCES "doc_Recipe"(id) ON DELETE CASCADE;


--
-- TOC entry 2014 (class 2606 OID 16626)
-- Name: fk_unit_delivery; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY "doc_DeliveryCost"
    ADD CONSTRAINT fk_unit_delivery FOREIGN KEY (rf_unitid) REFERENCES "ctl_Unit"(id) ON DELETE CASCADE;


--
-- TOC entry 2033 (class 0 OID 0)
-- Dependencies: 6
-- Name: public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;


-- Completed on 2013-05-16 10:44:02

--
-- PostgreSQL database dump complete
--

