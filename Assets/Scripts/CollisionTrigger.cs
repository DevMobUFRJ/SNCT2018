using UnityEngine;

public class CollisionTrigger : MonoBehaviour {

    public int actualWoman;

    public Canvas canvas1, canvas2, canvas3;


    private void Awake()
    {
        if(actualWoman == 1)
        {
            canvas1.gameObject.SetActive(false);
        }
        if(actualWoman == 2)
        {
            canvas2.gameObject.SetActive(false);
        }
        if(actualWoman == 3)
        {
            canvas3.gameObject.SetActive(false);
        }

    }

    private void OnTriggerEnter(Collider col)
    {
        MultiTagging.Tags myTag = col.gameObject.GetComponent<MultiTagging>().GetMyTag();

        if (col.gameObject.CompareTag("Item"))
        {
            if(actualWoman == 1 && myTag == MultiTagging.Tags.Item1)
            {
                canvas1.gameObject.SetActive(true);
            }
            else
            {
                if(actualWoman == 2 && myTag == MultiTagging.Tags.Item2)
                {
                    canvas2.gameObject.SetActive(true);
                }
                else
                {
                    if(actualWoman == 3 && myTag == MultiTagging.Tags.Item3)
                    {
                        canvas3.gameObject.SetActive(true);
                    }
                }
            }
        }
    }

    private void OnTriggerExit(Collider col)
    {
        MultiTagging.Tags myTag = col.gameObject.GetComponent<MultiTagging>().GetMyTag();

        if (col.gameObject.CompareTag("Item"))
        {
            if (actualWoman == 1 && myTag == MultiTagging.Tags.Item1)
            {
                canvas1.gameObject.SetActive(false);
            }
            else
            {
                if (actualWoman == 2 && myTag == MultiTagging.Tags.Item2)
                {
                    canvas2.gameObject.SetActive(false);
                }
                else
                {
                    if (actualWoman == 3 && myTag == MultiTagging.Tags.Item3)
                    {
                        canvas3.gameObject.SetActive(false);
                    }
                }
            }
        }
    }
}
