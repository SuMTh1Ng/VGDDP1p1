using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
	//private float m_RotationSpeed = 1f;
	//private float xRotation = 0f;
	
	
    #region Editor Variables
	[SerializeField]
	[Tooltip("The player to follow")]
	private Transform m_PlayerTransform;
	
	[SerializeField]
	[Tooltip("The offset from the player's origin to the camera")]
	private Vector3 m_Offset;
	
	[SerializeField]
	private float m_RotationSpeed = 1f;
	#endregion
	
	/* first person camera
	private void Update(){
		
		//float mouseX = m_RotationSpeed * Input.GetAxis("Mouse X") * Time.deltaTime;
		//float mouseY = m_RotationSpeed * Input.GetAxis("Mouse Y") * Time.deltaTime;
		
		xRotation -= mouseY;
		xRotation = Mathf.Clamp(xRotation, -90f, 90f);
		
		transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        m_PlayerTransform.Rotate(Vector3.up * mouseX);
		

	}
	*/
	
	
	#region Main Updates
	private void LateUpdate(){
		Vector3 newPos = m_PlayerTransform.position + m_Offset;
		transform.position = Vector3.Slerp(transform.position, newPos, 1);
		
		float rotationAmount = m_RotationSpeed * Input.GetAxis("Mouse X");
		transform.RotateAround(m_PlayerTransform.position, Vector3.up, rotationAmount);
		
		m_Offset = transform.position - m_PlayerTransform.position;
		
		
	}
	#endregion
}

