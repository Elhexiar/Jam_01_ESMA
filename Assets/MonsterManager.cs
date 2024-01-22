using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterManager : MonoBehaviour
{
    [SerializeField] public List<GameObject> monsterList;
    [SerializeField] private int drop;
    [SerializeField] private int dropcutoff;
    [SerializeField] public List<Color> colorList;
    [SerializeField] public Color nextColor;
    [SerializeField] public Image uiRef;
    // Start is called before the first frame update
    void Start()
    {
        drop = 0;
        nextColor = colorList[drop];

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnMonster()
    {

        

        Instantiate(monsterList[drop],transform.position,transform.rotation);
        drop = Random.Range(0, dropcutoff);
        nextColor = colorList[drop];
        uiRef.color = nextColor;

        Debug.Log("Spawn Monster");
    }
}
