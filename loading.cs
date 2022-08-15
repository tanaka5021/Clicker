using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loading : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        cover.bardeffectclick = PlayerPrefs.GetInt("BORNUS", save.bornas);
        if (cover.bardeffectclick == 0)
        {
            cover.bardeffectclick = 1;
        }

        Sdetail.Sgage = PlayerPrefs.GetInt("SMETER", save.Smeter);


        if (PlayerPrefs.GetInt("SBREAK", save.Sbreak) == 0)
        {
            Sdetail.isSMax = false;
        }
        else
        {
            Sdetail.isSMax = true;
        }


        Gdetail.Ggage = PlayerPrefs.GetInt("GMETER", save.Gmeter);


        if (PlayerPrefs.GetInt("GBREAK", save.Gbreak) == 0)
        {
            Gdetail.isGMax = false;
        }
        else
        {
            Gdetail.isGMax = true;
        }

        Bdetail.Bgage = PlayerPrefs.GetInt("BMETER", save.Bmeter);


        if (PlayerPrefs.GetInt("BBREAK", save.Bbreak) == 0)
        {
            Bdetail.isBMax = false;
        }
        else
        {
            Bdetail.isBMax = true;
        }


        Ndetail.Ngage = PlayerPrefs.GetInt("NMETER", save.Nmeter);


        if (PlayerPrefs.GetInt("NBREAK", save.Nbreak) == 0)
        {
            Ndetail.isNMax = false;
        }
        else
        {
            Ndetail.isNMax = true;
        }

        if (PlayerPrefs.GetInt("BBUY", save.Bbuy) == 0)
        {
            bronzbuy.bronzegg = false;
        }
        else
        {
            bronzbuy.bronzegg = true;
        }

        if (PlayerPrefs.GetInt("GBUY", save.Gbuy) == 0)
        {
            goldbuy.goldegg = false;
        }
        else
        {
            goldbuy.goldegg = true;
        }

        if (PlayerPrefs.GetInt("SBUY", save.Sbuy) == 1)
        {
            silberbuy.silberegg = true;
        }
        else
        {
            silberbuy.silberegg = false;
        }

        //sum.total = (long)(PlayerPrefs.GetFloat("MONEY", save.money) * 1000);
        sum.total = PlayerPrefs.GetInt("MONEY", save.money);


        /*
        Debug.Log(silberbuy.silberegg);
        Debug.Log(goldbuy.goldegg);
        Debug.Log(bronzbuy.bronzegg);
        Debug.Log(cover.bardeffectclick);
        Debug.Log(cover.bardeffectclick);
        Debug.Log(Sdetail.Sgage);
        Debug.Log(Sdetail.isSMax);
        Debug.Log(Bdetail.Bgage);
        Debug.Log(Gdetail.Ggage);
        Debug.Log(Gdetail.isGMax);
        Debug.Log(Bdetail.isBMax);
        Debug.Log(Ndetail.isNMax);
        Debug.Log(sum.total);
        */
        Debug.Log(PlayerPrefs.GetFloat("MONEY", save.money));


    }

}
