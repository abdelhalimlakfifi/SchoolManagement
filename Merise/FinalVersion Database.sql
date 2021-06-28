/*==============================================================*/
/* Nom de SGBD :  Microsoft SQL Server 2000                     */
/* Date de création :  6/9/2021 10:39:36 AM                     */
/*==============================================================*/


if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ABSENCE') and o.name = 'FK_ABSENCE_S_ABSENTE_ETUDIANT')
alter table ABSENCE
   drop constraint FK_ABSENCE_S_ABSENTE_ETUDIANT


if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLACEMENT') and o.name = 'FK_EMPLACEM_EMPLACEME_MODULE')
alter table EMPLACEMENT
   drop constraint FK_EMPLACEM_EMPLACEME_MODULE


if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLACEMENT') and o.name = 'FK_EMPLACEM_EMPLACEME_SALLE')
alter table EMPLACEMENT
   drop constraint FK_EMPLACEM_EMPLACEME_SALLE


if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ENSEIGNEMENT') and o.name = 'FK_ENSEIGNE_ENSEIGNEM_MODULE')
alter table ENSEIGNEMENT
   drop constraint FK_ENSEIGNE_ENSEIGNEM_MODULE


if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ENSEIGNEMENT') and o.name = 'FK_ENSEIGNE_ENSEIGNEM_PROF')
alter table ENSEIGNEMENT
   drop constraint FK_ENSEIGNE_ENSEIGNEM_PROF


if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ETUDIANT') and o.name = 'FK_ETUDIANT_CHOIXFILL_FILIER')
alter table ETUDIANT
   drop constraint FK_ETUDIANT_CHOIXFILL_FILIER

if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ETUDIANT') and o.name = 'FK_ETUDIANT_INSCRIPTI_ADMINIST')
alter table ETUDIANT
   drop constraint FK_ETUDIANT_INSCRIPTI_ADMINIST


if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FACTURE') and o.name = 'FK_FACTURE_EFFECTUER_ADMINIST')
alter table FACTURE
   drop constraint FK_FACTURE_EFFECTUER_ADMINIST


if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FACTURE') and o.name = 'FK_FACTURE_PAIMENT_ETUDIANT')
alter table FACTURE
   drop constraint FK_FACTURE_PAIMENT_ETUDIANT


if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INTEGRATION') and o.name = 'FK_INTEGRAT_INTEGRATI_MODULE')
alter table INTEGRATION
   drop constraint FK_INTEGRAT_INTEGRATI_MODULE


if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('INTEGRATION') and o.name = 'FK_INTEGRAT_INTEGRATI_FILIER')
alter table INTEGRATION
   drop constraint FK_INTEGRAT_INTEGRATI_FILIER


if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NOTES') and o.name = 'FK_NOTES_NOTE_MODULE')
alter table NOTES
   drop constraint FK_NOTES_NOTE_MODULE


if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NOTES') and o.name = 'FK_NOTES_NOTEDONNE_PROF')
alter table NOTES
   drop constraint FK_NOTES_NOTEDONNE_PROF


if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NOTES') and o.name = 'FK_NOTES_NOTEPRIS_ETUDIANT')
alter table NOTES
   drop constraint FK_NOTES_NOTEPRIS_ETUDIANT


if exists (select 1
   from dbo.sysreferences r join dbo.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PROF') and o.name = 'FK_PROF_AJOUT_PRO_ADMINIST')
alter table PROF
   drop constraint FK_PROF_AJOUT_PRO_ADMINIST


if exists (select 1
            from  sysobjects
           where  id = object_id('ABSENCE')
            and   type = 'U')
   drop table ABSENCE


if exists (select 1
            from  sysobjects
           where  id = object_id('ADMINISTRATEUR')
            and   type = 'U')
   drop table ADMINISTRATEUR


if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLACEMENT')
            and   type = 'U')
   drop table EMPLACEMENT

if exists (select 1
            from  sysobjects
           where  id = object_id('ENSEIGNEMENT')
            and   type = 'U')
   drop table ENSEIGNEMENT


if exists (select 1
            from  sysobjects
           where  id = object_id('ETUDIANT')
            and   type = 'U')
   drop table ETUDIANT


if exists (select 1
            from  sysobjects
           where  id = object_id('FACTURE')
            and   type = 'U')
   drop table FACTURE


