using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class timesetting : MonoBehaviour
{

    //�J�E���g�_�E��
    public float countdown = 5.0f;

    //�n�܂�O�̃J�E���g
    public static float beforecount = 5.0f;

    //���Ԃ�\������Text�^�̕ϐ�
    public Text timeText;


    // Update is called once per frame
    void Update()
    {
        beforecount -= Time.deltaTime;


        timeText.text = "�J�n�܂�" + beforecount.ToString("f1") + "�b�O";

        if (beforecount <= 0)
        {

            //���Ԃ��J�E���g�_�E������
            countdown -= Time.deltaTime;

            //���Ԃ�\������
            timeText.text = "�c��" + countdown.ToString("f1") + "�b";



            //countdown��0�ȉ��ɂȂ����Ƃ�
            if (countdown <= 0)
            {
                SceneManager.LoadScene("result");
                countdown = 5.0f;
                beforecount = 5.0f;
            }
        }
    }
}
