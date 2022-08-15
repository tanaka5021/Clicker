using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gocollection : MonoBehaviour
{
    public static bool isBroke = false;

    public void GoCollectionButton()
    {
        SceneManager.LoadScene("collection");
        isBroke = true;
    }
}
