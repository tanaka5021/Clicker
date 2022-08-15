using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class non : MonoBehaviour
{
    public GameObject Non;

    // Start is called before the first frame update
    void Start()
    {
        Non.SetActive(true);

        if (Ndetail.isNMax)
        {
            Non.SetActive(false);
        }

        if (Bdetail.isBMax)
        {
            Non.SetActive(false);
        }

        if (Sdetail.isSMax)
        {
            Non.SetActive(false);
        }

        if (Gdetail.isGMax)
        {
            Non.SetActive(false);
        }
    }

}
