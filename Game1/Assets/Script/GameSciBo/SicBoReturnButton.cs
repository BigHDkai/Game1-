using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class SicBoReturnButton : Button
{
    public override void OnPointerClick(PointerEventData eventData)
    {
        var GameSciBo=GameObject.Find("GameSciBo");
        GameSciBo.GetComponent<Canvas>().enabled = false;
        var ShareObj=GameObject.Find("ShareObj");
        ShareObj.transform.GetChild(1).gameObject.SetActive(true);
        ShareObj.transform.GetChild(2).gameObject.SetActive(true);
        ShareObj.transform.GetChild(3).gameObject.SetActive(true);
        ShareObj.transform.GetChild(4).gameObject.SetActive(true);

        //再來一局
        var Dices=GameObject.Find("Dices");
        Dices.GetComponent<DiceControl>().ReturnSicBoGame();
    }
}