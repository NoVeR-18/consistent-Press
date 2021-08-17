using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnWorker : MonoBehaviour
{
    public static int points = 0;
    [SerializeField]
    BTN[] Btn = new BTN[9];

    bool flag = false;


    void OnEnable()
    {
        points = 0;
        for (int i = 0; i < Btn.Length; )
        {
            Btn[i].Number = Random.Range(1, Btn.Length+1);
            Btn[i].maxPoint = Btn.Length;
            for (int j = 0; j < i; j++)
            {
                if (Btn[j].Number == Btn[i].Number)
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                i++;
            }
            flag = false;
        }
    }
}
