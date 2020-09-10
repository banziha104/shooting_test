using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script
{
    public class VictoryControl : MonoBehaviour
    {
        private void OnGUI()
        {
            var centerX = Screen.width * 0.5f;
            var centerY = Screen.height * 0.5f;
            var buttonRect = new Rect(centerX - 100.0f, centerY - 100.0f,200.0f,200.0f);
            if (GUI.Button(buttonRect,"YOU WIN!!")==true)
            {
                SceneManager.LoadScene("Level1");
            }
        }

    }
}
