using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class countup : MonoBehaviour
{
    public Text textField;
    public static int count;



    public GameObject[] images;

    private int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        textField.text = count.ToString();
    }

    void Update()
    {
        timesetting.beforecount -= Time.deltaTime;
    }

    public void CountButton()
    {
        if (timesetting.beforecount <= 0)
        {
            count++;
            textField.text = count.ToString();

            if (count%5==0)
            {
                images[i].SetActive(true);
                i++;
            }
        }
    }
}
