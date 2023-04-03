using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targetsCatalogue;
    private float spawnRate = 1f;
    private float elaspedTime = 0f;



    void Start(){}


    void Update()
    {
        elaspedTime += Time.deltaTime;
        if(elaspedTime > spawnRate){
            SpawnNewCrate();
            elapsedTime = 0;
        }
    }

    void SpawnNewCrate(){
        int index = Random.Range(0, targetsCatalogue.Count);
        Instantiate(targetsCatalogue[index]);
    }
}
