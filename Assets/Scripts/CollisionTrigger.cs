using UnityEngine;

public class CollisionTrigger : MonoBehaviour {

    public int actualWoman;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Item"))
        {
            Debug.Log("Entrou no item");
            if(actualWoman == 1)
            {
                //Aparece Canvas 1
                Debug.Log("Canvas 1");
            }
            else
            {
                if(actualWoman == 2)
                {
                    //Aparece Canvas 2
                    Debug.Log("Canvas 2");
                }
                else
                {
                    if(actualWoman == 3)
                    {
                        //Aparece Canvas 3
                        Debug.Log("Canvas 3");
                    }
                }
            }
        }
    }
}
