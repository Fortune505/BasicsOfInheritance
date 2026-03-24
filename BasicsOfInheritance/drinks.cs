using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfInheritance
{
    public class Drinks
    {
        public virtual String GetInfo()
        {
            return "Я напиток";
        }

    }
    public class Juice : Drinks
    {
        public double Volume = 0.0;
        public string FruitsUsed = "";
        public bool PresenceOfPulp = false;

        public override String GetInfo()
        {
            var str = "Я сок";
            str += String.Format("\nОбъем {0}", this.Volume);
            return str;
        }
    }

    public enum SodaView {sweet, mineralWater}
    public class Soda : Drinks
    {
        public double Volume = 0.0;
        public int NumberOfBubbles = 0;
        public SodaView view = SodaView.sweet;

        public override String GetInfo()
        {
            var str = "Я газировка";
            str += String.Format("\nОбъем {0}", this.Volume);
            return str;
        }
    }

    public enum AlcoholType {fermented, distillate, rectifiedSpirit}
    public class Alcohol : Drinks
    {
        public double Volume = 0.0;
        public int Fortress = 0;
        public AlcoholType type = AlcoholType.fermented;

        public override String GetInfo()
        {
            var str = "Я алкаголь";
            str += String.Format("\nОбъем {0}", this.Volume);
            return str;
        }
    }
}