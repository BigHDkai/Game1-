using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public class CardMove : Button
{
    Tweener tweener;
    public override void OnPointerClick(PointerEventData eventData)
    {
        CardsShow();
    }

    void CardsShow()
    {
        tweener = transform.DOLocalMove(new Vector3(0,-90,0),1);
        transform.GetComponentInParent<CardManager>().Mycard(this.transform);
        transform.GetComponentInParent<CardManager>().EnabledAllButton();
    }
    
    public override void OnPointerEnter(PointerEventData eventData)
    {
        base.OnPointerEnter(eventData);
        tweener = transform.DOLocalMove(new Vector3(transform.localPosition.x,20,0),0.1f);
    }
    
    public override void OnPointerExit(PointerEventData eventData)
    {
        base.OnPointerExit(eventData);
        tweener = transform.DOLocalMove(new Vector3(transform.localPosition.x,0,0),0.1f);  
    }
}
