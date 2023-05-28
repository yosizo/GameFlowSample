using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

using MessagePipe;

public class Test : MonoBehaviour
{
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        var subscriber = GlobalMessagePipe.GetSubscriber<int>();
        subscriber.Subscribe(data =>
        {
            text.text = "cnt:"+data;
        });
    }
}
