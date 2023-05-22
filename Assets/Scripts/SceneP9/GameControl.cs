using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public int score_attemps;
    private float score_timer;
    public BallsControler ballsControler;
    public Score score;
    public GameObject endGameMenu;
    public GameObject[] levels;
    public int indexlevel;
    public bool play = false;

    public void startGame(){
        play = true;
    }

    public void previousLevel(){
        ballsControler.RestartBall();
        hideLevels();
        if (indexlevel > 0){
            indexlevel -= 1;
        }
        showLevel();
        score_attemps += 1;
    }

    public void nextLevel(){
        ballsControler.RestartBall();
        hideLevels();
        
        if (indexlevel < levels.Length)
            indexlevel += 1;
        
        if (indexlevel == levels.Length)
            GameWin();
        else
            showLevel();
    }

    void showLevel(){
        if(indexlevel < levels.Length)
            levels[indexlevel].SetActive(true);
    }

    void hideLevels(){
        for( int i = 0; i < levels.Length; i++ ){
            levels[i].SetActive(false);
        }
    }

    void EndGame(){
        play = false;
        hideLevels();

        GameObject ball = ballsControler.getBall();
        if(ball)
            ball.SetActive(false);

        endGameMenu.SetActive(true);
        score.setAttemps(score_attemps.ToString());
        if (score_timer < 60)
            score.setTime( score_timer.ToString("0.00"), "s" );
        else
            score.setTime( (score_timer/60.0f).ToString("0.00"), "min" );
    }

    void GameWin(){
        EndGame();
        score.setTitle("¡WINNER!");
    }

    void GameOver(){
        EndGame();
        score.setTitle("GAME OVER");
    }

    void Start(){
        hideLevels();
        endGameMenu.SetActive(false);
        
        GameObject ball = ballsControler.getBall();
        if(ball) ball.SetActive(false);

        score_attemps = 1;
        score_timer = 0;
        indexlevel = 0;
        play = false;
    }

    void Update()
    {
        if(play == true){
            score_timer += Time.deltaTime;
            Debug.LogWarning(score_timer);
            if(score_timer > 60){ // 300 : 5 minutes
                GameOver();
            }
            
            showLevel();
            GameObject ball = ballsControler.getBall();
            if (ball) ball.SetActive(true);
        }
        else{
            GameObject ball = ballsControler.getBall();
            if (ball) ball.SetActive(false);
        }
    }
}
