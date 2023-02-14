using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAlpha0._1
{
    static class DataBank
    {
        private static int bueyr = 0;
        private static int order = 0;
        private static int money = 240;
        /// элементы
        private static int hydrogen = 0;// +
        private static int sulfur = 0; // +
        private static int Helium = 0;//гелий + +
        private static int Boron = 0;//бор ++
        private static int Carbon = 10;//углерод // не добавляю в покупки
        private static int Nitrogen = 0;//азот ++
        private static int Oxygen = 777;//кислород 
        private static int Chlorine = 0;//хлор ++
        /// кол-во синтезируемого вещества
        private static int Hydrogen_Sulfide = 0;
        private static int hel_hel_hel = 0;// получение из 3 гелиев одного углерода
        private static int helium_hydrogen = 0;//получение гидрогелия из гелия и гидрогена
        private static int carbid_bora = 0;//получение карбида бора из карбона и бора
        private static int nitrogen_boron = 0;//получение нитрида бора из азота и бора
        private static int oksid_azota = 0;//оксид азота из азота и кислорода
        private static int dioksid_hlora = 0;//диоксид хлора из хлора и двух кислорода 
        private static int trihlorid_azota = 0;//трихлорид азота из азотов и трех хлора
        /// комбинация для синтеза
        private static string HydrogenSulfide = "H2 + S";
        private static string helhelhel = "He + He + He";
        private static string heliumhydrogen = "He + H";
        private static string carbidbora = "C + B";
        private static string nitrogenboron = "N + B";
        private static string oksidazota = "N + O";
        private static string dioksidhlora = "Cl + O2";
        private static string trihloridazota = "N + Cl3";

        private static bool sound_volume = true;


        public static int get_bueyr()
        {
            return bueyr;
        }
        public static void set_bueyr(int buy)
        {
            bueyr = buy;
        }
        public static int get_money()
        {
            return money;
        }
        public static void set_money(int monet)
        {
            money = monet;
        }
        public static int get_order()
        {
            return order;
        }
        public static void set_order(int ordet)
        {
            order = ordet;
        }
        
        public static int get_hydrogen()
        {
            return hydrogen;
        }
        public static void set_hydrogen(int hydroget)
        {
            hydrogen = hydroget;
        }
        public static int get_sulfur()
        {
            return sulfur;
        }
        public static void set_sulfur(int sulfut)
        {
            sulfur = sulfut;
        }
        public static int get_helium()
        {
            return Helium;
        }
        public static void set_helium(int heliut)
        {
            Helium= heliut;
        }
        public static int get_boron()
        {
            return Boron;
        }
        public static void set_boron(int borot)
        {
            Boron= borot;
        }
        public static int get_carbon()
        {
            return Carbon;
        }
        public static void set_carbon(int carbon)
        {
            Carbon= carbon;
        }
        public static int get_nitrogen()
        {
            return Nitrogen;
        }
        public static void set_nitrogen(int nitrogen)
        {
            Nitrogen= nitrogen;
        }
        public static int get_oxygen()
        {
            return Oxygen;
        }
        public static void set_oxygen(int oxygen)
        {
            Oxygen= oxygen;
        }
        public static int get_chlorine()
        {
            return Chlorine;
        }
        public static void set_chlorine(int chlorine)
        {
            Chlorine= chlorine;
        }
        
        public static int get_hydrogen_sulfide()
        {
            return Hydrogen_Sulfide;
        }
        public static void set_hydrogen_sulfide(int hydrogenfid)
        {
            Hydrogen_Sulfide= hydrogenfid;
        }
        public static int get_hel_hel_hel()
        {
            return hel_hel_hel;
        }
        public static void set_hel_hel_hel(int hel_hel)
        {
            hel_hel_hel= hel_hel;
        }
        public static int get_helium_hydrogen()
        {
            return helium_hydrogen;
        }
        public static void set_helium_hydrogen(int helium_hydrogent)
        {
            helium_hydrogen= helium_hydrogent;
        }
        public static int get_carbid_bora()
        {
            return carbid_bora;
        }
        public static void set_carbid_bora(int carbid_borat)
        {
            carbid_bora= carbid_borat;
        }
        public static int get_nitrogen_boron()
        {
            return nitrogen_boron;
        }
        public static void set_nitrogen_boron(int nitrogen_noront)
        {
            nitrogen_boron= nitrogen_noront;
        }
        public static int get_oksid_azota()
        {
            return oksid_azota;
        }
        public static void set_oksid_azota(int oksid_azott)
        {
            oksid_azota= oksid_azott;
        }
        public static int get_dioksid_hlora()
        {
            return dioksid_hlora;
        }
        public static void set_dioksid_hlora(int dioksid_hlorat)
        {
            dioksid_hlora= dioksid_hlorat;
        }
        public static int get_trihlorid_azota()
        {
            return trihlorid_azota;
        }
        public static void set_trihlorid_azota(int trihlorid_azott)
        {
            trihlorid_azota= trihlorid_azott;
        }
        
        public static string get_HydrogenSulfide()
        {
            return HydrogenSulfide;
        }
        public static string get_helhelhel()
        {
            return helhelhel;
        }
        public static string get_heliumhydrogen()
        {
            return heliumhydrogen;
        }
        public static string get_carbidbora()
        {
            return carbidbora;
        }
        public static string get_nitrogenboron()
        {
            return nitrogenboron;
        }
        public static string get_oksidazota()
        {
            return oksidazota;
        }
        public static string get_dioksidhlora()
        {
            return dioksidhlora;
        }
        public static string get_trihloridazota()
        {
            return trihloridazota;
        }

        public static bool get_sound_volume()
        {
            return sound_volume;
        }
        public static void set_sound_volume(bool volume) 
        { 
            sound_volume = volume; 
        }

        public static List<string> getallstr()
        {
            var fieldValues = typeof(DataBank)
                                 .GetFields().Where(x => x.FieldType == typeof(int))
                                 .Select(field => field.GetValue(null).ToString())
                                 .ToList();
            Console.WriteLine(fieldValues);
            return fieldValues;

        }
    }
}
