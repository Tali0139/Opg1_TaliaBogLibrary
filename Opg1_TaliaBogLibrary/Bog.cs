using System;

namespace Opg1_TaliaBogLibrary
{
    public class Bog
    {
        private string _titel;
        private string _forfatter;
        private int _sidetal;
        private string _isbn;
        
        public Bog(string titel, string forfatter, int sidetal, string isbn)
        {
            Titel = titel;
            Forfatter = forfatter;
            Sidetal = sidetal;
            Isbn = isbn;
        }

        /*Tilføjet constructor uden titel, da der ifølge opgaven ikke er nogen constraints på titlen, 
        som jeg derfor må formode, må tillade null værdier/intet input. I den virkelige verden giver 
        det måske ikke så meget mening, men der findes jo f.eks. bands som har udgivet plader uden titel.
        Er godt klar over, at man jo bare kan bruge null eller "" i den første constructor, men når det 
        nu i følge opgavebeskrivelsen er lovligt med en tom titel, kan man lige så godt gøre det eksplicit*/
        public Bog(string forfatter, int sidetal, string isbn)
        {   
            Forfatter = forfatter;
            Sidetal = sidetal;
            Isbn = isbn;
        }
        
        public string Titel
        {
            get => _titel;
            set => _titel = value;
        }
        
        public string Forfatter
        {
            get => _forfatter;
            set
            {
                if (value.Length >= 2) _forfatter = value;
                else
                {
                    string e = "Forfatternavnet skal være på mindst 2 bogstaver!";
                    throw new ArgumentOutOfRangeException(e);
                }
            }
        }
        
        public int Sidetal
        {
            get => _sidetal;
            set
            {
                if (value >= 4 && value <= 1000) _sidetal = value;
                else
                {
                    string e = "Bogen skal have mindst 4 og højst 1000 sider!";
                    throw new ArgumentOutOfRangeException(e);
                }
            }
        }

        public string Isbn
        {
            get => _isbn;
            set
            {
                if (value.Length == 13) _isbn = value;
                else
                {
                    string e = "Isbn skal altid være på præcis 13 bogstaver!";
                    throw new ArgumentOutOfRangeException(e);
                }
            }
        }
    }
}
