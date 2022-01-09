using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyDiceManager : MonoBehaviour
{
    [SerializeField] Transform Dice;
    [SerializeField] int MyNum;
    [SerializeField] int ComputerDiceNum;

    [SerializeField] Button ShakeDice;
    [SerializeField] Text ResultText;
    [SerializeField] Text ScoreText;


    
    int a;
    int b;
    int c;
    int d;


    public void Start()
    {
        NCDice();
    }

    public void NCDice()
    {
        for(int i=0,j=0;i<4;i++,j+=60)
        {
            var NDice = Instantiate(Dice,transform.position,new Quaternion(0,0,0,0) ,transform);
            NDice.transform.localPosition = new Vector3(-60+j,-100,0);
        }
        
    }

    public void DiceNum()
    {
        a=Random.Range(1,7);
        b=Random.Range(1,7);
        c=Random.Range(1,7);
        d=Random.Range(1,7);
        if(a==b)
        {
            DiceSetNum();
            MyNum = c+d;
            ShakeDice.GetComponentInChildren<Text>().text = "開牌";
            GameObject.Find("Content").GetComponent<Notemanager>().SetNoteMyDice(a,b,c,d);
        }else if(a==c)
        {
            DiceSetNum();
            MyNum = b+d;
            ShakeDice.GetComponentInChildren<Text>().text = "開牌";
            GameObject.Find("Content").GetComponent<Notemanager>().SetNoteMyDice(a,c,b,d);
        }else if(a==d)
        {
            DiceSetNum();
            MyNum = b+c;
            ShakeDice.GetComponentInChildren<Text>().text = "開牌";
            GameObject.Find("Content").GetComponent<Notemanager>().SetNoteMyDice(a,d,b,c);
        }else if(b==c)
        {
            DiceSetNum();
            MyNum = a+d;
            ShakeDice.GetComponentInChildren<Text>().text = "開牌";
            GameObject.Find("Content").GetComponent<Notemanager>().SetNoteMyDice(b,c,a,d);
        }else if(b==d)
        {
            DiceSetNum();
            MyNum = a+c;
            ShakeDice.GetComponentInChildren<Text>().text = "開牌";
            GameObject.Find("Content").GetComponent<Notemanager>().SetNoteMyDice(b,d,a,c);
        }else if(c==d)
        {
            DiceSetNum();
            MyNum = a+b;
            ShakeDice.GetComponentInChildren<Text>().text = "開牌";
            GameObject.Find("Content").GetComponent<Notemanager>().SetNoteMyDice(c,d,a,b);
        }else
        {
            DiceSetNum();
        }
    }

    void DiceSetNum()
    {
        transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+a.ToString());
        transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+b.ToString());
        transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+c.ToString());
        transform.GetChild(3).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+d.ToString());
    }


    public void EndNum(int McEndNum)
    {
        ComputerDiceNum = McEndNum;
    }

    public void EndGame()
    {
        if(ComputerDiceNum > MyNum){
            ScoreText.text = (int.Parse(ScoreText.text)-10).ToString();
            ResultText.text="<color=#FF0000>你輸了</color>";
        }else
        {
            ScoreText.text = (int.Parse(ScoreText.text)+10).ToString();
            ResultText.text="<color=#00FF00>你贏了</color>";
        }
    }



}
