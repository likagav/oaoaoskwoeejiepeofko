using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private static int scoreCount;
    void Start()
    {
        GameObject textObject = GameObject.Find("scoretext");
        scoreText = textObject.GetComponent<TextMeshProUGUI>();
        scoreText.text = "Score: "+ scoreCount.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        scoreCount++;
        scoreText.text = "Score: " + scoreCount.ToString();
    }
}
