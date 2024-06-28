using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGenerator : MonoBehaviour
{
    private bool mobIsSpawning = false;

    //recuperation de l'object enemy pour le faire spawn
    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private Transform enemyGenerator1;
    [SerializeField]
    private Transform enemyGenerator2;
    private int whatSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (mobIsSpawning == false)
        {
            StartCoroutine(spawn(Random.Range(3,7)));
            mobIsSpawning = true;
        }  
    }
     
    IEnumerator spawn(int intervalle)
    {
        if (whatSpawn == 1)
        {
            Instantiate(enemy, transform.position, transform.rotation);
        }

        if (whatSpawn == 2)
        {
            Instantiate(enemy, enemyGenerator1.position, enemyGenerator1.rotation);
        }

        if (whatSpawn == 3)
        {
            Instantiate(enemy, enemyGenerator2.position, enemyGenerator2.rotation);
        }

        //attente de intervalle seconde
        yield return new WaitForSeconds(intervalle);

        whatSpawn = Random.Range(1,4);

        //creation de l'enemy 
        mobIsSpawning = false;
    }
}
