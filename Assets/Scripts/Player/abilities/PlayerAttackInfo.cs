using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerAttackInfo
{
	#region Editor Variables
	[SerializeField]
	[Tooltip("Attack name")]
	private string m_Name;
	public string AttackName{
		get{
			return m_Name;
		}
	}
	
	[SerializeField]
	[Tooltip("Attack input")]
	private string m_Button;
	public string Button{
		get{
			return m_Button;
		}
	}
	
	[SerializeField]
	[Tooltip("Attack animation trigger")]
	private string m_TriggerName;
	public string TriggerName{
		get{
			return m_TriggerName;
		}
	}
	
	[SerializeField]
	[Tooltip("Attack GameObject")]
	private GameObject m_AbilityGO;
	public GameObject AbilityGO{
		get{
			return m_AbilityGO;
		}
	}
	
	[SerializeField]
	[Tooltip("Attack spawn offset")]
	private Vector3 m_offset;
	public Vector3 offset{
		get{
			return m_offset;
		}
	}
	
	[SerializeField]
	[Tooltip("Attack windup")]
	private float m_WindUpTime;
	public float WindUpTime{
		get{
			return m_WindUpTime;
		}
	}
	
	[SerializeField]
	[Tooltip("Attack animation cast time")]
	private float m_FrozenTime;
	public float FrozenTime{
		get{
			return m_FrozenTime;
		}
	}
	
	[SerializeField]
	[Tooltip("Attack cooldown")]
	private float m_Cooldown;
	
	[SerializeField]
	[Tooltip("Attack health cost")]
	private int m_HealthCost;
	public int HealthCost{
		get{
			return m_HealthCost;
		}
	}
	
	[SerializeField]
	[Tooltip("Attack color")]
	private Color m_Color;
	public Color AbilityColor{
		get{
			return m_Color;
		}
	}
	
	
	#endregion
	
	#region Public Variiables
	public float Cooldown{
		get;
		set;
	}
	#endregion
	
	#region Cooldown Methods
	public void ResetCooldown(){
		Cooldown = m_Cooldown;
	}
	
	public bool IsReady(){
		return Cooldown <= 0;
	}
	#endregion
	

}
