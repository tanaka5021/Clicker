using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class shop : MonoBehaviour
{
    public void ShopButton()
    {

        SceneManager.LoadScene("super");
        silberbuy.silberegg = silberbuy.silberegg;
        Debug.Log(silberbuy.silberegg);




    }
}
