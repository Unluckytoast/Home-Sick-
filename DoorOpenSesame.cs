using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class DoorOpenSesame : MonoBehaviour
{
    public IEnumerator PushDoorForTime(float duration)
    {
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            transform.Translate(Time.deltaTime, 0, 0);

            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}
