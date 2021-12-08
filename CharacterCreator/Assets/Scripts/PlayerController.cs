using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public SpriteRenderer ArmorRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SetArmor(Sprite newSprite)
    {
        ArmorRenderer.sprite = newSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
