using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Bsoldout;
    public GameObject Ssoldout;
    public GameObject Gsoldout;



    void Start()
    {
        if (bronzbuy.bronzegg)
        {
            Bsoldout.SetActive(true);

        }

        if (silberbuy.silberegg)
        {
            Ssoldout.SetActive(true);

        }

        if (goldbuy.goldegg)
        {
            Gsoldout.SetActive(true);

        }
    }


}
