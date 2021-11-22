using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFileScript : MonoBehaviour
{

    public static Sprite GetSpriteFromFile(string file)
    {
        var res = Resources.Load(file) as Texture2D;
        Rect rec = new Rect(0, 0, res.width, res.height);
        return Sprite.Create(res, rec, Vector2.zero);
    }
}
