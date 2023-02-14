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
        static int order = 0;
        static int money = 240;
        /// элементы
        static int hydrogen = 0;// +
        static int sulfur = 0; // +
        static int Helium = 0;//гелий + +
        static int Boron = 0;//бор ++
        static int Carbon = 10;//углерод // не добавляю в покупки
        static int Nitrogen = 0;//азот ++
        static int Oxygen = 777;//кислород 
        static int Chlorine = 0;//хлор ++
        /// кол-во синтезируемого вещества
        static int Hydrogen_Sulfide = 0;
        static int hel_hel_hel = 0;// получение из 3 гелиев одного углерода
        static int helium_hydrogen = 0;//получение гидрогелия из гелия и гидрогена
        static int carbid_bora = 0;//получение карбида бора из карбона и бора
        static int nitrogen_boron = 0;//получение нитрида бора из азота и бора
        static int oksid_azota = 0;//оксид азота из азота и кислорода
        static int dioksid_hlora = 0;//диоксид хлора из хлора и двух кислорода 
        static int trihlorid_azota = 0;//трихлорид азота из азотов и трех хлора
        /// комбинация для синтеза
        static string HydrogenSulfide = "H2 + S";
        static string helhelhel = "He + He + He";
        static string heliumhydrogen = "He + H";
        static string carbidbora = "C + B";
        static string nitrogenboron = "N + B";
        static string oksidazota = "N + O";
        static string dioksidhlora = "Cl + O2";
        static string trihloridazota = "N + Cl3";

        static bool sound_volume = true;

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
