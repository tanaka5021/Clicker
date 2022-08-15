using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class havemoney : MonoBehaviour
{

    public Text textField;

    public int max = 999999999;

    // Start is called before the first frame update
    void Start()
    {
        // moneyText();
    }

    void Update()
    {
        if (sum.total >= 1000000000)
        {
            textField.text = max.ToString() + "+";

        }
        else
        {
            textField.text = sum.total.ToString();

        }
    }

    /*
    public void moneyText()
    {
        if (sum.total >= 1000000000)
        {
            textField.text =max.ToString()+"+";

        }
        else
        {
            textField.text = sum.total.ToString();

        }
    }*/

}
