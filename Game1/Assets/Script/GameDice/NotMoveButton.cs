using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotMoveButton : MonoBehaviour
{
    [SerializeField] Transform Note;
    [SerializeField] Transform Content;

    public void ShowNote()
    {
        Note.transform.localPosition = new Vector3(0,0,0);
        for(int i=0 ;i < Content.transform.childCount;i++)
        {
            Content.GetChild(i).gameObject.SetActive(true);
        }
    }

    public void DisNote()
    {
        Note.transform.localPosition = new Vector3(0,-500,0);
        for(int i=0 ;i < Content.transform.childCount;i++)
        {
            Content.GetChild(i).gameObject.SetActive(false);
        }
    }
}
