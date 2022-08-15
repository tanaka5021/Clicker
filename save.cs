using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class save : MonoBehaviour
{
    //public static float money;    //持ち金
    public static int money;    //持ち金


    //購入
    public static int Bbuy;//銅
    public static int Sbuy;//銀
    public static int Gbuy;//金

    //卵のメーター情報
    public static int Nmeter;
    public static int Bmeter;
    public static int Smeter;
    public static int Gmeter;

    //卵の割れている状況
    public static int Nbreak;
    public static int Bbreak;
    public static int Sbreak;
    public static int Gbreak;

    //ボーナス
    public static int bornas;


    public void SaveAction()
    {
        // money = sum.total/1000;    //持ち金
        money = sum.total;    //持ち金

        bornas = cover.bardeffectmoney;
        Nmeter = Ndetail.Ngage;
        Bmeter = Bdetail.Bgage;
        Smeter = Sdetail.Sgage;
        Gmeter = Gdetail.Ggage;

        if (bronzbuy.bronzegg)
        {
            Bbuy = 1;
        }
        else
        {
            Bbuy = 0;
        };

        if (silberbuy.silberegg)
        {
            Sbuy = 1;
        }
        else
        {
            Sbuy = 0;
        };

        if (goldbuy.goldegg)
        {
            Gbuy = 1;
        }
        else
        {
            Gbuy = 0;
        };

        if (Ndetail.isNMax)
        {
            Nbreak = 1;
        }
        else
        {
            Nbreak = 0;
        };

        if (Bdetail.isBMax)
        {
            Bbreak = 1;
        }
        else
        {
            Bbreak = 0;
        };

        if (Sdetail.isSMax)
        {
            Sbreak = 1;
        }
        else
        {
            Sbreak = 0;
        };

        if (Gdetail.isGMax)
        {
            Gbreak = 1;
        }
        else
        {
            Gbreak = 0;
        };

        //"SCORE"をキーとして、ハイスコアを保存
        //PlayerPrefs.SetFloat("MONEY", money);
        PlayerPrefs.SetInt("MONEY", money);

        PlayerPrefs.SetInt("BBUY", Bbuy);
        PlayerPrefs.SetInt("SBUY", Sbuy);
        PlayerPrefs.SetInt("GBUY", Gbuy);
        PlayerPrefs.SetInt("NMETER", Nmeter);
        PlayerPrefs.SetInt("SMETER", Smeter);
        PlayerPrefs.SetInt("BMETER", Bmeter);
        PlayerPrefs.SetInt("GMETER", Gmeter);
        PlayerPrefs.SetInt("NBREAK", Nbreak);
        PlayerPrefs.SetInt("BBREAK", Bbreak);
        PlayerPrefs.SetInt("SBREAK", Sbreak);
        PlayerPrefs.SetInt("GBREAK", Gbreak);
        PlayerPrefs.SetInt("BORNUS", bornas);



        PlayerPrefs.Save();//ディスクへの書き込み
    }
    /*


     // Start is called before the first frame update
     void Start()
     {
         // "SCORE"をキーとして、ハイスコアを取得
         //※値がない場合は０となる。

         /*
         money = PlayerPrefs.GetInt("MONEY", 0);
         Bbuy = PlayerPrefs.GetString("BBUY", 0);
         Sbuy = PlayerPrefs.GetString("SBUY", 0);
         Gbuy = PlayerPrefs.GetString("GBUY", 0);
         Nmeter = PlayerPrefs.GetInt("GMETER", 0);
         Bmeter = PlayerPrefs.GetInt("BMETER", 0);
         Smeter = PlayerPrefs.GetInt("SMETER", 0);
         Gmeter = PlayerPrefs.GetInt("GMETER", 0);
         Nbreak = PlayerPrefs.GetString("NBREAK", 0);
         Bbreak = PlayerPrefs.GetString("BBREAK", 0);
         Sbreak = PlayerPrefs.GetString("SBREAK", 0);
         Gbreak = PlayerPrefs.GetString("GBREAK", 0);
         bornas = PlayerPrefs.GetInt("BORNUS", 0);
         *


         money = sum.total;    //持ち金

         //購入
         Bbuy = bronzbuy.bronzegg;//銅
         Sbuy = silberbuy.silberegg;//銀
         Gbuy = goldbuy.goldegg;//金

         //卵のメーター情報
         Nmeter = Ndetail.Ngage;
         Bmeter = Bdetail.Bgage;
         Smeter = Sdetail.Sgage;
         Gmeter = Gdetail.Ggage;

         //卵の割れている状況
         Nbreak = Ndetail.isNMax;
         Bbreak = Bdetail.isBMax;
         Sbreak = Sdetail.isSMax;
         Gbreak = Gdetail.isGMax;

         //ボーナス
         bornas = cover.bardeffectmoney;


         //"SCORE"をキーとして、ハイスコアを保存
         PlayerPrefs.SetLong("MONEY", money);
         PlayerPrefs.SetBool("BBUY", Bbuy);
         PlayerPrefs.SetBool("SBUY", Sbuy);
         PlayerPrefs.SetBool("GBUY", Gbuy);
         PlayerPrefs.SetInt("GMETER", Nmeter);
         PlayerPrefs.SetInt("BMETER", Smeter);
         PlayerPrefs.SetInt("SMETER", Bmeter);
         PlayerPrefs.SetInt("GMETER", Gmeter);
         PlayerPrefs.SetBool("NBREAK", Nbreak);
         PlayerPrefs.SetBool("BBREAK", Bbreak);
         PlayerPrefs.SetBool("SBREAK", Sbreak);
         PlayerPrefs.SetBool("GBREAK", Gbreak);
         PlayerPrefs.SetInt("BORNUS", bornas);



         PlayerPrefs.Save();//ディスクへの書き込み
     }*/

}
