--------------------------------------------------------
--  Fichier créé - mardi-janvier-09-2018   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table EQUIPE
--------------------------------------------------------

  CREATE TABLE "FOOT"."EQUIPE" 
   (	"CLASSEMENT" NUMBER(20,0), 
	"NOM" VARCHAR2(20 BYTE), 
	"TEAMCATEGORY" VARCHAR2(10 BYTE), 
	"FLAG" VARCHAR2(20 BYTE), 
	"CONTINENT" VARCHAR2(20 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
REM INSERTING into FOOT.EQUIPE
SET DEFINE OFF;
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('0','Russie','A','rus','euro');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('2','Bresil','A','bra','southa');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('3','Portugal','A','por','euro');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('4','Argentine','A','arg','southa');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('5','Belgique','A','bel','euro');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('8','Espagne','A','esp','euro');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('6','Poland','A','pol','euro');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('10','Suisse','A','sui','euro');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('7','France','A','fra','euro');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('9','Perou','A','per','southa');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('16','Danemark','A','den','euro');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('11','Angleterre','A','eng','euro');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('13','Mexique','A','mex','northa');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('15','Croatie','A','cro','euro');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('19','Suede','A','swe','euro');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('14','Uruguay','A','uru','southa');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('17','Islande','A','isl','euro');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('22','Senegal','A','sen','africa');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('18','CostaRica','A','crc','northa');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('20','Tunisie','A','tun','africa');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('21','Egypte','A','egy','africa');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('23','Iran','A','irn','asia');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('26','Australie','A','aus','asia');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('28','Maroc','A','mar','africa');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('25','Nigeria','A','nga','africa');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('27','Japon','A','jpn','asia');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('29','Panama','A','pan','northa');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('30','KoreaRep','A','kor','asia');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('31','A_Saoudite','A','ksa','asia');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('24','Serbia','A','srb','euro');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('1','Allemagne','A','ger','euro');
Insert into FOOT.EQUIPE (CLASSEMENT,NOM,TEAMCATEGORY,FLAG,CONTINENT) values ('12','Colombia','A','col','southa');
