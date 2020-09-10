using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class AbilityInfo{
	#region Editor Variables
	[SerializeField]
	[Tooltip("ability power")]
	private int m_Power;
	public int Power{
		get{
			return m_Power;
		}
		
	}
	[SerializeField]
	[Tooltip("ability range")]
	private int m_Range;
	public float Range{
		get{
			return m_Range;
		}
		
	}
	#endregion
	
	
	
}
