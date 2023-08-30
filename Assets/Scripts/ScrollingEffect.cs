using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingEffect : MonoBehaviour
{
    [SerializeField] Transform endPos, startPos;
    [SerializeField] float speed;

    Vector2 targetPos, rePosition;

    // Start is called before the first frame update
    void Start()
    {
        targetPos = new Vector2(endPos.position.x, transform.position.y);
        rePosition = new Vector2(startPos.position.x, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Vector2)transform.position != targetPos)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        }
        else
        {
            transform.position = rePosition;
        }
    }
}
