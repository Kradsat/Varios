using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum StepStatus
{
    stay = 1,
    Rest = 2,
}
public class Step : MonoBehaviour
{
    [SerializeField] private int stepValue = 0;
    [SerializeField] private StepStatus status = StepStatus.stay;

    public void Init()
    {
        stepValue = 0;
        status = StepStatus.stay;
    }

    public void SetStep(int diceNO)
    {
        stepValue += diceNO;
        Debug.Log(gameObject.name + " Step Value: " + stepValue);
    }
}
