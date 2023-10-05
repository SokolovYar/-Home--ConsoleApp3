using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal abstract class MusicInstrument
    {
        protected string TYPE { get; set; }
    }
    interface IMusicInstrument
    {
        void Sound();
        void Show();
        void Desc();
        void History();
    }

    internal class Violin : MusicInstrument, IMusicInstrument
    {
        public Violin()
        {
            TYPE = "Violin";
        }

        public virtual void Sound()
        {
            Console.WriteLine("U-u-u-u-u");
        }
        public virtual void Show()
        {
            Console.WriteLine($"This is the {TYPE ?? "unknown"}");
        }
        public virtual void Desc()
        {
            Console.WriteLine("Gentle bow instrument");
        }
        public virtual void History()
        {
            Console.WriteLine("The earliest stringed instruments were mostly plucked (for example, the Greek lyre).");
        }
    }

    internal class Trombone : MusicInstrument, IMusicInstrument
    {
        public Trombone()
        {

            TYPE = "Trombone";
        }
        public virtual void Sound()
        {
            Console.WriteLine("Pumb-pumb-pum");
        }
        public virtual void Show()
        {
            Console.WriteLine($"This is the {TYPE ?? "unknown"}");
        }
        public virtual void Desc()
        {
            Console.WriteLine("Gentle bow instrument");
        }
        public virtual void History()
        {
            Console.WriteLine("Trombone comes from the Italian word tromba (trumpet) plus the suffix -one (large), meaning large trumpet.");
        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            IMusicInstrument MyInstrument = new Violin();
            MyInstrument.Show();
            MyInstrument.Sound();
            MyInstrument.Desc();
            MyInstrument.History();

            Console.WriteLine();
            MyInstrument = new Trombone();
            MyInstrument.Show();
            MyInstrument.Sound();
            MyInstrument.Desc();
            MyInstrument.History();
        }
    }
}
