using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")] //This results in a "state" asset appearing at the top of the context menu, it lets you select it repeatedly.
public class State : ScriptableObject
{
	[TextArea(20, 20)] [SerializeField] string storyText; //TextArea numbers: First, minimum size of the field. Second, amount of lines before scrolling.
	[SerializeField] State[] nextStates;

	public string GetStateStory()
	{
		return storyText;
	}

	public State[] GetNextStates()
	{
		return nextStates;
	}
}
