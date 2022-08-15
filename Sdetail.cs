using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Sdetail : MonoBehaviour
{
    public GameObject Segg;
    public GameObject CollectionButton;


    public Text textField;

    public static int Smaxvalue = 5000;

    public static bool isSMax = false;

    public static int Sgage = 0;

    // Start is called before the first frame update
    void Start()
    {
        LoadData();

        if (silberbuy.silberegg)
        {
            Segg.SetActive(true);

            Sgage = Sgage + countup.count;
            textField.text = Sgage.ToString() + "/" + Smaxvalue.ToString();

            if (Sgage >= Smaxvalue)
            {
                isSMax = true;
                textField.text = "ƒRƒŒƒNƒVƒ‡ƒ“‚Ö";
                CollectionButton.SetActive(true);

            }
        }
    }

    public void LoadData()
    {
        Sgage = PlayerPrefs.GetInt("SMETER", save.Smeter);


        if (PlayerPrefs.GetInt("SBREAK", save.Sbreak) == 0)
        {
            isSMax = false;
        }
        else
        {
            isSMax = true;
        }
    }
}
