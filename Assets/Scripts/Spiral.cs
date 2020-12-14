using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiral : MonoBehaviour
{
        private GameManagerGS1 gameManagerGS1;

    // Start is called before the first frame update
    void Start()
    {
     gameManagerGS1 = GameObject.FindObjectOfType<GameManagerGS1>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
void OnCollisionEnter2D(Collision2D collision)
{
     if (collision.gameObject.tag == "FruitPrefab"){
        gameManagerGS1.IncreaseScore(17);

    }
}
}
