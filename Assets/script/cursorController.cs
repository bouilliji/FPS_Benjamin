using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cursorController : MonoBehaviour
{
    //varriable etat du curser
    private bool cursorIsLocked = true;
    // Start is called before the first frame update
    void Start()
    {
        //innitialisation etat du curser
      //  Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        ////si 0 est preser et que le curser est unlock allors on lock
        //if (cursorIsLocked == false && Input.GetKeyDown(KeyCode.Keypad0))
        //{
        //    LockCursor();
        //    cursorIsLocked = true;
        //}
        ////si 0 est preser et que le curser est lock allors on unlock
        //else if (cursorIsLocked == true && Input.GetKeyDown(KeyCode.Keypad0))
        //{
        //    UnlockCursor();
        //    cursorIsLocked = false;
        //}
    }

    public void LockCursor()
    {
        //lock du curser et cachage du curser
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void UnlockCursor()
    {
        //unlock du curser et curser vissible
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
