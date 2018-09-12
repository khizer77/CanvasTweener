using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseTweenOnEnable : MonoBehaviour
{
	void OnEnable ()
	{
		GetComponent<UITweener> ().ResetToBeginning ();
		GetComponent<UITweener> ().enabled = true;		
	}
}
