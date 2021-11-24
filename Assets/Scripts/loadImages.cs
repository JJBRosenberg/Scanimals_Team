using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.IO;
using System.IO;

public class loadImages : MonoBehaviour
{
    private Image myIMGcomponent;
    public string imageToLoad = "123";
    // Use this for initialization
    void Start()
    {
        myIMGcomponent = this.GetComponent<Image>();
        myIMGcomponent.sprite = GetSpriteFromFile(imageToLoad);
    }

    // Update is called once per frame
    void Update()
    {

    }
    /*
    private void OnEnable()
    {
        myIMGcomponent.sprite = GetSpriteFromFile("123");
    }
    */
    public static Sprite GetSpriteFromFile(string file)
    {
        var res = Resources.Load(file) as Texture2D;
        Rect rec = new Rect(0, 0, res.width, res.height);
        return Sprite.Create(res, rec, Vector2.zero);
    }
    
}


