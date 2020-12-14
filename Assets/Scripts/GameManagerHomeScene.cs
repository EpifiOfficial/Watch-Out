using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerHomeScene : MonoBehaviour
{
    public GameObject tapPrefab;
    public Animator transition;
    public float transitionTime = 0f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0){
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            if(touch.phase == TouchPhase.Began){
                Instantiate(tapPrefab,touchPos,Quaternion.identity);
                LoadNextLevel();
            }
        }
    }
    void LoadNextLevel(){
        StartCoroutine(loadLevel(SceneManager.GetActiveScene().buildIndex+1));
    }

    IEnumerator loadLevel(int levelIndex){
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
    

}
