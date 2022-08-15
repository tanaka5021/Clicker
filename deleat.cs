using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleat : MonoBehaviour
{
    public void DeleatAction()
    {
        //データを前削除
        PlayerPrefs.SetInt("MONEY", 0);

        PlayerPrefs.SetInt("BBUY", 0);
        PlayerPrefs.SetInt("SBUY", 0);
        PlayerPrefs.SetInt("GBUY", 0);
        PlayerPrefs.SetInt("NMETER", 0);
        PlayerPrefs.SetInt("SMETER", 0);
        PlayerPrefs.SetInt("BMETER", 0);
        PlayerPrefs.SetInt("GMETER", 0);
        PlayerPrefs.SetInt("NBREAK", 0);
        PlayerPrefs.SetInt("BBREAK", 0);
        PlayerPrefs.SetInt("SBREAK", 0);
        PlayerPrefs.SetInt("GBREAK", 0);
        PlayerPrefs.SetInt("BORNUS", 0);



        PlayerPrefs.Save();//ディスクへの書き込み
        //
        if (cover.bardeffectclick == 0)
        {
            cover.bardeffectclick = 1;
        }
    }

}
