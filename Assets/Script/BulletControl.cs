using System;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class BulletControl : MonoBehaviour
    {

        public float bulletSpeed = 100.0f;
        private Transform _transform = null;
        
        void Start()
        {
            _transform = GetComponent<Transform>();
        }

        // Update is called once per frame
        void Update()
        {
            var moveAmount = Vector3.up * (bulletSpeed * Time.deltaTime);
            _transform.Translate(moveAmount);
            if (_transform.position.y > 60) 
            {
                Destroy(gameObject);
            }
        }
    }
}
