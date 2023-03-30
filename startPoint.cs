using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startPoint : MonoBehaviour
{

    public string goToMatch;
    private Moving thePlayer;
    // Start is called before the first frame update
    void Start()
    {
        if (goToMatch == FindObjectOfType<Moving>().goTo)
        {
            thePlayer = FindObjectOfType<Moving>();
            thePlayer.transform.position = transform.position;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
