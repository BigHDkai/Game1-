using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform Note;

    public Transform[] NoteEndpoke = new Transform[2];



    int NoCount = 1;
    public void CreativityNote()
    {
        var newnote = Instantiate(Note,transform.position,new Quaternion(0,0,0,0),transform);
        newnote.GetChild(0).GetComponent<Text>().text =NoCount.ToString();
        NoCount++;
        Debug.Log(NoteEndpoke[0]);
        newnote.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("pokeImage/"+NoteEndpoke[0].GetComponentInChildren<Text>().text);
        newnote.GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("pokeImage/"+NoteEndpoke[1].GetComponentInChildren<Text>().text);
        if(int.Parse(NoteEndpoke[0].GetComponentInChildren<Text>().text) > int.Parse(NoteEndpoke[1].GetComponentInChildren<Text>().text)){
            newnote.GetChild(3).GetComponent<Text>().text ="<color=#FF0000>-10</color>";
        }else
        {
            newnote.GetChild(3).GetComponent<Text>().text ="<color=#00FF00>+10</color>";
        }
    }

    public void SetNoteEndpoke(Transform a , Transform b)
    {
        NoteEndpoke[0]=a;
        NoteEndpoke[1]=b;
    }


}
