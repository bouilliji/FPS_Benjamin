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
    private int whatSpawn = 1;
    [SerializeField]
    private playerController playerController;
    // Start is called before the first frame update
    void Start()
    {
    }

    private bool isRunning = false;

    public void StartGAme()
    {
        isRunning = true;
        EnemiesAlive = new List<GameObject>();
    }

    public void EndGame()
    {
        isRunning = false;
        StopAllCoroutines();

        foreach (GameObject go in EnemiesAlive)
        {
            if (go != null)
            {
                Destroy(go);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!isRunning)
            return;

        if (mobIsSpawning == false)
        {
            StartCoroutine(spawn(Random.Range(3,7)));
            mobIsSpawning = true;
        }  
    }

    public List<GameObject> EnemiesAlive;

    IEnumerator spawn(int intervalle)
    {
        GameObject nE = null;

        if (whatSpawn == 1)
        {
                
            nE = Instantiate(enemy, transform.position, transform.rotation);
        }
        else if (whatSpawn == 2)
        {
            nE = Instantiate(enemy, enemyGenerator1.position, enemyGenerator1.rotation);
        }
        else if (whatSpawn == 3)
        {
            nE  = Instantiate(enemy, enemyGenerator2.position, enemyGenerator2.rotation);
        }

        if (nE == null)
            Debug.Log("nE null");

        enemyController ec = nE.GetComponent<enemyController>();
        ec.playerController = playerController;
        ec.playerTransform = playerController.transform;

        EnemiesAlive.Add(nE);

        //attente de intervalle seconde
        yield return new WaitForSeconds(intervalle);

        whatSpawn = Random.Range(1,4);

        //creation de l'enemy 
        mobIsSpawning = false;
    }
}
