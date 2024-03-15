using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerAnimHandler : MonoBehaviour
{
    public UnityEvent ReloadComplete;
    public void Reload_Completed()
    {
        ReloadComplete.Invoke();
    }
}
