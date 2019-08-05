using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
	[SerializeField] Text textComponent; //SerializeField: Makes the variable visible within the inspector.
	[SerializeField] State startingState;

	State state;

    // Start is called before the first frame update
    void Start()
    {
		state = startingState;
		textComponent.text = state.GetStateStory(); //Specifies the text field within the text component. Allows us to call the method State in this script.
    }

    // Update is called once per frame
    void Update()
    {
		ManageState();
    }

	private void ManageState()
	{
		var nextState = state.GetNextStates(); //Specifies the nextStates variable within the state item.
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			state = nextState[0];
		}
		else if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			state = nextState[1];
		}
		else if(Input.GetKeyDown(KeyCode.Alpha3))
		{
			state = nextState[2];
		}
		textComponent.text = state.GetStateStory();
	}
}
