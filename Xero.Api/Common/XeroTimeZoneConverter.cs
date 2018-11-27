using System;
using System.Collections.Generic;
using System.Linq;

namespace Xero.Api.Common
{
    public static class XeroTimeZoneConverter
    {
        private const string XERO_AFGHANISTAN_STANDARD_TIME = "AFGHANISTANSTANDARDTIME";
        private const string XERO_ALASKAN_STANDARD_TIME = "ALASKANSTANDARDTIME";
        private const string XERO_ARAB_STANDARD_TIME = "ARABIANSTANDARDTIME";
        private const string XERO_ARABIAN_STANDARD_TIME = "ARABICSTANDARDTIME";
        private const string XERO_ARABIC_STANDARD_TIME = "ARABSTANDARDTIME";
        private const string XERO_ARGENTINA_STANDARD_TIME = "ARGENTINASTANDARDTIME";
        private const string XERO_ATLANTIC_STANDARD_TIME = "ATLANTICSTANDARDTIME";
        private const string XERO_AUS_CENTRAL_STANDARD_TIME = "AUSCENTRALSTANDARDTIME";
        private const string XERO_AUS_EASTERN_STANDARD_TIME = "AUSEASTERNSTANDARDTIME";
        private const string XERO_AZERBAIJAN_STANDARD_TIME = "AZERBAIJANSTANDARDTIME";
        private const string XERO_AZORES_STANDARD_TIME = "AZORESSTANDARDTIME";
        private const string XERO_BAHIA_STANDARD_TIME = "BAHIASTANDARDTIME";
        private const string XERO_BANGLADESH_STANDARD_TIME = "BANGLADESHSTANDARDTIME";
        private const string XERO_CABO_VERDE_STANDARD_TIME = "CAPEVERDESTANDARDTIME";
        private const string XERO_CANADA_CENTRAL_STANDARD_TIME = "CANADACENTRALSTANDARDTIME";
        private const string XERO_CAUCASUS_STANDARD_TIME = "CAUCASUSSTANDARDTIME";
        private const string XERO_CEN_AUSTRALIA_STANDARD_TIME = "CENAUSTRALIASTANDARDTIME";
        private const string XERO_CENTRAL_AMERICA_STANDARD_TIME = "CENTRALAMERICASTANDARDTIME";
        private const string XERO_CENTRAL_ASIA_STANDARD_TIME = "CENTRALASIASTANDARDTIME";
        private const string XERO_CENTRAL_BRAZILIAN_STANDARD_TIME = "CENTRALBRAZILIANSTANDARDTIME";
        private const string XERO_CENTRAL_EUROPE_STANDARD_TIME = "CENTRALEUROPESTANDARDTIME";
        private const string XERO_CENTRAL_EUROPEAN_STANDARD_TIME = "CENTRALEUROPEANSTANDARDTIME";
        private const string XERO_CENTRAL_PACIFIC_STANDARD_TIME = "CENTRALPACIFICSTANDARDTIME";
        private const string XERO_CENTRAL_STANDARD_TIME = "CENTRALSTANDARDTIME";
        private const string XERO_CENTRAL_STANDARD_TIME_MEXICO = "CENTRALSTANDARDTIMEMEXICO";
        private const string XERO_CHINA_STANDARD_TIME = "CHINASTANDARDTIME";
        private const string XERO_DATELINE_STANDARD_TIME = "DATELINESTANDARDTIME";
        private const string XERO_E_AFRICA_STANDARD_TIME = "EAFRICASTANDARDTIME";
        private const string XERO_E_AUSTRALIA_STANDARD_TIME = "EAUSTRALIASTANDARDTIME";
        private const string XERO_E_EUROPE_STANDARD_TIME = "EEUROPESTANDARDTIME";
        private const string XERO_E_SOUTH_AMERICA_STANDARD_TIME = "ESOUTHAMERICASTANDARDTIME";
        private const string XERO_EASTERN_STANDARD_TIME = "EASTERNSTANDARDTIME";
        private const string XERO_EGYPT_STANDARD_TIME = "EGYPTSTANDARDTIME";
        private const string XERO_EKATERINBURG_STANDARD_TIME = "EKATERINBURGSTANDARDTIME";
        private const string XERO_FIJI_STANDARD_TIME = "FIJISTANDARDTIME";
        private const string XERO_FLE_STANDARD_TIME = "FLESTANDARDTIME";
        private const string XERO_GEORGIAN_STANDARD_TIME = "GEORGIANSTANDARDTIME";
        private const string XERO_GMT_STANDARD_TIME = "GMTSTANDARDTIME";
        private const string XERO_GREENLAND_STANDARD_TIME = "GREENLANDSTANDARDTIME";
        private const string XERO_GREENWICH_STANDARD_TIME = "GREENWICHSTANDARDTIME";
        private const string XERO_GTB_STANDARD_TIME = "GTBSTANDARDTIME";
        private const string XERO_HAWAIIAN_STANDARD_TIME = "HAWAIIANSTANDARDTIME";
        private const string XERO_INDIA_STANDARD_TIME = "INDIASTANDARDTIME";
        private const string XERO_IRAN_STANDARD_TIME = "IRANSTANDARDTIME";
        private const string XERO_ISRAEL_STANDARD_TIME = "ISRAELSTANDARDTIME";
        private const string XERO_JORDAN_STANDARD_TIME = "JORDANSTANDARDTIME";
        private const string XERO_KALININGRAD_STANDARD_TIME = "KALININGRADSTANDARDTIME";
        private const string XERO_KAMCHATKA_STANDARD_TIME = "KAMCHATKASTANDARDTIME";
        private const string XERO_KOREA_STANDARD_TIME = "KOREASTANDARDTIME";
        private const string XERO_MAGADAN_STANDARD_TIME = "MAGADANSTANDARDTIME";
        private const string XERO_MAURITIUS_STANDARD_TIME = "MAURITIUSSTANDARDTIME";
        private const string XERO_MID_ATLANTIC_STANDARD_TIME = "MIDATLANTICSTANDARDTIME";
        private const string XERO_MIDDLE_EAST_STANDARD_TIME = "MIDDLEEASTSTANDARDTIME";
        private const string XERO_MONTEVIDEO_STANDARD_TIME = "MONTEVIDEOSTANDARDTIME";
        private const string XERO_MOROCCO_STANDARD_TIME = "MOROCCOSTANDARDTIME";
        private const string XERO_MOUNTAIN_STANDARD_TIME = "MOUNTAINSTANDARDTIME";
        private const string XERO_MOUNTAIN_STANDARD_TIME_MEXICO = "MOUNTAINSTANDARDTIMEMEXICO";
        private const string XERO_MYANMAR_STANDARD_TIME = "MYANMARSTANDARDTIME";
        private const string XERO_N_CENTRAL_ASIA_STANDARD_TIME = "NCENTRALASIASTANDARDTIME";
        private const string XERO_NAMIBIA_STANDARD_TIME = "NAMIBIASTANDARDTIME";
        private const string XERO_NEPAL_STANDARD_TIME = "NEPALSTANDARDTIME";
        private const string XERO_NEW_ZEALAND_STANDARD_TIME = "NEWZEALANDSTANDARDTIME";
        private const string XERO_NEWFOUNDLAND_STANDARD_TIME = "NEWFOUNDLANDSTANDARDTIME";
        private const string XERO_NORTH_ASIA_EAST_STANDARD_TIME = "NORTHASIAEASTSTANDARDTIME";
        private const string XERO_NORTH_ASIA_STANDARD_TIME = "NORTHASIASTANDARDTIME";
        private const string XERO_PACIFIC_SA_STANDARD_TIME = "PACIFICSASTANDARDTIME";
        private const string XERO_PACIFIC_STANDARD_TIME = "PACIFICSTANDARDTIME";
        private const string XERO_PACIFIC_STANDARD_TIME_MEXICO = "PACIFICSTANDARDTIMEMEXICO";
        private const string XERO_PAKISTAN_STANDARD_TIME = "PAKISTANSTANDARDTIME";
        private const string XERO_PARAGUAY_STANDARD_TIME = "PARAGUAYSTANDARDTIME";
        private const string XERO_ROMANCE_STANDARD_TIME = "ROMANCESTANDARDTIME";
        private const string XERO_RUSSIAN_STANDARD_TIME = "RUSSIANSTANDARDTIME";
        private const string XERO_RUSSIA_TIMEZONE3_TIME = "RUSSIATIMEZONE3";
        private const string XERO_SA_EASTERN_STANDARD_TIME = "SAEASTERNSTANDARDTIME";
        private const string XERO_SA_PACIFIC_STANDARD_TIME = "SAPACIFICSTANDARDTIME";
        private const string XERO_SA_WESTERN_STANDARD_TIME = "SAWESTERNSTANDARDTIME";
        private const string XERO_SAMOA_STANDARD_TIME = "SAMOASTANDARDTIME";
        private const string XERO_SE_ASIA_STANDARD_TIME = "SEASIASTANDARDTIME";
        private const string XERO_SINGAPORE_STANDARD_TIME = "SINGAPORESTANDARDTIME";
        private const string XERO_SOUTH_AFRICA_STANDARD_TIME = "SOUTHAFRICASTANDARDTIME";
        private const string XERO_SRI_LANKA_STANDARD_TIME = "SRILANKASTANDARDTIME";
        private const string XERO_SYRIA_STANDARD_TIME = "SYRIASTANDARDTIME";
        private const string XERO_TAIPEI_STANDARD_TIME = "TAIPEISTANDARDTIME";
        private const string XERO_TASMANIA_STANDARD_TIME = "TASMANIASTANDARDTIME";
        private const string XERO_TOKYO_STANDARD_TIME = "TOKYOSTANDARDTIME";
        private const string XERO_TONGA_STANDARD_TIME = "TONGASTANDARDTIME";
        private const string XERO_TURKEY_STANDARD_TIME = "TURKEYSTANDARDTIME";
        private const string XERO_ULAANBAATAR_STANDARD_TIME = "ULAANBAATARSTANDARDTIME";
        private const string XERO_US_EASTERN_STANDARD_TIME = "USEASTERNSTANDARDTIME";
        private const string XERO_US_MOUNTAIN_STANDARD_TIME = "USMOUNTAINSTANDARDTIME";
        private const string XERO_UTC = "UTC";
        private const string XERO_UTC_MINUS_11 = "UTC11";
        private const string XERO_VENEZUELA_STANDARD_TIME = "VENEZUELASTANDARDTIME";
        private const string XERO_VLADIVOSTOK_STANDARD_TIME = "VLADIVOSTOKSTANDARDTIME";
        private const string XERO_W_AUSTRALIA_STANDARD_TIME = "WAUSTRALIASTANDARDTIME";
        private const string XERO_W_CENTRAL_AFRICA_STANDARD_TIME = "WCENTRALAFRICASTANDARDTIME";
        private const string XERO_W_EUROPE_STANDARD_TIME = "WEUROPESTANDARDTIME";
        private const string XERO_WEST_ASIA_STANDARD_TIME = "WESTASIASTANDARDTIME";
        private const string XERO_WEST_PACIFIC_STANDARD_TIME = "WESTPACIFICSTANDARDTIME";
        private const string XERO_YAKUTSK_STANDARD_TIME = "YAKUTSKSTANDARDTIME";

