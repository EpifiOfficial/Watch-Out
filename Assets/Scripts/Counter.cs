using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{  //Countdown timer variables
    public float currentTimeText = 0f;
    public float startingTimeProgressBar = 0f;
        public float TimeForWait;
            public TextMeshProUGUI TimeText;
    public int min;
    public GameObject UiGameEnded;
    private GameManagerGS1 gameManagerGS1;
   


    // Start is called before the first frame update
    void Start()
    {
        gameManagerGS1 = GameObject.FindObjectOfType<GameManagerGS1>();
          currentTimeText = TimeForWait;

    }

    // Update is called once per frame
    void Update()
    {
        if(currentTimeText<=min)
        {
            gameManagerGS1.finalUi();
        }else
        {
         currentTimeText -=  1* Time.deltaTime;
        }
        TimeText.text = currentTimeText.ToString("00:00");
    }
    
}
