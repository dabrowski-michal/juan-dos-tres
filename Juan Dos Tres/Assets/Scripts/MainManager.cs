using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour {

    [SerializeField] AudioSource[] evilPresidentSounds;
    [SerializeField] AudioSource gritoSound;

    [SerializeField] GameObject defeatPanel;
    [SerializeField] GameObject wall;
    [SerializeField] GameObject arrivaPanel;
    [SerializeField] GameObject newHat;
    [SerializeField] GameObject oldHat;

    [SerializeField] Text scoreText;

    [SerializeField] Animator wallAnimator;
    [SerializeField] Animator scoreAnimator;

    [SerializeField] int score;
    [SerializeField] int wallHeight = 1;
    private int realScoreToIncrease = 1;

    EnemySpawner enemySpawner;

    private void Start () {
        wallAnimator = wall.GetComponent<Animator>();
        scoreAnimator = scoreText.GetComponent<Animator>();
        enemySpawner = GetComponent<EnemySpawner>();

    }

    private void Update () {
        scoreText.text =""+ score;
    }

    public void IncreaseScore(int scoreToIncrease)
    {
        print("Increased!");
        score = score + scoreToIncrease;
        scoreAnimator.SetTrigger("Enlarge");
        scoreText.text = "Score: " + score;
    }

    public void BuildWall()
    {
        wallHeight += 10;
        switch (wallHeight)
        {
            case 11:
                evilPresidentSounds[0].Play();
                break;
            case 21:
                evilPresidentSounds[1].Play();
                break;
            case 31:
                evilPresidentSounds[2].Play();
                break;
            case 41:
                evilPresidentSounds[3].Play();
                break;
            case 51:
                evilPresidentSounds[4].Play();
                EndTheGame();
                break;
        }
        wallAnimator.SetInteger("WallHeight", wallHeight);

    }


    IEnumerator TriggerSuperPower()
    {
        enemySpawner.superPower = true; //TODO change to setter
        gritoSound.Play();
        arrivaPanel.SetActive(true);
        newHat.SetActive(true);
        oldHat.SetActive(false);

        yield return new WaitForSeconds(5);
        enemySpawner.superPower = false;
        arrivaPanel.SetActive(false);
        oldHat.SetActive(true);
        newHat.SetActive(false);

        enemySpawner.difficultyLevel += 1; //every super power used makes the game harder
    }


    public void EndTheGame()
    {
        defeatPanel.SetActive(true);
        enemySpawner.shouldSpawnEnemy = false;
    }


    public void RestartLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