        private const string AFGHANISTAN_STANDARD_TIME = "Afghanistan Standard Time";
        private const string ALASKAN_STANDARD_TIME = "Alaskan Standard Time";
        private const string ARAB_STANDARD_TIME = "Arab Standard Time";
        private const string ARABIAN_STANDARD_TIME = "Arabian Standard Time";
        private const string ARABIC_STANDARD_TIME = "Arabic Standard Time";
        private const string ARGENTINA_STANDARD_TIME = "Argentina Standard Time";
        private const string ATLANTIC_STANDARD_TIME = "Atlantic Standard Time";
        private const string AUS_CENTRAL_STANDARD_TIME = "AUS Central Standard Time";
        private const string AUS_EASTERN_STANDARD_TIME = "AUS Eastern Standard Time";
        private const string AZERBAIJAN_STANDARD_TIME = "Azerbaijan Standard Time";
        private const string AZORES_STANDARD_TIME = "Azores Standard Time";
        private const string BANGLADESH_STANDARD_TIME = "Bangladesh Standard Time";
        private const string CABO_VERDE_STANDARD_TIME = "Cabo Verde Standard Time";
        private const string CANADA_CENTRAL_STANDARD_TIME = "Canada Central Standard Time";
        private const string CAUCASUS_STANDARD_TIME = "Caucasus Standard Time";
        private const string CEN_AUSTRALIA_STANDARD_TIME = "Cen. Australia Standard Time";
        private const string CENTRAL_AMERICA_STANDARD_TIME = "Central America Standard Time";
        private const string CENTRAL_ASIA_STANDARD_TIME = "Central Asia Standard Time";
        private const string CENTRAL_BRAZILIAN_STANDARD_TIME = "Central Brazilian Standard Time";
        private const string CENTRAL_EUROPE_STANDARD_TIME = "Central Europe Standard Time";
        private const string CENTRAL_EUROPEAN_STANDARD_TIME = "Central European Standard Time";
        private const string CENTRAL_PACIFIC_STANDARD_TIME = "Central Pacific Standard Time";
        private const string CENTRAL_STANDARD_TIME = "Central Standard Time";
        private const string CENTRAL_STANDARD_TIME_MEXICO = "Central Standard Time (Mexico)";
        private const string CHINA_STANDARD_TIME = "China Standard Time";
        private const string DATELINE_STANDARD_TIME = "Dateline Standard Time";
        private const string E_AFRICA_STANDARD_TIME = "E. Africa Standard Time";
        private const string E_AUSTRALIA_STANDARD_TIME = "E. Australia Standard Time";
        private const string E_EUROPE_STANDARD_TIME = "E. Europe Standard Time";
        private const string E_SOUTH_AMERICA_STANDARD_TIME = "E. South America Standard Time";
        private const string EASTERN_STANDARD_TIME = "Eastern Standard Time";
        private const string EGYPT_STANDARD_TIME = "Egypt Standard Time";
        private const string EKATERINBURG_STANDARD_TIME = "Ekaterinburg Standard Time";
        private const string FIJI_STANDARD_TIME = "Fiji Standard Time";
        private const string FLE_STANDARD_TIME = "FLE Standard Time";
        private const string GEORGIAN_STANDARD_TIME = "Georgian Standard Time";
        private const string GMT_STANDARD_TIME = "GMT Standard Time";
        private const string GREENLAND_STANDARD_TIME = "Greenland Standard Time";
        private const string GREENWICH_STANDARD_TIME = "Greenwich Standard Time";
        private const string GTB_STANDARD_TIME = "GTB Standard Time";
        private const string HAWAIIAN_STANDARD_TIME = "Hawaiian Standard Time";
        private const string INDIA_STANDARD_TIME = "India Standard Time";
        private const string IRAN_STANDARD_TIME = "Iran Standard Time";
        private const string ISRAEL_STANDARD_TIME = "Israel Standard Time";
        private const string JORDAN_STANDARD_TIME = "Jordan Standard Time";
        private const string KALININGRAD_STANDARD_TIME = "Kaliningrad Standard Time";
        private const string FIJI_ISLANDS_STANDARD_TIME = "Fiji Islands Standard Time";
        private const string KOREA_STANDARD_TIME = "Korea Standard Time";
        private const string MAGADAN_STANDARD_TIME = "Magadan Standard Time";
        private const string MAURITIUS_STANDARD_TIME = "Mauritius Standard Time";
        private const string MID_ATLANTIC_STANDARD_TIME = "Mid-Atlantic Standard Time";
        private const string MIDDLE_EAST_STANDARD_TIME = "Middle East Standard Time";
        private const string MONTEVIDEO_STANDARD_TIME = "Montevideo Standard Time";
        private const string MOROCCO_STANDARD_TIME = "Morocco Standard Time";
        private const string MOUNTAIN_STANDARD_TIME = "Mountain Standard Time";
        private const string MOUNTAIN_STANDARD_TIME_MEXICO = "Mountain Standard Time (Mexico)";
        private const string MYANMAR_STANDARD_TIME = "Myanmar Standard Time";
        private const string N_CENTRAL_ASIA_STANDARD_TIME = "N. Central Asia Standard Time";
        private const string NAMIBIA_STANDARD_TIME = "Namibia Standard Time";
        private const string NEPAL_STANDARD_TIME = "Nepal Standard Time";
        private const string NEW_ZEALAND_STANDARD_TIME = "New Zealand Standard Time";
        private const string NEWFOUNDLAND_STANDARD_TIME = "Newfoundland Standard Time";
        private const string NORTH_ASIA_EAST_STANDARD_TIME = "North Asia East Standard Time";
        private const string NORTH_ASIA_STANDARD_TIME = "North Asia Standard Time";
        private const string PACIFIC_SA_STANDARD_TIME = "Pacific SA Standard Time";
        private const string PACIFIC_STANDARD_TIME = "Pacific Standard Time";
        private const string PACIFIC_STANDARD_TIME_MEXICO = "Pacific Standard Time (Mexico)";
        private const string PAKISTAN_STANDARD_TIME = "Pakistan Standard Time";
        private const string PARAGUAY_STANDARD_TIME = "Paraguay Standard Time";
        private const string ROMANCE_STANDARD_TIME = "Romance Standard Time";
        private const string RUSSIAN_STANDARD_TIME = "Russian Standard Time";
        private const string RUSSIAN_TIMEZONE3_TIME = "Russia Time Zone 3";
        private const string SA_EASTERN_STANDARD_TIME = "SA Eastern Standard Time";
        private const string SA_PACIFIC_STANDARD_TIME = "SA Pacific Standard Time";
        private const string SA_WESTERN_STANDARD_TIME = "SA Western Standard Time";
        private const string SAMOA_STANDARD_TIME = "Samoa Standard Time";
        private const string SE_ASIA_STANDARD_TIME = "SE Asia Standard Time";
        private const string SINGAPORE_STANDARD_TIME = "Singapore Standard Time";
        private const string SOUTH_AFRICA_STANDARD_TIME = "South Africa Standard Time";
        private const string SRI_LANKA_STANDARD_TIME = "Sri Lanka Standard Time";
        private const string SYRIA_STANDARD_TIME = "Syria Standard Time";
        private const string TAIPEI_STANDARD_TIME = "Taipei Standard Time";
        private const string TASMANIA_STANDARD_TIME = "Tasmania Standard Time";
        private const string TOKYO_STANDARD_TIME = "Tokyo Standard Time";
        private const string TONGA_STANDARD_TIME = "Tonga Standard Time";
        private const string TURKEY_STANDARD_TIME = "Turkey Standard Time";
        private const string ULAANBAATAR_STANDARD_TIME = "Ulaanbaatar Standard Time";
        private const string US_EASTERN_STANDARD_TIME = "US Eastern Standard Time";
        private const string US_MOUNTAIN_STANDARD_TIME = "US Mountain Standard Time";
        private const string UTC = "UTC";
        private const string UTC_PLUS_12 = "UTC+12";
        private const string UTC_MINUS_11 = "UTC-11";
        private const string UTC_MINUS_2 = "UTC-2";
        private const string VENEZUELA_STANDARD_TIME = "Venezuela Standard Time";
        private const string VLADIVOSTOK_STANDARD_TIME = "Vladivostok Standard Time";
        private const string W_AUSTRALIA_STANDARD_TIME = "W. Australia Standard Time";
        private const string W_CENTRAL_AFRICA_STANDARD_TIME = "W. Central Africa Standard Time";
        private const string W_EUROPE_STANDARD_TIME = "W. Europe Standard Time";
        private const string WEST_ASIA_STANDARD_TIME = "West Asia Standard Time";
        private const string WEST_PACIFIC_STANDARD_TIME = "West Pacific Standard Time";
        private const string YAKUTSK_STANDARD_TIME = "Yakutsk Standard Time";

