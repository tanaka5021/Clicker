using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class silberbuy : MonoBehaviour
{
    public int silberprice = 2000;

    public static bool silberegg;

    public GameObject soldout;
    public Text textField;
    public string silber = "‹â‚Ì—‘";



    public void SilberBuy()
    {
        LoadData();

        if (sum.total >= silberprice)
        {
            silberegg = true;
            textField.text = silber.ToString() + "‚ğw“ü‚µ‚Ü‚µ‚½";
            sum.total = sum.total - silberprice;


        }

        if (silberbuy.silberegg)
        {
            soldout.SetActive(true);

        }
    }

    public void LoadData()
    {
        if (PlayerPrefs.GetInt("SBUY", save.Sbuy) == 1)
        {
            silberegg = true;
        }
        else
        {
            silberegg = false;
        }
    }
}
