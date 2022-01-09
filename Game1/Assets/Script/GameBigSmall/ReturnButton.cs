using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ReturnButton : Button
{
    public override void OnPointerClick(PointerEventData eventData)
    {
        var GameBigSmall=GameObject.Find("GameBigSmall");
        GameBigSmall.GetComponent<EndGame>().RepeatGame();
        GameBigSmall.transform.GetChild(3).transform.localPosition = new Vector3(0,300,0);
        var CardManager=GameObject.Find("CardManager");
        for(int i = 0 ;i < CardManager.transform.childCount;i++){
            Destroy(CardManager.transform.GetChild(i).gameObject);
        }
        GameBigSmall.GetComponent<Canvas>().enabled = false;
        var ShareObj=GameObject.Find("ShareObj");
        ShareObj.transform.GetChild(1).gameObject.SetActive(true);
        ShareObj.transform.GetChild(2).gameObject.SetActive(true);
        ShareObj.transform.GetChild(3).gameObject.SetActive(true);
    }
}
