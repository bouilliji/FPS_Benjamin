using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class bulletGenerator : MonoBehaviour
{

    //deffinition de l'object wings_bullet pour le fair spawn
    public GameObject wings_bullet;

    //donne l'autorisation de tirrer par default
    [SerializeField]
    private bool itCanPull = true;

    public int munition = 30;

    [SerializeField]
    private CheatController CheatController;
    /*[SerializeField]
    private TextMeshProUGUI munitionText;*/

    // Start is called before the first frame update
    void Start()
    {
        /*munitionText = GetComponent<TextMeshProUGUI>();
        munitionText.text = "30";*/
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
            if (CheatController.cooldoxnIsTrue)
            {
                //debut du cooldown
                StartCoroutine(Cooldown(0.5f));
            }
            else
            {
                itCanPull = true;
            }
            
        }
        if (CheatController.munitionInfinit)
        {
            munition = 10;
            //munitionText.text = "∞";
        }
        /*else
        {
            munitionText.text = munition.ToString();
        }*/

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
