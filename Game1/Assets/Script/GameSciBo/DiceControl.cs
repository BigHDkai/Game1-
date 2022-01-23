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
            SetDicenum();
            ShowDice();
        }else if(DiceState == "stop" & Dicenum[0] == Dicenum[1])
        {
            transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+ Random.Range(1,7).ToString());
            var Bit = GameObject.Find("Bit");
            Bit.GetComponent<Button>().enabled = false;
        }
    }

    void SetDicenum()
    {
        Dicenum[0] = Random.Range(1,7);
        Dicenum[1] = Random.Range(1,7);
        Dicenum[2] = Random.Range(1,7);
    }
    void ShowDice()
    {
        transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+ Dicenum[0].ToString());
        transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+ Dicenum[1].ToString());
        transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+ Dicenum[2].ToString());
    }

    void StopDice(){
        DiceState = "stop";
        //設定結束骰子點數
        var ChipsManager = GameObject.Find("ChipsManager");
        ChipsManager.GetComponent<SiBoGameManager>().SetEndDicenum(Dicenum[0],Dicenum[1],Dicenum[2]);
        if(Dicenum[0] != Dicenum[1])
        {
            ChipsManager.GetComponent<SiBoGameManager>().EndGame();
            var Bit = GameObject.Find("Bit");
            Bit.GetComponentInChildren<Text>().text = "再來一局";
            Bit.GetComponent<Button>().enabled = true;
            GameObject.Find("SciBoContent").GetComponent<SicBoNotManager>().CreativityNote();
        }else
        {
            Invoke( "StopThreeDice" , 3f);
        }
    }
    void StopThreeDice(){
        DiceState = "stop1";
        //設定結束骰子點數
        transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("DiceImage/"+ Dicenum[2].ToString());
        var ChipsManager = GameObject.Find("ChipsManager");
        ChipsManager.GetComponent<SiBoGameManager>().EndGame();
        var Bit = GameObject.Find("Bit");
        Bit.GetComponentInChildren<Text>().text = "再來一局";
        Bit.GetComponent<Button>().enabled = true;
        GameObject.Find("SciBoContent").GetComponent<SicBoNotManager>().CreativityNote();
    }

    public void StopDiceClick(){
        var Bit = GameObject.Find("Bit");//確定下注按鈕
        var Big = GameObject.Find("Big");
        var Leopard = GameObject.Find("Leopard");
        var Small = GameObject.Find("Small");
        var ChipsManager = GameObject.Find("ChipsManager");
        if(DiceState == "run")
        {
            Bit.GetComponent<Button>().enabled = false;
            Invoke( "StopDice" , 1f);
            Big.GetComponent<Button>().enabled = false;
            Leopard.GetComponent<Button>().enabled = false;
            Small.GetComponent<Button>().enabled = false;
        }

        if(Bit.GetComponentInChildren<Text>().text == "再來一局")
        {
            Bit.GetComponentInChildren<Text>().text = "確定下注";
            DiceState = "run";
            var ResultText = GameObject.Find("ResultText");
            ResultText.transform.localPosition = new Vector3 (0,300,0);
            Big.GetComponent<Button>().enabled = true;
            Leopard.GetComponent<Button>().enabled = true;
            Small.GetComponent<Button>().enabled = true;
            for(int i = 0 ;i < ChipsManager.transform.childCount;i++){
            Destroy(ChipsManager.transform.GetChild(i).gameObject);
            }
        }
    }
    //返回大廳初始化遊戲
    public void ReturnSicBoGame(){
        var Bit = GameObject.Find("Bit");//確定下注按鈕
        var Big = GameObject.Find("Big");
        var Leopard = GameObject.Find("Leopard");
        var Small = GameObject.Find("Small");
        var ChipsManager = GameObject.Find("ChipsManager");
        Bit.GetComponentInChildren<Text>().text = "確定下注";
        DiceState = "run";
        var ResultText = GameObject.Find("ResultText");
        ResultText.transform.localPosition = new Vector3 (0,300,0);
        Big.GetComponent<Button>().enabled = true;
        Leopard.GetComponent<Button>().enabled = true;
        Small.GetComponent<Button>().enabled = true;
        for(int i = 0 ;i < ChipsManager.transform.childCount;i++){
            Destroy(ChipsManager.transform.GetChild(i).gameObject);
        }
    }
}
