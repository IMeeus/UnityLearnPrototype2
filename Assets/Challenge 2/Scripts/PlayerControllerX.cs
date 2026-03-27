using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public InputActionReference sendDogAction;

    void Update()
    {
        if (sendDogAction.action.WasPressedThisFrame())
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }   
    }
}
