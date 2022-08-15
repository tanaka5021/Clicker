using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Bdetail : MonoBehaviour
{

    public GameObject Begg;
    public GameObject CollectionButton;


    public Text textField;

    public static int Bmaxvalue = 1000;

    public static bool isBMax = false;

    public static int Bgage = 0;

    // Start is called before the first frame update
    void Start()
    {
        LoadData();

        if (bronzbuy.bronzegg)
        {
            Begg.SetActive(true);


            Bgage = Bgage + countup.count;
            textField.text = Bgage.ToString() + "/" + Bmaxvalue.ToString();

            if (Bgage >= Bmaxvalue)
            {
                isBMax = true;
                textField.text = "ƒRƒŒƒNƒVƒ‡ƒ“‚Ö";
                CollectionButton.SetActive(true);

            }
        }
    }

    public void LoadData()
    {
        Bgage = PlayerPrefs.GetInt("BMETER", save.Bmeter);


        if (PlayerPrefs.GetInt("BBREAK", save.Bbreak) == 0)
        {
            isBMax = false;
        }
        else
        {
            isBMax = true;
        }
    }

}
