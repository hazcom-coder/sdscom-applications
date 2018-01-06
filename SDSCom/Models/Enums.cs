using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSCom.Models
{

    /// <remarks/>
    public enum SolubilityMediumEnum
    {

        /// <remarks/>
        Water,

        /// <remarks/>
        Fat,

        /// <remarks/>
        Undefined,

        /// <remarks/>
        Other,
    }

    /// <remarks/>
    public enum SafetySignEnum
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.1")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.2")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.3")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.4")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2.1")]
        Item21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2.2")]
        Item22,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2.3")]
        Item23,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2.4")]
        Item24,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2.5")]
        Item25,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2.6")]
        Item26,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3.1")]
        Item31,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3.2")]
        Item32,
    }

    /// <remarks/>
    public enum PhValueStateEnum
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("In delivery state")]
        Indeliverystate,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("In aqueous solution")]
        Inaqueoussolution,
    }

    /// <remarks/>
    public enum EffectLevelGroupEnum
    {

        /// <remarks/>
        Industrial,

        /// <remarks/>
        Professional,

        /// <remarks/>
        Consumer,

        /// <remarks/>
        Undefined,
    }

    /// <remarks/>


    /// <remarks/>
    public enum PNECTypeEnum
    {

        /// <remarks/>
        Soil,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Sediment, marine water")]
        Sedimentmarinewater,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Sediment, freshwater")]
        Sedimentfreshwater,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Aquatic, intermittent release")]
        Aquaticintermittentrelease,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Aquatic, marine water")]
        Aquaticmarinewater,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Aquatic, freshwater")]
        Aquaticfreshwater,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Sewage treatment plant (STP)")]
        SewagetreatmentplantSTP,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Secondary poisoning")]
        Secondarypoisoning,

        /// <remarks/>
        Air,
    }

    //public enum EffectLevelTypeEnum
    //{

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("Acute oral (systemic)")]
    //    Acuteoralsystemic,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("Long-term oral (systemic)")]
    //    Longtermoralsystemic,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("Acute dermal (local)")]
    //    Acutedermallocal,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("Acute dermal (systemic)")]
    //    Acutedermalsystemic,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("Long-term dermal (local)")]
    //    Longtermdermallocal,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("Long-term dermal (systemic)")]
    //    Longtermdermalsystemic,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("Acute inhalation (local)")]
    //    Acuteinhalationlocal,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("Acute inhalation (systemic)")]
    //    Acuteinhalationsystemic,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("Long-term inhalation (local)")]
    //    Longterminhalationlocal,

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlEnumAttribute("Long-term inhalation (systemic)")]
    //    Longterminhalationsystemic,
    //}


    /// <remarks/>
    public enum EffectLevelTypeEnum
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Acute oral (systemic)")]
        Acuteoralsystemic,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Long-term oral (systemic)")]
        Longtermoralsystemic,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Acute dermal (local)")]
        Acutedermallocal,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Acute dermal (systemic)")]
        Acutedermalsystemic,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Long-term dermal (local)")]
        Longtermdermallocal,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Long-term dermal (systemic)")]
        Longtermdermalsystemic,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Acute inhalation (local)")]
        Acuteinhalationlocal,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Acute inhalation (systemic)")]
        Acuteinhalationsystemic,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Long-term inhalation (local)")]
        Longterminhalationlocal,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Long-term inhalation (systemic)")]
        Longterminhalationsystemic,
    }



    /// <remarks/>
    public enum ExposureLimitValueTypeEnum
    {

        /// <remarks/>
        AGW,

        /// <remarks/>
        VLA,

        /// <remarks/>
        MAC,

        /// <remarks/>
        WEL,

        /// <remarks/>
        OEL,

        /// <remarks/>
        TWA,

        /// <remarks/>
        STEL,

        /// <remarks/>
        VLE,

        /// <remarks/>
        AK,

        /// <remarks/>
        PK,

        /// <remarks/>
        MK,

        /// <remarks/>
        PEL,

        /// <remarks/>
        MAK,

        /// <remarks/>
        NDS,

        /// <remarks/>
        NDSCH,

        /// <remarks/>
        NDSP,

        /// <remarks/>
        GV,

        /// <remarks/>
        NGV,

        /// <remarks/>
        TGV,

        /// <remarks/>
        KTV,

        /// <remarks/>
        AN,

        /// <remarks/>
        ADN,

        /// <remarks/>
        HTP,
    }

    /// <remarks/>
    public enum HazardStatementEnum
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("200")]
        Item200,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("201")]
        Item201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("202")]
        Item202,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("203")]
        Item203,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("204")]
        Item204,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("205")]
        Item205,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("220")]
        Item220,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("221")]
        Item221,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("222")]
        Item222,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("223")]
        Item223,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("224")]
        Item224,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("225")]
        Item225,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("226")]
        Item226,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("228")]
        Item228,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("229")]
        Item229,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("230")]
        Item230,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("231")]
        Item231,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("240")]
        Item240,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("241")]
        Item241,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("242")]
        Item242,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("250")]
        Item250,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("251")]
        Item251,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("252")]
        Item252,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("260")]
        Item260,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("261")]
        Item261,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("270")]
        Item270,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("271")]
        Item271,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("272")]
        Item272,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("280")]
        Item280,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("281")]
        Item281,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("290")]
        Item290,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("300")]
        Item300,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("301")]
        Item301,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("302")]
        Item302,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("304")]
        Item304,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("310")]
        Item310,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("311")]
        Item311,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("312")]
        Item312,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("314")]
        Item314,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("315")]
        Item315,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("317")]
        Item317,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("318")]
        Item318,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("319")]
        Item319,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("330")]
        Item330,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("331")]
        Item331,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("332")]
        Item332,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("334")]
        Item334,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("335")]
        Item335,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("336")]
        Item336,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("340")]
        Item340,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("341")]
        Item341,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("350")]
        Item350,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("350i")]
        Item350i,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("351")]
        Item351,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("360")]
        Item360,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("360F")]
        Item360F,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("360D")]
        Item360D,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("360FD")]
        Item360FD,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("360Fd")]
        Item360Fd,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("360Df")]
        Item360Df,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("361")]
        Item361,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("361f")]
        Item361f,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("361d")]
        Item361d,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("361fd")]
        Item361fd,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("362")]
        Item362,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("370")]
        Item370,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("371")]
        Item371,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("372")]
        Item372,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("373")]
        Item373,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("400")]
        Item400,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("410")]
        Item410,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("411")]
        Item411,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("412")]
        Item412,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("413")]
        Item413,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("420")]
        Item420,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("300+310")]
        Item300310,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("300+330")]
        Item300330,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("310+330")]
        Item310330,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("300+310+330")]
        Item300310330,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("301+311")]
        Item301311,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("301+331")]
        Item301331,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("311+331")]
        Item311331,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("301+311+331")]
        Item301311331,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("302+312")]
        Item302312,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("302+332")]
        Item302332,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("312+332")]
        Item312332,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("302+312+332")]
        Item302312332,
    }

    /// <remarks/>
    public enum ClassificationCategoryEnum
    {

        /// <remarks/>
        E,

        /// <remarks/>
        O,

        /// <remarks/>
        F,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("F+")]
        F1,

        /// <remarks/>
        Xi,

        /// <remarks/>
        Xn,

        /// <remarks/>
        T,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("T+")]
        T1,

        /// <remarks/>
        C,

        /// <remarks/>
        N,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Carc. Cat. 1")]
        CarcCat1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Carc. Cat. 2")]
        CarcCat2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Carc. Cat. 3")]
        CarcCat3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Muta. Cat. 1")]
        MutaCat1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Muta. Cat. 2")]
        MutaCat2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Muta. Cat. 3")]
        MutaCat3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Repr. Cat. 1")]
        ReprCat1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Repr. Cat. 2")]
        ReprCat2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Repr. Cat. 3")]
        ReprCat3,
    }

    /// <remarks/>
    public enum RiskPhraseEnum
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("18")]
        Item18,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("19")]
        Item19,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20")]
        Item20,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        Item28,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        Item29,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("30")]
        Item30,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("31")]
        Item31,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32")]
        Item32,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("33")]
        Item33,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("34")]
        Item34,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("35")]
        Item35,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("36")]
        Item36,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("37")]
        Item37,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("38")]
        Item38,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39")]
        Item39,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("40")]
        Item40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42")]
        Item42,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("43")]
        Item43,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("44")]
        Item44,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("45")]
        Item45,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("46")]
        Item46,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48")]
        Item48,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("56")]
        Item56,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("57")]
        Item57,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("58")]
        Item58,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("59")]
        Item59,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("61")]
        Item61,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("62")]
        Item62,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("63")]
        Item63,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("64")]
        Item64,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("66")]
        Item66,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("67")]
        Item67,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("68")]
        Item68,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14/15")]
        Item1415,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15/29")]
        Item1529,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20/21")]
        Item2021,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20/21/22")]
        Item202122,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20/22")]
        Item2022,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21/22")]
        Item2122,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23/24")]
        Item2324,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23/24/25")]
        Item232425,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23/25")]
        Item2325,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24/25")]
        Item2425,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26/27")]
        Item2627,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26/27/28")]
        Item262728,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26/28")]
        Item2628,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27/28")]
        Item2728,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("36/37")]
        Item3637,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("36/37/38")]
        Item363738,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("36/38")]
        Item3638,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("37/38")]
        Item3738,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39/23")]
        Item3923,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39/23/24")]
        Item392324,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39/23/24/25")]
        Item39232425,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39/23/25")]
        Item392325,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39/24")]
        Item3924,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39/24/25")]
        Item392425,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39/25")]
        Item3925,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39/26")]
        Item3926,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39/26/27")]
        Item392627,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39/26/27/28")]
        Item39262728,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39/26/28")]
        Item392628,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39/27")]
        Item3927,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39/27/28")]
        Item392728,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39/28")]
        Item3928,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42/43")]
        Item4243,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48/20")]
        Item4820,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48/20/21")]
        Item482021,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48/20/21/22")]
        Item48202122,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48/20/22")]
        Item482022,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48/21")]
        Item4821,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48/21/22")]
        Item482122,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48/22")]
        Item4822,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48/23")]
        Item4823,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48/23/24")]
        Item482324,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48/23/24/25")]
        Item48232425,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48/23/25")]
        Item482325,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48/24")]
        Item4824,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48/24/25")]
        Item482425,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48/25")]
        Item4825,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50/53")]
        Item5053,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51/53")]
        Item5153,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52/53")]
        Item5253,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("68/20")]
        Item6820,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("68/20/21")]
        Item682021,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("68/20/21/22")]
        Item68202122,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("68/20/22")]
        Item682022,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("68/21")]
        Item6821,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("68/21/22")]
        Item682122,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("68/22")]
        Item6822,
    }

    /// <remarks/>
    public enum SectorOfUseCodeEnum
    {

        /// <remarks/>
        SU1,

        /// <remarks/>
        SU2a,

        /// <remarks/>
        SU2b,

        /// <remarks/>
        SU3,

        /// <remarks/>
        SU4,

        /// <remarks/>
        SU5,

        /// <remarks/>
        SU6a,

        /// <remarks/>
        SU6b,

        /// <remarks/>
        SU7,

        /// <remarks/>
        SU8,

        /// <remarks/>
        SU9,

        /// <remarks/>
        SU10,

        /// <remarks/>
        SU11,

        /// <remarks/>
        SU12,

        /// <remarks/>
        SU13,

        /// <remarks/>
        SU14,

        /// <remarks/>
        SU15,

        /// <remarks/>
        SU16,

        /// <remarks/>
        SU17,

        /// <remarks/>
        SU18,

        /// <remarks/>
        SU19,

        /// <remarks/>
        SU20,

        /// <remarks/>
        SU21,

        /// <remarks/>
        SU22,

        /// <remarks/>
        SU23,

        /// <remarks/>
        SU24,

        /// <remarks/>
        SU0,
    }

    /// <remarks/>
    public enum ProductCategoryCodeEnum
    {

        /// <remarks/>
        PC1,

        /// <remarks/>
        PC2,

        /// <remarks/>
        PC3,

        /// <remarks/>
        PC4,

        /// <remarks/>
        PC7,

        /// <remarks/>
        PC8,

        /// <remarks/>
        PC9a,

        /// <remarks/>
        PC9b,

        /// <remarks/>
        PC9c,

        /// <remarks/>
        PC11,

        /// <remarks/>
        PC12,

        /// <remarks/>
        PC13,

        /// <remarks/>
        PC14,

        /// <remarks/>
        PC15,

        /// <remarks/>
        PC16,

        /// <remarks/>
        PC17,

        /// <remarks/>
        PC18,

        /// <remarks/>
        PC19,

        /// <remarks/>
        PC20,

        /// <remarks/>
        PC21,

        /// <remarks/>
        PC22,

        /// <remarks/>
        PC23,

        /// <remarks/>
        PC24,

        /// <remarks/>
        PC25,

        /// <remarks/>
        PC26,

        /// <remarks/>
        PC27,

        /// <remarks/>
        PC28,

        /// <remarks/>
        PC29,

        /// <remarks/>
        PC30,

        /// <remarks/>
        PC31,

        /// <remarks/>
        PC32,

        /// <remarks/>
        PC33,

        /// <remarks/>
        PC34,

        /// <remarks/>
        PC35,

        /// <remarks/>
        PC36,

        /// <remarks/>
        PC37,

        /// <remarks/>
        PC38,

        /// <remarks/>
        PC39,

        /// <remarks/>
        PC40,

        /// <remarks/>
        PC0,
    }

    /// <remarks/>
    public enum ProcessCategoryCodeEnum
    {

        /// <remarks/>
        PROC1,

        /// <remarks/>
        PROC2,

        /// <remarks/>
        PROC3,

        /// <remarks/>
        PROC4,

        /// <remarks/>
        PROC5,

        /// <remarks/>
        PROC6,

        /// <remarks/>
        PROC7,

        /// <remarks/>
        PROC8a,

        /// <remarks/>
        PROC8b,

        /// <remarks/>
        PROC9,

        /// <remarks/>
        PROC10,

        /// <remarks/>
        PROC11,

        /// <remarks/>
        PROC12,

        /// <remarks/>
        PROC13,

        /// <remarks/>
        PROC14,

        /// <remarks/>
        PROC15,

        /// <remarks/>
        PROC16,

        /// <remarks/>
        PROC17,

        /// <remarks/>
        PROC18,

        /// <remarks/>
        PROC19,

        /// <remarks/>
        PROC20,

        /// <remarks/>
        PROC21,

        /// <remarks/>
        PROC22,

        /// <remarks/>
        PROC23,

        /// <remarks/>
        PROC24,

        /// <remarks/>
        PROC25,

        /// <remarks/>
        PROC26,

        /// <remarks/>
        PROC27a,

        /// <remarks/>
        PROC27b,
    }


    /// <remarks/>
    public enum EnvironmentalReleaseCategoryCodeEnum
    {

        /// <remarks/>
        ERC1,

        /// <remarks/>
        ERC2,

        /// <remarks/>
        ERC3,

        /// <remarks/>
        ERC4,

        /// <remarks/>
        ERC5,

        /// <remarks/>
        ERC6a,

        /// <remarks/>
        ERC6b,

        /// <remarks/>
        ERC6c,

        /// <remarks/>
        ERC6d,

        /// <remarks/>
        ERC7,

        /// <remarks/>
        ERC8a,

        /// <remarks/>
        ERC8b,

        /// <remarks/>
        ERC8c,

        /// <remarks/>
        ERC8d,

        /// <remarks/>
        ERC8e,

        /// <remarks/>
        ERC8f,

        /// <remarks/>
        ERC9a,

        /// <remarks/>
        ERC9b,

        /// <remarks/>
        ERC10a,

        /// <remarks/>
        ERC10b,

        /// <remarks/>
        ERC11a,

        /// <remarks/>
        ERC11b,

        /// <remarks/>
        ERC12a,

        /// <remarks/>
        ERC12b,
    }



    /// <remarks/>
    public enum ArticleCategoryCodeEnum
    {

        /// <remarks/>
        AC1,

        /// <remarks/>
        AC2,

        /// <remarks/>
        AC3,

        /// <remarks/>
        AC4,

        /// <remarks/>
        AC5,

        /// <remarks/>
        AC6,

        /// <remarks/>
        AC7,

        /// <remarks/>
        AC8,

        /// <remarks/>
        AC10,

        /// <remarks/>
        AC11,

        /// <remarks/>
        AC13,

        /// <remarks/>
        AC30,

        /// <remarks/>
        AC31,

        /// <remarks/>
        AC32,

        /// <remarks/>
        AC33,

        /// <remarks/>
        AC34,

        /// <remarks/>
        AC35,

        /// <remarks/>
        AC36,

        /// <remarks/>
        AC38,

        /// <remarks/>
        AC0,
    }

    /// <remarks/>



    /// <remarks/>
    public enum SafetyPhraseEnum
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("18")]
        Item18,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20")]
        Item20,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        Item28,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        Item29,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("30")]
        Item30,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("33")]
        Item33,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("35")]
        Item35,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("36")]
        Item36,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("37")]
        Item37,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("38")]
        Item38,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39")]
        Item39,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("40")]
        Item40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42")]
        Item42,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("43")]
        Item43,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("45")]
        Item45,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("46")]
        Item46,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("47")]
        Item47,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48")]
        Item48,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("56")]
        Item56,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("57")]
        Item57,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("59")]
        Item59,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("61")]
        Item61,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("62")]
        Item62,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("63")]
        Item63,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("64")]
        Item64,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1/2")]
        Item121,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3/7")]
        Item371,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3/9/14")]
        Item3914,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3/9/14/49")]
        Item391449,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3/9/49")]
        Item3949,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3/14")]
        Item314,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7/8")]
        Item78,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7/9")]
        Item79,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7/47")]
        Item747,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20/21")]
        Item2021,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24/25")]
        Item2425,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27/28")]
        Item2728,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("29/35")]
        Item2935,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("29/56")]
        Item2956,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("36/37")]
        Item3637,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("36/37/39")]
        Item363739,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("36/39")]
        Item3639,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("37/39")]
        Item3739,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("47/49")]
        Item4749,
    }


    /// <remarks/>
    public enum SpecialSupplementalLabelInfoEnum
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("201")]
        Item201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("201A")]
        Item201A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("202")]
        Item202,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("203")]
        Item203,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("204")]
        Item204,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("205")]
        Item205,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("206")]
        Item206,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("207")]
        Item207,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("208")]
        Item208,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("209")]
        Item209,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("209A")]
        Item209A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("210")]
        Item210,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("401")]
        Item401,
    }

    /// <remarks/>
    public enum SupplementalHazardInformationEnum
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("001")]
        Item001,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("006")]
        Item006,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("014")]
        Item014,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("018")]
        Item018,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("019")]
        Item019,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("044")]
        Item044,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("029")]
        Item029,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("031")]
        Item031,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("032")]
        Item032,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("066")]
        Item066,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("070")]
        Item070,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("071")]
        Item071,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("059")]
        Item059,
    }

    /// <remarks/>
    public enum SignalWordEnum
    {

        /// <remarks/>
        DGR,

        /// <remarks/>
        WNG,
    }

    /// <remarks/>
    public enum PictogramCodeEnum
    {

        /// <remarks/>
        GHS01,

        /// <remarks/>
        GHS02,

        /// <remarks/>
        GHS03,

        /// <remarks/>
        GHS04,

        /// <remarks/>
        GHS05,

        /// <remarks/>
        GHS06,

        /// <remarks/>
        GHS07,

        /// <remarks/>
        GHS08,

        /// <remarks/>
        GHS09,
    }

    /// <remarks/>
    public enum LanguageCodeEnum
    {

        /// <remarks/>
        aa,

        /// <remarks/>
        ab,

        /// <remarks/>
        ae,

        /// <remarks/>
        af,

        /// <remarks/>
        ak,

        /// <remarks/>
        am,

        /// <remarks/>
        an,

        /// <remarks/>
        ar,

        /// <remarks/>
        @as,

        /// <remarks/>
        av,

        /// <remarks/>
        ay,

        /// <remarks/>
        az,

        /// <remarks/>
        ba,

        /// <remarks/>
        be,

        /// <remarks/>
        bg,

        /// <remarks/>
        bh,

        /// <remarks/>
        bi,

        /// <remarks/>
        bm,

        /// <remarks/>
        bn,

        /// <remarks/>
        bo,

        /// <remarks/>
        br,

        /// <remarks/>
        bs,

        /// <remarks/>
        ca,

        /// <remarks/>
        ce,

        /// <remarks/>
        ch,

        /// <remarks/>
        co,

        /// <remarks/>
        cr,

        /// <remarks/>
        cs,

        /// <remarks/>
        cu,

        /// <remarks/>
        cv,

        /// <remarks/>
        cy,

        /// <remarks/>
        da,

        /// <remarks/>
        de,

        /// <remarks/>
        dv,

        /// <remarks/>
        dz,

        /// <remarks/>
        ee,

        /// <remarks/>
        el,

        /// <remarks/>
        en,

        /// <remarks/>
        eo,

        /// <remarks/>
        es,

        /// <remarks/>
        et,

        /// <remarks/>
        eu,

        /// <remarks/>
        fa,

        /// <remarks/>
        ff,

        /// <remarks/>
        fi,

        /// <remarks/>
        fj,

        /// <remarks/>
        fo,

        /// <remarks/>
        fr,

        /// <remarks/>
        fy,

        /// <remarks/>
        ga,

        /// <remarks/>
        gd,

        /// <remarks/>
        gl,

        /// <remarks/>
        gn,

        /// <remarks/>
        gu,

        /// <remarks/>
        gv,

        /// <remarks/>
        ha,

        /// <remarks/>
        he,

        /// <remarks/>
        hi,

        /// <remarks/>
        ho,

        /// <remarks/>
        hr,

        /// <remarks/>
        ht,

        /// <remarks/>
        hu,

        /// <remarks/>
        hy,

        /// <remarks/>
        hz,

        /// <remarks/>
        ia,

        /// <remarks/>
        id,

        /// <remarks/>
        ie,

        /// <remarks/>
        ig,

        /// <remarks/>
        ii,

        /// <remarks/>
        ik,

        /// <remarks/>
        io,

        /// <remarks/>
        @is,

        /// <remarks/>
        it,

        /// <remarks/>
        iu,

        /// <remarks/>
        ja,

        /// <remarks/>
        jv,

        /// <remarks/>
        ka,

        /// <remarks/>
        kg,

        /// <remarks/>
        ki,

        /// <remarks/>
        kj,

        /// <remarks/>
        kk,

        /// <remarks/>
        kl,

        /// <remarks/>
        km,

        /// <remarks/>
        kn,

        /// <remarks/>
        ko,

        /// <remarks/>
        kr,

        /// <remarks/>
        ks,

        /// <remarks/>
        ku,

        /// <remarks/>
        kv,

        /// <remarks/>
        kw,

        /// <remarks/>
        ky,

        /// <remarks/>
        la,

        /// <remarks/>
        lb,

        /// <remarks/>
        lg,

        /// <remarks/>
        li,

        /// <remarks/>
        ln,

        /// <remarks/>
        lo,

        /// <remarks/>
        lt,

        /// <remarks/>
        lu,

        /// <remarks/>
        lv,

        /// <remarks/>
        mg,

        /// <remarks/>
        mh,

        /// <remarks/>
        mi,

        /// <remarks/>
        mk,

        /// <remarks/>
        ml,

        /// <remarks/>
        mn,

        /// <remarks/>
        mr,

        /// <remarks/>
        ms,

        /// <remarks/>
        mt,

        /// <remarks/>
        my,

        /// <remarks/>
        na,

        /// <remarks/>
        nb,

        /// <remarks/>
        nd,

        /// <remarks/>
        ne,

        /// <remarks/>
        ng,

        /// <remarks/>
        nl,

        /// <remarks/>
        nn,

        /// <remarks/>
        no,

        /// <remarks/>
        nr,

        /// <remarks/>
        nv,

        /// <remarks/>
        ny,

        /// <remarks/>
        oc,

        /// <remarks/>
        oj,

        /// <remarks/>
        om,

        /// <remarks/>
        or,

        /// <remarks/>
        os,

        /// <remarks/>
        pa,

        /// <remarks/>
        pi,

        /// <remarks/>
        pl,

        /// <remarks/>
        ps,

        /// <remarks/>
        pt,

        /// <remarks/>
        qu,

        /// <remarks/>
        rm,

        /// <remarks/>
        rn,

        /// <remarks/>
        ro,

        /// <remarks/>
        ru,

        /// <remarks/>
        rw,

        /// <remarks/>
        sa,

        /// <remarks/>
        sc,

        /// <remarks/>
        sd,

        /// <remarks/>
        se,

        /// <remarks/>
        sg,

        /// <remarks/>
        si,

        /// <remarks/>
        sk,

        /// <remarks/>
        sl,

        /// <remarks/>
        sm,

        /// <remarks/>
        sn,

        /// <remarks/>
        so,

        /// <remarks/>
        sq,

        /// <remarks/>
        sr,

        /// <remarks/>
        ss,

        /// <remarks/>
        st,

        /// <remarks/>
        su,

        /// <remarks/>
        sv,

        /// <remarks/>
        sw,

        /// <remarks/>
        ta,

        /// <remarks/>
        te,

        /// <remarks/>
        tg,

        /// <remarks/>
        th,

        /// <remarks/>
        ti,

        /// <remarks/>
        tk,

        /// <remarks/>
        tl,

        /// <remarks/>
        tn,

        /// <remarks/>
        to,

        /// <remarks/>
        tr,

        /// <remarks/>
        ts,

        /// <remarks/>
        tt,

        /// <remarks/>
        tw,

        /// <remarks/>
        ty,

        /// <remarks/>
        ug,

        /// <remarks/>
        uk,

        /// <remarks/>
        ur,

        /// <remarks/>
        uz,

        /// <remarks/>
        ve,

        /// <remarks/>
        vi,

        /// <remarks/>
        vo,

        /// <remarks/>
        wa,

        /// <remarks/>
        wo,

        /// <remarks/>
        xh,

        /// <remarks/>
        yi,

        /// <remarks/>
        yo,

        /// <remarks/>
        za,

        /// <remarks/>
        zh,

        /// <remarks/>
        zu,
    }

    /// <remarks/>
    public enum CountryCodeEnum
    {

        /// <remarks/>
        AD,

        /// <remarks/>
        AE,

        /// <remarks/>
        AF,

        /// <remarks/>
        AG,

        /// <remarks/>
        AI,

        /// <remarks/>
        AL,

        /// <remarks/>
        AM,

        /// <remarks/>
        AO,

        /// <remarks/>
        AQ,

        /// <remarks/>
        AR,

        /// <remarks/>
        AS,

        /// <remarks/>
        AT,

        /// <remarks/>
        AU,

        /// <remarks/>
        AW,

        /// <remarks/>
        AX,

        /// <remarks/>
        AZ,

        /// <remarks/>
        BA,

        /// <remarks/>
        BB,

        /// <remarks/>
        BD,

        /// <remarks/>
        BE,

        /// <remarks/>
        BF,

        /// <remarks/>
        BG,

        /// <remarks/>
        BH,

        /// <remarks/>
        BI,

        /// <remarks/>
        BJ,

        /// <remarks/>
        BL,

        /// <remarks/>
        BM,

        /// <remarks/>
        BN,

        /// <remarks/>
        BO,

        /// <remarks/>
        BQ,

        /// <remarks/>
        BR,

        /// <remarks/>
        BS,

        /// <remarks/>
        BT,

        /// <remarks/>
        BV,

        /// <remarks/>
        BW,

        /// <remarks/>
        BY,

        /// <remarks/>
        BZ,

        /// <remarks/>
        CA,

        /// <remarks/>
        CC,

        /// <remarks/>
        CD,

        /// <remarks/>
        CF,

        /// <remarks/>
        CG,

        /// <remarks/>
        CH,

        /// <remarks/>
        CI,

        /// <remarks/>
        CK,

        /// <remarks/>
        CL,

        /// <remarks/>
        CM,

        /// <remarks/>
        CN,

        /// <remarks/>
        CO,

        /// <remarks/>
        CR,

        /// <remarks/>
        CU,

        /// <remarks/>
        CV,

        /// <remarks/>
        CW,

        /// <remarks/>
        CX,

        /// <remarks/>
        CY,

        /// <remarks/>
        CZ,

        /// <remarks/>
        DE,

        /// <remarks/>
        DJ,

        /// <remarks/>
        DK,

        /// <remarks/>
        DM,

        /// <remarks/>
        DO,

        /// <remarks/>
        DZ,

        /// <remarks/>
        EC,

        /// <remarks/>
        EE,

        /// <remarks/>
        EG,

        /// <remarks/>
        EH,

        /// <remarks/>
        ER,

        /// <remarks/>
        ES,

        /// <remarks/>
        ET,

        /// <remarks/>
        FI,

        /// <remarks/>
        FJ,

        /// <remarks/>
        FK,

        /// <remarks/>
        FM,

        /// <remarks/>
        FO,

        /// <remarks/>
        FR,

        /// <remarks/>
        GA,

        /// <remarks/>
        GB,

        /// <remarks/>
        GD,

        /// <remarks/>
        GE,

        /// <remarks/>
        GF,

        /// <remarks/>
        GG,

        /// <remarks/>
        GH,

        /// <remarks/>
        GI,

        /// <remarks/>
        GL,

        /// <remarks/>
        GM,

        /// <remarks/>
        GN,

        /// <remarks/>
        GP,

        /// <remarks/>
        GQ,

        /// <remarks/>
        GR,

        /// <remarks/>
        GS,

        /// <remarks/>
        GT,

        /// <remarks/>
        GU,

        /// <remarks/>
        GW,

        /// <remarks/>
        GY,

        /// <remarks/>
        HK,

        /// <remarks/>
        HM,

        /// <remarks/>
        HN,

        /// <remarks/>
        HR,

        /// <remarks/>
        HT,

        /// <remarks/>
        HU,

        /// <remarks/>
        ID,

        /// <remarks/>
        IE,

        /// <remarks/>
        IL,

        /// <remarks/>
        IM,

        /// <remarks/>
        IN,

        /// <remarks/>
        IO,

        /// <remarks/>
        IQ,

        /// <remarks/>
        IR,

        /// <remarks/>
        IS,

        /// <remarks/>
        IT,

        /// <remarks/>
        JE,

        /// <remarks/>
        JM,

        /// <remarks/>
        JO,

        /// <remarks/>
        JP,

        /// <remarks/>
        KE,

        /// <remarks/>
        KG,

        /// <remarks/>
        KH,

        /// <remarks/>
        KI,

        /// <remarks/>
        KM,

        /// <remarks/>
        KN,

        /// <remarks/>
        KP,

        /// <remarks/>
        KR,

        /// <remarks/>
        KW,

        /// <remarks/>
        KY,

        /// <remarks/>
        KZ,

        /// <remarks/>
        LA,

        /// <remarks/>
        LB,

        /// <remarks/>
        LC,

        /// <remarks/>
        LI,

        /// <remarks/>
        LK,

        /// <remarks/>
        LR,

        /// <remarks/>
        LS,

        /// <remarks/>
        LT,

        /// <remarks/>
        LU,

        /// <remarks/>
        LV,

        /// <remarks/>
        LY,

        /// <remarks/>
        MA,

        /// <remarks/>
        MC,

        /// <remarks/>
        MD,

        /// <remarks/>
        ME,

        /// <remarks/>
        MF,

        /// <remarks/>
        MG,

        /// <remarks/>
        MH,

        /// <remarks/>
        MK,

        /// <remarks/>
        ML,

        /// <remarks/>
        MM,

        /// <remarks/>
        MN,

        /// <remarks/>
        MO,

        /// <remarks/>
        MP,

        /// <remarks/>
        MQ,

        /// <remarks/>
        MR,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        MU,

        /// <remarks/>
        MV,

        /// <remarks/>
        MW,

        /// <remarks/>
        MX,

        /// <remarks/>
        MY,

        /// <remarks/>
        MZ,

        /// <remarks/>
        NA,

        /// <remarks/>
        NC,

        /// <remarks/>
        NE,

        /// <remarks/>
        NF,

        /// <remarks/>
        NG,

        /// <remarks/>
        NI,

        /// <remarks/>
        NL,

        /// <remarks/>
        NO,

        /// <remarks/>
        NP,

        /// <remarks/>
        NR,

        /// <remarks/>
        NU,

        /// <remarks/>
        NZ,

        /// <remarks/>
        OM,

        /// <remarks/>
        PA,

        /// <remarks/>
        PE,

        /// <remarks/>
        PF,

        /// <remarks/>
        PG,

        /// <remarks/>
        PH,

        /// <remarks/>
        PK,

        /// <remarks/>
        PL,

        /// <remarks/>
        PM,

        /// <remarks/>
        PN,

        /// <remarks/>
        PR,

        /// <remarks/>
        PS,

        /// <remarks/>
        PT,

        /// <remarks/>
        PW,

        /// <remarks/>
        PY,

        /// <remarks/>
        QA,

        /// <remarks/>
        RE,

        /// <remarks/>
        RO,

        /// <remarks/>
        RS,

        /// <remarks/>
        RU,

        /// <remarks/>
        RW,

        /// <remarks/>
        SA,

        /// <remarks/>
        SB,

        /// <remarks/>
        SC,

        /// <remarks/>
        SD,

        /// <remarks/>
        SE,

        /// <remarks/>
        SG,

        /// <remarks/>
        SH,

        /// <remarks/>
        SI,

        /// <remarks/>
        SJ,

        /// <remarks/>
        SK,

        /// <remarks/>
        SL,

        /// <remarks/>
        SM,

        /// <remarks/>
        SN,

        /// <remarks/>
        SO,

        /// <remarks/>
        SR,

        /// <remarks/>
        SS,

        /// <remarks/>
        ST,

        /// <remarks/>
        SV,

        /// <remarks/>
        SX,

        /// <remarks/>
        SY,

        /// <remarks/>
        SZ,

        /// <remarks/>
        TC,

        /// <remarks/>
        TD,

        /// <remarks/>
        TF,

        /// <remarks/>
        TG,

        /// <remarks/>
        TH,

        /// <remarks/>
        TJ,

        /// <remarks/>
        TK,

        /// <remarks/>
        TL,

        /// <remarks/>
        TM,

        /// <remarks/>
        TN,

        /// <remarks/>
        TO,

        /// <remarks/>
        TR,

        /// <remarks/>
        TT,

        /// <remarks/>
        TV,

        /// <remarks/>
        TW,

        /// <remarks/>
        TZ,

        /// <remarks/>
        UA,

        /// <remarks/>
        UG,

        /// <remarks/>
        UM,

        /// <remarks/>
        US,

        /// <remarks/>
        UY,

        /// <remarks/>
        UZ,

        /// <remarks/>
        VA,

        /// <remarks/>
        VC,

        /// <remarks/>
        VE,

        /// <remarks/>
        VG,

        /// <remarks/>
        VI,

        /// <remarks/>
        VN,

        /// <remarks/>
        VU,

        /// <remarks/>
        WF,

        /// <remarks/>
        WS,

        /// <remarks/>
        YE,

        /// <remarks/>
        YT,

        /// <remarks/>
        ZA,

        /// <remarks/>
        ZM,

        /// <remarks/>
        ZW,
    }

    /// <remarks/>
    public enum RoleDescriptionEnum
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Responsible company")]
        Responsiblecompany,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("National responsible")]
        Nationalresponsible,

        /// <remarks/>
        Manufacturer,

        /// <remarks/>
        Importer,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Only representative")]
        Onlyrepresentative,

        /// <remarks/>
        Reimporter,

        /// <remarks/>
        Formulator,

        /// <remarks/>
        Distributor,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Downstream user")]
        Downstreamuser,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Foreign manufacturer")]
        Foreignmanufacturer,
    }

    /// <remarks/>


    public enum ReachRoleDescriptionEnum
    {

        /// <remarks/>
        Manufacturer,

        /// <remarks/>
        Importer,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Only representative")]
        Onlyrepresentative,

        /// <remarks/>
        Distributor,
    }

    /// <remarks/>
    public enum HazardSymbolCodeEnum
    {

        /// <remarks/>
        E,

        /// <remarks/>
        O,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("T+")]
        T,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("T")]
        T1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("F+")]
        F,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("F")]
        F1,

        /// <remarks/>
        C,

        /// <remarks/>
        Xn,

        /// <remarks/>
        Xi,

        /// <remarks/>
        N,
    }


    /// <remarks/>
    public enum PackingGroupEnum
    {

        /// <remarks/>
        I,

        /// <remarks/>
        II,

        /// <remarks/>
        III,
    }

    /// <remarks/>
    public enum XMLStandardSubsetEnum
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("SdsComXml Light")]
        SdsComXmlLight,

        /// <remarks/>
        EDASXBau,

        /// <remarks/>
        EDASXChem,

        /// <remarks/>
        undefined,
    }

    /// <remarks/>
    public enum AssessmentEnum
    {

        /// <remarks/>
        Yes,

        /// <remarks/>
        No,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Not assessed")]
        Notassessed,
    }

    /// <remarks/>
    public enum ViscosityTypeEnum
    {

        /// <remarks/>
        Dynamic,

        /// <remarks/>
        Kinematic,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Flow time")]
        Flowtime,

        /// <remarks/>
        Undefined,

        /// <remarks/>
        Other,
    }

    /// <remarks/>
    public enum GasGroupEnum
    {

        /// <remarks/>
        IIA,

        /// <remarks/>
        IIB,

        /// <remarks/>
        IIC,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType2
    {

        /// <remarks/>
        Method,

        /// <remarks/>
        ReasonForWaiving,

        /// <remarks/>
        TestReference,

        /// <remarks/>
        Value,
    }

    /// <remarks/>
    public enum ExposureRouteEnum
    {

        /// <remarks/>
        Inhalation,

        /// <remarks/>
        Oral,

        /// <remarks/>
        Dermal,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Inhalation(Gas)")]
        InhalationGas,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Inhalation(Vapour)")]
        InhalationVapour,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Inhalation(Dust/Mist)")]
        InhalationDustMist,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Inhalation(Dust)")]
        InhalationDust,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Inhalation(Mist)")]
        InhalationMist,

        /// <remarks/>
        Subcutane,

        /// <remarks/>
        Intraperitonial,

        /// <remarks/>
        Intravenal,

        /// <remarks/>
        Intraarterial,

        /// <remarks/>
        Unreported,
    }

    /// <remarks/>
    public enum HazardClassCategoryEnum
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Unst. Expl.")]
        UnstExpl,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Expl. 1.1")]
        Expl11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Expl. 1.2")]
        Expl12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Expl. 1.3")]
        Expl13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Expl. 1.4")]
        Expl14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Expl. 1.5")]
        Expl15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Expl. 1.6")]
        Expl16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Flam. Gas 1")]
        FlamGas1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Flam. Gas 2")]
        FlamGas2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Chem. Unst. Gas A")]
        ChemUnstGasA,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Chem. Unst. Gas B")]
        ChemUnstGasB,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Aerosol 1")]
        Aerosol1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Aerosol 2")]
        Aerosol2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Aerosol 3")]
        Aerosol3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Oxid. Gas 1")]
        OxidGas1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Press. Gas")]
        PressGas,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Compr. Gas")]
        ComprGas,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Liquef. Gas")]
        LiquefGas,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Refr. Liquef. Gas")]
        RefrLiquefGas,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Diss. Gas")]
        DissGas,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Flam. Liq. 1")]
        FlamLiq1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Flam. Liq. 2")]
        FlamLiq2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Flam. Liq. 3")]
        FlamLiq3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Flam. Sol. 1")]
        FlamSol1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Flam. Sol. 2")]
        FlamSol2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Self-react. A")]
        SelfreactA,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Self-react. B")]
        SelfreactB,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Self-react. C")]
        SelfreactC,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Self-react. CD")]
        SelfreactCD,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Self-react. D")]
        SelfreactD,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Self-react. E")]
        SelfreactE,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Self-react. EF")]
        SelfreactEF,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Self-react. F")]
        SelfreactF,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Self-react. G")]
        SelfreactG,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Pyr. Liq. 1")]
        PyrLiq1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Pyr. Sol. 1")]
        PyrSol1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Self-heat. 1")]
        Selfheat1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Self-heat. 2")]
        Selfheat2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Water-react. 1")]
        Waterreact1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Water-react. 2")]
        Waterreact2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Water-react. 3")]
        Waterreact3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ox. Liq. 1")]
        OxLiq1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ox. Liq. 2")]
        OxLiq2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ox. Liq. 3")]
        OxLiq3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ox. Sol. 1")]
        OxSol1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ox. Sol. 2")]
        OxSol2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ox. Sol. 3")]
        OxSol3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Org. Perox. A")]
        OrgPeroxA,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Org. Perox. B")]
        OrgPeroxB,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Org. Perox. C")]
        OrgPeroxC,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Org. Perox. CD")]
        OrgPeroxCD,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Org. Perox. D")]
        OrgPeroxD,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Org. Perox. E")]
        OrgPeroxE,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Org. Perox. EF")]
        OrgPeroxEF,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Org. Perox. F")]
        OrgPeroxF,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Org. Perox. G")]
        OrgPeroxG,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Met. Corr. 1")]
        MetCorr1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Acute Tox. 1")]
        AcuteTox1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Acute Tox. 2")]
        AcuteTox2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Acute Tox. 3")]
        AcuteTox3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Acute Tox. 4")]
        AcuteTox4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Skin Corr. 1A")]
        SkinCorr1A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Skin Corr. 1B")]
        SkinCorr1B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Skin Corr. 1C")]
        SkinCorr1C,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Skin Irrit. 2")]
        SkinIrrit2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Eye Irrit. 2")]
        EyeIrrit2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Eye Dam. 1")]
        EyeDam1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Resp. Sens. 1")]
        RespSens1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Resp. Sens. 1A")]
        RespSens1A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Resp. Sens. 1B")]
        RespSens1B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Skin Sens. 1")]
        SkinSens1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Skin Sens. 1A")]
        SkinSens1A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Skin Sens. 1B")]
        SkinSens1B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Muta. 1A")]
        Muta1A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Muta. 1B")]
        Muta1B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Muta. 2")]
        Muta2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Carc. 1A")]
        Carc1A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Carc. 1B")]
        Carc1B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Carc. 2")]
        Carc2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Repr. 1A")]
        Repr1A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Repr. 1B")]
        Repr1B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Repr. 2")]
        Repr2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Lact.")]
        Lact,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("STOT SE 1")]
        STOTSE1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("STOT SE 2")]
        STOTSE2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("STOT SE 3")]
        STOTSE3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("STOT RE 1")]
        STOTRE1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("STOT RE 2")]
        STOTRE2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Asp. Tox. 1")]
        AspTox1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Aquatic Acute 1")]
        AquaticAcute1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Aquatic Chronic 1")]
        AquaticChronic1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Aquatic Chronic 2")]
        AquaticChronic2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Aquatic Chronic 3")]
        AquaticChronic3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Aquatic Chronic 4")]
        AquaticChronic4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ozone 1")]
        Ozone1,
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    public enum XmlStandardVersionEnum
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4.2.0")]
        Item420,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4.2.1")]
        Item421,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4.2.2")]
        Item422,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4.2.3")]
        Item423,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    public enum WaterHazardClassEnum
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        nwg,

        /// <remarks/>
        awg,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    public enum UnitIdEnum
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10081150700")]
        Item10081150700,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10081150900")]
        Item10081150900,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10081151900")]
        Item10081151900,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14290121400")]
        Item14290121400,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9267233755")]
        Item9267233755,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144102")]
        Item9269144102,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144104")]
        Item9269144104,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144105")]
        Item9269144105,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144106")]
        Item9269144106,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144108")]
        Item9269144108,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144109")]
        Item9269144109,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144110")]
        Item9269144110,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144112")]
        Item9269144112,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144113")]
        Item9269144113,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144114")]
        Item9269144114,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144115")]
        Item9269144115,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144116")]
        Item9269144116,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144117")]
        Item9269144117,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144118")]
        Item9269144118,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144119")]
        Item9269144119,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144121")]
        Item9269144121,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144122")]
        Item9269144122,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144123")]
        Item9269144123,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144124")]
        Item9269144124,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144125")]
        Item9269144125,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144126")]
        Item9269144126,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144127")]
        Item9269144127,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144128")]
        Item9269144128,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144130")]
        Item9269144130,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144131")]
        Item9269144131,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144132")]
        Item9269144132,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144133")]
        Item9269144133,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144134")]
        Item9269144134,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144135")]
        Item9269144135,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144136")]
        Item9269144136,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144137")]
        Item9269144137,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144138")]
        Item9269144138,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144139")]
        Item9269144139,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144140")]
        Item9269144140,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144141")]
        Item9269144141,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144142")]
        Item9269144142,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144143")]
        Item9269144143,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144144")]
        Item9269144144,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144145")]
        Item9269144145,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144146")]
        Item9269144146,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144148")]
        Item9269144148,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144149")]
        Item9269144149,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144150")]
        Item9269144150,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144151")]
        Item9269144151,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144152")]
        Item9269144152,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144153")]
        Item9269144153,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144154")]
        Item9269144154,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144155")]
        Item9269144155,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144156")]
        Item9269144156,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144157")]
        Item9269144157,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144158")]
        Item9269144158,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144159")]
        Item9269144159,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144160")]
        Item9269144160,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144161")]
        Item9269144161,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144162")]
        Item9269144162,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144163")]
        Item9269144163,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144164")]
        Item9269144164,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144165")]
        Item9269144165,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144166")]
        Item9269144166,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144167")]
        Item9269144167,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144168")]
        Item9269144168,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144169")]
        Item9269144169,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144170")]
        Item9269144170,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144171")]
        Item9269144171,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144172")]
        Item9269144172,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144173")]
        Item9269144173,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144174")]
        Item9269144174,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144175")]
        Item9269144175,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144176")]
        Item9269144176,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144177")]
        Item9269144177,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144178")]
        Item9269144178,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144179")]
        Item9269144179,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144180")]
        Item9269144180,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144181")]
        Item9269144181,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144182")]
        Item9269144182,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144183")]
        Item9269144183,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144184")]
        Item9269144184,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144185")]
        Item9269144185,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144186")]
        Item9269144186,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144200")]
        Item9269144200,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144201")]
        Item9269144201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144202")]
        Item9269144202,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144203")]
        Item9269144203,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144204")]
        Item9269144204,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144205")]
        Item9269144205,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144206")]
        Item9269144206,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144207")]
        Item9269144207,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144208")]
        Item9269144208,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144209")]
        Item9269144209,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144210")]
        Item9269144210,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144211")]
        Item9269144211,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144212")]
        Item9269144212,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144213")]
        Item9269144213,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144214")]
        Item9269144214,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144215")]
        Item9269144215,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144216")]
        Item9269144216,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144217")]
        Item9269144217,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144218")]
        Item9269144218,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144219")]
        Item9269144219,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144220")]
        Item9269144220,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144221")]
        Item9269144221,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144222")]
        Item9269144222,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144223")]
        Item9269144223,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144224")]
        Item9269144224,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144225")]
        Item9269144225,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144226")]
        Item9269144226,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144227")]
        Item9269144227,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144228")]
        Item9269144228,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144229")]
        Item9269144229,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144230")]
        Item9269144230,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144231")]
        Item9269144231,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144232")]
        Item9269144232,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144233")]
        Item9269144233,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144234")]
        Item9269144234,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144235")]
        Item9269144235,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144236")]
        Item9269144236,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144237")]
        Item9269144237,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144238")]
        Item9269144238,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144239")]
        Item9269144239,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144240")]
        Item9269144240,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144241")]
        Item9269144241,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144242")]
        Item9269144242,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144243")]
        Item9269144243,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144244")]
        Item9269144244,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144245")]
        Item9269144245,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144246")]
        Item9269144246,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144247")]
        Item9269144247,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144248")]
        Item9269144248,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144250")]
        Item9269144250,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144251")]
        Item9269144251,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144252")]
        Item9269144252,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144253")]
        Item9269144253,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144254")]
        Item9269144254,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144255")]
        Item9269144255,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144256")]
        Item9269144256,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144257")]
        Item9269144257,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144259")]
        Item9269144259,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144260")]
        Item9269144260,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144261")]
        Item9269144261,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144262")]
        Item9269144262,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144263")]
        Item9269144263,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144265")]
        Item9269144265,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144266")]
        Item9269144266,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144267")]
        Item9269144267,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144268")]
        Item9269144268,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144269")]
        Item9269144269,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144270")]
        Item9269144270,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144271")]
        Item9269144271,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144272")]
        Item9269144272,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144274")]
        Item9269144274,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144275")]
        Item9269144275,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144276")]
        Item9269144276,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144277")]
        Item9269144277,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144279")]
        Item9269144279,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144280")]
        Item9269144280,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144281")]
        Item9269144281,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144282")]
        Item9269144282,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144283")]
        Item9269144283,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144284")]
        Item9269144284,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144285")]
        Item9269144285,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144286")]
        Item9269144286,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144288")]
        Item9269144288,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144289")]
        Item9269144289,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144290")]
        Item9269144290,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144291")]
        Item9269144291,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144292")]
        Item9269144292,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144294")]
        Item9269144294,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144295")]
        Item9269144295,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144296")]
        Item9269144296,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144297")]
        Item9269144297,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144300")]
        Item9269144300,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144301")]
        Item9269144301,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144302")]
        Item9269144302,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144303")]
        Item9269144303,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144304")]
        Item9269144304,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144305")]
        Item9269144305,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144306")]
        Item9269144306,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144307")]
        Item9269144307,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144308")]
        Item9269144308,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144309")]
        Item9269144309,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144310")]
        Item9269144310,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144311")]
        Item9269144311,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144312")]
        Item9269144312,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144314")]
        Item9269144314,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144315")]
        Item9269144315,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144316")]
        Item9269144316,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144317")]
        Item9269144317,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144318")]
        Item9269144318,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144319")]
        Item9269144319,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144320")]
        Item9269144320,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144321")]
        Item9269144321,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144322")]
        Item9269144322,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144323")]
        Item9269144323,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144324")]
        Item9269144324,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144325")]
        Item9269144325,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144327")]
        Item9269144327,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144328")]
        Item9269144328,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144329")]
        Item9269144329,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144330")]
        Item9269144330,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144331")]
        Item9269144331,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144332")]
        Item9269144332,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144333")]
        Item9269144333,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144334")]
        Item9269144334,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144335")]
        Item9269144335,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144336")]
        Item9269144336,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144337")]
        Item9269144337,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144338")]
        Item9269144338,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144340")]
        Item9269144340,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144341")]
        Item9269144341,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144342")]
        Item9269144342,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144343")]
        Item9269144343,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144344")]
        Item9269144344,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144345")]
        Item9269144345,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144346")]
        Item9269144346,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144347")]
        Item9269144347,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144348")]
        Item9269144348,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144349")]
        Item9269144349,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144350")]
        Item9269144350,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144351")]
        Item9269144351,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144352")]
        Item9269144352,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144353")]
        Item9269144353,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144354")]
        Item9269144354,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144355")]
        Item9269144355,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144356")]
        Item9269144356,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144358")]
        Item9269144358,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144359")]
        Item9269144359,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144360")]
        Item9269144360,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144361")]
        Item9269144361,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144362")]
        Item9269144362,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144363")]
        Item9269144363,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144364")]
        Item9269144364,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144365")]
        Item9269144365,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144366")]
        Item9269144366,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144367")]
        Item9269144367,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144368")]
        Item9269144368,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144369")]
        Item9269144369,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144370")]
        Item9269144370,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144371")]
        Item9269144371,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144372")]
        Item9269144372,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144373")]
        Item9269144373,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144374")]
        Item9269144374,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144375")]
        Item9269144375,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144376")]
        Item9269144376,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144377")]
        Item9269144377,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144378")]
        Item9269144378,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144379")]
        Item9269144379,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144380")]
        Item9269144380,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144381")]
        Item9269144381,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144382")]
        Item9269144382,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144383")]
        Item9269144383,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144384")]
        Item9269144384,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144385")]
        Item9269144385,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144386")]
        Item9269144386,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144387")]
        Item9269144387,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144388")]
        Item9269144388,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9269144416")]
        Item9269144416,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9294211101")]
        Item9294211101,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    public enum SymbolEnum
    {

        /// <remarks/>
        lt,

        /// <remarks/>
        gt,

        /// <remarks/>
        le,

        /// <remarks/>
        ge,

        /// <remarks/>
        eq,

        /// <remarks/>
        ca,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        ExactValue,

        /// <remarks/>
        ExactValueSymbol,

        /// <remarks/>
        LowerValue,

        /// <remarks/>
        LowerValueSymbol,

        /// <remarks/>
        UpperValue,

        /// <remarks/>
        UpperValueSymbol,
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    public enum StorageClassEnum
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 1")]
        LGK1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 2A")]
        LGK2A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 2B")]
        LGK2B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 3")]
        LGK3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 4.1A")]
        LGK41A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 4.1B")]
        LGK41B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 4.2")]
        LGK42,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 4.3")]
        LGK43,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 5.1A")]
        LGK51A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 5.1B")]
        LGK51B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 5.1C")]
        LGK51C,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 5.2")]
        LGK52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 6.1A")]
        LGK61A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 6.1B")]
        LGK61B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 6.1C")]
        LGK61C,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 6.1D")]
        LGK61D,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 6.2")]
        LGK62,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 7")]
        LGK7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 8A")]
        LGK8A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 8B")]
        LGK8B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 9")]
        LGK9,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 10")]
        LGK10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 11")]
        LGK11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 12")]
        LGK12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("LGK 13")]
        LGK13,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    public enum GisCodeEnum
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("BTM 10")]
        BTM10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("BTM 15")]
        BTM15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("BTM 20")]
        BTM20,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("BTM 30")]
        BTM30,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("BTM 40")]
        BTM40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("BTM 50")]
        BTM50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("BTM 60")]
        BTM60,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("BTM 70")]
        BTM70,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("NBM 10")]
        NBM10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("BZM 1")]
        BZM1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("BZM 2")]
        BZM2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("BZM 3")]
        BZM3,

        /// <remarks/>
        BBP10,

        /// <remarks/>
        BBP20,

        /// <remarks/>
        BBP30,

        /// <remarks/>
        BBP40,

        /// <remarks/>
        BBP50,

        /// <remarks/>
        BBP60,

        /// <remarks/>
        BBP70,

        /// <remarks/>
        RE0,

        /// <remarks/>
        RE1,

        /// <remarks/>
        RE2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("RE2.5")]
        RE25,

        /// <remarks/>
        RE3,

        /// <remarks/>
        RE4,

        /// <remarks/>
        RE5,

        /// <remarks/>
        RE6,

        /// <remarks/>
        RE7,

        /// <remarks/>
        RE8,

        /// <remarks/>
        RE9,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-BA01")]
        MBA01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-BA02")]
        MBA02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-DF01")]
        MDF01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-DF02")]
        MDF02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-DF03")]
        MDF03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-DF04")]
        MDF04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-GF01")]
        MGF01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-GF02")]
        MGF02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-GF03")]
        MGF03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-GF04")]
        MGF04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-GF05")]
        MGF05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-GP01")]
        MGP01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-GP02")]
        MGP02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-GP03")]
        MGP03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-GP04")]
        MGP04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-GP05")]
        MGP05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-KH01")]
        MKH01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-KH02")]
        MKH02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-KH03")]
        MKH03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-KH04")]
        MKH04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-KH05")]
        MKH05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-LL01")]
        MLL01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-LL02")]
        MLL02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-LL03")]
        MLL03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-LL04")]
        MLL04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-LL05")]
        MLL05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-LW01")]
        MLW01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-PL01")]
        MPL01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-PL02")]
        MPL02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-PL03")]
        MPL03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-PL04")]
        MPL04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-SF01")]
        MSF01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-SK01")]
        MSK01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-SK02")]
        MSK02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-VM01")]
        MVM01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-VM02")]
        MVM02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-VM03")]
        MVM03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-VM04")]
        MVM04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-VM05")]
        MVM05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-AB10")]
        MAB10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-AB20")]
        MAB20,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-AB30")]
        MAB30,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-AB40")]
        MAB40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-AL10")]
        MAL10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("M-AL20")]
        MAL20,

        /// <remarks/>
        PU10,

        /// <remarks/>
        PU20,

        /// <remarks/>
        PU30,

        /// <remarks/>
        PU40,

        /// <remarks/>
        PU50,

        /// <remarks/>
        PU60,

        /// <remarks/>
        PU70,

        /// <remarks/>
        PU80,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-LB 10")]
        HSMLB10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-LB 15")]
        HSMLB15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-LB 20")]
        HSMLB20,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-LB 30")]
        HSMLB30,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-LB 40")]
        HSMLB40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-LB 50")]
        HSMLB50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-LV 10")]
        HSMLV10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-LV 15")]
        HSMLV15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-LV 20")]
        HSMLV20,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-LV 30")]
        HSMLV30,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-LV 40")]
        HSMLV40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-W 10")]
        HSMW10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-W 20")]
        HSMW20,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-W 30")]
        HSMW30,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-W 40")]
        HSMW40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-W 44")]
        HSMW44,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-W 47")]
        HSMW47,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-W 50")]
        HSMW50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-W 60")]
        HSMW60,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-W 65")]
        HSMW65,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-W 70")]
        HSMW70,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-W 80")]
        HSMW80,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HSM-W 90")]
        HSMW90,

        /// <remarks/>
        BS10,

        /// <remarks/>
        BS20,

        /// <remarks/>
        BS30,

        /// <remarks/>
        BS40,

        /// <remarks/>
        BS50,

        /// <remarks/>
        BS60,

        /// <remarks/>
        ESI10,

        /// <remarks/>
        ESI20,

        /// <remarks/>
        W1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("W2+")]
        W2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("W2")]
        W21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("W3+")]
        W3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("W3")]
        W31,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("W1/DD")]
        W1DD,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("W2/DD+")]
        W2DD,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("W3/DD+")]
        W3DD,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("W3/DD")]
        W3DD1,

        /// <remarks/>
        G1,

        /// <remarks/>
        G2,

        /// <remarks/>
        G3,

        /// <remarks/>
        KH1,

        /// <remarks/>
        KH2,

        /// <remarks/>
        DD1,

        /// <remarks/>
        DD2,

        /// <remarks/>
        SH1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ö10+")]
        Ö10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ö10")]
        Ö101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ö10/DD+")]
        Ö10DD,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ö20+")]
        Ö20,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ö20")]
        Ö201,

        /// <remarks/>
        Ö30,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ö40+")]
        Ö40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ö40")]
        Ö401,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ö40/DD+")]
        Ö40DD,

        /// <remarks/>
        Ö50,

        /// <remarks/>
        Ö60,

        /// <remarks/>
        Ö70,

        /// <remarks/>
        Ö80,

        /// <remarks/>
        Ö90,

        /// <remarks/>
        Ö100,

        /// <remarks/>
        GD10,

        /// <remarks/>
        GD15,

        /// <remarks/>
        GD20,

        /// <remarks/>
        GD25,

        /// <remarks/>
        GD30,

        /// <remarks/>
        GD35,

        /// <remarks/>
        GD40,

        /// <remarks/>
        GD50,

        /// <remarks/>
        GD60,

        /// <remarks/>
        GD65,

        /// <remarks/>
        GD70,

        /// <remarks/>
        GD80,

        /// <remarks/>
        GD90,

        /// <remarks/>
        GD0,

        /// <remarks/>
        GE10,

        /// <remarks/>
        GE20,

        /// <remarks/>
        GE30,

        /// <remarks/>
        GE0,

        /// <remarks/>
        GF50,

        /// <remarks/>
        GF60,

        /// <remarks/>
        GF70,

        /// <remarks/>
        GF0,

        /// <remarks/>
        GG10,

        /// <remarks/>
        GG20,

        /// <remarks/>
        GG30,

        /// <remarks/>
        GG40,

        /// <remarks/>
        GG50,

        /// <remarks/>
        GG60,

        /// <remarks/>
        GG70,

        /// <remarks/>
        GG80,

        /// <remarks/>
        GG90,

        /// <remarks/>
        GG0,

        /// <remarks/>
        GGL10,

        /// <remarks/>
        GGL20,

        /// <remarks/>
        GGL0,

        /// <remarks/>
        GH10,

        /// <remarks/>
        GH20,

        /// <remarks/>
        GH30,

        /// <remarks/>
        GH40,

        /// <remarks/>
        GH0,

        /// <remarks/>
        GR10,

        /// <remarks/>
        GR20,

        /// <remarks/>
        GR0,

        /// <remarks/>
        GS10,

        /// <remarks/>
        GS20,

        /// <remarks/>
        GS25,

        /// <remarks/>
        GS30,

        /// <remarks/>
        GS40,

        /// <remarks/>
        GS50,

        /// <remarks/>
        GS60,

        /// <remarks/>
        GS70,

        /// <remarks/>
        GS80,

        /// <remarks/>
        GS90,

        /// <remarks/>
        GS0,

        /// <remarks/>
        GT10,

        /// <remarks/>
        GT0,

        /// <remarks/>
        GU10,

        /// <remarks/>
        GU20,

        /// <remarks/>
        GU30,

        /// <remarks/>
        GU40,

        /// <remarks/>
        GU50,

        /// <remarks/>
        GU55,

        /// <remarks/>
        GU60,

        /// <remarks/>
        GU70,

        /// <remarks/>
        GU80,

        /// <remarks/>
        GU85,

        /// <remarks/>
        GU90,

        /// <remarks/>
        GU0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("SB-F10")]
        SBF10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("SB-F20")]
        SBF20,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("SB-F30")]
        SBF30,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("SB-F40")]
        SBF40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("SB-P30")]
        SBP30,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("SB-P40")]
        SBP40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("SB-STY10")]
        SBSTY10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("SB-STY20")]
        SBSTY20,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("SB-STY30")]
        SBSTY30,

        /// <remarks/>
        RMA10,

        /// <remarks/>
        RMA20,

        /// <remarks/>
        D1,

        /// <remarks/>
        D2,

        /// <remarks/>
        D3,

        /// <remarks/>
        D4,

        /// <remarks/>
        D5,

        /// <remarks/>
        D6,

        /// <remarks/>
        D7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("S0,5")]
        S05,

        /// <remarks/>
        S1,

        /// <remarks/>
        S2,

        /// <remarks/>
        S3,

        /// <remarks/>
        S4,

        /// <remarks/>
        S5,

        /// <remarks/>
        S6,

        /// <remarks/>
        RS10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("RU0,5")]
        RU05,

        /// <remarks/>
        RU1,

        /// <remarks/>
        RU2,

        /// <remarks/>
        RU3,

        /// <remarks/>
        RU4,

        /// <remarks/>
        CP1,

        /// <remarks/>
        ZP1,

        /// <remarks/>
        ZP2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("-")]
        Item,

        /// <remarks/>
        CD01,

        /// <remarks/>
        CD02,

        /// <remarks/>
        RMA15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ö60+")]
        Ö601,

        /// <remarks/>
        BSW10,

        /// <remarks/>
        BSW20,

        /// <remarks/>
        BSW30,

        /// <remarks/>
        BSW40,

        /// <remarks/>
        BSW50,

        /// <remarks/>
        BSW60,

        /// <remarks/>
        BSL10,

        /// <remarks/>
        BSL20,

        /// <remarks/>
        BSL30,

        /// <remarks/>
        BSL40,

        /// <remarks/>
        BSL50,

        /// <remarks/>
        BSL60,

        /// <remarks/>
        HSW10,

        /// <remarks/>
        HSW13,

        /// <remarks/>
        HSW20,

        /// <remarks/>
        HSW23,

        /// <remarks/>
        HSW27,

        /// <remarks/>
        HSW30,

        /// <remarks/>
        HSW33,

        /// <remarks/>
        HSW37,

        /// <remarks/>
        HSW40,

        /// <remarks/>
        HSW50,

        /// <remarks/>
        HSL10,

        /// <remarks/>
        HSL17,

        /// <remarks/>
        HSL20,

        /// <remarks/>
        HSL27,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("BTM 5")]
        BTM5,

        /// <remarks/>
        BZM10,

        /// <remarks/>
        BZM20,

        /// <remarks/>
        BZM30,

        /// <remarks/>
        BZM40,

        /// <remarks/>
        BZM50,

        /// <remarks/>
        GD13,

        /// <remarks/>
        GD33,

        /// <remarks/>
        GD45,

        /// <remarks/>
        GD55,

        /// <remarks/>
        GF10,

        /// <remarks/>
        GF20,

        /// <remarks/>
        GF30,

        /// <remarks/>
        GF40,

        /// <remarks/>
        GG43,

        /// <remarks/>
        GG53,

        /// <remarks/>
        GG63,

        /// <remarks/>
        GGL05,

        /// <remarks/>
        GS15,

        /// <remarks/>
        GS18,

        /// <remarks/>
        GS35,

        /// <remarks/>
        GS38,

        /// <remarks/>
        GS45,

        /// <remarks/>
        GS48,

        /// <remarks/>
        GS85,

        /// <remarks/>
        GT20,

        /// <remarks/>
        GU73,

        /// <remarks/>
        GU83,

        /// <remarks/>
        GU88,

        /// <remarks/>
        GU93,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    public enum ReasonForWaiving
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("cannot be determined")]
        cannotbedetermined,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("not applicable")]
        notapplicable,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("no data")]
        nodata,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {

        /// <remarks/>
        Method,

        /// <remarks/>
        ReasonForWaiving,

        /// <remarks/>
        TestReference,

        /// <remarks/>
        UnitValue,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    public enum ToxicityTypeEnum
    {

        /// <remarks/>
        Acute,

        /// <remarks/>
        Delayed,

        /// <remarks/>
        Subchronic,

        /// <remarks/>
        Chronic,

        /// <remarks/>
        ReproductionSexualFunction,

        /// <remarks/>
        ReproductionDevToxicity,

        /// <remarks/>
        ReproductionLactation,

        /// <remarks/>
        Carcinogenicity,

        /// <remarks/>
        InVivoMutagenicity,

        /// <remarks/>
        InVitroMutagenicity,

        /// <remarks/>
        RespiratorySensitivity,

        /// <remarks/>
        SkinSensitivity,

        /// <remarks/>
        SkinCorrosion,

        /// <remarks/>
        EyeIrritation,

        /// <remarks/>
        SkinIrritation,

        /// <remarks/>
        EyeDamage,

        /// <remarks/>
        Aspiration,

        /// <remarks/>
        Other,

        /// <remarks/>
        Unreported,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    public enum DoseEnum
    {

        /// <remarks/>
        NOEC,

        /// <remarks/>
        LOEC,

        /// <remarks/>
        NOEL,

        /// <remarks/>
        LOEL,

        /// <remarks/>
        NOAEL,

        /// <remarks/>
        LOAEL,

        /// <remarks/>
        LC0,

        /// <remarks/>
        LClo,

        /// <remarks/>
        LCLo,

        /// <remarks/>
        LC50,

        /// <remarks/>
        LC100,

        /// <remarks/>
        LD0,

        /// <remarks/>
        LDlo,

        /// <remarks/>
        LDLo,

        /// <remarks/>
        LD50,

        /// <remarks/>
        LD100,

        /// <remarks/>
        EC0,

        /// <remarks/>
        EC3,

        /// <remarks/>
        EC10,

        /// <remarks/>
        EC20,

        /// <remarks/>
        EC25,

        /// <remarks/>
        EC50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("EC50 (+ UVA)")]
        EC50UVA,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("EC50 (- UVA)")]
        EC50UVA1,

        /// <remarks/>
        EC80,

        /// <remarks/>
        ATEmix,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("ATEmix tested")]
        ATEmixtested,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("ATEmix calculated")]
        ATEmixcalculated,

        /// <remarks/>
        cATpE,

        /// <remarks/>
        ERC50,

        /// <remarks/>
        ERClo,

        /// <remarks/>
        ERCLo,

        /// <remarks/>
        IC50,

        /// <remarks/>
        other,
    }
}
