using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class timesetting : MonoBehaviour
{

    //カウントダウン
    public float countdown = 5.0f;

    //始まる前のカウント
    public static float beforecount = 5.0f;

    //時間を表示するText型の変数
    public Text timeText;


    // Update is called once per frame
    void Update()
    {
        beforecount -= Time.deltaTime;


        timeText.text = "開始まで" + beforecount.ToString("f1") + "秒前";

        if (beforecount <= 0)
        {

            //時間をカウントダウンする
            countdown -= Time.deltaTime;

            //時間を表示する
            timeText.text = "残り" + countdown.ToString("f1") + "秒";



            //countdownが0以下になったとき
            if (countdown <= 0)
            {
                SceneManager.LoadScene("result");
                countdown = 5.0f;
                beforecount = 5.0f;
            }
        }
    }
}
