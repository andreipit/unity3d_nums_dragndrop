using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScale : MonoBehaviour
{
    const float scale = 0.15f;

    void Update()
    {
        float size = scale * GetComponent<RectTransform>().rect.height;
        GetComponent<GridLayoutGroup>().cellSize = new Vector2(size, size);
    }
}
