using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AllUnits
{
    public class MainStatus : MonoBehaviour
    {
        // 플레이어와 적 유닛이 공통으로 사용할 변수
        [SerializeField] protected float speed = 3f;
        [SerializeField] internal float maxHealth = 50f;
        [SerializeField] internal float currentHealth;
        [SerializeField] internal float damage = 2f;
        [SerializeField] internal float damageDelay = 2f;
        private float initialDamageDelay;
        [SerializeField] protected bool isDamage = false;

        // 자식 클래스들도 사용될 수 있도록
        public void Start()
        {
            currentHealth = maxHealth;
            initialDamageDelay = damageDelay;
        }
        public void Update()
        {
            DamageDelay();
        }
        public void DamageDelay()
        {
            if (isDamage && damageDelay > 0)
            {
                damageDelay -= Time.deltaTime;
                if (damageDelay <= 0)
                {
                    isDamage = false;
                    damageDelay = initialDamageDelay;
                }
            }
        }
    }
}
