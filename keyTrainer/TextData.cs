using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyTrainer
{
    static class TextData
    {
        private static int strInLengthRu = 55;
        private static int strInLengthEn = 70;
        private static string enText= "";
        public static List<string> enArray;
        private static string ruText= "";
        public static List<string> ruArray;
        private static string csText = "";
        public static List<string> csArray;
        public static void GetTextData()
        {
            // en
            enText = "";

            for (int i = 0; i < Properties.Resources.en.Length; i++)
            {
                if (Properties.Resources.en[i] == '\n' || Properties.Resources.ru[i] == '\t')
                {
                    enText += ' ';
                }
                else if (Properties.Resources.en[i] == '\r')
                {

                }
                else
                {
                    enText += Properties.Resources.en[i];
                }
            }
            enArray = new List<string>();
            for (int i = 0; i < enText.Length; )
            {
                if (enText.Length - i < strInLengthEn + 20)
                {
                    enArray.Add(enText.Substring(i, enText.Length - i));
                    i += strInLengthEn + 20;
                }
                else
                {
                    int spaceIndex = enText.IndexOf(' ', i + strInLengthEn);

                    enArray.Add(enText.Substring(i, spaceIndex - i));
                    i += spaceIndex - i;
                }
                enArray[enArray.Count - 1] = enArray[enArray.Count - 1].Trim();
            }
            //en


            //ru
            ruText = "";

            for (int i = 0; i < Properties.Resources.ru.Length; i++)
            {
                if (Properties.Resources.ru[i] == '\n' || Properties.Resources.ru[i] == '\t')
                {
                    ruText += ' ';
                }
                else if (Properties.Resources.ru[i] == '\r')
                {

                }
                else
                {
                    ruText += Properties.Resources.ru[i];
                }
            }
            ruArray = new List<string>();
            for (int i = 0; i < ruText.Length;)
            {
                if (ruText.Length - i < strInLengthRu + 20)
                {
                    ruArray.Add(ruText.Substring(i, ruText.Length - i));
                    i += strInLengthRu + 20;
                }
                else
                {
                    int spaceIndex = ruText.IndexOf(' ', i + strInLengthRu);

                    ruArray.Add(ruText.Substring(i, spaceIndex - i));
                    i += spaceIndex - i;
                }
                ruArray[ruArray.Count - 1] = ruArray[ruArray.Count - 1].Trim();
            }
            //ru

            
        }
        public static void GetForeignTextData(string text)
        {
            //cs
            csText = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '\n' || text[i] == '\t')
                {
                    csText += ' ';
                }
                else if (text[i] == '\r')
                {

                }
                else
                {
                    csText += text[i];
                }
            }
            csArray = new List<string>();
            for (int i = 0; i < csText.Length;)
            {
                if (csText.Length - i < strInLengthRu + 20)
                {
                    csArray.Add(csText.Substring(i, csText.Length - i));
                    i += strInLengthRu + 20;
                }
                else
                {
                    int spaceIndex = csText.IndexOf(' ', i + strInLengthRu);

                    csArray.Add(csText.Substring(i, spaceIndex - i));
                    i += spaceIndex - i;
                }
                csArray[csArray.Count - 1] = csArray[csArray.Count - 1].Trim();
            }
            //cs
        }
    }
}
