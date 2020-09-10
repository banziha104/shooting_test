using UnityEngine;

namespace Script
{
    public class BackgroundControl : MonoBehaviour
    {
        public float scrollSpeed = 0.1f;
        public Renderer renderer = null;
        
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            renderer.material.SetTextureOffset("_MainTex", new Vector2(0.0f,Time.time * scrollSpeed));
        }
    }
}
