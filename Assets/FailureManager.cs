using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailureManager : MonoBehaviour
{
    public DropperInputManager dropperInputManager;
    public GameObject loseScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        dropperInputManager.failed = true;
        loseScreen.SetActive(true);
    }
}
