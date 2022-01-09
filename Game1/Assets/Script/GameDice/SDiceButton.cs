using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class SDiceButton : Button
{
    public override void OnPointerClick(PointerEventData eventData)
    {
        var MyDice = GameObject.Find("MyDice");
        if(transform.GetComponentInChildren<Text>().text == "開牌")
        {
            Invoke( "EndGameClick" , 1f);
            Invoke( "DisDiice" , 1f);
            ResultTextMove();
            RepeatButtontMove();
            transform.GetComponent<SDiceButton>().enabled = false;
        }else
        {   
            MyDice.GetComponent<MyDiceManager>().DiceNum();
        }
    }
    void DisDiice()
    {
        var MyDice = GameObject.Find("MyDice");
        var ComputerDice = GameObject.Find("ComputerDice");
        MyDice.gameObject.SetActive(false);
        ComputerDice.gameObject.SetActive(false);
        transform.gameObject.SetActive(false);
    }
    void ResultTextMove()
    {
        var ResultText = GameObject.Find("ResultText");
        ResultText.GetComponent<EndDiceGame>().ClickResultTextMove();
    }
    void RepeatButtontMove()
    {
        var RepeatButton = GameObject.Find("RepeatButton");
        RepeatButton.GetComponent<EndDiceGame>().ClickRepeatButtontMove();
    }

    void EndGameClick()
    {
        var MyDice = GameObject.Find("MyDice");
        MyDice.GetComponent<MyDiceManager>().EndGame();
        var asd = GameObject.Find("Content");
        asd.GetComponent<Notemanager>().CreativityNote();
    }

}