        public static string GetTimeZoneIdFromXeroTimeZone(string xeroTimeZone)
        {
            string timeZoneId;

            switch (xeroTimeZone)
            {
                case XERO_AFGHANISTAN_STANDARD_TIME:
                    timeZoneId = AFGHANISTAN_STANDARD_TIME;
                    break;
                case XERO_ALASKAN_STANDARD_TIME:
                    timeZoneId = ALASKAN_STANDARD_TIME;
                    break;
                case XERO_ARAB_STANDARD_TIME:
                    timeZoneId = ARAB_STANDARD_TIME;
                    break;
                case XERO_ARABIAN_STANDARD_TIME:
                    timeZoneId = ARABIAN_STANDARD_TIME;
                    break;
                case XERO_ARABIC_STANDARD_TIME:
                    timeZoneId = ARABIC_STANDARD_TIME;
                    break;
                case XERO_ARGENTINA_STANDARD_TIME:
                    timeZoneId = ARGENTINA_STANDARD_TIME;
                    break;
                case XERO_ATLANTIC_STANDARD_TIME:
                    timeZoneId = ATLANTIC_STANDARD_TIME;
                    break;
                case XERO_AUS_CENTRAL_STANDARD_TIME:
                    timeZoneId = AUS_CENTRAL_STANDARD_TIME;
                    break;
                case XERO_AUS_EASTERN_STANDARD_TIME:
                    timeZoneId = AUS_EASTERN_STANDARD_TIME;
                    break;
                case XERO_AZERBAIJAN_STANDARD_TIME:
                    timeZoneId = AZERBAIJAN_STANDARD_TIME;
                    break;
                case XERO_AZORES_STANDARD_TIME:
                    timeZoneId = AZORES_STANDARD_TIME;
                    break;
                case XERO_BAHIA_STANDARD_TIME:
                    timeZoneId = CENTRAL_BRAZILIAN_STANDARD_TIME;
                    break;
                case XERO_BANGLADESH_STANDARD_TIME:
                    timeZoneId = BANGLADESH_STANDARD_TIME;
                    break;
                case XERO_CABO_VERDE_STANDARD_TIME:
                    timeZoneId = CABO_VERDE_STANDARD_TIME;
                    break;
                case XERO_CANADA_CENTRAL_STANDARD_TIME:
                    timeZoneId = CANADA_CENTRAL_STANDARD_TIME;
                    break;
                case XERO_CAUCASUS_STANDARD_TIME:
                    timeZoneId = CAUCASUS_STANDARD_TIME;
                    break;
                case XERO_CEN_AUSTRALIA_STANDARD_TIME:
                    timeZoneId = CEN_AUSTRALIA_STANDARD_TIME;
                    break;
                case XERO_CENTRAL_AMERICA_STANDARD_TIME:
                    timeZoneId = CENTRAL_AMERICA_STANDARD_TIME;
                    break;
                case XERO_CENTRAL_ASIA_STANDARD_TIME:
                    timeZoneId = CENTRAL_ASIA_STANDARD_TIME;
                    break;
                case XERO_CENTRAL_BRAZILIAN_STANDARD_TIME:
                    timeZoneId = CENTRAL_BRAZILIAN_STANDARD_TIME;
                    break;
                case XERO_CENTRAL_EUROPE_STANDARD_TIME:
                    timeZoneId = CENTRAL_EUROPE_STANDARD_TIME;
                    break;
                case XERO_CENTRAL_EUROPEAN_STANDARD_TIME:
                    timeZoneId = CENTRAL_EUROPEAN_STANDARD_TIME;
                    break;
                case XERO_CENTRAL_PACIFIC_STANDARD_TIME:
                    timeZoneId = CENTRAL_PACIFIC_STANDARD_TIME;
                    break;
                case XERO_CENTRAL_STANDARD_TIME:
                    timeZoneId = CENTRAL_STANDARD_TIME;
                    break;
                case XERO_CENTRAL_STANDARD_TIME_MEXICO:
                    timeZoneId = CENTRAL_STANDARD_TIME_MEXICO;
                    break;
                case XERO_CHINA_STANDARD_TIME:
                    timeZoneId = CHINA_STANDARD_TIME;
                    break;
                case XERO_DATELINE_STANDARD_TIME:
                    timeZoneId = DATELINE_STANDARD_TIME;
                    break;
                case XERO_E_AFRICA_STANDARD_TIME:
                    timeZoneId = E_AFRICA_STANDARD_TIME;
                    break;
                case XERO_E_AUSTRALIA_STANDARD_TIME:
                    timeZoneId = E_AUSTRALIA_STANDARD_TIME;
                    break;
                case XERO_E_EUROPE_STANDARD_TIME:
                    timeZoneId = E_EUROPE_STANDARD_TIME;
                    break;
                case XERO_E_SOUTH_AMERICA_STANDARD_TIME:
                    timeZoneId = E_SOUTH_AMERICA_STANDARD_TIME;
                    break;
                case XERO_EASTERN_STANDARD_TIME:
                    timeZoneId = EASTERN_STANDARD_TIME;
                    break;
                case XERO_EGYPT_STANDARD_TIME:
                    timeZoneId = EGYPT_STANDARD_TIME;
                    break;
                case XERO_EKATERINBURG_STANDARD_TIME:
                    timeZoneId = EKATERINBURG_STANDARD_TIME;
                    break;
                case XERO_FIJI_STANDARD_TIME:
                    timeZoneId = FIJI_STANDARD_TIME;
                    break;
                case XERO_FLE_STANDARD_TIME:
                    timeZoneId = FLE_STANDARD_TIME;
                    break;
                case XERO_GEORGIAN_STANDARD_TIME:
                    timeZoneId = GEORGIAN_STANDARD_TIME;
                    break;
                case XERO_GMT_STANDARD_TIME:
                    timeZoneId = GMT_STANDARD_TIME;
                    break;
                case XERO_GREENLAND_STANDARD_TIME:
                    timeZoneId = GREENLAND_STANDARD_TIME;
                    break;
                case XERO_GREENWICH_STANDARD_TIME:
                    timeZoneId = GREENWICH_STANDARD_TIME;
                    break;
                case XERO_GTB_STANDARD_TIME:
                    timeZoneId = GTB_STANDARD_TIME;
                    break;
                case XERO_HAWAIIAN_STANDARD_TIME:
                    timeZoneId = HAWAIIAN_STANDARD_TIME;
                    break;
                case XERO_INDIA_STANDARD_TIME:
                    timeZoneId = INDIA_STANDARD_TIME;
                    break;
                case XERO_IRAN_STANDARD_TIME:
                    timeZoneId = IRAN_STANDARD_TIME;
                    break;
                case XERO_ISRAEL_STANDARD_TIME:
                    timeZoneId = ISRAEL_STANDARD_TIME;
                    break;
                case XERO_JORDAN_STANDARD_TIME:
                    timeZoneId = JORDAN_STANDARD_TIME;
                    break;
                case XERO_KALININGRAD_STANDARD_TIME:
                    timeZoneId = KALININGRAD_STANDARD_TIME;
                    break;
                case XERO_KAMCHATKA_STANDARD_TIME:
                    timeZoneId = FIJI_ISLANDS_STANDARD_TIME;
                    break;
                case XERO_KOREA_STANDARD_TIME:
                    timeZoneId = KOREA_STANDARD_TIME;
                    break;
                case XERO_MAGADAN_STANDARD_TIME:
                    timeZoneId = MAGADAN_STANDARD_TIME;
                    break;
                case XERO_MAURITIUS_STANDARD_TIME:
                    timeZoneId = MAURITIUS_STANDARD_TIME;
                    break;
                case XERO_MID_ATLANTIC_STANDARD_TIME:
                    timeZoneId = MID_ATLANTIC_STANDARD_TIME;
                    break;
                case XERO_MIDDLE_EAST_STANDARD_TIME:
                    timeZoneId = MIDDLE_EAST_STANDARD_TIME;
                    break;
                case XERO_MONTEVIDEO_STANDARD_TIME:
                    timeZoneId = MONTEVIDEO_STANDARD_TIME;
                    break;
                case XERO_MOROCCO_STANDARD_TIME:
                    timeZoneId = MOROCCO_STANDARD_TIME;
                    break;
                case XERO_MOUNTAIN_STANDARD_TIME:
                    timeZoneId = MOUNTAIN_STANDARD_TIME;
                    break;
                case XERO_MOUNTAIN_STANDARD_TIME_MEXICO:
                    timeZoneId = MOUNTAIN_STANDARD_TIME_MEXICO;
                    break;
                case XERO_MYANMAR_STANDARD_TIME:
                    timeZoneId = MYANMAR_STANDARD_TIME;
                    break;
                case XERO_N_CENTRAL_ASIA_STANDARD_TIME:
                    timeZoneId = N_CENTRAL_ASIA_STANDARD_TIME;
                    break;
                case XERO_NAMIBIA_STANDARD_TIME:
                    timeZoneId = NAMIBIA_STANDARD_TIME;
                    break;
                case XERO_NEPAL_STANDARD_TIME:
                    timeZoneId = NEPAL_STANDARD_TIME;
                    break;
                case XERO_NEW_ZEALAND_STANDARD_TIME:
                    timeZoneId = NEW_ZEALAND_STANDARD_TIME;
                    break;
                case XERO_NEWFOUNDLAND_STANDARD_TIME:
                    timeZoneId = NEWFOUNDLAND_STANDARD_TIME;
                    break;
                case XERO_NORTH_ASIA_EAST_STANDARD_TIME:
                    timeZoneId = NORTH_ASIA_EAST_STANDARD_TIME;
                    break;
                case XERO_NORTH_ASIA_STANDARD_TIME:
                    timeZoneId = NORTH_ASIA_STANDARD_TIME;
                    break;
                case XERO_PACIFIC_SA_STANDARD_TIME:
                    timeZoneId = PACIFIC_SA_STANDARD_TIME;
                    break;
                case XERO_PACIFIC_STANDARD_TIME:
                    timeZoneId = PACIFIC_STANDARD_TIME;
                    break;
                case XERO_PACIFIC_STANDARD_TIME_MEXICO:
                    timeZoneId = PACIFIC_STANDARD_TIME_MEXICO;
                    break;
                case XERO_PAKISTAN_STANDARD_TIME:
                    timeZoneId = PAKISTAN_STANDARD_TIME;
                    break;
                case XERO_PARAGUAY_STANDARD_TIME:
                    timeZoneId = PARAGUAY_STANDARD_TIME;
                    break;
                case XERO_ROMANCE_STANDARD_TIME:
                    timeZoneId = ROMANCE_STANDARD_TIME;
                    break;
                case XERO_RUSSIAN_STANDARD_TIME:
                    timeZoneId = RUSSIAN_STANDARD_TIME;
                    break;
                case XERO_RUSSIA_TIMEZONE3_TIME:
                    timeZoneId = RUSSIAN_TIMEZONE3_TIME;
                    break;
                case XERO_SA_EASTERN_STANDARD_TIME:
                    timeZoneId = SA_EASTERN_STANDARD_TIME;
                    break;
                case XERO_SA_PACIFIC_STANDARD_TIME:
                    timeZoneId = SA_PACIFIC_STANDARD_TIME;
                    break;
                case XERO_SA_WESTERN_STANDARD_TIME:
                    timeZoneId = SA_WESTERN_STANDARD_TIME;
                    break;
                case XERO_SAMOA_STANDARD_TIME:
                    timeZoneId = SAMOA_STANDARD_TIME;
                    break;
                case XERO_SE_ASIA_STANDARD_TIME:
                    timeZoneId = SE_ASIA_STANDARD_TIME;
                    break;
                case XERO_SINGAPORE_STANDARD_TIME:
                    timeZoneId = SINGAPORE_STANDARD_TIME;
                    break;
                case XERO_SOUTH_AFRICA_STANDARD_TIME:
                    timeZoneId = SOUTH_AFRICA_STANDARD_TIME;
                    break;
                case XERO_SRI_LANKA_STANDARD_TIME:
                    timeZoneId = SRI_LANKA_STANDARD_TIME;
                    break;
                case XERO_SYRIA_STANDARD_TIME:
                    timeZoneId = SYRIA_STANDARD_TIME;
                    break;
                case XERO_TAIPEI_STANDARD_TIME:
                    timeZoneId = TAIPEI_STANDARD_TIME;
                    break;
                case XERO_TASMANIA_STANDARD_TIME:
                    timeZoneId = TASMANIA_STANDARD_TIME;
                    break;
                case XERO_TOKYO_STANDARD_TIME:
                    timeZoneId = TOKYO_STANDARD_TIME;
                    break;
                case XERO_TONGA_STANDARD_TIME:
                    timeZoneId = TONGA_STANDARD_TIME;
                    break;
                case XERO_TURKEY_STANDARD_TIME:
                    timeZoneId = TURKEY_STANDARD_TIME;
                    break;
                case XERO_ULAANBAATAR_STANDARD_TIME:
                    timeZoneId = ULAANBAATAR_STANDARD_TIME;
                    break;
                case XERO_US_EASTERN_STANDARD_TIME:
                    timeZoneId = US_EASTERN_STANDARD_TIME;
                    break;
                case XERO_US_MOUNTAIN_STANDARD_TIME:
                    timeZoneId = US_MOUNTAIN_STANDARD_TIME;
                    break;
                case XERO_UTC:
                    timeZoneId = UTC;
                    break;
                case XERO_UTC_MINUS_11:
                    timeZoneId = UTC_MINUS_11;
                    break;
                case XERO_VENEZUELA_STANDARD_TIME:
                    timeZoneId = VENEZUELA_STANDARD_TIME;
                    break;
                case XERO_VLADIVOSTOK_STANDARD_TIME:
                    timeZoneId = VLADIVOSTOK_STANDARD_TIME;
                    break;
                case XERO_W_AUSTRALIA_STANDARD_TIME:
                    timeZoneId = W_AUSTRALIA_STANDARD_TIME;
                    break;
                case XERO_W_CENTRAL_AFRICA_STANDARD_TIME:
                    timeZoneId = W_CENTRAL_AFRICA_STANDARD_TIME;
                    break;
                case XERO_W_EUROPE_STANDARD_TIME:
                    timeZoneId = W_EUROPE_STANDARD_TIME;
                    break;
                case XERO_WEST_ASIA_STANDARD_TIME:
                    timeZoneId = WEST_ASIA_STANDARD_TIME;
                    break;
                case XERO_WEST_PACIFIC_STANDARD_TIME:
                    timeZoneId = WEST_PACIFIC_STANDARD_TIME;
                    break;
                case XERO_YAKUTSK_STANDARD_TIME:
                    timeZoneId = YAKUTSK_STANDARD_TIME;
                    break;
                default:
                    timeZoneId = UTC;
                    break;
            }

            var timeZoneIds = new HashSet<string>(TimeZoneInfo.GetSystemTimeZones().Select(tz => tz.Id));

            if (!timeZoneIds.Contains(timeZoneId))
            {
                timeZoneId = string.Empty;
            }

            return timeZoneId;
        }
    }
}
