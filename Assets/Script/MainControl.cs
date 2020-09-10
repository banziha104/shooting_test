using System;
using UnityEngine;

namespace Script
{
    public class MainControl : MonoBehaviour
    {

        public static int Score = 0;
        public static int Life = 3;
        public GUISkin skin = null;
        

        // Start is called before the first frame update

        private void OnGUI()
        {
            GUI.skin = skin;
            var labelRect1 = new Rect(10.0f , 10.0f , 400.0f, 100.0f);
            var labelRect2 = new Rect(10.0f , 110.0f , 400.0f, 100.0f);
            GUI.Label(labelRect1,$"SCORE : {MainControl.Score}");
            GUI.Label(labelRect2,$"SCORE : {MainControl.Life}");
        }

        private void Update()
        {
            if (MainControl.Score > 500)
            {
                MainControl.Score = 0;
                UnityEngine.SceneManagement.SceneManager.LoadScene("Victory");
            }
        }

        // Update is called once per frame
    }
}

