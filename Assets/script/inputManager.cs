using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputManager : MonoBehaviour
{
    //recuperation des variable d'input player et camera
    private playerController playerInput;
    private cameraController cameraInput;
    // Start is called before the first frame update
    void Start()
    {
        //initialisation des variable
        playerInput = FindObjectOfType<playerController>();
        cameraInput = FindObjectOfType<cameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        //recuperation des des input souris en XY et les input clavier sur l'xe verticale et horizontale
        playerInput.mouvX   = Input.GetAxis("Horizontal");
        playerInput.mouvZ   = Input.GetAxis("Vertical");
        playerInput.rotateY = Input.GetAxis("Mouse X");
        cameraInput.rotateX = Input.GetAxis("Mouse Y") * -1;
    }
}
