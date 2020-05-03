using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAvatarScript : MonoBehaviour
{
	public GameObject avatar;
	
	public float T=1;
	public float F=1;
	
	public bool move = true;
	
	private bool ___firstonly = true; 
	
	void Start()
	{
		if(!avatar)
		{
			Debug.Log("Avatar is null");
		}
	}
	
    void Update()
    {
		if(!avatar)
		{
			return;
		}
		Transform transform = avatar.transform;
		
		{
			transform.localPosition = this.transform.localPosition;
			transform.localRotation = this.transform.localRotation;
		}
		
		if(move){
			float pos = Mathf.Sin(Time.time * F) * T;
			transform.localPosition = this.transform.localPosition + new Vector3(0, pos, 0);
		}
		
    }
}
