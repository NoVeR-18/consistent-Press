using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public float timeStart;

    public Text timerText;
    public Text Points;
    public Text WinText;
    public BtnWorker btnWorker;
    [SerializeField]
    private GameObject WinMenu ;
    [SerializeField]
    private GameObject ThisMenu ;
    void Start()
    {
        timeStart = 0;
        timerText.text = timeStart.ToString();
    }

    void Update()
    {
        
        Points.text = "Score :" + BtnWorker.points.ToString();
        timeStart += Time.deltaTime;
        timerText.text = "Time :" + Mathf.Round(timeStart).ToString();
    }
    public void Win()
    {
        WinMenu.SetActive(true);
        ThisMenu.SetActive(false);
        WinText.text = "Point:" + (BtnWorker.points) +"\n"+ "Time: " + Mathf.Round(timeStart).ToString();
        Time.timeScale = 0f;
    }
    public void Retry()
    {
        timeStart = 0;
        BtnWorker.points = 0;
    }
    public void End()
    {
        ThisMenu.SetActive(false);
    }
    public void StartGame()
    {
        timeStart = 0;
        Time.timeScale = 1f;
    }
}
