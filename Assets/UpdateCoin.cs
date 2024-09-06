using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateCoin : MonoBehaviour
{
    private Text _text;
    
    // Start is called before the first frame update
    void Awake()
    {
        _text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        _text.text = CoreData.instance.playerCoin.ToString();
    }
}
