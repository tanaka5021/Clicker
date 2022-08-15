using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cover : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Ncover;
    public GameObject Bcover;
    public GameObject Scover;
    public GameObject Gcover;

    public static int bardeffectclick = 1;
    public static int bardeffectmoney = 1;



    void Start()
    {

        LoadData();

        if (Ndetail.isNMax)
        {
            Ncover.SetActive(false);
            bardeffectclick = 2;
            bardeffectmoney = 2;
        }


        if (Bdetail.isBMax)
        {
            Bcover.SetActive(false);
            bardeffectclick = 4;
            bardeffectmoney = 3;
        }

        if (Sdetail.isSMax)
        {
            Scover.SetActive(false);
            bardeffectclick = 8;
            bardeffectmoney = 5;
        }

        if (Gdetail.isGMax)
        {
            Gcover.SetActive(false);
            bardeffectclick = 10;
            bardeffectmoney = 8;
        }
    }

    public void LoadData()
    {
        bardeffectclick = PlayerPrefs.GetInt("BORNUS", save.bornas);
    }
}
