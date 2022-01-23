using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SicBoNotManager : MonoBehaviour
{
    [SerializeField] Transform SicNote;
    int NoCount = 1;

    [SerializeField] int[] EndDicenum = new int[4];

    public void CreativityNote()
    {
        var SicNotes = Instantiate(SicNote,transform.position,new Quaternion(0,0,0,0),transform);
        SicNotes.GetChild(0).GetComponent<Text>().text =NoCount.ToString();
        NoCount++;
        SicNotes.GetChild(1).GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+EndDicenum[0].ToString());
        SicNotes.GetChild(1).GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+EndDicenum[1].ToString());
        SicNotes.GetChild(1).GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+EndDicenum[2].ToString());
        if(EndDicenum[3] > 0)
        {
            SicNotes.GetChild(2).GetComponent<Text>().text = "<color=#00FF00>" + EndDicenum[3].ToString() + "</color>";
        }else
        {
            SicNotes.GetChild(2).GetComponent<Text>().text = "<color=#FF0000>" + EndDicenum[3].ToString() + "</color>";
        }
    }


    public void SetNote(int a ,int b , int c ,int d) 
    {
        EndDicenum[0] = a;
        EndDicenum[1] = b;
        EndDicenum[2] = c;
        EndDicenum[3] = d;
    }
}
