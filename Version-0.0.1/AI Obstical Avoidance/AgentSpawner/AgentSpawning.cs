using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentSpawning : MonoBehaviour{
    [Header ("Spawn Area")]
    public float spawnWidth;
    public float spawnHeight;

    [Header ("Spawn Information")]
    public GameObject Agent;
    Vector3 randomPosition;
    [Range(0, 500)]
    public int amountOfAgents;
    private int curentlyAlive = 0;
    private int amountToSpawn = 0;

    void Start(){

    }

    void Update(){
        if(curentlyAlive < amountOfAgents){
            amountToSpawn = amountOfAgents - curentlyAlive;
        }
        if(amountToSpawn > 0){
            loadAgents();
        }
    }

    void loadAgents(){
        for(int i = 0; i < amountToSpawn; i++){

            randomPosition.x = Random.Range(spawnWidth / 2 * -1, spawnWidth / 2 + 1);
            randomPosition.y = transform.position.y;
            randomPosition.z = Random.Range(spawnHeight / 2 * -1, spawnHeight / 2 + 1);

            Instantiate(Agent, randomPosition, transform.rotation);
            amountToSpawn --;
            curentlyAlive ++;
        }
    }
}
