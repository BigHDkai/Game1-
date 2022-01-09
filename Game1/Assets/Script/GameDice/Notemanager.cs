using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Notemanager : MonoBehaviour
{
    [SerializeField] Transform Note;
    public int[] NoteMyDice = new int[4];
    public int[] NoteComputerDice = new int[4];
    int NoCount = 1;

    public void CreativityNote()
    {
        var newnote = Instantiate(Note,transform.position,new Quaternion(0,0,0,0),transform);
        newnote.GetChild(0).GetComponent<Text>().text =NoCount.ToString();
        NoCount++;
        newnote.GetChild(1).GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+NoteMyDice[0].ToString());
        newnote.GetChild(1).GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+NoteMyDice[1].ToString());
        newnote.GetChild(1).GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+NoteMyDice[2].ToString());
        newnote.GetChild(1).GetChild(3).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+NoteMyDice[3].ToString());
        newnote.GetChild(2).GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+NoteComputerDice[0].ToString());
        newnote.GetChild(2).GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+NoteComputerDice[1].ToString());
        newnote.GetChild(2).GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+NoteComputerDice[2].ToString());
        newnote.GetChild(2).GetChild(3).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+NoteComputerDice[3].ToString());
        if( NoteComputerDice[2]+NoteComputerDice[3] > NoteMyDice[2]+NoteMyDice[3]){
            newnote.GetChild(3).GetComponent<Text>().text ="<color=#FF0000>-10</color>";
        }else
        {
            newnote.GetChild(3).GetComponent<Text>().text ="<color=#00FF00>+10</color>";
        }
        newnote.gameObject.SetActive(false);
    }

    public void SetNoteMyDice(int a ,int b , int c ,int d) 
    {
        NoteMyDice[0] = a;
        NoteMyDice[1] = b;
        NoteMyDice[2] = c;
        NoteMyDice[3] = d;
    }

    public void SetNoteComputerDice(int a ,int b , int c ,int d) 
    {
        NoteComputerDice[0] = a;
        NoteComputerDice[1] = b;
        NoteComputerDice[2] = c;
        NoteComputerDice[3] = d;
    }


}
