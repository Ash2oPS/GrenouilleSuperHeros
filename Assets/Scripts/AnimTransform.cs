using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTransform : MonoBehaviour
{
    //[SerializeField]
    //private string animationName;

    //[SerializeField]
    //private List<Vector3> squareScales;

    //[SerializeField]
    //private List<float> scaleTimes;

    //private float timer, lerpT;

    //private int index;

    //public bool canGo;

    //private void Update()
    //{
    //    //if (canGo)
    //    //{
    //    //    if (timer < scaleTimes[scaleTimes.Count - 1])
    //    //    {
    //    //        SquareAnimation();
    //    //    }
    //    //}
    //}

    //public IEnumerator Animation()
    //{
    //    //yield return new WaitForEndOfFrame();
    //    while (index < scaleTimes.Count - 2)
    //    {
    //        while (timer < scaleTimes[scaleTimes.Count - 1])
    //        {
    //        }
    //        if (lerpT >= 1)
    //        {
    //            lerpT = 0;
    //            index++;
    //        }
    //        else
    //        {
    //            timer += Time.deltaTime;
    //            lerpT = (scaleTimes[index] - timer) / (scaleTimes[index] - scaleTimes[index + 1]);

    //            transform.localScale = Vector3.Lerp(squareScales[index], squareScales[index + 1], lerpT);
    //            SquareAnimation();
    //            yield return new WaitForEndOfFrame();
    //        }

    //        canGo = false;
    //        index = 0;
    //        lerpT = 0;
    //        timer = 0;
    //        Debug.Log("exit");
    //    }

    //    private void SquareAnimation()
    //    {
    //    }
    //}

    //public void SetCanGo()
    //{
    //    StartCoroutine(Animation());
    //}
}