if exists (select 1
            from  sysobjects
           where  id = object_id('FILIER')
            and   type = 'U')
   drop table FILIER


if exists (select 1
            from  sysobjects
           where  id = object_id('INTEGRATION')
            and   type = 'U')
   drop table INTEGRATION


if exists (select 1
            from  sysobjects
           where  id = object_id('MODULE')
            and   type = 'U')
   drop table MODULE


if exists (select 1
            from  sysobjects
           where  id = object_id('NOTES')
            and   type = 'U')
   drop table NOTES


if exists (select 1
            from  sysobjects
           where  id = object_id('PROF')
            and   type = 'U')
   drop table PROF


if exists (select 1
            from  sysobjects
           where  id = object_id('SALLE')
            and   type = 'U')
   drop table SALLE

/*==============================================================*/
/* Table : ABSENCE                                              */
/*==============================================================*/
create table ABSENCE (
   ID_ABSENCE           int                  not null,
   ID_ETUDIANT          int                  not null,
   DATE                 datetime             null,
   constraint PK_ABSENCE primary key nonclustered IDENTITY(1,1) (ID_ABSENCE)
)


/*==============================================================*/
/* Table : ADMINISTRATEUR                                       */
/*==============================================================*/
create table ADMINISTRATEUR (
   ID_ADMIN             int                  not null,
   NOM                  varchar(255)           null,
   PRENOM               varchar(255)           null,
   NUM_TELEPHONE        varchar(30)           null,
   EMAIL                varchar(255)           null,
   SURNOM               varchar(255)           null,
   PASSWORD             varchar(255)           null,
   constraint PK_ADMINISTRATEUR primary key IDENTITY(1,1) nonclustered (ID_ADMIN)
)


/*==============================================================*/
/* Table : EMPLACEMENT                                          */
/*==============================================================*/
create table EMPLACEMENT (
   ID_SALLE             int                  not null,
   ID_MODULE            int                  not null,
   constraint PK_EMPLACEMENT primary key nonclustered (ID_SALLE, ID_MODULE)
)


/*==============================================================*/
/* Table : ENSEIGNEMENT                                         */
/*==============================================================*/
create table ENSEIGNEMENT (
   ID_PROF              int                  not null,
   ID_MODULE            int                  not null,
   constraint PK_ENSEIGNEMENT primary key nonclustered (ID_PROF, ID_MODULE)
)


/*==============================================================*/
/* Table : ETUDIANT                                             */
/*==============================================================*/
create table ETUDIANT (
   ID_ETUDIANT          int                  not null,
   ID_ADMIN             int                  not null,
   ID_FILIER            int                  not null,
   NOM                  varchar(255)           null,
   PRENOM               varchar(255)           null,
   ADRESSE              varchar(255)           null,
   TELEPHONE            varchar(255)           null,
   AUTRE_PHONE          varchar(255)           null,
   PHOTOS               varchar(255)           null,
   SURNOM               varchar(255)           null,
   MOTS_DE_PASSE        varchar(255)           null,
   constraint PK_ETUDIANT primary key nonclustered IDENTITY(1,1) (ID_ETUDIANT)
)


/*==============================================================*/
/* Table : FACTURE                                              */
/*==============================================================*/
create table FACTURE (
   ID_FACTURE           int                  not null,
   ID_ETUDIANT          int                  not null,
   ID_ADMIN             int                  not null,
   MONTANT              int         null,
   MOISPAYE             varchar(255)           null,
   DATE                 datetime             null,
   constraint PK_FACTURE primary key nonclustered IDENTITY(1,1) (ID_FACTURE)
)


/*==============================================================*/
/* Table : FILIER                                               */
/*==============================================================*/
create table FILIER (
   ID_FILIER            int                  not null,
   NOM                  varchar(255)           null,
   SPECIALITE           varchar(255)           null,
   constraint PK_FILIER primary key nonclustered IDENTITY(1,1) (ID_FILIER)
)


/*==============================================================*/
/* Table : INTEGRATION                                          */
/*==============================================================*/
create table INTEGRATION (
   ID_FILIER            int                  not null,
   ID_MODULE            int                  not null,
   constraint PK_INTEGRATION primary key nonclustered IDENTITY(1,1) (ID_FILIER, ID_MODULE)
)


