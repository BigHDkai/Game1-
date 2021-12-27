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
        SceneManager.LoadScene("GameBigSmall");
    }




    void ResultTextMove()
    {
        tweener = transform.DOLocalMove(new Vector3(0,0,0),1);
    }    
    
    void RepeatButtontMove()
    {
        tweener = transform.DOLocalMove(new Vector3(250,0,0),1);
    }


    void disappear()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
    }


}
