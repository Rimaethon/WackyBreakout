using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardBlock : Block
{
    #region Fields
    [SerializeField] Sprite blockSprite1;
    [SerializeField] Sprite blockSprite2;
    [SerializeField] Sprite blockSprite3;
    #endregion


    #region Unity Methods
    // Start is called before the first frame update
    void Start()
    {
        int Points = ConfigurationUtils.StandardBlockPoints;
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        int spriteNumber = Random.Range(0, 3);
        if (spriteNumber == 0)
        {
            spriteRenderer.sprite = blockSprite1;
        }
        else if (spriteNumber == 1)
        {
            spriteRenderer.sprite = blockSprite2;
        }
        else
        {
            spriteRenderer.sprite = blockSprite3;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
}
