using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CardManager : MonoBehaviour
{
    static void Main()
    {
        Debug.Log("start");
    }
    // 單例模式
    static CardManager instance;
    Tweener tweener;


    //取得單例
    public static CardManager getInstance()
    {
        return instance;
    }

    [SerializeField] Button card;
    [SerializeField] Button OpencardButton;
    [SerializeField] Button RepeatButton;
    [SerializeField] Text ResultText;
    [SerializeField] Text ScoreText;

    int score = 1000;
    int[] poke = new int[52];
    Transform[] endpoke = new Transform[2];



    void Start()
    {
        Main();
        CardManager.instance = this;

        CardManager.getInstance().PokeNumber();
        CardManager.getInstance().CreativityCard();
        Invoke( "LicensingComputerCard" , 1f);
    }

    public void CreativityCard()
    {
        for(int i = 0 ,j=0; i < poke.Length;i++,j+=10)
        {
            var cards = Instantiate(card ,transform.localPosition,new Quaternion(0,0,0,0) ,transform);
            cards.GetComponentInChildren<Text>().text = poke[i].ToString();
            cards.GetComponentInChildren<Text>().enabled = false;
            cards.transform.localPosition = new Vector3(-255,0,0);
            tweener = cards.transform.DOLocalMove(new Vector3(-255+j,0,0),1);
        }
    }

    public void LicensingComputerCard()
    {
        //ComputerCard = endpoke[0]
        endpoke[0] = transform.GetChild(Random.Range(0,transform.childCount));
        tweener = endpoke[0].transform.DOLocalMove(new Vector3(0,90,0),1);
        endpoke[0].GetComponent<Button>().enabled = false;
        Destroy(endpoke[0].GetComponent<CardMove>());
    }


    public void PokeNumber()
    {
        for(int i=0,j=0; i < poke.Length ; i++)
        {
            do
            {
                poke[i] = Random.Range(1,53);
                for(j=0;j<i;j++){
                    if(poke[i] == poke[j])
                    {
                        break;
                    }
                }
            }while(j != i);
        }
    }

    public void EnabledAllButton()
    {
        for(int i=0; i < transform.childCount ; i++){
            transform.GetChild(i).GetComponent<Button>().enabled = false;
        }
        OpencardButton.GetComponent<Button>().enabled = true;
    }

    public void Mycard(Transform mycard)
    {
        endpoke[1] = mycard;
        Destroy(endpoke[1].GetComponent<CardMove>());
    }
    
    public void OpenCards()
    {
        endpoke[0].GetComponentInChildren<Text>().enabled = true;
        endpoke[1].GetComponentInChildren<Text>().enabled = true;
        OpencardButton.GetComponent<Button>().enabled = false;
        RepeatButton.GetComponent<Button>().enabled = true;
        Invoke( "GameResult" , 1f);
    }

    void GameResult()
    {
        if(int.Parse(endpoke[0].GetComponentInChildren<Text>().text) > int.Parse(endpoke[1].GetComponentInChildren<Text>().text)){
            ScoreText.text = "分數 : "+ (score-10);
            ResultText.text="<color=#FF0000>你輸了</color>";
            score -=10;
        }else
        {
            ScoreText.text = "分數 : "+ (score+10);
            ResultText.text="<color=#00FF00>你贏了</color>";
            score +=10;
        }
        Destroy(endpoke[1].gameObject);
        Destroy(endpoke[0].gameObject);
    }

    public void Gamere()
    {
        for(int i = 0,j=0; i < transform.childCount;i++,j+=10)
        {
            transform.GetChild(i).transform.localPosition = new Vector3(-255,0,0);
            tweener = transform.GetChild(i).transform.DOLocalMove(new Vector3(-255+j,0,0),1);
            transform.GetChild(i).GetComponent<Button>().enabled = true;
        }
        Invoke( "LicensingComputerCard" , 1f);
    }

}

