using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playonattack2 : MonoBehaviour
{
	public AudioSource ability1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1)){
			ability1.Play();
		}
    }
}
