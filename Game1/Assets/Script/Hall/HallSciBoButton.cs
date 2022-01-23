using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HallSciBoButton : Button
{
    public override void OnPointerClick(PointerEventData eventData)
    {
        //大廳消失
        var ShareObj=GameObject.Find("ShareObj");
        ShareObj.transform.GetChild(1).gameObject.SetActive(false);
        ShareObj.transform.GetChild(2).gameObject.SetActive(false);
        ShareObj.transform.GetChild(3).gameObject.SetActive(false);
        ShareObj.transform.GetChild(4).gameObject.SetActive(false);
        //開始比骰寶
        var GameSciBo=GameObject.Find("GameSciBo");
        GameSciBo.GetComponent<Canvas>().enabled = true;
    }
}
