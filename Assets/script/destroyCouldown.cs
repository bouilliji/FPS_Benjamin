using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCouldown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //debut du cooldown
        StartCoroutine(Wait(2f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Wait(float seconde)
    {
        //attente de seconde seconde
        yield return new WaitForSeconds(seconde);

        //destruction de la balle au bout de seconde seconde
        Destroy(gameObject);
    }
}
