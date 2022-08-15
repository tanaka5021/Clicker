using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class result : MonoBehaviour
{
    public Text textField;
    public Text clickField;
    public Text moneyField;
    public static bool isResult = false;
    public static int bornasclick;

    // Start is called before the first frame update
    void Start()
    {
        bornasclick = countup.count * cover.bardeffectclick;
        textField.text = "あなたは" + bornasclick.ToString() + "回クリックしました";
        clickField.text = "クリックボーナス：" + cover.bardeffectclick.ToString() + "倍";
        moneyField.text = "収入ボーナス：" + cover.bardeffectmoney.ToString() + "倍";
        isResult = true;
    }

}
