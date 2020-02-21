using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloadasProject
{
    public class Eloadas
    {
        bool[,] foglalasok;
        public Eloadas(int sorokSzama, int helyekSzama)
        {
            foglalasok = new bool[sorokSzama, helyekSzama];
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < helyekSzama; j++)
                {
                    foglalasok[i, j] = false;
                }
            }
            if (sorokSzama <= 0 || helyekSzama <= 0)
            {
                throw new ArgumentException();
            }
        }
        bool Lefoglal()
        {  
            for (int i = 0; i < foglalasok.Length-1; i++)
            {
                for (int j = 0; j < foglalasok.Length-1; j++)
                {
                    if (foglalasok[i, j] == false)
                    {
                        foglalasok[i, j] = true;
                        return true;
                    }
                }
            }
            return false;
        }
        int SzabadHelyekSzama()
        {
            int db = 0;
            for (int i = 0; i < foglalasok.Length - 1; i++)
            {
                for (int j = 0; j < foglalasok.Length - 1; j++)
                {
                    if (!Lefoglal())
                    {
                        db++;
                    }
                }
            }
            
            return db;
        }
        bool Teli()
        {
            if (SzabadHelyekSzama() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool Foglalt(int sorSzam, int helySzam)
        {
            if (sorSzam > foglalasok.Length || helySzam > foglalasok.Length)
            {
                throw new ArgumentException();
            }
            else
            {
                if (foglalasok[sorSzam, helySzam] == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
