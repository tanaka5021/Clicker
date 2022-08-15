using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class sucore : MonoBehaviour
{
    public Text textResult;
    //public static long sum;
    public static int sum;


    // Start is called before the first frame update
    void Start()
    {
        sum = 20 * result.bornasclick * cover.bardeffectmoney;
        textResult.text = "20Å~" + result.bornasclick.ToString() + "=" + sum.ToString() + "(â~)";

    }
}
