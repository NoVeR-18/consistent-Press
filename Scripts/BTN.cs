using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BTN : MonoBehaviour
{
    public Text text;
    public int Number;
    public int maxPoint;
    [SerializeField]
    private Controller controller;
    private void Update()
    {
        text.text = Number.ToString();
    }
    public void onClick()
    {
        if (BtnWorker.points == maxPoint-1)
        {
            BtnWorker.points++;
            controller.Win();
            if (BtnWorker.points > PlayerPrefs.GetInt("Score")){
                PlayerPrefs.SetInt("Score", BtnWorker.points);
            }
            BtnWorker.points = 0;
        }
        if (BtnWorker.points == Number - 1)
        {
            BtnWorker.points++;
        }
        else
            BtnWorker.points = 0;
    }
}
