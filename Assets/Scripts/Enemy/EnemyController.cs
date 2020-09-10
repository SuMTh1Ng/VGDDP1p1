using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
	#region Editor Variables
	[SerializeField]
	[Tooltip("enemy health")]
	private int m_MaxHealth;
	
	[SerializeField]
	[Tooltip("enemy speed")]
	private float m_Speed;
	
	[SerializeField]
	[Tooltip("enemy dps")]
	private float m_Damage;
	
	[SerializeField]
	[Tooltip("death explosion")]
	private ParticleSystem m_DeathExplosion;
	
	[SerializeField]
	[Tooltip("health pill drop percent")]
	private float m_HealthPillDropRate;
	
	[SerializeField]
	[Tooltip("health pill type")]
	private GameObject m_HealthPill;
	
	[SerializeField]
	[Tooltip("score")]
	private int m_Score = 0;
	#endregion
	
	#region Private Variables
	private float p_curHealth;
	#endregion
	
	#region Cached Componenets
	private Rigidbody cc_Rb;
	#endregion
	
	#region Cached References
	private Transform cr_Player;
	#endregion

	#region Initialization
	private void Awake(){
		p_curHealth = m_MaxHealth;
		
		cc_Rb = GetComponent<Rigidbody>();
		
	}
	
	private void Start(){
		cr_Player = FindObjectOfType<PlayerController>().transform;
	}
	#endregion
	
	#region Main Updates
	private void FixedUpdate(){
		Vector3 dir = cr_Player.position - transform.position;
		dir.Normalize();
		cc_Rb.MovePosition(cc_Rb.position + dir * m_Speed * Time.fixedDeltaTime);
		
	}
	#endregion
	
	#region Collision Methods
	private void OnCollisionStay(Collision collision){
		GameObject other = collision.collider.gameObject;
		if(other.CompareTag("Player")){
			//DecreaseHealth(m_Damage);
			other.GetComponent<PlayerController>().DecreaseHealth(m_Damage);
		}
	}
	#endregion
	
	#region health methods
	public void DecreaseHealth(float amount){
		p_curHealth -= amount;
		if(p_curHealth <= 0){
			ScoreManager.singleton.IncreaseScore(m_Score);
			if(Random.value < m_HealthPillDropRate){
				Instantiate(m_HealthPill, transform.position, Quaternion.identity);
			}
			Instantiate(m_DeathExplosion, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}
	#endregion
}
