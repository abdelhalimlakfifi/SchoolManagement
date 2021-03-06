/*==============================================================*/
/* Nom de SGBD :  Microsoft SQL Server 2000                     */
/* Date de cr?ation :  6/9/2021 10:39:36 AM                     */
/*==============================================================*/


if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ABSENCE') and o.name = 'FK_ABSENCE_S_ABSENTE_ETUDIANT')
alter table ABSENCE
   drop constraint FK_ABSENCE_S_ABSENTE_ETUDIANT
go

if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLACEMENT') and o.name = 'FK_EMPLACEM_EMPLACEME_MODULE')
alter table EMPLACEMENT
   drop constraint FK_EMPLACEM_EMPLACEME_MODULE
go

if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLACEMENT') and o.name = 'FK_EMPLACEM_EMPLACEME_SALLE')
alter table EMPLACEMENT
   drop constraint FK_EMPLACEM_EMPLACEME_SALLE
go

if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ENSEIGNEMENT') and o.name = 'FK_ENSEIGNE_ENSEIGNEM_MODULE')
alter table ENSEIGNEMENT
   drop constraint FK_ENSEIGNE_ENSEIGNEM_MODULE
go

if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ENSEIGNEMENT') and o.name = 'FK_ENSEIGNE_ENSEIGNEM_PROF')
alter table ENSEIGNEMENT
   drop constraint FK_ENSEIGNE_ENSEIGNEM_PROF
go

if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ETUDIANT') and o.name = 'FK_ETUDIANT_CHOIXFILL_FILIER')
alter table ETUDIANT
   drop constraint FK_ETUDIANT_CHOIXFILL_FILIER
go

if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ETUDIANT') and o.name = 'FK_ETUDIANT_INSCRIPTI_ADMINIST')
alter table ETUDIANT
   drop constraint FK_ETUDIANT_INSCRIPTI_ADMINIST
go

if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FACTURE') and o.name = 'FK_FACTURE_EFFECTUER_ADMINIST')
alter table FACTURE
   drop constraint FK_FACTURE_EFFECTUER_ADMINIST
go

if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FACTURE') and o.name = 'FK_FACTURE_PAIMENT_ETUDIANT')
alter table FACTURE
   drop constraint FK_FACTURE_PAIMENT_ETUDIANT
go

if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INTEGRATION') and o.name = 'FK_INTEGRAT_INTEGRATI_MODULE')
alter table INTEGRATION
   drop constraint FK_INTEGRAT_INTEGRATI_MODULE
go

if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INTEGRATION') and o.name = 'FK_INTEGRAT_INTEGRATI_FILIER')
alter table INTEGRATION
   drop constraint FK_INTEGRAT_INTEGRATI_FILIER
go

if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NOTES') and o.name = 'FK_NOTES_NOTE_MODULE')
alter table NOTES
   drop constraint FK_NOTES_NOTE_MODULE
go

if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NOTES') and o.name = 'FK_NOTES_NOTEDONNE_PROF')
alter table NOTES
   drop constraint FK_NOTES_NOTEDONNE_PROF
go

if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NOTES') and o.name = 'FK_NOTES_NOTEPRIS_ETUDIANT')
alter table NOTES
   drop constraint FK_NOTES_NOTEPRIS_ETUDIANT
go

if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROF') and o.name = 'FK_PROF_AJOUT_PRO_ADMINIST')
alter table PROF
   drop constraint FK_PROF_AJOUT_PRO_ADMINIST
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ABSENCE')
            and   type = 'U')
   drop table ABSENCE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMINISTRATEUR')
            and   type = 'U')
   drop table ADMINISTRATEUR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLACEMENT')
            and   type = 'U')
   drop table EMPLACEMENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ENSEIGNEMENT')
            and   type = 'U')
   drop table ENSEIGNEMENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ETUDIANT')
            and   type = 'U')
   drop table ETUDIANT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FACTURE')
            and   type = 'U')
   drop table FACTURE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FILIER')
            and   type = 'U')
   drop table FILIER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INTEGRATION')
            and   type = 'U')
   drop table INTEGRATION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MODULE')
            and   type = 'U')
   drop table MODULE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NOTES')
            and   type = 'U')
   drop table NOTES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PROF')
            and   type = 'U')
   drop table PROF
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SALLE')
            and   type = 'U')
   drop table SALLE
