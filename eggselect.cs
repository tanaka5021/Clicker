using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class eggselect : MonoBehaviour
{

    public GameObject[] eggs;

    public int i = 0;

    public int r;

    // Start is called before the first frame update

    void Start()
    {


        if (goldbuy.goldegg == true)
        {
            i = 3;
        }
        else if (silberbuy.silberegg == true)
        {
            i = 2;
        }
        else if (bronzbuy.bronzegg == true)
        {
            i = 1;
        }
        else
        {
            i = 0;
        }

        r = Random.Range(0, i + 1);
        eggs[r].SetActive(true);
        Debug.Log(r);
    }
}
