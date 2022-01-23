using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class EndDiceGame : MonoBehaviour
{
    public void ClickResultTextMove()
    {
        Invoke( "ResultTextMove" , 1f);
    }

    public void ClickRepeatButtontMove()
    {        
        Invoke( "RepeatButtontMove" , 1f);
    }
    
    void ResultTextMove()
    {
        transform.localPosition = new Vector3(0,0,0);
    }

    public void ResultTextMoveOut()
    {
        transform.localPosition = new Vector3(0,300,0);
    }     
    
    void RepeatButtontMove()
    {
        transform.localPosition = new Vector3(250,0,0);
    }

    public void RepeatGame()
    {
        transform.GetChild(5).transform.localPosition = new Vector3(250,-300,0);
        var DiceResultText = GameObject.Find("DiceResultText");
        DiceResultText.GetComponent<EndDiceGame>().ResultTextMoveOut();
        for(int i =0;i<4;i++){
            Destroy(transform.GetChild(0).GetChild(i).gameObject);
        }
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);
        transform.GetChild(2).gameObject.SetActive(true);
        transform.GetChild(0).GetComponent<MyDiceManager>().NCDice();
        transform.GetChild(1).GetComponent<ComputerDiceManager>().DiceNum();
        transform.GetChild(2).GetComponent<SDiceButton>().enabled = true;
        transform.GetChild(2).GetComponentInChildren<Text>().text = "搖骰";
        
    }
    
}
