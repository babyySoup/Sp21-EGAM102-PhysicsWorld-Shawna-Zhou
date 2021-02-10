using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class SpriteShapeVertexMatcher : MonoBehaviour
{

    public Transform[] CornerObjects;

    private SpriteShapeController spriteShapeController;

    void Start()
    {
        spriteShapeController = GetComponent<SpriteShapeController>();
    }

    void FixedUpdate()
    {
        for (int pointID = 0; pointID < CornerObjects.Length; pointID++)
        {
            spriteShapeController.spline.SetPosition(pointID, CornerObjects[pointID].localPosition);
        }
    }
}
