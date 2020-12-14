using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManagerGS1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UiPause;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI FinalUiScoreText;
    public GameObject FinalUi;
    public Animator transition;
    public float transitionTime = 0f;

    int Score;

    void Start()
    {
            Time.timeScale = 1;

     Score=0;   
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
        LoadPreviousLevel();
    }
    public void Restart(){
        Time.timeScale = 1;

        LoadCurrentLevel();  
    }
    public void IncreaseScore(int incrementScore){
        Score = Score+incrementScore;
        ScoreText.text = Score.ToString();
    }
    public void finalUi(){
        FinalUi.SetActive(true);
        FinalUiScoreText.text = Score.ToString();
        Time.timeScale = 0.1f;

    }

    void LoadPreviousLevel(){
                Time.timeScale = 1;

        StartCoroutine(loadLevel(SceneManager.GetActiveScene().buildIndex - 1));
    }
    void LoadCurrentLevel(){
                Time.timeScale = 1;

        StartCoroutine(loadLevel(SceneManager.GetActiveScene().buildIndex + 0 ));
    }
    IEnumerator loadLevel(int levelIndex){
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);

    }
}
