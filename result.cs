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
        textField.text = "���Ȃ���" + bornasclick.ToString() + "��N���b�N���܂���";
        clickField.text = "�N���b�N�{�[�i�X�F" + cover.bardeffectclick.ToString() + "�{";
        moneyField.text = "�����{�[�i�X�F" + cover.bardeffectmoney.ToString() + "�{";
        isResult = true;
    }

}
