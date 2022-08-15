using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class sum : MonoBehaviour
{
    public Text textField;

    //public static long total;
    public static int total;


    // Start is called before the first frame update
    void Start()
    {

        LoadData();
        total = total + sucore.sum;
        textField.text = "ëçé˚ì¸" + total.ToString() + "â~";
    }

    public void LoadData()
    {
        //total = (long)(PlayerPrefs.GetFloat("MONEY", save.money) * 1000);
        total = PlayerPrefs.GetInt("MONEY", save.money);


    }
}
