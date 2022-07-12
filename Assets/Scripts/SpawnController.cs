using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnController : MonoBehaviour
{

    private GameObject player;


    public Text CounterText;
    
    public int Count = 0;
    //list of sphere prefabs to spawn
    public GameObject[] spherePrefabs;
    //controls spwan rate of balls
    public float ballSpawnRate = 2;

    private float spawnTimer;
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = ballSpawnRate;
        Count = 0;
        //player = GameObject.Find
    }

    // Update is called once per frame
    void Update()
    {
        spawnBall();



    }

    void spawnBall(){
        //select a different coloured ball at random
        int ballIndex = Random.Range(0,3);

        
        //keep track of how much time has passed to spawn a new ball based on ballSpawnRate
        spawnTimer -= Time.deltaTime;

        //spawn ball 
        if(spawnTimer <=0){
            Debug.Log(ballIndex);
            Instantiate(spherePrefabs[ballIndex], new Vector3(0, 17, 0.64f), spherePrefabs[ballIndex].transform.rotation);
            //reset timer
            spawnTimer = ballSpawnRate;
        }

    }

}
