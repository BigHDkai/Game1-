using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerDiceManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform Dice;

    [SerializeField] Transform My;

    [SerializeField] int ComputerDiceNum;
    int a;
    int b;
    int c;
    int d;


    void Start()
    {
        NCDice();
    }
    public void NCDice()
    {
        for(int i=0,j=0;i<4;i++,j+=60)
        {
            var NDice = Instantiate(Dice,transform.position,new Quaternion(0,0,0,0) ,transform);
            NDice.transform.localPosition = new Vector3(-60+j,100,0);
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
            ComputerDiceNum = c+d;
            GameObject.Find("Content").GetComponent<Notemanager>().SetNoteComputerDice(a,b,c,d);
        }else if(a==c)
        {
            DiceSetNum();
            ComputerDiceNum = b+d;
            GameObject.Find("Content").GetComponent<Notemanager>().SetNoteComputerDice(a,c,b,d);
        }else if(a==d)
        {
            DiceSetNum();
            ComputerDiceNum = b+c;
            GameObject.Find("Content").GetComponent<Notemanager>().SetNoteComputerDice(a,d,b,c);
        }else if(b==c)
        {
            DiceSetNum();
            ComputerDiceNum = a+d;
            GameObject.Find("Content").GetComponent<Notemanager>().SetNoteComputerDice(b,c,a,d);
        }else if(b==d)
        {
            DiceSetNum();
            ComputerDiceNum = a+c;
            GameObject.Find("Content").GetComponent<Notemanager>().SetNoteComputerDice(b,d,a,c);
        }else if(c==d)
        {
            DiceSetNum();
            ComputerDiceNum = a+b;
            GameObject.Find("Content").GetComponent<Notemanager>().SetNoteComputerDice(c,d,a,b);
        }else
        {
            DiceNum();
        }
        My.GetComponent<MyDiceManager>().EndNum(ComputerDiceNum);
    }

    public void DiceSetNum()
    {
        transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+a.ToString());
        transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+b.ToString());
        transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+c.ToString());
        transform.GetChild(3).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+d.ToString());
    }
}
