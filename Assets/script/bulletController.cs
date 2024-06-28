using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static generalClass;

public class bulletController : MonoBehaviour
{

    //newBullet herite de la class generalClass.Bullet    
    public Bullet newBullet = new Bullet();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mouvement de la balle en lige droite
        transform.Translate(0 , 0 , newBullet.bulletSpeed  * Time.deltaTime);
    }

}