/*==============================================================*/
/* Table : MODULE                                               */
/*==============================================================*/
create table MODULE (
   ID_MODULE            int                  not null,
   MODULE               varchar(255)           null,
   COEFFICIENT          int                  null,
   constraint PK_MODULE primary key nonclustered IDENTITY(1,1) (ID_MODULE)
)


/*==============================================================*/
/* Table : NOTES                                                */
/*==============================================================*/
create table NOTES (
   ID_NOTE              int                  not null,
   ID_MODULE            int                  not null,
   ID_PROF              int                  not null,
   ID_ETUDIANT          int                  not null,
   LA_NOTE              int                  null,
   REMARQUE             varchar(255)           null,
   constraint PK_NOTES primary key nonclustered IDENTITY(1,1) (ID_NOTE)
)


/*==============================================================*/
/* Table : PROF                                                 */
/*==============================================================*/
create table PROF (
   ID_PROF              int                  not null,
   ID_ADMIN             int                  not null,
   NOM                  varchar(255)           null,
   PRENOM               varchar(255)           null,
   NUM_TELEPHONE        varchar(255)           null,
   SALAIRE              int         null,
   CIN                  varchar(255)           null,
   SURNOM               varchar(255)           null,
   PASSWORD             varchar(255)           null,
   constraint PK_PROF primary key nonclustered  IDENTITY(1,1) (ID_PROF)
)


/*==============================================================*/
/* Table : SALLE                                                */
/*==============================================================*/
create table SALLE (
   ID_SALLE             int                  not null,
   NOM_SALLE            varchar(255)           null,
   TYPE                 varchar(255)           null,
   constraint PK_SALLE primary key nonclustered IDENTITY(1,1) (ID_SALLE)
)

alter table ABSENCE
   add constraint FK_ABSENCE_S_ABSENTE_ETUDIANT foreign key (ID_ETUDIANT)
      references ETUDIANT (ID_ETUDIANT) ON DELETE NO ACTION ON UPDATE CASCADE


alter table EMPLACEMENT
   add constraint FK_EMPLACEM_EMPLACEME_MODULE foreign key (ID_MODULE)
      references MODULE (ID_MODULE) ON DELETE NO ACTION ON UPDATE CASCADE


alter table EMPLACEMENT
   add constraint FK_EMPLACEM_EMPLACEME_SALLE foreign key (ID_SALLE)
      references SALLE (ID_SALLE) ON DELETE NO ACTION ON UPDATE CASCADE


alter table ENSEIGNEMENT
   add constraint FK_ENSEIGNE_ENSEIGNEM_MODULE foreign key (ID_MODULE)
      references MODULE (ID_MODULE) ON DELETE NO ACTION ON UPDATE CASCADE


alter table ENSEIGNEMENT
   add constraint FK_ENSEIGNE_ENSEIGNEM_PROF foreign key (ID_PROF)
      references PROF (ID_PROF) ON DELETE NO ACTION ON UPDATE CASCADE


alter table ETUDIANT
   add constraint FK_ETUDIANT_CHOIXFILL_FILIER foreign key (ID_FILIER)
      references FILIER (ID_FILIER) ON DELETE NO ACTION ON UPDATE CASCADE


alter table ETUDIANT
   add constraint FK_ETUDIANT_INSCRIPTI_ADMINIST foreign key (ID_ADMIN)
      references ADMINISTRATEUR (ID_ADMIN) ON DELETE NO ACTION ON UPDATE CASCADE


alter table FACTURE
   add constraint FK_FACTURE_EFFECTUER_ADMINIST foreign key (ID_ADMIN)
      references ADMINISTRATEUR (ID_ADMIN) ON DELETE NO ACTION ON UPDATE CASCADE


alter table FACTURE
   add constraint FK_FACTURE_PAIMENT_ETUDIANT foreign key (ID_ETUDIANT)
      references ETUDIANT (ID_ETUDIANT) ON DELETE NO ACTION ON UPDATE NO ACTION


alter table INTEGRATION
   add constraint FK_INTEGRAT_INTEGRATI_MODULE foreign key (ID_MODULE)
      references MODULE (ID_MODULE) ON DELETE NO ACTION ON UPDATE CASCADE


