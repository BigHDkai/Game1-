using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HallDiceButton : Button
{
    public override void OnPointerClick(PointerEventData eventData)
    {
        //大廳消失
        var ShareObj=GameObject.Find("ShareObj");
        ShareObj.transform.GetChild(1).gameObject.SetActive(false);
        ShareObj.transform.GetChild(2).gameObject.SetActive(false);
        ShareObj.transform.GetChild(3).gameObject.SetActive(false);
        //開始比骰子
        var GameDice=GameObject.Find("GameDice");
        GameDice.GetComponent<Canvas>().enabled = true;
        var ComputerDice=GameObject.Find("ComputerDice");
        ComputerDice.GetComponent<ComputerDiceManager>().DiceNum();
    }
}
