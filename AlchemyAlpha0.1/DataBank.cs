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
        public static int order = 0;
        public static int money = 240;
        /// элементы
        public static int hydrogen = 0;// +
        public static int sulfur = 0; // +
        public static int Helium = 0;//гелий + +
        public static int Boron = 0;//бор ++
        public static int Carbon = 10;//углерод // не добавляю в покупки
        public static int Nitrogen = 0;//азот ++
        public static int Oxygen = 777;//кислород 
        public static int Chlorine = 0;//хлор ++
        /// кол-во синтезируемого вещества
        public static int Hydrogen_Sulfide = 0;
        public static int hel_hel_hel = 0;// получение из 3 гелиев одного углерода
        public static int helium_hydrogen = 0;//получение гидрогелия из гелия и гидрогена
        public static int carbid_bora = 0;//получение карбида бора из карбона и бора
        public static int nitrogen_boron = 0;//получение нитрида бора из азота и бора
        public static int oksid_azota = 0;//оксид азота из азота и кислорода
        public static int dioksid_hlora = 0;//диоксид хлора из хлора и двух кислорода 
        public static int trihlorid_azota = 0;//трихлорид азота из азотов и трех хлора
        /// комбинация для синтеза
        public static string HydrogenSulfide = "H2 + S";
        public static string helhelhel = "He + He + He";
        public static string heliumhydrogen = "He + H";
        public static string carbidbora = "C + B";
        public static string nitrogenboron = "N + B";
        public static string oksidazota = "N + O";
        public static string dioksidhlora = "Cl + O2";
        public static string trihloridazota = "N + Cl3";

        public static bool sound_volume = true;

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
