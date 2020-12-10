using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
     public GameObject prefab;
    public bool isPrefabActive;
    private Vector2 screenBounds;
    void Start()
    {
       
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    public void SpawnObject(){
        GameObject gameObject = Instantiate(prefab) as GameObject;
        gameObject.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), Random.Range(-screenBounds.y, screenBounds.y));  
          }
}
