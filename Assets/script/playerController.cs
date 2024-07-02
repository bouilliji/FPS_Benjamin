using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static generalClass;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    [SerializeField]
    private GameOverController gameOverController;
    //playerOne herite de la class generalClass.Player
    public Player playerOne = new Player();

    //variable d'input controler par inputManager
    public float mouvX;
    public float mouvZ;
    public float rotateY;

    //cette variable gèrre la barre de vie
    [SerializeField]
    private Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
        //initialisation bar de vie
        healthBar.maxValue = playerOne.playerLife;
        healthBar.value = playerOne.playerLife;
    }

    // Update is called once per frame
    void Update()
    {
        //mouvement du player en X et Z
        transform.Translate(mouvX * playerOne.playerSpeed * Time.deltaTime, 0, mouvZ * playerOne.playerSpeed * Time.deltaTime);

        //Rotation du player en Y
        transform.Rotate(0, rotateY * playerOne.playerRotationSensitivity * Time.deltaTime, 0);
    }

    void OnCollisionEnter(Collision collision)
    {

        //verefication que la collition est avec l'enemy
        if (collision.gameObject.CompareTag("enemy"))
        {
            //decompte des point bde vie et mis a jour de la bar de vie
            playerOne.playerLife -= 10;
            healthBar.value = playerOne.playerLife;

            //condition gamme over
            if (playerOne.playerLife <= 0)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                gameOverController.gameOver();
            }
        }
    }
}
