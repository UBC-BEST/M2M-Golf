using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSizeScript : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] GameObject Background;
    [SerializeField] Rigidbody2D backgroundBody;
    [SerializeField] Sprite backgroundSprite;
    [SerializeField] Vector2 startingPosition = new Vector2(0, 0); 

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.sprite = backgroundSprite;
        backgroundBody.position = startingPosition;
        float screenHeight = 1/(Screen.height);
        float screenWidth = 1/(Screen.width);
        Vector3 scaleChange = new Vector3(screenWidth, screenHeight, 1);
        Background.transform.localScale = scaleChange;

    }

}