go

/*==============================================================*/
/* Table : ABSENCE                                              */
/*==============================================================*/
create table ABSENCE (
   ID_ABSENCE           int                  not null,
   ID_ETUDIANT          int                  not null,
   DATE                 datetime             null,
   constraint PK_ABSENCE primary key nonclustered (ID_ABSENCE)
)
go

/*==============================================================*/
/* Table : ADMINISTRATEUR                                       */
/*==============================================================*/
create table ADMINISTRATEUR (
   ID_ADMIN             int                  not null,
   NOM                  varchar(1)           null,
   PRENOM               varchar(1)           null,
   NUM_TELEPHONE        varchar(1)           null,
   EMAIL                varchar(1)           null,
   SURNOM               varchar(1)           null,
   PASSWORD             varchar(1)           null,
   constraint PK_ADMINISTRATEUR primary key nonclustered (ID_ADMIN)
)
go

/*==============================================================*/
/* Table : EMPLACEMENT                                          */
/*==============================================================*/
create table EMPLACEMENT (
   ID_SALLE             int                  not null,
   ID_MODULE            int                  not null,
   constraint PK_EMPLACEMENT primary key nonclustered (ID_SALLE, ID_MODULE)
)
go

/*==============================================================*/
/* Table : ENSEIGNEMENT                                         */
/*==============================================================*/
create table ENSEIGNEMENT (
   ID_PROF              int                  not null,
   ID_MODULE            int                  not null,
   constraint PK_ENSEIGNEMENT primary key nonclustered (ID_PROF, ID_MODULE)
)
go

/*==============================================================*/
/* Table : ETUDIANT                                             */
/*==============================================================*/
create table ETUDIANT (
   ID_ETUDIANT          int                  not null,
   ID_ADMIN             int                  not null,
   ID_FILIER            int                  not null,
   NOM                  varchar(1)           null,
   PRENOM               varchar(1)           null,
   ADRESSE              varchar(1)           null,
   TELEPHONE            varchar(1)           null,
   AUTRE_PHONE          varchar(1)           null,
   PHOTOS               varchar(1)           null,
   SURNOM               varchar(1)           null,
   MOTS_DE_PASSE        varchar(1)           null,
   constraint PK_ETUDIANT primary key nonclustered (ID_ETUDIANT)
)
go

/*==============================================================*/
/* Table : FACTURE                                              */
/*==============================================================*/
create table FACTURE (
   ID_FACTURE           int                  not null,
   ID_ETUDIANT          int                  not null,
   ID_ADMIN             int                  not null,
   MONTANT              numeric(8,2)         null,
   MOISPAYE             varchar(1)           null,
   DATE                 datetime             null,
   constraint PK_FACTURE primary key nonclustered (ID_FACTURE)
)
go

/*==============================================================*/
/* Table : FILIER                                               */
/*==============================================================*/
create table FILIER (
   ID_FILIER            int                  not null,
   NOM                  varchar(1)           null,
   SPECIALITE           varchar(1)           null,
   constraint PK_FILIER primary key nonclustered (ID_FILIER)
)
go

/*==============================================================*/
/* Table : INTEGRATION                                          */
/*==============================================================*/
create table INTEGRATION (
   ID_FILIER            int                  not null,
   ID_MODULE            int                  not null,
   constraint PK_INTEGRATION primary key nonclustered (ID_FILIER, ID_MODULE)
)
go

/*==============================================================*/
/* Table : MODULE                                               */
/*==============================================================*/
create table MODULE (
   ID_MODULE            int                  not null,
   MODULE               varchar(1)           null,
   COEFFICIENT          int                  null,
   constraint PK_MODULE primary key nonclustered (ID_MODULE)
)
go

