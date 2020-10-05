using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
	public Text HighScoreText;
    // Start is called before the first frame update
    void Start()
    {
    	string str = PlayerPrefs.GetFloat("Score", 0f).ToString("F2");
        HighScoreText.text = str;
    }
}
