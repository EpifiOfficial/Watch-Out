using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerGS1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UiPause;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame ()
    {
        UiPause.SetActive(true);
        Time.timeScale = 0;

    }

    public void ResumeGame ()
    {
        Time.timeScale = 1;
        UiPause.SetActive(false);

    }

    public void Quit(){
        SceneManager.LoadScene("HomeScene");
    }
    public void Restart(){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
}