alter table INTEGRATION
   add constraint FK_INTEGRAT_INTEGRATI_FILIER foreign key (ID_FILIER)
      references FILIER (ID_FILIER) ON DELETE NO ACTION ON UPDATE CASCADE


alter table NOTES
   add constraint FK_NOTES_NOTE_MODULE foreign key (ID_MODULE)
      references MODULE (ID_MODULE) ON DELETE NO ACTION ON UPDATE CASCADE


alter table NOTES
   add constraint FK_NOTES_NOTEDONNE_PROF foreign key (ID_PROF)
      references PROF (ID_PROF) ON DELETE NO ACTION ON UPDATE CASCADE


alter table NOTES
   add constraint FK_NOTES_NOTEPRIS_ETUDIANT foreign key (ID_ETUDIANT)
      references ETUDIANT (ID_ETUDIANT) ON DELETE NO ACTION ON UPDATE CASCADE


alter table PROF
   add constraint FK_PROF_AJOUT_PRO_ADMINIST foreign key (ID_ADMIN)
      references ADMINISTRATEUR (ID_ADMIN) ON DELETE NO ACTION ON UPDATE NO ACTION


=======================================LALALALALALALLALALALALALALALA==========================================



/*==============================================================*/
/* Table : ABSENCE                                              */
/*==============================================================*/
create table ABSENCE (
   ID_ABSENCE           int                  IDENTITY(1,1) not null,
   ID_ETUDIANT          int                  not null,
   DATE                 datetime             null,
   constraint PK_ABSENCE primary key nonclustered  (ID_ABSENCE)
)


/*==============================================================*/
/* Table : ADMINISTRATEUR                                       */
/*==============================================================*/
create table ADMINISTRATEUR (
   ID_ADMIN             int                  IDENTITY(1,1) not null,
   NOM                  varchar(255)           null,
   PRENOM               varchar(255)           null,
   NUM_TELEPHONE        varchar(30)           null,
   EMAIL                varchar(255)           null,
   SURNOM               varchar(255)           null,
   PASSWORD             varchar(255)           null,
   constraint PK_ADMINISTRATEUR primary key nonclustered (ID_ADMIN)
)





/*==============================================================*/
/* Table : ENSEIGNEMENT                                         */
/*==============================================================*/
create table ENSEIGNEMENT (
   ID_PROF              int                  not null,
   ID_MODULE            int                  not null,
   constraint PK_ENSEIGNEMENT primary key nonclustered (ID_PROF, ID_MODULE)
)


/*==============================================================*/
/* Table : ETUDIANT                                             */
/*==============================================================*/
create table ETUDIANT (
   ID_ETUDIANT          int                  IDENTITY(1,1) not null,
   ID_ADMIN             int                  not null,
   ID_FILIER            int                  not null,
   NOM                  varchar(255)           null,
   PRENOM               varchar(255)           null,
   ADRESSE              varchar(255)           null,
   TELEPHONE            varchar(255)           null,
   AUTRE_PHONE          varchar(255)           null,
   PHOTOS               varchar(255)           null,
   SURNOM               varchar(255)           null,
   MOTS_DE_PASSE        varchar(255)           null,
   constraint PK_ETUDIANT primary key nonclustered (ID_ETUDIANT)
)


/*==============================================================*/
/* Table : FACTURE                                              */
/*==============================================================*/
create table FACTURE (
   ID_FACTURE           int                  IDENTITY(1,1) not null,
   ID_ETUDIANT          int                  not null,
   ID_ADMIN             int                  not null,
   MONTANT              int         null,
   MOISPAYE             varchar(255)           null,
   DATE                 datetime             null,
   constraint PK_FACTURE primary key nonclustered  (ID_FACTURE)
)


/*==============================================================*/
/* Table : FILIER                                               */
/*==============================================================*/
create table FILIER (
   ID_FILIER            int                  IDENTITY(1,1) not null,
   NOM                  varchar(255)           null,
   SPECIALITE           varchar(255)           null,
   constraint PK_FILIER primary key nonclustered  (ID_FILIER)
)


/*==============================================================*/
/* Table : INTEGRATION                                          */
/*==============================================================*/
create table INTEGRATION (
   ID_FILIER            int                  not null,
   ID_MODULE            int                  not null,
   constraint PK_INTEGRATION primary key nonclustered  (ID_FILIER, ID_MODULE)
)


