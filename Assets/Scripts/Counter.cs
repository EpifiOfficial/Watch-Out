using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{  //Countdown timer variables
    public float currentTimeProgressBar = 0f;
    public float currentTimeText = 0f;
    public float startingTimeProgressBar = 0f;
        public float TimeForWait;
            public TextMeshProUGUI TimeText;
    public int min;


    // Start is called before the first frame update
    void Start()
    {
          currentTimeText = TimeForWait;

    }

    // Update is called once per frame
    void Update()
    {
        if(currentTimeText<=min)
        {
         
   
        }else
        {
         currentTimeText -=  1* Time.deltaTime;
        }
        TimeText.text = currentTimeText.ToString("00:00");
    }
}
