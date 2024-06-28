using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static generalClass;

public class enemyController : MonoBehaviour
{
    [SerializeField]
    public playerController playerController;

    //newEnemy herite de la class generalClass.Enemy
    private Enemy newEnemy = new Enemy();

    //vecteur de mouvement de l'enemy et ce vecteur normaliser
    private Vector3 mouvEnemy;
    private Vector3 mouvEnemyNormalized;

    //recupération gamme Object player et sa position
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        
     }

    // Update is called once per frame
    void Update()
    {
        //calcule du vecteur de mouvement et normalisation
        mouvEnemy = new Vector3(playerTransform.position.x - transform.position.x, 0 , playerTransform.position.z - transform.position.z);
        mouvEnemyNormalized = mouvEnemy.normalized;

        //mouvement de l'enemy
        transform.LookAt(playerTransform,Vector3.up);
        transform.Translate(transform.forward * newEnemy.enemySpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {

        //vereification que la collition est avec une balle
        if (collision.gameObject.CompareTag("bullet"))
        {
            //decompte des point de vit
            newEnemy.enemyLife -= 20;

            //destruction de l'enemy quant sa vie est a zero
            if (newEnemy.enemyLife <= 0)
            {
                Destroy(gameObject);
                playerController.playerOne.playerKill += 1;
            }
        }

        //verrifiacetion que la collition est avec le player
        if (collision.gameObject.CompareTag("Player"))
        {
            //appelle de la fonction recule
            Recule();
        }
    }

    private void Recule()
    {
        //memes etape que dans update mais cette fois l'enemy recule d'une vitesse de 100 metre par seconde
        mouvEnemy = new Vector3(playerTransform.position.x - transform.position.x, 0 , playerTransform.position.z - transform.position.z);
        mouvEnemyNormalized = mouvEnemy.normalized * -1;
        transform.Translate(mouvEnemyNormalized * newEnemy.enemyRecule * Time.deltaTime);
    }
}