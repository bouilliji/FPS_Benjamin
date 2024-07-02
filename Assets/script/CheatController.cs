using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatController : MonoBehaviour
{
    public bool munitionInfinit = false;
    public bool cooldoxnIsTrue = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F12))
        {
            munitionInfinit = true;
            cooldoxnIsTrue = false;
        }
    }
}
