using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    [SerializeField] public int score;
    [SerializeField] public TextMeshProUGUI scoreUIRef;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateUI();
    }

    public void UpdateUI()
    {
        scoreUIRef.text = score.ToString();
    }
}
