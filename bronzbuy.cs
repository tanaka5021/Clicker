using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class bronzbuy : MonoBehaviour
{
    public int bronzprice = 2000;

    public static bool bronzegg = false;

    public GameObject soldout;

    public Text textField;
    public string bronze = "ì∫ÇÃóë";



    public void BronzBuy()
    {
        LoadData();


        if (sum.total >= bronzprice)
        {
            bronzegg = true;
            soldout.SetActive(true);
            textField.text = bronze.ToString() + "Ççwì¸ÇµÇ‹ÇµÇΩ";
            sum.total = sum.total - bronzprice;


        }
    }

    public void LoadData()
    {

        if (PlayerPrefs.GetInt("BBUY", save.Bbuy) == 0)
        {
            bronzegg = false;
        }
        else
        {
            bronzegg = true;
        }
    }

}
