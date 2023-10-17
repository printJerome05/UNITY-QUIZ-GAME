using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject QuizPanel;
    public GameObject GoPanel;
    public GameObject WinPanel;

    public Text QuestionTxt;
    public Text WinScoreTxt;
    public Text LoseScoreTxt;

    int totalQuestions = 0;
    public int score;

     private float timer = 120f;
     public Text timerSecond;


    private void Start()
    {
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        generateQuestion();
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        timerSecond.text = timer.ToString("f0");

        if(timer <= 0)
        {
            QuizPanel.SetActive(false);
            GoPanel.SetActive(true);
        }
    }


    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Win()
    {
        WinPanel.SetActive(true);
        QuizPanel.SetActive(false);
        GoPanel.SetActive(false);
        WinScoreTxt.text = score + "/" + totalQuestions;
    }

    void GameOver()
    {
        QuizPanel.SetActive(false);
        GoPanel.SetActive(true);
        WinPanel.SetActive(false);
        LoseScoreTxt.text = score + "/" + totalQuestions;
    }

    public void Quit()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void correct()
    {
        //When your asnwer is right  
        score += 1;
        QnA.RemoveAt(currentQuestion);   
        generateQuestion();
        timer += 3f;
    }

    //When your answer is wrong GAMEOVER PANEL WILL APPEAR.
    public void wrong()
    {
        
        QnA.RemoveAt(currentQuestion);
        //QuizPanel.SetActive(false);
        //GoPanel.SetActive(true);
        GameOver();
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswers == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        if(QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of Questions");
            Win(); 
        }
        
    }
}
