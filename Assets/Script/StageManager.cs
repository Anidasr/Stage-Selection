using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;


public class StageManager : MonoBehaviour
{
    public Button buttonStage2;
    public Button buttonStage3;

    void Start()
    {
        CheckStage();
    }

    public void CheckStage()
    {
        int statusStage2 = PlayerPrefs.GetInt("Stage2");
        int statusStageBoss = PlayerPrefs.GetInt("StageBoss");

        if (statusStage2 == 1)
            buttonStage2.interactable = true;
            
        else
            buttonStage2.interactable = false;

        if (statusStageBoss == 1)
            buttonStage3.interactable = true;
        else
            buttonStage3.interactable = false;
    }

    //Stage2
    //StageBoss
    //1 == Unlock
    //0 == Lock
}
