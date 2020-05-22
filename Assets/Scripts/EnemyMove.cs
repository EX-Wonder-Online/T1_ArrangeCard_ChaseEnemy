using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; // AIを追加　NavMeshAgentを使えるように入れる

public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent aganet; // Agentを取得
    [SerializeField]
    private GameObject terget; // 目的地を指定　Playerにすると鬼ごっこできる

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        aganet.SetDestination(terget.transform.position); // 常に自分自身はプレイヤーに向かう
    }
}
