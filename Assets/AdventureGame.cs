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
		textComponent.text = state.GetStateStory(); //Specifies the text field within the tex component. Allows us to call the method State in this script.
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
