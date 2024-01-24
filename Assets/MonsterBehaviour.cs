using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBehaviour : MonoBehaviour
{
    [SerializeField] public MonsterManager manager;
    [SerializeField] public ScoreManager scoreManager;
    [SerializeField] public int index;
    [SerializeField] public bool colliding = false;
    [SerializeField] public int value;

    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<MonsterManager>();
        scoreManager = FindObjectOfType<ScoreManager>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        
        if (collision.gameObject.tag == "Ennemie" ) 
        {
            if (collision.gameObject.GetComponent<MonsterBehaviour>().index == index)
            {
                if(collision.gameObject.GetComponent<MonsterBehaviour>().colliding == false && colliding == false)
                {
                    colliding = true;
                    Destroy(collision.gameObject);
                    if (index+1 <= manager.monsterList.Count -1)
                    {
                        Instantiate(manager.monsterList[index + 1], transform.position + (transform.position - collision.transform.position) / 2, transform.rotation);
                    }
                    scoreManager.IncreaseScore(value);
                }
                
                
                
                Destroy(gameObject);
            }
            

        }
    }
}
