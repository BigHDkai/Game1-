using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HallBigSmallButton : Button
{
    public override void OnPointerClick(PointerEventData eventData)
    {
        //大廳消失
        var ShareObj=GameObject.Find("ShareObj");
        ShareObj.transform.GetChild(1).gameObject.SetActive(false);
        ShareObj.transform.GetChild(2).gameObject.SetActive(false);
        ShareObj.transform.GetChild(3).gameObject.SetActive(false);
        //開始比大小
        var GameBigSmall=GameObject.Find("GameBigSmall");
        GameBigSmall.GetComponent<Canvas>().enabled = true;
        var CardManager=GameObject.Find("CardManager");
        CardManager.GetComponent<CardManager>().StartGame();
    }
}
