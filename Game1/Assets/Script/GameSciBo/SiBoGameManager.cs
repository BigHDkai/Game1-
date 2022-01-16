using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class SiBoGameManager : MonoBehaviour
{
    [SerializeField] Transform ChipsImg1;
    [SerializeField] Transform ChipsImg5;
    [SerializeField] Transform ChipsImg10;
    Tweener tweener;

    [SerializeField]int Chipsnum = 0;
    [SerializeField]int BigChipsnum = 0;
    [SerializeField]int LeopardChipsnum = 0;
    [SerializeField]int SmallChipsnum = 0;
    [SerializeField]int EndGamenum = 0;

    [SerializeField] int[] EndDicenum = new int[3];


    public void BigCreativityChips()
    {
        if(Chipsnum == 1){
            var Chips = Instantiate(ChipsImg1 ,transform.localPosition,new Quaternion(0,0,0,0) ,transform);
            Chips.transform.localPosition = new Vector3(-100,-130,0);
            tweener = Chips.transform.DOLocalMove(new Vector3(-Random.Range(120,280),Random.Range(-60,60),0),1);
            BigChipsnum += 1;
        }else if(Chipsnum == 5)
        {
            var Chips = Instantiate(ChipsImg5 ,transform.localPosition,new Quaternion(0,0,0,0) ,transform);
            Chips.transform.localPosition = new Vector3(0,-130,0);
            tweener = Chips.transform.DOLocalMove(new Vector3(-Random.Range(120,280),Random.Range(-60,60),0),1);
            BigChipsnum += 5;
        }else if(Chipsnum == 10)
        {
            var Chips = Instantiate(ChipsImg10 ,transform.localPosition,new Quaternion(0,0,0,0) ,transform);
            Chips.transform.localPosition = new Vector3(100,-130,0);
            tweener = Chips.transform.DOLocalMove(new Vector3(-Random.Range(120,280),Random.Range(-60,60),0),1);
            BigChipsnum += 10;
        }
    }

    public void LeopardCreativityChips()
    {
        if(Chipsnum == 1){
            var Chips = Instantiate(ChipsImg1 ,transform.localPosition,new Quaternion(0,0,0,0) ,transform);
            Chips.transform.localPosition = new Vector3(-100,-130,0);
            tweener = Chips.transform.DOLocalMove(new Vector3(Random.Range(-80,80),Random.Range(-60,60),0),1);
            LeopardChipsnum += 1;
        }else if(Chipsnum == 5)
        {
            var Chips = Instantiate(ChipsImg5 ,transform.localPosition,new Quaternion(0,0,0,0) ,transform);
            Chips.transform.localPosition = new Vector3(0,-130,0);
            tweener = Chips.transform.DOLocalMove(new Vector3(Random.Range(-80,80),Random.Range(-60,60),0),1);
            LeopardChipsnum += 5;
        }else if(Chipsnum == 10)
        {
            var Chips = Instantiate(ChipsImg10 ,transform.localPosition,new Quaternion(0,0,0,0) ,transform);
            Chips.transform.localPosition = new Vector3(100,-130,0);
            tweener = Chips.transform.DOLocalMove(new Vector3(Random.Range(-80,80),Random.Range(-60,60),0),1);
            LeopardChipsnum += 10;
        }
    }

    public void SmallCreativityChips()
    {
        if(Chipsnum == 1){
            var Chips = Instantiate(ChipsImg1 ,transform.localPosition,new Quaternion(0,0,0,0) ,transform);
            Chips.transform.localPosition = new Vector3(-100,-130,0);
            tweener = Chips.transform.DOLocalMove(new Vector3(Random.Range(120,280),Random.Range(-60,60),0),1);
            SmallChipsnum += 1;
        }else if(Chipsnum == 5)
        {
            var Chips = Instantiate(ChipsImg5 ,transform.localPosition,new Quaternion(0,0,0,0) ,transform);
            Chips.transform.localPosition = new Vector3(0,-130,0);
            tweener = Chips.transform.DOLocalMove(new Vector3(Random.Range(120,280),Random.Range(-60,60),0),1);
            SmallChipsnum += 5;
        }else if(Chipsnum == 10)
        {
            var Chips = Instantiate(ChipsImg10 ,transform.localPosition,new Quaternion(0,0,0,0) ,transform);
            Chips.transform.localPosition = new Vector3(100,-130,0);
            tweener = Chips.transform.DOLocalMove(new Vector3(Random.Range(120,280),Random.Range(-60,60),0),1);
            SmallChipsnum += 10;
        }
    }

    public void EndGame()
    {
        if(EndDicenum[0] == EndDicenum[1] & EndDicenum[1]==EndDicenum[2])
        {
            EndGamenum = LeopardChipsnum + (LeopardChipsnum*30) - BigChipsnum - SmallChipsnum;
            Debug.Log("豹子");
            Debug.Log(EndGamenum);
        }else if(EndDicenum[0]+EndDicenum[1]+EndDicenum[2] < 11)
        {
            EndGamenum = SmallChipsnum + SmallChipsnum - LeopardChipsnum - BigChipsnum;
            Debug.Log("小");
            Debug.Log(EndGamenum);
        }else if(EndDicenum[0]+EndDicenum[1]+EndDicenum[2] > 10)
        {
            EndGamenum = BigChipsnum + BigChipsnum - SmallChipsnum - LeopardChipsnum;
            Debug.Log("大");
            Debug.Log(EndGamenum);
        }
    }


    public void SetEndDicenum(int num0,int num1,int num2)
    {
        EndDicenum[0] = num0;
        EndDicenum[1] = num1;
        EndDicenum[2] = num2;
    }


    public void OneClick()
    {
        Chipsnum = 1;
        var oneButton = GameObject.Find("1Button");
        oneButton.transform.GetChild(0).GetComponent<Image>().color = new Color32(255,0,0,255);
        var FiveButton = GameObject.Find("5Button");
        FiveButton.transform.GetChild(0).GetComponent<Image>().color = new Color32(255,255,255,255);
        var TenButton = GameObject.Find("10Button");
        TenButton.transform.GetChild(0).GetComponent<Image>().color = new Color32(255,255,255,255); 
    }
    public void FiveClick()
    {
        Chipsnum = 5;
        var oneButton = GameObject.Find("1Button");
        oneButton.transform.GetChild(0).GetComponent<Image>().color = new Color32(255,255,255,255);
        var FiveButton = GameObject.Find("5Button");
        FiveButton.transform.GetChild(0).GetComponent<Image>().color = new Color32(255,0,0,255);
        var TenButton = GameObject.Find("10Button");
        TenButton.transform.GetChild(0).GetComponent<Image>().color = new Color32(255,255,255,255); 
    }
    public void TenClick()
    {
        Chipsnum = 10;
        var oneButton = GameObject.Find("1Button");
        oneButton.transform.GetChild(0).GetComponent<Image>().color = new Color32(255,255,255,255);
        var FiveButton = GameObject.Find("5Button");
        FiveButton.transform.GetChild(0).GetComponent<Image>().color = new Color32(255,255,255,255);
        var TenButton = GameObject.Find("10Button");
        TenButton.transform.GetChild(0).GetComponent<Image>().color = new Color32(255,0,0,255); 
    }
    
}
