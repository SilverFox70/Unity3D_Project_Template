using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {

	// Awake this instance
	void Awake()
	{

	}

	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Event Manager online: " + this.isActiveAndEnabled);
	}

	// Subscribe to events and assign delegates
	private void OnEnable()
	{
		// Register your events here...
	}

	// Unsubscribe to events and unregister delegates
	private void OnDisable()
	{
		// UnRegister your event here...
	}

}
