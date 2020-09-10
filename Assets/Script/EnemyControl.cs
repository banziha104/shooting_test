using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Script
{
    public class EnemyControl : MonoBehaviour
    {
        // Start is called before the first frame update
        public float enemySpeed = 50.0f;
        public GameObject explosion = null;
        private Transform _transform;
        void Start()
        {
            _transform = GetComponent<Transform>();
        }

        
        void Update()
        {
            var moveAmount = enemySpeed * Time.deltaTime * Vector3.back;
            _transform.Translate(moveAmount);

            if (_transform.position.y < -50.0f)
            {
                InitPosition();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Bullet"))
            {
                MainControl.Score += 100;
                Debug.Log("Bullet Trigger Enter");

                Instantiate(explosion, _transform.position, Quaternion.identity);
                InitPosition();
                Destroy(other.gameObject);
            }
        }

        /// <summary>
        /// 내 위치를 초기화해주는 함수
        /// 이렇게하면 메소드 설명에 나타남
        /// </summary>
        private void InitPosition()
        {
            _transform.position = new Vector3(Random.Range(-60.0f,60.0f),50.0f,0.0f); 
        }
    }
}
