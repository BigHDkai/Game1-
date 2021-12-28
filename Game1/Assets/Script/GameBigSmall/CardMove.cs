using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class CardMove : MonoBehaviour
{
    Tweener tweener;
    public void CardsClick()
    {
        CardsShow();
    }

    void CardsShow()
    {
        tweener = transform.DOLocalMove(new Vector3(0,-90,0),1);
        transform.GetComponentInParent<CardManager>().EnabledAllButton();
        transform.GetComponentInParent<CardManager>().Mycard(this.transform);
    }
}
