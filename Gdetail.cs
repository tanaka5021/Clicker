using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Gdetail : MonoBehaviour
{
    public GameObject Gegg;
    public GameObject CollectionButton;


    public Text textField;

    public static int Gmaxvalue = 3000;

    public static bool isGMax = false;

    public static int Ggage = 0;

    // Start is called before the first frame update
    void Start()
    {

        LoadData();

        if (goldbuy.goldegg)
        {
            Gegg.SetActive(true);

            Ggage = Ggage + countup.count;
            textField.text = Ggage.ToString() + "/" + Gmaxvalue.ToString();

            if (Ggage >= Gmaxvalue)
            {
                isGMax = true;
                textField.text = "ƒRƒŒƒNƒVƒ‡ƒ“‚Ö";
                CollectionButton.SetActive(true);

            }
        }
    }

    public void LoadData()
    {
        Ggage = PlayerPrefs.GetInt("GMETER", save.Gmeter);


        if (PlayerPrefs.GetInt("GBREAK", save.Gbreak) == 0)
        {
            isGMax = false;
        }
        else
        {
            isGMax = true;
        }
    }
}
