using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    [SerializeField] Text TextComponent;
    [SerializeField] State startingState;

     

    State state;
    // Use this for initialization
 
    void Start()
    {
        state = startingState;
        TextComponent.text = state.GetStateStory();
    }


    // Update is called once per frame
    void Update () {
        ManageState();

    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        for (int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextStates[i];

            }
        }
        TextComponent.text = state.GetStateStory();
    }
}