/*==============================================================*/
/* Table : MODULE                                               */
/*==============================================================*/
create table MODULE (
   ID_MODULE            int                 IDENTITY(1,1) not null,
   MODULE               varchar(255)           null,
   COEFFICIENT          int                  null,
   constraint PK_MODULE primary key nonclustered (ID_MODULE)
)


/*==============================================================*/
/* Table : NOTES                                                */
/*==============================================================*/
create table NOTES (
   ID_NOTE              int                 IDENTITY(1,1) not null,
   ID_MODULE            int                  not null,
   ID_PROF              int                  not null,
   ID_ETUDIANT          int                  not null,
   LA_NOTE              int                  null,
   REMARQUE             varchar(255)           null,
   constraint PK_NOTES primary key nonclustered  (ID_NOTE)
)


/*==============================================================*/
/* Table : PROF                                                 */
/*==============================================================*/
create table PROF (
   ID_PROF              int                 IDENTITY(1,1) not null,
   ID_ADMIN             int                  not null,
   NOM                  varchar(255)           null,
   PRENOM               varchar(255)           null,
   NUM_TELEPHONE        varchar(255)           null,
   SALAIRE              int         null,
   CIN                  varchar(255)           null,
   SURNOM               varchar(255)           null,
   PASSWORD             varchar(255)           null,
   constraint PK_PROF primary key nonclustered (ID_PROF)
)




alter table ABSENCE
   add constraint FK_ABSENCE_S_ABSENTE_ETUDIANT foreign key (ID_ETUDIANT)
      references ETUDIANT (ID_ETUDIANT) ON DELETE NO ACTION 




alter table ENSEIGNEMENT
   add constraint FK_ENSEIGNE_ENSEIGNEM_MODULE foreign key (ID_MODULE)
      references MODULE (ID_MODULE) ON DELETE NO ACTION 


alter table ENSEIGNEMENT
   add constraint FK_ENSEIGNE_ENSEIGNEM_PROF foreign key (ID_PROF)
      references PROF (ID_PROF) ON DELETE NO ACTION 


alter table ETUDIANT
   add constraint FK_ETUDIANT_CHOIXFILL_FILIER foreign key (ID_FILIER)
      references FILIER (ID_FILIER) ON DELETE NO ACTION 


alter table ETUDIANT
   add constraint FK_ETUDIANT_INSCRIPTI_ADMINIST foreign key (ID_ADMIN)
      references ADMINISTRATEUR (ID_ADMIN) ON DELETE NO ACTION 


alter table FACTURE
   add constraint FK_FACTURE_EFFECTUER_ADMINIST foreign key (ID_ADMIN)
      references ADMINISTRATEUR (ID_ADMIN) ON DELETE NO ACTION 


alter table FACTURE
   add constraint FK_FACTURE_PAIMENT_ETUDIANT foreign key (ID_ETUDIANT)
      references ETUDIANT (ID_ETUDIANT) ON DELETE NO ACTION 


alter table INTEGRATION
   add constraint FK_INTEGRAT_INTEGRATI_MODULE foreign key (ID_MODULE)
      references MODULE (ID_MODULE) ON DELETE NO ACTION 


alter table INTEGRATION
   add constraint FK_INTEGRAT_INTEGRATI_FILIER foreign key (ID_FILIER)
      references FILIER (ID_FILIER) ON DELETE NO ACTION 


alter table NOTES
   add constraint FK_NOTES_NOTE_MODULE foreign key (ID_MODULE)
      references MODULE (ID_MODULE) ON DELETE NO ACTION 


alter table NOTES
   add constraint FK_NOTES_NOTEDONNE_PROF foreign key (ID_PROF)
      references PROF (ID_PROF) ON DELETE NO ACTION 


alter table NOTES
   add constraint FK_NOTES_NOTEPRIS_ETUDIANT foreign key (ID_ETUDIANT)
      references ETUDIANT (ID_ETUDIANT) ON DELETE NO ACTION 


alter table PROF
   add constraint FK_PROF_AJOUT_PRO_ADMINIST foreign key (ID_ADMIN)
      references ADMINISTRATEUR (ID_ADMIN) ON DELETE NO ACTION 
