using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Event handler for EndButtonPressed Event
    public void OnEndButtonPressed()
    {
        Debug.Log("End Button");
        SceneManager.LoadScene("GameOver");
    }
}
