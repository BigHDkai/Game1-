using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class DiceReturnButton : Button
{
    public override void OnPointerClick(PointerEventData eventData)
    {
        var GameDice=GameObject.Find("GameDice");
        GameDice.GetComponent<Canvas>().enabled = false;
        var ShareObj=GameObject.Find("ShareObj");
        ShareObj.transform.GetChild(1).gameObject.SetActive(true);
        ShareObj.transform.GetChild(2).gameObject.SetActive(true);
        ShareObj.transform.GetChild(3).gameObject.SetActive(true);
        ShareObj.transform.GetChild(4).gameObject.SetActive(true);
    }
}
