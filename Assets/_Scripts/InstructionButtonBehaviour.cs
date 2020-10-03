using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Event handler for InstructionButtonPressed Event
    public void OnInstructionButtonPressed()
    {
        Debug.Log("Instruction show!");
        SceneManager.LoadScene("Instruction");
    }
}
