using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    Tweener tweener;


    public void ClickResultTextMove()
    {
        Invoke( "ResultTextMove" , 1f);
    }
    public void Clickdisappear()
    {
        Invoke( "disappear" , 1f);
    }

    public void ClickRepeatButtontMove()
    {        
        Invoke( "RepeatButtontMove" , 1f);
    }

    public void RepeatGame()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);
        transform.GetChild(2).gameObject.SetActive(true);
        //RepeatButtontMoveOut
        transform.GetChild(4).transform.localPosition = new Vector3(250,-300,0);
        transform.GetChild(4).GetComponent<Button>().enabled = false;
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

        void disappear()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
    }


}
