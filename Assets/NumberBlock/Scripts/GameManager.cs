using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    private NumberBlockManager NumberBlockManager;
    private void Awake()
    {
        new CalculateManager();
        NumberBlockManager = GetComponent<NumberBlockManager>();
        if(NumberBlockManager == null)
        {
            NumberBlockManager = gameObject.AddComponent<NumberBlockManager>();
        }
    }

    private void Start()
    {
        
    }
}
