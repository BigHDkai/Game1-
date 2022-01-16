using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceControl : MonoBehaviour
{
    [SerializeField] int[] Dicenum = new int[3];

    string DiceState = "run";

    void Update()
    {
        if(DiceState == "run"){
             ShowDice();
        } 
    }

    void ShowDice()
    {
        Dicenum[0] = Random.Range(1,7);
        Dicenum[1] = Random.Range(1,7);
        Dicenum[2] = Random.Range(1,7);
        transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+ Dicenum[0].ToString());
        transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+ Dicenum[1].ToString());
        transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+ Dicenum[2].ToString());
    }

    void StopDice(){
        DiceState = "stop";
        //設定結束骰子點數
        var ChipsManager = GameObject.Find("ChipsManager");
        ChipsManager.GetComponent<SiBoGameManager>().SetEndDicenum(Dicenum[0],Dicenum[1],Dicenum[2]);
        ChipsManager.GetComponent<SiBoGameManager>().EndGame();
    }

    public void StopDiceClick(){
        Invoke( "StopDice" , 1f);
    }
}
