using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class SpriteShapeVertexMatcher : MonoBehaviour
{
   
    public Transform[] CornerObjects;
    //set up spritesape controller for future calling
    private SpriteShapeController spriteShapeController;

    void Start()
    {
        //get spriteshape controller from unity and use it
        spriteShapeController = GetComponent<SpriteShapeController>();
    }

    void FixedUpdate()
    {
        //set different points that will be linked to different corners of the object 
        //allow the points to be linked to the length of the object
        for (int pointID = 0; pointID < CornerObjects.Length; pointID++)
        {
            //set the new position 
            //this is an easier way to write it. can be also written for 4 indivisual points.
            spriteShapeController.spline.SetPosition(pointID, CornerObjects[pointID].localPosition);
        }
    }
}
