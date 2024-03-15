using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key1 : MonoBehaviour
{
    [SerializeField] GameManager3d _gameManager;
    [SerializeField] DoorOpen _doorOpen;

    private void Update()
    {
        if(_gameManager._goldKey)
        {
            _doorOpen.enabled = true;
        }
    }


}
