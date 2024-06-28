using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletGenerator : MonoBehaviour
{

    //deffinition de l'object wings_bullet pour le fair spawn
    public GameObject wings_bullet;

    //donne l'autorisation de tirrer par default
    [SerializeField]
    private bool itCanPull = true;

    public int munition = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //verification clic gauche et autorisation de tire
        if (Input.GetMouseButton(0) && itCanPull == true && munition > 0)
        {
            //creation de la balle
            Instantiate(wings_bullet, transform.position, transform.rotation);

            munition -= 1;

            //suprésion de l'autorisation de tirrer
            itCanPull = false;

            //debut du cooldown
            StartCoroutine(Cooldown(0.5f));
        }

        if (Input.GetMouseButtonDown(1))
        {
            munition = 30;
            itCanPull = false;
            StartCoroutine(Cooldown(1f));
        }
    }

    IEnumerator Cooldown(float seconde)
    {
        //attente de seconde seconde
        yield return new WaitForSeconds(seconde);

        //redonnez l'autorisation de tire
        itCanPull = true;
    }
}
