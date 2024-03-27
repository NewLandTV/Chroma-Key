using System.Collections;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    private RectTransform target;

    private IEnumerator Start()
    {
        while (true)
        {
            target.position = Input.mousePosition;

            yield return null;
        }
    }
}