/*==============================================================*/
/* Table : NOTES                                                */
/*==============================================================*/
create table NOTES (
   ID_NOTE              int                  not null,
   ID_MODULE            int                  not null,
   ID_PROF              int                  not null,
   ID_ETUDIANT          int                  not null,
   LA_NOTE              int                  null,
   REMARQUE             varchar(1)           null,
   constraint PK_NOTES primary key nonclustered (ID_NOTE)
)
go

/*==============================================================*/
/* Table : PROF                                                 */
/*==============================================================*/
create table PROF (
   ID_PROF              int                  not null,
   ID_ADMIN             int                  not null,
   NOM                  varchar(1)           null,
   PRENOM               varchar(1)           null,
   NUM_TELEPHONE        varchar(1)           null,
   SALAIRE              numeric(8,2)         null,
   CIN                  varchar(1)           null,
   SURNOM               varchar(1)           null,
   PASSWORD             varchar(1)           null,
   constraint PK_PROF primary key nonclustered (ID_PROF)
)
go

/*==============================================================*/
/* Table : SALLE                                                */
/*==============================================================*/
create table SALLE (
   ID_SALLE             int                  not null,
   NOM_SALLE            varchar(1)           null,
   TYPE                 varchar(1)           null,
   constraint PK_SALLE primary key nonclustered (ID_SALLE)
)
go

alter table ABSENCE
   add constraint FK_ABSENCE_S_ABSENTE_ETUDIANT foreign key (ID_ETUDIANT)
      references ETUDIANT (ID_ETUDIANT)
go

alter table EMPLACEMENT
   add constraint FK_EMPLACEM_EMPLACEME_MODULE foreign key (ID_MODULE)
      references MODULE (ID_MODULE)
go

alter table EMPLACEMENT
   add constraint FK_EMPLACEM_EMPLACEME_SALLE foreign key (ID_SALLE)
      references SALLE (ID_SALLE)
go

alter table ENSEIGNEMENT
   add constraint FK_ENSEIGNE_ENSEIGNEM_MODULE foreign key (ID_MODULE)
      references MODULE (ID_MODULE)
go

alter table ENSEIGNEMENT
   add constraint FK_ENSEIGNE_ENSEIGNEM_PROF foreign key (ID_PROF)
      references PROF (ID_PROF)
go

alter table ETUDIANT
   add constraint FK_ETUDIANT_CHOIXFILL_FILIER foreign key (ID_FILIER)
      references FILIER (ID_FILIER)
go

alter table ETUDIANT
   add constraint FK_ETUDIANT_INSCRIPTI_ADMINIST foreign key (ID_ADMIN)
      references ADMINISTRATEUR (ID_ADMIN)
go

alter table FACTURE
   add constraint FK_FACTURE_EFFECTUER_ADMINIST foreign key (ID_ADMIN)
      references ADMINISTRATEUR (ID_ADMIN)
go

alter table FACTURE
   add constraint FK_FACTURE_PAIMENT_ETUDIANT foreign key (ID_ETUDIANT)
      references ETUDIANT (ID_ETUDIANT)
go

alter table INTEGRATION
   add constraint FK_INTEGRAT_INTEGRATI_MODULE foreign key (ID_MODULE)
      references MODULE (ID_MODULE)
go

alter table INTEGRATION
   add constraint FK_INTEGRAT_INTEGRATI_FILIER foreign key (ID_FILIER)
      references FILIER (ID_FILIER)
go

alter table NOTES
   add constraint FK_NOTES_NOTE_MODULE foreign key (ID_MODULE)
      references MODULE (ID_MODULE)
go

alter table NOTES
   add constraint FK_NOTES_NOTEDONNE_PROF foreign key (ID_PROF)
      references PROF (ID_PROF)
go

alter table NOTES
   add constraint FK_NOTES_NOTEPRIS_ETUDIANT foreign key (ID_ETUDIANT)
      references ETUDIANT (ID_ETUDIANT)
go

alter table PROF
   add constraint FK_PROF_AJOUT_PRO_ADMINIST foreign key (ID_ADMIN)
      references ADMINISTRATEUR (ID_ADMIN)
go

