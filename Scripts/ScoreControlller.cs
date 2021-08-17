using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControlller : MonoBehaviour
{
    [SerializeField]
    Text text;

    private void OnEnable()
    {
        text.text = "Best Score: " + PlayerPrefs.GetInt("Score");
    }
}
