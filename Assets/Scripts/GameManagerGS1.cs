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
    public int transitionTime;
    int Score;

    void Start()
    {
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
        SceneManager.LoadScene("HomeScene");
    }
    public void Restart(){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
    public void IncreaseScore(int incrementScore){
        Score = Score+incrementScore;
        ScoreText.text = Score.ToString();
    }
    public void finalUi(){
        FinalUi.SetActive(true);
        FinalUiScoreText.text = Score.ToString();
        Time.timeScale = 0;

    }
    void LoadPreviousLevel(){
        StartCoroutine(loadLevel(SceneManager.GetActiveScene().buildIndex-1));
    }
    IEnumerator loadScene(int levelIndex){
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);

    }
}
