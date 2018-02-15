using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    [SerializeField] GameObject enemyToSpawn;
    [SerializeField] GameObject rewardToSpawn;
    [SerializeField] GameObject superPowerToSpawn;

    [SerializeField] Vector3 leftSpawner;
    [SerializeField] Vector3 middleSpawner;
    [SerializeField] Vector3 rightSpawner;

    [SerializeField] float timeToSpawnEnemy =5;

    public int difficultyLevel = 3;
    public bool superPower = false;
    public bool shouldSpawnEnemy;

    void Start () {
        leftSpawner = new Vector3(-5, 40, 0);
        middleSpawner = new Vector3(0, 40, 0);
        rightSpawner = new Vector3(5, 40, 0);
        StartCoroutine("SpawnFallingObjects");
    }
	
	// Update is called once per frame
	void Update () {
	}

    IEnumerator SpawnFallingObjects()
    {
        while (shouldSpawnEnemy)
        {
        int randomSpawner = Random.Range(0,3);


            Vector3 currentSpawner = leftSpawner;
            GameObject objectToSpawn = enemyToSpawn;
            int randomObject = Random.Range(0,30);

            switch (randomSpawner)
            {
                case 0:
                    currentSpawner = leftSpawner;
                    break;
                case 1:
                    currentSpawner = rightSpawner;
                    break;
                default:
                    currentSpawner = middleSpawner;
                    break;
            }



            if(randomObject == 0)
            {
                objectToSpawn = superPowerToSpawn;
            }else if ((randomObject > 0)&&(randomObject<difficultyLevel))
            {
                objectToSpawn = enemyToSpawn;
            }
            else
            {
                objectToSpawn = rewardToSpawn;
            }


            if (superPower)
            {
                objectToSpawn = rewardToSpawn;
            }

            switch (randomSpawner)
        {
            case 0:
                currentSpawner = leftSpawner;
                break;
            case 1:
                currentSpawner = rightSpawner;
                    break;
                default:
                    currentSpawner = middleSpawner;
                    break;
            }

            yield return new WaitForSeconds(timeToSpawnEnemy);

        Instantiate(objectToSpawn, currentSpawner, Quaternion.identity);
    }
}
}
