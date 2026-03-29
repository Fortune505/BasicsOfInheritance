using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfInheritance
{
    public class Drinks
    {
        public double Volume = 0.0;
        public virtual String GetInfo()
        {
            return String.Format("Объем: {0} л.", this.Volume);
        }

    }
    public class Juice : Drinks
    {
        public string FruitsUsed = "";
        public bool PresenceOfPulp = false;

        public override String GetInfo()
        {
            var str = "Я сок\n";
            str += base.GetInfo();
            str += String.Format("\nФрукты: {0}", this.FruitsUsed);
            str += String.Format("\nНаличие мякоти: {0}", this.PresenceOfPulp ? "Да" : "Нет");
            return str;
        }
    }

    public enum SodaView {sweet, mineralWater}
    public class Soda : Drinks
    {
        
        public int NumberOfBubbles = 0;
        public SodaView view = SodaView.sweet;

        public override String GetInfo()
        {
            var str = "Я газировка\n";
            str += base.GetInfo();
            str += String.Format("\nКоличество пузырьков: {0}", this.NumberOfBubbles);
            str += String.Format("\nВид: {0}", this.view == SodaView.sweet ? "Сладкая" : "Минеральная");
            return str;
        }
    }

    public enum AlcoholType {fermented, distillate, rectifiedSpirit}
    public class Alcohol : Drinks
    {
        
        public int Fortress = 0;
        public AlcoholType type = AlcoholType.fermented;

        public override String GetInfo()
        {
            var str = "Я алкаголь\n";
            str += base.GetInfo();
            str += String.Format("\nКрепость: {0}", this.Fortress);
            string translationType = "";
            switch (this.type)
            {
                case AlcoholType.fermented:
                    translationType = "Ферментированный";
                    break;
                case AlcoholType.distillate:
                    translationType = "Дистиллят";
                    break;
                case AlcoholType.rectifiedSpirit:
                    translationType = "Ректифицированный спирт";
                    break;
            }
            str += String.Format("\nТип: {0}", translationType);
            return str;
        }
    }
}