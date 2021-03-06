using UnityEngine;
using System.Collections;

public class TriggerSadDayOnLose : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ChildBehaviour.OnHealthChanged += Trigger;
	}

	public void Trigger(int newHealth)
	{
		if(newHealth <= 0)
			SadDayEvent.Send(true);
	}

#if UNITY_EDITOR
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.F1))
		{
			SadDayEvent.Send(true);
		}
	}
#endif

	// Update is called once per frame
	void OnDestroy () {
		ChildBehaviour.OnHealthChanged -= Trigger;
	}
}
