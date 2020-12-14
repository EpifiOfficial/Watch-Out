using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float speed;
    public float stopDistance;
    private Transform target;
    bool isLoadingVisible;

    // Start is called before the first frame update
    void Start()
    {
        isLoadingVisible=true;
        enemyFollow();
    }

    // Update is called once per frame
    void Update()
    {
           if(isLoadingVisible==false){
            target = GameObject.FindGameObjectWithTag("FruitPrefab").GetComponent<Transform>();

            if(Vector2.Distance(transform.position,target.position)>stopDistance){
                transform.position = Vector2.MoveTowards(transform.position,target.position,speed*Time.deltaTime);

            }
         }
        
    }
    IEnumerator enemyFollow(){

            yield return new WaitForSeconds(2.3f);
        isLoadingVisible=false;
    
    }
}
