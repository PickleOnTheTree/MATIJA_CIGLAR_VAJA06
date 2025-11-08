using System;
using System.IO;

namespace vaja6
{
    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

    public class Igralec
    {
        public int id;
        public string u_ime;
        public string u_geslo;
        public static int stIg = 1; 

        public Igralec()
        {
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }


        public Igralec(Igralec drugi)
        {
            this.u_ime = drugi.u_ime;
            this.u_geslo = drugi.u_geslo;
            this.id = drugi.id;
        }

        public Igralec(string podatki)
        {
            string[] deli = podatki.Split(';');
            if (deli.Length == 2)
            {
                this.u_ime = deli[0].Trim();
                this.u_geslo = deli[1].Trim();
            }
            else
            {
                this.u_ime = "";
                this.u_geslo = "";
            }
            this.id = stIg;
            stIg++;
        }

        public int Id
        {
            get { return id; }
        }

        public string U_ime
        {
            get { return u_ime; }
            set { u_ime = value.Trim(); }
        }

        public string U_geslo
        {
            get { return u_geslo; }
            set { u_geslo = value.Trim(); }
        }

        public static int StIg
        {
            get { return stIg; }
        }

        public override string ToString()
        {
            return $"{id}: {u_ime} ({u_geslo})";
        }
    }

    class Vaja
    {
        public static void Main(string[] args)
        {
            Igralec ig1 = new Igralec("Marko;geslo123");
            Igralec ig2 = new Igralec(ig1);

            Console.WriteLine(ig1);
            Console.WriteLine(ig2);
        }
    }
}

