using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class goldbuy : MonoBehaviour
{
    public int goldprice = 2000;

    public static bool goldegg = false;

    public GameObject soldout;
    public Text textGold;

    public string gold = "金の卵";



    public void GoldBuy()
    {
        LoadData();

        if (sum.total >= goldprice)
        {
            goldegg = true;
            soldout.SetActive(true);
            textGold.text = gold + "を購入しました";
            sum.total = sum.total - goldprice;



        }
    }

    public void LoadData()
    {

        if (PlayerPrefs.GetInt("GBUY", save.Gbuy) == 0)
        {
            goldegg = false;
        }
        else
        {
            goldegg = true;
        }
    }

}
