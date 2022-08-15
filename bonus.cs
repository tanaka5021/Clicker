using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bonus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Ndetail.isNMax)
        {
            cover.bardeffectclick = 2;
            cover.bardeffectmoney = 2;
        }


        if (Bdetail.isBMax)
        {
            cover.bardeffectclick = 4;
            cover.bardeffectmoney = 3;
        }

        if (Sdetail.isSMax)
        {
            cover.bardeffectclick = 8;
            cover.bardeffectmoney = 5;
        }

        if (Gdetail.isGMax)
        {
            cover.bardeffectclick = 10;
            cover.bardeffectmoney = 8;
        }
    }
}
