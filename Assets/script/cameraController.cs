using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static generalClass;

public class cameraController : MonoBehaviour
{
    //mainCamera herite de la class generalClass.BaseCamera
    private BaseCamera mainCamera = new BaseCamera();

    //varriable de l'input de la souris et de calcul de l'angle de rotation
    public float rotateX;
    public float rotationInDegret;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //calcul de l'angle de rotation a partir de la senssibilité definie dans la class generalClass.BaseCamera
        rotationInDegret += rotateX * mainCamera.cameraRotationSensitivity * Time.deltaTime;

        //rotation de la cammera et clanmp de la rotation en Y
        transform.localRotation = Quaternion.Euler(Mathf.Clamp(rotationInDegret, -90, 75) , 0 , 0);
    }
}
