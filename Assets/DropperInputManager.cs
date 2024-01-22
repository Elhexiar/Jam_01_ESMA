using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperInputManager : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float leftBound;
    [SerializeField] private float rightBound;
    [SerializeField] private float topBound;
    [SerializeField] private float bottomBound;

    [SerializeField] private MonsterManager monsterManger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            monsterManger.SpawnMonster();
        }
     
        if(Input.GetKey(KeyCode.A))
        {
            if(transform.localPosition.x >= leftBound)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            
        }
        if(Input.GetKey(KeyCode.D)) 
        {

            if(transform.localPosition.x <= rightBound)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
            
        }
        if(Input.GetKey(KeyCode.W))
        {
            if(transform.localPosition.z <= topBound)
            {
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            if(transform.localPosition.z >= bottomBound)
            {
                transform.Translate(Vector3.back * speed * Time.deltaTime);

            }
        }

    }
}
