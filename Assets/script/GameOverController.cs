using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{

    public Button startButton;
    public Button quitButton;
    [SerializeField]
    private cursorController cursorController;
    public GameObject BAckground;
    [SerializeField]
    private enemyGenerator enemyGenerator;
    [SerializeField]
    private playerController playerController;
    [SerializeField]
    private Slider healthBar;
    [SerializeField]
    private bulletGenerator bulletGenerator;

    private void Awake()
    {
        startButton.onClick.AddListener(StartGame);
        quitButton.onClick.AddListener(Application.Quit);
    }

    public void StartGame()
    {
        BAckground.SetActive(false);
        cursorController.LockCursor();
        enemyGenerator.StartGAme();
        playerController.playerOne.playerLife = 100;
        healthBar.value = playerController.playerOne.playerLife;
        playerController.playerOne.playerKill = 0;
        bulletGenerator.munition = 30;

    }


    public void gameOver()
    {
        enemyGenerator.EndGame();
        BAckground.SetActive(true);

    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
