using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Edificios 
{
    public int edificiosTier1;
    public int edificiosTier2;
    public int edificiosTier3;
    public int edificiosTier4;
    public int edificiosTier5;

    public int costeEdificiosTier1;
    public int costeEdificiosTier2;
    public int costeEdificiosTier3;
    public int costeEdificiosTier4;
    public int costeEdificiosTier5;

    public Edificios(int edificiosTier1, int edificiosTier2, int edificiosTier3, int edificiosTier4, int edificiosTier5,
                int costeEdificiosTier1, int costeEdificiosTier2, int costeEdificiosTier3, int costeEdificiosTier4, int costeEdificiosTier5)
    {
        this.edificiosTier1 = edificiosTier1;
        this.edificiosTier2 = edificiosTier2;
        this.edificiosTier3 = edificiosTier1;
        this.edificiosTier4 = edificiosTier4;
        this.edificiosTier5 = edificiosTier5;

        this.costeEdificiosTier1 = costeEdificiosTier1;
        this.costeEdificiosTier2 = costeEdificiosTier2;
        this.costeEdificiosTier3 = costeEdificiosTier3;
        this.costeEdificiosTier4 = costeEdificiosTier4;
        this.costeEdificiosTier5 = costeEdificiosTier5;
    }

    public Edificios()
    {

    }

}
