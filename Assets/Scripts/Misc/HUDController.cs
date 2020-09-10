using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDController : MonoBehaviour
{
	#region Editor Variables
    [SerializeField]
	[Tooltip("health bar")]
	private RectTransform m_HealthBar;
	
	#endregion
	
	#region Private Variables
	private float p_HealthBarOriginWidth;
	#endregion
	
	#region Initialization
	private void Awake(){
		p_HealthBarOriginWidth = m_HealthBar.sizeDelta.x;
	}
	#endregion
	
	#region Update Health Bar
	public void UpdateHealth(float percent){
		m_HealthBar.sizeDelta = new Vector2(p_HealthBarOriginWidth * percent, m_HealthBar.sizeDelta.y);
	}
	#endregion
}
