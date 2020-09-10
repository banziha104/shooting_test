using UnityEngine;

namespace Script
{
    public class PlayerControl : MonoBehaviour
    {
        public float speed = 15.0f;
        private Transform _transform = null;
        public GameObject bulletPrefab = null;
        
        void Start()
        {
            _transform = GetComponent<Transform>();
            
        }

        // Update is called once per frame
        void Update()
        {
            // -1 ~ 1 왼쪽 화살키 (-1) 오른쪽 화살키(1)
            var axis = Input.GetAxis("Horizontal");
            // Debug.Log($"axis : axis: {axis}");
            var moveAmount = -Vector3.right * (axis * speed * Time.deltaTime);
            _transform.Translate(moveAmount);
            
            if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                Instantiate(bulletPrefab,_transform.position,Quaternion.identity);
            }
        }
    }
}
