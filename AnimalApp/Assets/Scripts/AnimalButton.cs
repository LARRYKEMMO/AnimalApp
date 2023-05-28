using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AnimalButton : MonoBehaviour
{
    private GameAI AIScript;
    // Start is called before the first frame update
    void Start()
    {
        AIScript = FindObjectOfType<GameAI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void onClick1()
    {
        AIScript.CorrectSprite = 0;
        //Debug.Log(AIScript.TempList2[0]);
        //Debug.Log(AIScript.AnimalList[AIScript.TempList2[0]]);
        AIScript.CorrectCounter++;
    }

    public void onClick2()
    {
        AIScript.CorrectSprite = 1;
        //Debug.Log(AIScript.TempList2[1]);
        //Debug.Log(AIScript.AnimalList[AIScript.TempList2[1]]);
        AIScript.CorrectCounter++;
    }

    public void onClick3()
    {
        AIScript.CorrectSprite = 2;
        //Debug.Log(AIScript.TempList2[2]);
        //Debug.Log(AIScript.AnimalList[AIScript.TempList2[2]]);
        AIScript.CorrectCounter++;
    }

    public void onClick4()
    {
        AIScript.CorrectSprite = 3;
        //Debug.Log(AIScript.TempList2[3]);
        //Debug.Log(AIScript.AnimalList[AIScript.TempList2[3]]);
        AIScript.CorrectCounter++;
    }

    public void onClick5()
    {
        AIScript.CorrectSprite = 4;
        //Debug.Log(AIScript.TempList2[4]);
        //Debug.Log(AIScript.AnimalList[AIScript.TempList2[4]]);
        AIScript.CorrectCounter++;
    }
    public void onClick6()
    {
        AIScript.correctText = 0;
        //Debug.Log(AIScript.AnimalList[AIScript.TempList[0]]);
        AIScript.CorrectCounter++;
    }

    public void onClick7()
    {
        AIScript.correctText = 1;
        //Debug.Log(AIScript.AnimalList[AIScript.TempList[1]]);
        AIScript.CorrectCounter++;
    }

    public void onClick8()
    {
        AIScript.correctText = 2;
        //Debug.Log(AIScript.AnimalList[AIScript.TempList[2]]);
        AIScript.CorrectCounter++;
    }

    public void onClick9()
    {
        AIScript.correctText = 3;
        //Debug.Log(AIScript.AnimalList[AIScript.TempList[3]]);
        AIScript.CorrectCounter++;
    }

    public void onClick10()
    {
        AIScript.correctText = 4;
        //Debug.Log(AIScript.AnimalList[AIScript.TempList[4]]);
        AIScript.CorrectCounter++;
    }
}
